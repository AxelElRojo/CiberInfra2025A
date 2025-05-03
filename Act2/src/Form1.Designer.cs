namespace Act2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUser = new TextBox();
            txtDB = new TextBox();
            txtPort = new TextBox();
            txtHost = new TextBox();
            txtPasswd = new TextBox();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 128);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Base de datos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 99);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Puerto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 70);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Host:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(104, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 1;
            // 
            // txtDB
            // 
            txtDB.Location = new Point(104, 128);
            txtDB.Name = "txtDB";
            txtDB.Size = new Size(100, 23);
            txtDB.TabIndex = 5;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(104, 99);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 4;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(104, 70);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(100, 23);
            txtHost.TabIndex = 3;
            // 
            // txtPasswd
            // 
            txtPasswd.Location = new Point(104, 41);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.PasswordChar = '●';
            txtPasswd.Size = new Size(100, 23);
            txtPasswd.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(64, 157);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 186);
            Controls.Add(btnConnect);
            Controls.Add(txtPasswd);
            Controls.Add(txtHost);
            Controls.Add(txtPort);
            Controls.Add(txtDB);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUser;
        private TextBox txtDB;
        private TextBox txtPort;
        private TextBox txtHost;
        private TextBox txtPasswd;
        private Button btnConnect;
    }
}
