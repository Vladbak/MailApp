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
                DataSet ds = ms.GetMail(Letter_id);
                label_reciever.Text = ds.Tables[0].Rows[0].Field<Int32>("recieverid").ToString();
                label_Sender.Text = ds.Tables[0].Rows[0].Field<Int32>("senderid").ToString();
                label_time.Text = ds.Tables[0].Rows[0].Field<DateTime>("time").ToString();
                label_title.Text = ds.Tables[0].Rows[0].Field<string>("title").ToString();
            }
            

        }
    }
}
