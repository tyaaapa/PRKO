using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.Collections;

namespace PRKO
{
    public partial class AddForm : Form
    {
        public static AuthForm f1 = new AuthForm();
        public static MenuForm f2 = new MenuForm();
        public static UristForm f3 = new UristForm();
        public static AddForm f4 = new AddForm();

        public AddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Улица". При необходимости она может быть перемещена или удалена.
            this.улицаTableAdapter.Fill(this.pRKODataSet.Улица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Город". При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.pRKODataSet.Город);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Тип_документа". При необходимости она может быть перемещена или удалена.
            this.тип_документаTableAdapter.Fill(this.pRKODataSet.Тип_документа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.pRKODataSet.Специальность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this.pRKODataSet.Факультет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Учебное_заведение". При необходимости она может быть перемещена или удалена.
            this.учебное_заведениеTableAdapter.Fill(this.pRKODataSet.Учебное_заведение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Гражданство". При необходимости она может быть перемещена или удалена.
            this.гражданствоTableAdapter.Fill(this.pRKODataSet.Гражданство);

        }
    }
}
