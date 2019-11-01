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
            try
            {
                string email = TBEmail.Text;
                string pass = TBPass.Text;
                //DataTable TB = new DataTable();
                //TB.Columns.Add("id");
                //TB.Columns.Add("Email");
                //TB.Columns.Add("Password");
                //TB.Columns.Add("id_role");
                this.LoginList.DataSource = userTableAdapter.GetDateUser(email, pass);

                var data = new sqlDataSetTableAdapters.UserTableAdapter().GetData().Rows.Count;

                var daa = Convert.ToString(new sqlDataSetTableAdapters.UserTableAdapter().GetData().Rows[0].ItemArray[1]); //Получения логина из базы данных
                //for (int i=0;i<data;i++)
                //{
                //    if(email== )&& pass == Convert.ToString(new sqlDataSetTableAdapters.UserTableAdapter().GetData().Columns[2]))
                //    {
                //        MessageBox.Show("OK");
                //        return;
                //    }
                //}
                
              


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


                if (LoginList.RowCount == 1)
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
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Reg registr = new Reg();
            this.Hide();
            registr.ShowDialog();
            TBEmail.Text = null;
            TBPass.Text = null;
            this.Show();
            this.userTableAdapter.Fill(this.sqlDataSet.User);



        }
    }
}
