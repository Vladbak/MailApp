namespace MailClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mailDataSet1 = new MailClient.MailDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mailDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Send_button = new System.Windows.Forms.Button();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.mailtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mail_tableTableAdapter = new MailClient.MailDataSetTableAdapters.Mail_tableTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailtableBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mailDataSet1
            // 
            this.mailDataSet1.DataSetName = "MailDataSet";
            this.mailDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.senderIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.recieverIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mailtableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mailDataSet1BindingSource
            // 
            this.mailDataSet1BindingSource.DataSource = this.mailDataSet1;
            this.mailDataSet1BindingSource.Position = 0;
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(486, 328);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(94, 54);
            this.Send_button.TabIndex = 1;
            this.Send_button.Text = "Отправить новое письмо";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(597, 328);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(94, 54);
            this.Refresh_button.TabIndex = 2;
            this.Refresh_button.Text = "Обновить";
            this.Refresh_button.UseVisualStyleBackColor = true;
            // 
            // mailtableBindingSource
            // 
            this.mailtableBindingSource.DataMember = "Mail_table";
            this.mailtableBindingSource.DataSource = this.mailDataSet1BindingSource;
            // 
            // mail_tableTableAdapter
            // 
            this.mail_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 370);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Входящие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Исходящие";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.textDataGridViewTextBoxColumn1,
            this.recieverIDDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1,
            this.senderIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.mailtableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(448, 332);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDataGridViewTextBoxColumn.Visible = false;
            // 
            // senderIDDataGridViewTextBoxColumn
            // 
            this.senderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.senderIDDataGridViewTextBoxColumn.DataPropertyName = "SenderID";
            this.senderIDDataGridViewTextBoxColumn.HeaderText = "Отправитель";
            this.senderIDDataGridViewTextBoxColumn.Name = "senderIDDataGridViewTextBoxColumn";
            this.senderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderIDDataGridViewTextBoxColumn.Width = 98;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время отправления";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recieverIDDataGridViewTextBoxColumn
            // 
            this.recieverIDDataGridViewTextBoxColumn.DataPropertyName = "RecieverID";
            this.recieverIDDataGridViewTextBoxColumn.HeaderText = "RecieverID";
            this.recieverIDDataGridViewTextBoxColumn.Name = "recieverIDDataGridViewTextBoxColumn";
            this.recieverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recieverIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // textDataGridViewTextBoxColumn1
            // 
            this.textDataGridViewTextBoxColumn1.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn1.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn1.Name = "textDataGridViewTextBoxColumn1";
            this.textDataGridViewTextBoxColumn1.ReadOnly = true;
            this.textDataGridViewTextBoxColumn1.Visible = false;
            // 
            // recieverIDDataGridViewTextBoxColumn1
            // 
            this.recieverIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.recieverIDDataGridViewTextBoxColumn1.DataPropertyName = "RecieverID";
            this.recieverIDDataGridViewTextBoxColumn1.HeaderText = "Получатель";
            this.recieverIDDataGridViewTextBoxColumn1.Name = "recieverIDDataGridViewTextBoxColumn1";
            this.recieverIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.recieverIDDataGridViewTextBoxColumn1.Width = 91;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Время отправления";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn1.Width = 122;
            // 
            // senderIDDataGridViewTextBoxColumn1
            // 
            this.senderIDDataGridViewTextBoxColumn1.DataPropertyName = "SenderID";
            this.senderIDDataGridViewTextBoxColumn1.HeaderText = "SenderID";
            this.senderIDDataGridViewTextBoxColumn1.Name = "senderIDDataGridViewTextBoxColumn1";
            this.senderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.senderIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 394);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.Send_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mailDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailtableBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MailDataSet mailDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mailDataSet1BindingSource;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.BindingSource mailtableBindingSource;
        private MailDataSetTableAdapters.Mail_tableTableAdapter mail_tableTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderIDDataGridViewTextBoxColumn1;
    }
}

