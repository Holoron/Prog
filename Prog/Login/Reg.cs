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
            try
            {
                this.BackColor = Color.FromArgb(0x6d, 0x6d, 0x6d);
                this.ShowIcon = false;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка в загрузке формы");
            }
          

        }

        private void Regis_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
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
            if (string.IsNullOrWhiteSpace(TBPhone.Text))
            {
                MessageBox.Show("Не введен номер телефона");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBName.Text))
            {
                MessageBox.Show("Не введено имя");
                return;
            }


            string email = TBEmail.Text;
            string pass = TBPass.Text;
            int Pref = CBPref.SelectedIndex+1;
            string Phone = Convert.ToString(TBPhone.Text);
            string Name = TBName.Text;

            label1.Text = TBPhone.Text;

            this.LoginList.DataSource = UserTA.GetEmail(email);
            if (LoginList.RowCount >= 1)
            {
                MessageBox.Show("Такой пользователь уже существует");
                return;
            }

            UserTA.InserUser(email, pass, Pref, DateTime.Now, Phone, Name);
            MessageBox.Show("Пользователь зарегистрирован");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
