using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
         
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailService.MailService ms = new MailService.MailService();
            
            
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            CreateMailForm cmf = new CreateMailForm();
            cmf.ShowDialog();
            
            
        }

      

    

        private void Form1_Load(object sender, EventArgs e)
        {
            // открываем форму регистрации или входа в приложение
            LoginAndRegistrationForm lrf = new LoginAndRegistrationForm();
            lrf.ShowDialog();
            // Если не получилось зарегаться\войти\форма закрыта - выйти из приложения
            if (User.CurrentID == -1)
                Application.Exit();
            //Обновить таблицу исходящих писем
            this.mailTableTableAdapter1.Fill(this.dataSetOut.MailTable,   User.CurrentID);

            //Обновить таблицу входящих писем
            this.mailTableTableAdapter2.Fill(this.dataSetIn.MailTable,   User.CurrentID);


        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            using (Show_Letter show_letter_form = new Show_Letter())
            {
                show_letter_form.Letter_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                show_letter_form.ShowDialog();
            }

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            using (Show_Letter show_letter_form = new Show_Letter())
            {
                show_letter_form.Letter_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                show_letter_form.ShowDialog();
            }
        }

    
    }
}
