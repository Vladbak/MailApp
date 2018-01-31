using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mailDataSet1.Mail_table". При необходимости она может быть перемещена или удалена.
            this.mail_tableTableAdapter.Fill(this.mailDataSet1.Mail_table);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
           
            
            
        }
    }
}
