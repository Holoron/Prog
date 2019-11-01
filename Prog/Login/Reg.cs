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

            string email = TBEmail.Text;
            string pass = TBPass.Text;
            int Pref = CBPref.SelectedIndex;
            string Phone = Convert.ToString(TBPhone.Text);
            string Name = TBName.Text;



            LoginList.DataSource = UserTA.GetEmail(email);
            if (LoginList.RowCount >= 1)
            {
                MessageBox.Show("Такой пользователь уже существует");
                return;
            }

            //UserTA.InserUser(email, pass, Pref, DateTime.Now, Phone, Name);
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
