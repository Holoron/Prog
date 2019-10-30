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
    public partial class AunthForm : Form
    {
        public AunthForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sqlDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.sqlDataSet.User);





        }

        private void Aunth_Click(object sender, EventArgs e)
        {

            string email = TBEmail.Text;
            string pass = TBPass.Text;
            bool login = false;
            int i;

            for (i = 0; i < Users.RowCount; i++)
            {
                string DefEmail = Convert.ToString(Users[1, i].Value);
                string DefPass = Convert.ToString(Users[2, i].Value);
                if (email==DefEmail)
                {
                    if(pass==DefPass)
                    {
                        login = true;
                        break;
                    }
                }
            }

            if (login == true)
            {
                int role = Convert.ToInt16(Users[3, i].Value);
                switch (role)
                {
                    case 1: {
                            FormUser FU = new FormUser();
                            this.Hide();
                            FU.ShowDialog();
                            this.Show();
                        }
                        break;
                    case 2:
                        {
                            Realtor FU = new Realtor();
                            this.Hide();
                            FU.ShowDialog();
                            this.Show();
                        }
                        break;
                    case 3:
                        {
                            FormAdmin FU = new FormAdmin();
                            this.Hide();
                            FU.ShowDialog();
                            this.Show();
                        }
                        break;


                    default:
                        break;
                }
            }
        }
    }
}
