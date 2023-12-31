using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Library
{
    public partial class AllBorrowingForm : Form
    {
        HovLibraryEntities db = new HovLibraryEntities();

        public AllBorrowingForm()
        {
            InitializeComponent();
        }

        private void AllBorrowingForm_Load(object sender, EventArgs e)
        {
            initDate();
            loadBorrowStatus();
            loadBorrowing();
        }

        void loadBorrowing()
        {
            bindingSource1.Clear();
            var query = db.Borrowings.Where(f => f.deleted_at == null);
            var statusID = (int)comboBox1.SelectedValue;

            if (statusID == 1)
            {
                query = query.Where(f => f.return_date == null).OrderByDescending(f => f.borrow_date);
            }

            if (statusID == 2)
            {
                query = query.Where(f => DbFunctions.DiffDays(f.borrow_date, DateTime.Now) > 7 && f.fine != 0 || f.fine == null).OrderByDescending(f => f.borrow_date);
            }

            if (statusID == 3)
            {
                query = query.Where(f => f.return_date != null).OrderByDescending(f => f.borrow_date);
            }

            if (dateTimePicker1.Text != " " && dateTimePicker1.Text != " ")
            {
                var dateStart = dateTimePicker1.Value;
                var dateEnd = dateTimePicker2.Value;
                query = query.Where(f => f.borrow_date >= dateStart && f.borrow_date <= dateEnd).OrderByDescending(f => f.borrow_date);
            }


            bindingSource1.DataSource = query
                .OrderByDescending(f => f.borrow_date)
                .OrderByDescending(f => f.id)
                .ToList().Take(100);
        }

        void initDate()
        {
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
        }

        void loadBorrowStatus()
        {
            List<KeyValuePair<int, string>> status = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0,"Select Status"),
                new KeyValuePair<int, string>(1,"On Going"),
                new KeyValuePair<int, string>(2,"Late"),
                new KeyValuePair<int, string>(3,"Returned"),
            };

            comboBox1.DataSource = status;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dddd,MMMM dd,yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dddd,MMMM dd,yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadBorrowing();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Borrowing borrow)
            {
                if (e.ColumnIndex == MemberColumn.Index)
                {
                    e.Value = borrow.Member.name;
                }

                if (e.ColumnIndex == bookTitleColumn.Index)
                {
                    e.Value = borrow.BookDetail.Book.title;

                }

                if (e.ColumnIndex == bookCodeColumn.Index)
                {
                    e.Value = borrow.BookDetail.code;
                }

                if (e.ColumnIndex == btnReturnColumn.Index)
                {
                    var check = borrow.return_date != null;
                    if (check)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["btnReturnColumn"].ReadOnly = true;
                        e.CellStyle.Padding = new Padding(50);
                    }
                    else
                    {
                        e.Value = "Return";
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].DataBoundItem is Borrowing borrow)
            {
                if (e.ColumnIndex == btnReturnColumn.Index)
                {
                    if (Alerts.Confirm("Return borrowing book?") == DialogResult.Yes)
                    {
                        var diff = Math.Abs((int)(borrow.borrow_date - DateTime.Now).Days * 1000);

                        borrow.return_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                        borrow.last_updated_at = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                        borrow.fine = diff;

                        db.Borrowings.AddOrUpdate(borrow);
                        int rows = db.SaveChanges();
                        if (rows > 0)
                        {
                            Alerts.Success("Book successfully returned");
                            loadBorrowing();
                            return;
                        }

                        Alerts.Error("Failed to return book");
                    }
                }
            }
        }
    }
}