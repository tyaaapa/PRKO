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
        public static AddForm f4 = new AddForm();

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

        private void UristForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSkgyugkuбходимости она может быть перемещена или удалена.
            this.абитуриентTableAdapter.Fill(this.pRKODataSet.Абитуриент);

        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            абитуриентTableAdapter.Update(this.pRKODataSet.Абитуриент);
            String path = @"Z:\PRKO.mdb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            f4.ShowDialog();
            this.Close();
        }
    }
}
