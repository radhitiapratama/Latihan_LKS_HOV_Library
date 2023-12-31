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
using System.Xml.XPath;

namespace HOV_Library
{
    public partial class MasterBookForm : Form
    {
        HovLibraryEntities db = new HovLibraryEntities();

        public MasterBookForm()
        {
            InitializeComponent();
        }

        private void MasterBookForm_Load(object sender, EventArgs e)
        {
            bindingSource2.AddNew();
            loadPublisher();
            initNumeric();
            loadBooks();
            loadLanguage();
            loadSeachBy();
            resetState();
        }

        public void initNumeric()
        {
            numericUpDown1.Maximum = Decimal.MaxValue;
            numericUpDown2.Maximum = Decimal.MaxValue;
            numericUpDown3.Maximum = Decimal.MaxValue;
            numericUpDown4.Maximum = Decimal.MaxValue;
            numericUpDown5.Maximum = Decimal.MaxValue;
            numericUpDown6.Maximum = Decimal.MaxValue;


            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            numericUpDown1.Text = "";
            numericUpDown2.Text = "";
            numericUpDown3.Text = "";
            numericUpDown4.Text = "";
        }

        void enableInput()
        {
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            dateTimePicker3.Enabled = true;
            numericUpDown5.Enabled = true;
            numericUpDown6.Enabled = true;

            button3.Enabled = true;
            button4.Enabled = true;
        }

        void resetState()
        {
            bindingSource2.Clear();
            bindingSource2.AddNew();
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker3.Value = DateTime.Now;
            numericUpDown5.Enabled = false;
            numericUpDown6.Enabled = false;

            comboBox3.SelectedValue = 0;
            comboBox4.SelectedValue = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;

            button3.Enabled = false;
            button4.Enabled = false;
        }

        void loadBooks()
        {
            bindingSource1.Clear();
            var query = db.Books.Where(f => f.deleted_at == null).ToList().Take(100);
            bindingSource1.DataSource = query;
        }

        void loadSeachBy()
        {
            var list = new List<KeyValuePair<int, string>>
            {
              new KeyValuePair<int,string>(0,"Search...."),
              new KeyValuePair<int,string>(1,"Title"),
              new KeyValuePair<int,string>(2,"Author"),
              new KeyValuePair<int,string>(3,"Publisher"),
            };

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        void loadLanguage()
        {
            bindingSource3.Clear();
            var result = db.Languages.OrderBy(f => f.long_text).ToList();
            result.Insert(0, new Language
            {
                id = 0,
                long_text = "Search Language..."
            });

            bindingSource3.DataSource = result;
            comboBox2.SelectedValue = 0;

            bindingSource4.DataSource = result;
        }

        void loadPublisher()
        {
            var result = db.Publishers.OrderBy(f => f.name).ToList();
            result.Insert(0, new Publisher
            {
                id = 0,
                name = "Select Publisher"
            });

            bindingSource5.DataSource = result;
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Book book)
            {
                if (e.ColumnIndex == BookListColumn.Index)
                {
                    e.Value = "Show";
                }

                if (e.ColumnIndex == btnEdit.Index)
                {
                    e.Value = "Edit";
                }

                if (e.ColumnIndex == btnDelete.Index)
                {
                    e.Value = "Delete";
                }

                if (e.ColumnIndex == languageColumn.Index)
                {
                    e.Value = book.Language.long_text;
                }

                if (e.ColumnIndex == PublisherColumn.Index)
                {
                    e.Value = book.Publisher.name;
                }

                if (e.ColumnIndex == ratings_countColumn.Index)
                {
                    e.Value = $"{book.average_rating} ({book.ratings_count})";
                }

                if (e.ColumnIndex == publication_dateColumn.Index)
                {
                    e.Value = book.publication_date.ToString("dd MMMM yyyy");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterBooks();
        }

        void filterBooks()
        {
            resetState();
            int searchBy = (int)comboBox1.SelectedValue;
            var languageID = (int)comboBox2.SelectedValue;

            var query = db.Books.Where(f => f.deleted_at == null);

            if (languageID != 0)
            {
                query = query.Where(f => f.language_id == languageID).OrderBy
                    (f => f.Language.long_text);
            }

            if (searchBy == 1 && !string.IsNullOrEmpty(textBox1.Text))
            {
                query = query.Where(f => f.title.Contains(textBox1.Text));
            }

            if (searchBy == 2 && !string.IsNullOrEmpty(textBox1.Text))
            {
                query = query.Where(f => f.authors.Contains(textBox1.Text));
            }

            if (searchBy == 3 && !string.IsNullOrEmpty(textBox1.Text))
            {
                query = query.Where(f => f.Publisher.name.Contains(textBox1.Text));
            }

            if (!string.IsNullOrWhiteSpace(dateTimePicker1.Text) && !string.IsNullOrWhiteSpace(dateTimePicker2.Text))
            {
                var startDate = dateTimePicker1.Value;
                var endDate = dateTimePicker2.Value;
                query = query.Where(f => f.publication_date >= startDate && f.publication_date <= endDate).OrderBy(f => f.publication_date);
            }

            if (!string.IsNullOrEmpty(numericUpDown1.Text) && !string.IsNullOrEmpty(numericUpDown2.Text))
            {
                var pageStart = numericUpDown1.Value;
                var pageEnd = numericUpDown2.Value;
                query = query.Where(f => f.number_of_pages >= pageStart && f.number_of_pages <= pageEnd).OrderBy(f => f.number_of_pages);
            }

            if (!string.IsNullOrEmpty(numericUpDown3.Text) && !string.IsNullOrEmpty(numericUpDown4.Text))
            {
                var ratingStart = numericUpDown3.Value;
                var ratingEnd = numericUpDown4.Value;
                query = query.Where(f => f.average_rating >= (double)ratingStart && f.average_rating <= (double)ratingEnd).OrderBy(f => f.ratings_count);
            }

            bindingSource1.Clear();
            bindingSource1.DataSource = query.ToList().Take(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterBooks();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd MMMM yyyy";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].DataBoundItem is Book book)
            {
                if (e.ColumnIndex == BookListColumn.Index)
                {
                    new FormBookList(book).ShowDialog();
                }

                if (e.ColumnIndex == btnEdit.Index)
                {
                    var data = db.Books.Where(f => f.id == book.id).AsNoTracking().First();
                    bindingSource2.DataSource = data;
                    enableInput();
                }

                if (e.ColumnIndex == btnDelete.Index)
                {
                    if (Alerts.Confirm("Are you sure you want to delete the data?") == DialogResult.Yes)
                    {
                        book.deleted_at = DateTime.Now;
                        db.Books.AddOrUpdate(book);
                        int rows = db.SaveChanges();

                        if (rows > 0)
                        {
                            Alerts.Success("Book successfully deleted");
                            loadBooks();
                            return;
                        }

                        Alerts.Error("Failed to delete book");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSource2.Current is Book book)
            {
                if (!validate()) return;

                db.Books.AddOrUpdate(book);
                int rows = db.SaveChanges();
                if (rows > 0)
                {
                    Alerts.Success("Book successfully edited");
                    loadBooks();
                    resetState();
                    return;
                }

                Alerts.Error("Failed to edit Book");

            }
        }

        bool validate()
        {
            if (textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" ||
                (int)comboBox3.SelectedValue == 0 ||
                (int)comboBox4.SelectedValue == 0)
            {
                Alerts.Error("All input must be filled!");
                return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetState();
        }

    }
}
