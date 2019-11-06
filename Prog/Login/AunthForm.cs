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

        public void Clean()
        {
            TBEmail.Text = null;
            TBPass.Text = null;
            ProfileClass.Id_Roles = 0;
            ProfileClass.Id_profiles = 0;
        }

        private void Aunth_Click(object sender, EventArgs e)
        {
            try
            {
                string email = TBEmail.Text;
                string pass = TBPass.Text;
                if (string.IsNullOrWhiteSpace(TBEmail.Text))
                {
                    MessageBox.Show("Не введена почта");
                    return;
                }
                if (string.IsNullOrWhiteSpace(TBPass.Text))
                {
                    MessageBox.Show("Не введен пароль");
                    return;
                }


                if (new sqlDataSetTableAdapters.UserTableAdapter().GetData().Where(p => p.Email == TBEmail.Text && p.Password == TBPass.Text).Count() == 0)
                {
                    MessageBox.Show("Такой пользователь не зарегистрирован");
                    return;
                }
                else
                {



                    ProfileClass.Id_profiles = new sqlDataSetTableAdapters.UserTableAdapter().GetData().Where(p => p.Email == TBEmail.Text && p.Password == TBPass.Text).ElementAt(0).id_user;
                    ProfileClass.Id_Roles = new sqlDataSetTableAdapters.UserTableAdapter().GetData().Where(p => p.Email == TBEmail.Text && p.Password == TBPass.Text).ElementAt(0).id_role;
                    if (ProfileClass.Id_Roles == 1 && ProfileClass.Id_Roles == 4)
                    {
                        this.Hide();

                        new FormAdmin().ShowDialog();
                        Clean();
                        this.Show();
                    }
                    else
                    {
                        this.Hide();
                        new FormUser(ProfileClass.Id_Roles).ShowDialog();
                        Clean();
                        this.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка в нажатии кнопки Авторизация");
            }
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            try
            {
                Reg registr = new Reg();
                this.Hide();
                registr.ShowDialog();
                TBEmail.Text = null;
                TBPass.Text = null;
                this.Show();
                this.userTableAdapter.Fill(this.sqlDataSet.User);
            }
            catch (Exception)
            {

                throw;
            }
            



        }
    }
}
