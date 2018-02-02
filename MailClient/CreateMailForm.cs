using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailClient;

namespace MailClient
{
    public partial class CreateMailForm : Form
    {
        public CreateMailForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Send_mail_button_Click(object sender, EventArgs e)
        {
            //TextBox_Reciever.Text = DateTime.Now.ToString();
            MailService.MailService ms = new MailService.MailService();
            if (!ms.Insert(RichTextBox_Letter.Text, System.DateTime.Now, TextBox_title_letter.Text, User.CurrentID, Convert.ToInt32(comboBox_reciever.SelectedValue))) 
                MessageBox.Show("Ошибка");
            else
                MessageBox.Show("Сообщение отправлено");
            Close();

        }

        private void CreateMailForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mailServiceDBDataSet.EmployeeTable". При необходимости она может быть перемещена или удалена.
            this.employeeTableTableAdapter.Fill(this.mailServiceDBDataSet.EmployeeTable);

        }

    }
}
