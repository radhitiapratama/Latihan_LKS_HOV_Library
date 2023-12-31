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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void masterBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterMemberForm form = new MasterMemberForm();
            closeAllMdiChild();
            addMdiChild(form);
        }

        void closeAllMdiChild()
        {
            this.ActiveMdiChild?.Close();
        }

        void addMdiChild(Form f)
        {
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.ControlBox = false;
            f.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllMdiChild();
            addMdiChild(new MasterBookForm());
        }

        private void newBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllMdiChild();
            addMdiChild(new NewBorrowingForm());
        }

        private void allBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllMdiChild();
            addMdiChild(new AllBorrowingForm());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAllMdiChild();
            new AppContext(new LoginForm());
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeMDIBg();
        }

        public void ChangeMDIBg()
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }
    }
}
