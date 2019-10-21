using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRKO
{
    public partial class UristForm : Form
    {
        public static AuthForm f1 = new AuthForm();
        public static MenuForm f2 = new MenuForm();
        public static UristForm f3 = new UristForm();

        public UristForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
