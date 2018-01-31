namespace MailClient
{
    partial class CreateMailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Reciever = new System.Windows.Forms.TextBox();
            this.TextBox_title_letter = new System.Windows.Forms.TextBox();
            this.RichTextBox_Letter = new System.Windows.Forms.RichTextBox();
            this.Button_send_mail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отправить новое письмо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адресат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст письма";
            // 
            // TextBox_Reciever
            // 
            this.TextBox_Reciever.Location = new System.Drawing.Point(74, 44);
            this.TextBox_Reciever.MaxLength = 1000;
            this.TextBox_Reciever.Name = "TextBox_Reciever";
            this.TextBox_Reciever.Size = new System.Drawing.Size(284, 20);
            this.TextBox_Reciever.TabIndex = 7;
            // 
            // TextBox_title_letter
            // 
            this.TextBox_title_letter.Location = new System.Drawing.Point(74, 78);
            this.TextBox_title_letter.MaxLength = 1000;
            this.TextBox_title_letter.Name = "TextBox_title_letter";
            this.TextBox_title_letter.Size = new System.Drawing.Size(284, 20);
            this.TextBox_title_letter.TabIndex = 8;
            // 
            // RichTextBox_Letter
            // 
            this.RichTextBox_Letter.Location = new System.Drawing.Point(16, 138);
            this.RichTextBox_Letter.MaxLength = 10000;
            this.RichTextBox_Letter.Name = "RichTextBox_Letter";
            this.RichTextBox_Letter.Size = new System.Drawing.Size(342, 144);
            this.RichTextBox_Letter.TabIndex = 9;
            this.RichTextBox_Letter.Text = "";
            // 
            // Button_send_mail
            // 
            this.Button_send_mail.Location = new System.Drawing.Point(16, 297);
            this.Button_send_mail.Name = "Button_send_mail";
            this.Button_send_mail.Size = new System.Drawing.Size(101, 33);
            this.Button_send_mail.TabIndex = 10;
            this.Button_send_mail.Text = "Отправить";
            this.Button_send_mail.UseVisualStyleBackColor = true;
            this.Button_send_mail.Click += new System.EventHandler(this.Send_mail_button_Click);
            // 
            // CreateMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 342);
            this.Controls.Add(this.Button_send_mail);
            this.Controls.Add(this.RichTextBox_Letter);
            this.Controls.Add(this.TextBox_title_letter);
            this.Controls.Add(this.TextBox_Reciever);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "CreateMailForm";
            this.ShowIcon = false;
            this.Text = "Письмо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Reciever;
        private System.Windows.Forms.TextBox TextBox_title_letter;
        private System.Windows.Forms.RichTextBox RichTextBox_Letter;
        private System.Windows.Forms.Button Button_send_mail;
    }
}