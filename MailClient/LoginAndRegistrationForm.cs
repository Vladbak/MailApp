using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace MailClient
{
    public partial class LoginAndRegistrationForm : Form
    {
        private bool wasConnected=false;

        public LoginAndRegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private bool Checkinput()
        {
            if (textBox_Login.TextLength<1)
            {
                MessageBox.Show("Пустое поле Id или имени!");
                return false;
            }

            if (textBox_Password.TextLength < 1)
            {
                MessageBox.Show("Пустое поле Пароля!");
                return false;
            }
            if (checkBox1.Checked)
            {

                if (textBox_surname.TextLength < 1)
                {
                    MessageBox.Show("Пустое поле фамилии!");
                    return false;
                }
            }
            return true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Checkinput())
                return;

            MailService.MailService ms = new MailService.MailService();
            //Если мы пытаемся зарегистрировать нового пользователя
            if (checkBox1.Checked)
            {
                int resultID = -1; ;
                if ((resultID= ms.NewUser(textBox_Login.Text, textBox_surname.Text, textBox_Password.Text)) == -1)
                {
                    MessageBox.Show("Не удалось зарегистрировать пользователя");
                    User.CurrentID = -1;
                    wasConnected = false; 
                }
                else
                {
                    MessageBox.Show("Вы зарегистрированы, ваш ID "+resultID);
                    User.CurrentID = resultID;
                    wasConnected = true;
                    this.Close();
                    
                }

            }
            //Если мы пытаемся войти как новый пользователь
            else
            {
                int entered_id;
                int result = -1;
                try {
                    entered_id = Convert.ToInt32(textBox_Login.Text);
                }
                catch
                {
                    MessageBox.Show("Неправильный формат Id!");
                    return;
                }
                
                
                if ((result = ms.Login(textBox_Login.Text, textBox_Password.Text)) == entered_id)
                {
                    User.CurrentID = entered_id;
                    wasConnected = true;
                    MessageBox.Show("Успешно");
                    this.Close();
                } else if (result == -1)// Введен не тот пароль
                {
                    MessageBox.Show("Введен неверный пароль!");
                }
                else // сервис не нашел такой айди в БД
                {
                    MessageBox.Show("Такого пользователя не существует!");
                }
            }
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label_surname.Visible = true;
                textBox_surname.Visible = true;
                label_login.Text = "Имя";
            }
            else
            {
                label_surname.Visible = false;
                textBox_surname.Visible = false;
                label_login.Text = "ID";
            }
              
        }

        private void LoginAndRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (wasConnected == false)
                    User.CurrentID = -1;

            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
