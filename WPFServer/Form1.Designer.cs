namespace WPFServer
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
            this.bt_StartServer = new System.Windows.Forms.Button();
            this.tBox_StatusServer = new System.Windows.Forms.TextBox();
            this.bt_StopServer = new System.Windows.Forms.Button();
            this.labelServerStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_StartServer
            // 
            this.bt_StartServer.Location = new System.Drawing.Point(33, 94);
            this.bt_StartServer.Name = "bt_StartServer";
            this.bt_StartServer.Size = new System.Drawing.Size(93, 34);
            this.bt_StartServer.TabIndex = 0;
            this.bt_StartServer.Text = "Start Server";
            this.bt_StartServer.UseVisualStyleBackColor = true;
            this.bt_StartServer.Click += new System.EventHandler(this.bt_StartServer_Click);
            // 
            // tBox_StatusServer
            // 
            this.tBox_StatusServer.Location = new System.Drawing.Point(114, 52);
            this.tBox_StatusServer.Name = "tBox_StatusServer";
            this.tBox_StatusServer.Size = new System.Drawing.Size(165, 20);
            this.tBox_StatusServer.TabIndex = 1;
            this.tBox_StatusServer.Text = "Stop";
            this.tBox_StatusServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_StopServer
            // 
            this.bt_StopServer.Location = new System.Drawing.Point(175, 94);
            this.bt_StopServer.Name = "bt_StopServer";
            this.bt_StopServer.Size = new System.Drawing.Size(104, 34);
            this.bt_StopServer.TabIndex = 2;
            this.bt_StopServer.Text = "Stop Server";
            this.bt_StopServer.UseVisualStyleBackColor = true;
            this.bt_StopServer.Click += new System.EventHandler(this.bt_StopServer_Click);
            // 
            // labelServerStatus
            // 
            this.labelServerStatus.AutoSize = true;
            this.labelServerStatus.Location = new System.Drawing.Point(44, 55);
            this.labelServerStatus.Name = "labelServerStatus";
            this.labelServerStatus.Size = new System.Drawing.Size(67, 13);
            this.labelServerStatus.TabIndex = 3;
            this.labelServerStatus.Text = "server State:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 160);
            this.Controls.Add(this.labelServerStatus);
            this.Controls.Add(this.bt_StopServer);
            this.Controls.Add(this.tBox_StatusServer);
            this.Controls.Add(this.bt_StartServer);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_StartServer;
        private System.Windows.Forms.TextBox tBox_StatusServer;
        private System.Windows.Forms.Button bt_StopServer;
        private System.Windows.Forms.Label labelServerStatus;
    }
}

