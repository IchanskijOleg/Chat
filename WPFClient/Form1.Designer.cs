namespace WPFClient
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
            this.lable_FirstName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.bt_Send = new System.Windows.Forms.Button();
            this.tb_mess = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pColor = new System.Windows.Forms.Panel();
            this.rtfMessageAll = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lable_FirstName
            // 
            this.lable_FirstName.AutoSize = true;
            this.lable_FirstName.Location = new System.Drawing.Point(25, 15);
            this.lable_FirstName.Name = "lable_FirstName";
            this.lable_FirstName.Size = new System.Drawing.Size(52, 13);
            this.lable_FirstName.TabIndex = 2;
            this.lable_FirstName.Text = "MyName:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(83, 12);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(127, 20);
            this.textBox_FirstName.TabIndex = 3;
            this.textBox_FirstName.Text = "Oleg";
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(93, 249);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(75, 23);
            this.bt_Send.TabIndex = 5;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // tb_mess
            // 
            this.tb_mess.Location = new System.Drawing.Point(28, 200);
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.Size = new System.Drawing.Size(220, 20);
            this.tb_mess.TabIndex = 6;
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(216, 12);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(32, 21);
            this.pColor.TabIndex = 7;
            this.pColor.Click += new System.EventHandler(this.pColor_Click);
            this.pColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pColor_Paint);
            // 
            // rtfMessageAll
            // 
            this.rtfMessageAll.Enabled = false;
            this.rtfMessageAll.Location = new System.Drawing.Point(28, 38);
            this.rtfMessageAll.Name = "rtfMessageAll";
            this.rtfMessageAll.Size = new System.Drawing.Size(220, 144);
            this.rtfMessageAll.TabIndex = 0;
            this.rtfMessageAll.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 287);
            this.Controls.Add(this.rtfMessageAll);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.tb_mess);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.lable_FirstName);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lable_FirstName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.TextBox tb_mess;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.RichTextBox rtfMessageAll;
    }
}

