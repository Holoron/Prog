﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog
{
    public partial class FormAdmin : Form
    {
        int id;
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(int x)
        {
            InitializeComponent();
            id = x;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.sqlDataSet.User);

        }

        private void v_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
