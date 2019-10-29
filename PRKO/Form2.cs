﻿using System;
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
    public partial class MenuForm : Form
    {
        public static AuthForm f1 = new AuthForm();
        public static MenuForm f2 = new MenuForm();
        public static UristForm f3 = new UristForm();
        public static AddForm f4 = new AddForm();

        public MenuForm()
        {
            InitializeComponent();
        }
        
        private void юридическийФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
