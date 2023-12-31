using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Library
{
    public partial class MasterMemberForm : Form
    {
        HovLibraryEntities db = new HovLibraryEntities();

        public MasterMemberForm()
        {
            InitializeComponent();
        }

        private void MasterMemberForm_Load(object sender, EventArgs e)
        {
            bindingSource2.AddNew();
            loadMember();
            resetState();
        }

        void loadMember()
        {
            bindingSource1.Clear();
            bindingSource1.DataSource = db.Members.OrderBy(f => f.name).Where(f => f.deleted_at == null).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].DataBoundItem is Member member)
            {
                if (e.ColumnIndex == btnEditColumn.Index)
                {
                    var dataMember = db.Members.Where(f => f.id == member.id).AsNoTracking().First();
                    bindingSource2.DataSource = dataMember;
                    enableInput();

                    radioButton1.Checked = dataMember.gender == "Male";
                    radioButton2.Checked = dataMember.gender == "Female";
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Member member)
            {
                if (e.ColumnIndex == btnEditColumn.Index)
                {
                    e.Value = "Edit";
                }
            }
        }

        void enableInput()
        {
            Control[] controls =
            {
                textBox1,textBox2,textBox3,textBox4,textBox5,dateTimePicker1,radioButton1,radioButton2,button1,button2
            };

            foreach (Control c in controls)
            {
                c.Enabled = true;
            }
        }

        void resetState()
        {
            bindingSource2.Clear();
            bindingSource2.AddNew();

            Control[] controls =
           {
                textBox1,textBox2,textBox3,textBox4,textBox5,dateTimePicker1,radioButton1,radioButton2,button1,button2
            };

            foreach (Control c in controls)
            {
                c.Enabled = false;
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            if (bindingSource1.Current is Member member)
            {
                member.gender = radioButton1.Checked ? "Male" : "Female";
                member.date_of_birth = dateTimePicker1.Value;
                db.Members.AddOrUpdate(member);
                int rows = db.SaveChanges();

                if (rows > 0)
                {
                    Alerts.Success("Member succesfully edited");
                    loadMember();
                    resetState();
                    return;
                }
                Alerts.Error("Member failed to edit");
            }
        }

        bool validate()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || !radioButton1.Checked && !radioButton2.Checked)
            {
                Alerts.Error("All input must be filled");
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetState();
        }
    }
}
