using System;
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
    public partial class FormUser : Form
    {
        int id;
        public FormUser()
        {
            InitializeComponent();
        }
        public FormUser(int x)
        {
            id = x;
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        { 
        }
    }
}
