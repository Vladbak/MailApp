namespace MailClient
{
    partial class Show_Letter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_reciever = new System.Windows.Forms.Label();
            this.label_Sender = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.richTextBox_letter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отправитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Получатель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время отправления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Название";
            // 
            // label_reciever
            // 
            this.label_reciever.AutoSize = true;
            this.label_reciever.Location = new System.Drawing.Point(201, 36);
            this.label_reciever.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_reciever.Name = "label_reciever";
            this.label_reciever.Size = new System.Drawing.Size(68, 19);
            this.label_reciever.TabIndex = 4;
            this.label_reciever.Text = "Ошибка!";
            // 
            // label_Sender
            // 
            this.label_Sender.AutoSize = true;
            this.label_Sender.Location = new System.Drawing.Point(201, 17);
            this.label_Sender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sender.Name = "label_Sender";
            this.label_Sender.Size = new System.Drawing.Size(68, 19);
            this.label_Sender.TabIndex = 3;
            this.label_Sender.Text = "Ошибка!";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(201, 73);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(68, 19);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Ошибка!";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(201, 55);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(68, 19);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "Ошибка!";
            // 
            // richTextBox_letter
            // 
            this.richTextBox_letter.Location = new System.Drawing.Point(12, 102);
            this.richTextBox_letter.Name = "richTextBox_letter";
            this.richTextBox_letter.ReadOnly = true;
            this.richTextBox_letter.Size = new System.Drawing.Size(628, 186);
            this.richTextBox_letter.TabIndex = 8;
            this.richTextBox_letter.Text = "";
            // 
            // Show_Letter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 300);
            this.Controls.Add(this.richTextBox_letter);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_reciever);
            this.Controls.Add(this.label_Sender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Show_Letter";
            this.ShowIcon = false;
            this.Text = "Письмо";
            this.Load += new System.EventHandler(this.Show_Letter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_reciever;
        private System.Windows.Forms.Label label_Sender;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.RichTextBox richTextBox_letter;
    }
}