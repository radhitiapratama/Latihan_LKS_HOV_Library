using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Library
{
    public partial class FormBookList : Form
    {

        HovLibraryEntities db = new HovLibraryEntities();
        Book book;
        string code;

        public FormBookList(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void FormBookList_Load(object sender, EventArgs e)
        {
            bindingSource3.AddNew();
            textBox1.Text = book.title;
            loadBookList();
            loadLocation();
        }

        void resetState()
        {
            bindingSource3.Clear();
            bindingSource3.AddNew();
            comboBox1.SelectedValue = 0;

        }

        void loadLocation()
        {
            bindingSource2.Clear();
            var result = db.Locations.Where(f => f.deleted_at == null).OrderBy(f => f.name).ToList();
            result.Insert(0, new Location
            {
                id = 0,
                name = "Select Location..."
            });

            bindingSource2.DataSource = result;
        }

        void loadBookList()
        {
            bindingSource1.Clear();
            var result = db.BookDetails.Where(f => f.book_id == book.id && f.deleted_at == null).ToList();
            bindingSource1.DataSource = result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].DataBoundItem is BookDetail detail)
            {
                if (e.ColumnIndex == btnDeleteColumn.Index)
                {
                    var check = db.Borrowings.Where(f => f.bookdetails_id == detail.id && f.return_date > DateTime.Now && f.deleted_at == null).OrderByDescending(f => f.id).FirstOrDefault();

                    if (check != null)
                    {
                        Alerts.Error("Book unavailable");
                        return;
                    }

                    if (Alerts.Confirm("Sure delete data?") == DialogResult.Yes)
                    {
                        detail.deleted_at = DateTime.Now;
                        int rows = db.SaveChanges();
                        if (rows > 0)
                        {
                            Alerts.Success("Book detail successfully deleted");
                            loadBookList();
                            return;
                        }

                        Alerts.Error("Failed to delete book detail");
                    }
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is BookDetail detail)
            {
                if (e.ColumnIndex == locationColumn.Index)
                {
                    e.Value = detail.Location.name;
                }

                if (e.ColumnIndex == statusColumn.Index)
                {
                    var check = db.Borrowings.Where(f => f.bookdetails_id == detail.id && f.return_date > DateTime.Now && f.deleted_at == null).OrderByDescending(f => f.id).FirstOrDefault();

                    if (check == null)
                    {
                        e.Value = "Available";
                        return;
                    }

                    e.Value = "Unavailable";
                }

                if (e.ColumnIndex == btnDeleteColumn.Index)
                {
                    e.Value = "Delete";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                return;
            }

            var locationID = (int)comboBox1.SelectedValue;
            if (locationID == 0)
            {
                textBox2.Text = "";
                return;
            }

            var bookDetailId = db.BookDetails.Count() + 1;
            var bookId = book.id.ToString("D4");
            var locationStr = locationID.ToString("D2");
            var year = book.publication_date.ToString("yyyy");

            textBox2.Text = $"{bookDetailId}.{bookId}.{locationStr}.{year}";
            this.code = $"{bookDetailId}.{bookId}.{locationStr}.{year}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == " " || (int)comboBox1.SelectedValue == 0)
            {
                Alerts.Error("All field must be filled");
                return;
            }

            if (bindingSource3.Current is BookDetail detail)
            {
                detail.book_id = book.id;
                detail.created_at = DateTime.Now;
                detail.code = this.code;
                db.BookDetails.AddOrUpdate(detail);
                int rows = db.SaveChanges();
                if (rows > 0)
                {
                    Alerts.Success("Book List added successfully!");
                    loadBookList();
                    resetState();
                    return;
                }

                Alerts.Error("Failed to add book list");
            }
        }
    }
}
