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
    public partial class Show_Letter : Form
    {
       public int Letter_id;

        public Show_Letter()
        {
            InitializeComponent();
        }

        private void Show_Letter_Load(object sender, EventArgs e)
        {
            using (MailService.MailService ms = new MailService.MailService())
            {
                try {
                    DataSet ds = ms.GetMail(Letter_id);
                    DataRow row = ds.Tables[0].Rows[0];
                    label_reciever.Text = row.Field<string>("recieverSurname").ToString() + " " + row.Field<string>("recieverName").ToString();
                    label_Sender.Text = row.Field<string>("senderSurname").ToString() + " " + row.Field<string>("senderName").ToString();
                    label_time.Text = row.Field<DateTime>("time").ToString();
                    label_title.Text = row.Field<string>("title").ToString();
                    richTextBox_letter.Text = row.Field<string>("text").ToString();
                }
                catch
                {
                    MessageBox.Show("Письмо не найдено!");
                }
            }
            

        }
    }
}
