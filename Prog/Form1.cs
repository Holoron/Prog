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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.sqlDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlData.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.sqlData.User);

        }

        private void Aunth_Click(object sender, EventArgs e)
        {

        }
    }
}
