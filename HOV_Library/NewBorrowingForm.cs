using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Library
{
    public partial class NewBorrowingForm : Form
    {
        HovLibraryEntities db = new HovLibraryEntities();

        public NewBorrowingForm()
        {
            InitializeComponent();
        }

        private void NewBorrowingForm_Load(object sender, EventArgs e)
        {
            initTitle();
            loadMember();
        }

        void initTitle()
        {
            bindingSource1.Clear();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var query = db.Books.Where(f => f.deleted_at == null).Select(f => new
            {
                f.id,
                f.title,
            }).ToList();

            foreach (var q in query)
            {
                collection.Add(q.title);
            }

            comboBox1.AutoCompleteCustomSource = collection;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            query.Insert(0, new
            {
                id = 0,
                title = "Select Book"
            });

            bindingSource1.DataSource = query;
        }

        void loadBookDetails()
        {
            if (comboBox1.SelectedValue != null)
            {
                int bookID = (int)comboBox1.SelectedValue;
                if (bookID == 0) return;

                var result = db.BookDetails.Where(f => f.book_id == bookID && f.deleted_at == null).ToList();

                bindingSource2.DataSource = result;
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            loadBookDetails();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is BookDetail detail)
            {
                if (e.ColumnIndex == LocationColumn.Index)
                {
                    e.Value = detail.Location.name;
                }

                if (e.ColumnIndex == statusColumn.Index)
                {
                    var check = db.Borrowings.Where(f => f.deleted_at == null && f.bookdetails_id == detail.id && f.return_date == null).FirstOrDefault();

                    if (check == null)
                    {
                        e.Value = "Available";
                        return;
                    }

                    e.Value = "Unavailable";
                }

                if (e.ColumnIndex == checkBoxColumn.Index)
                {
                    var check = db.Borrowings.Where(f => f.deleted_at == null && f.bookdetails_id == detail.id && f.return_date == null).FirstOrDefault();

                    if (check != null)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["checkBoxColumn"].ReadOnly = true;
                    }
                }
            }
        }

        void loadMember()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            var result = db.Members.Where(f => f.deleted_at == null).OrderBy(f => f.name).ToList();
            result.Insert(0, new Member
            {
                id = 0,
                name = "Select Member"
            });

            foreach (var m in result)
            {
                collection.Add(m.name);
            }


            comboBox2.AutoCompleteCustomSource = collection;
            comboBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            bindingSource3.DataSource = result;
        }

        void resetState()
        {
            comboBox2.SelectedValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checkedCheckbox = false;
            int memberID = (int)comboBox2.SelectedValue;

            if (memberID == 0)
            {
                Alerts.Error("Select member first!");
                return;
            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows[row.Index].DataBoundItem is BookDetail detail)
                {
                    var isChecked = row.Cells["checkBoxColumn"].Value;
                    if (isChecked != null && (bool)isChecked)
                    {
                        checkedCheckbox = true;
                        Borrowing borrowing = new Borrowing
                        {
                            member_id = memberID,
                            bookdetails_id = detail.id,
                            borrow_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                            created_at = DateTime.Now,
                        };

                        db.Borrowings.Add(borrowing);
                        db.SaveChanges();
                    }
                }
            }

            if (checkedCheckbox)
            {
                Alerts.Success("Books successfully borrowed");
                loadBookDetails();
                resetState();
                return;
            }

            Alerts.Error("At least one book must be selected");
        }
    }
}
