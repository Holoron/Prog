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

            this.userTableAdapter.Fill(this.sqlDataSet.User);
            this.BackColor = Color.FromArgb(0x6d, 0x6d, 0x6d);
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Aunth_Click(object sender, EventArgs e)
        {
            string email = TBEmail.Text;
            string pass = TBPass.Text;
            //DataTable TB = new DataTable();
            //TB.Columns.Add("id");
            //TB.Columns.Add("Email");
            //TB.Columns.Add("Password");
            //TB.Columns.Add("id_role");
            LoginList.DataSource = userTableAdapter.GetDateUser(email, pass);



            if (TBEmail == null)
            {
                MessageBox.Show("Не введена почта");
                return;
            }
            if (TBPass == null)
            {
                MessageBox.Show("Не введен пароль");
                return;
            }


            if(LoginList.RowCount == 1)
            {
                int role = Convert.ToInt16(LoginList[3, 0].Value);
                int userid = Convert.ToInt16(LoginList[0, 0].Value);
                switch (role)
                {
                    case 1:
                        {
                            FormUser FU = new FormUser(userid);
                            this.Hide();
                            FU.ShowDialog();
                            this.Show();
                        }
                        break;
                    case 2:
                        {
                            Realtor FU = new Realtor(userid);
                            this.Hide();
                            FU.ShowDialog();
                            this.Show();
                        }
                        break;
                    case 3:
                        {
                            FormAdmin FU = new FormAdmin(userid);
                            this.Hide();
                            FU.ShowDialog();
                            this.Show();
                        }
                        break;


                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя нет, зарегистрируйтесь");
                return;
            }
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Reg registr = new Reg();
            this.Hide();
            registr.ShowDialog();
            this.Show();
            this.userTableAdapter.Fill(this.sqlDataSet.User);


        }
    }
}
