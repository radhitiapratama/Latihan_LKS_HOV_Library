using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Library
{
    class AppContext : ApplicationContext
    {
        public AppContext(Form f)
        {
            f.FormClosed += F_FormClosed;
            f.Show();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            int count = Application.OpenForms.Cast<Form>().Where(f => f.TopLevel).Count();
            if (count == 0)
            {
                Application.Exit();
                ExitThread();
            }
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppContext(new LoginForm()));
        }
    }
}
