using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Library
{
    public partial class LoginForm : Form
    {
        HovLibraryEntities db = new HovLibraryEntities();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Alerts.Error("Email must be filled!");
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                Alerts.Error("Password must be filled!");
                return;
            }

            string pass = Hash.make(textBox2.Text);

            var emp = db.Employees.Where(f => f.email == textBox1.Text && f.password == pass).FirstOrDefault();
            if (emp == null)
            {
                Alerts.Error("Employee not found!");
                return;
            }

            new AppContext(new MainForm());
            this.Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "ghuriche0@skyrock.com";
            textBox2.Text = "admin1";
        }
    }
}
