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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0x6d, 0x6d, 0x6d);
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Regis_Click(object sender, EventArgs e)
        {
            //aa
        }
    }
}
