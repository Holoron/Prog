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
    public partial class Realtor : Form
    {
        int id;
        public Realtor()
        {
            InitializeComponent();
        }
        public Realtor(int x)
        {
            InitializeComponent();
            id = x;
        }
    }
}
