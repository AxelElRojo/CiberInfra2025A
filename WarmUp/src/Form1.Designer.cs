namespace HolaMundo
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
            btnValidar = new Button();
            txtPasswd1 = new TextBox();
            txtPasswd2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(22, 102);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(177, 43);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += button1_Click;
            // 
            // txtPasswd1
            // 
            txtPasswd1.Location = new Point(22, 29);
            txtPasswd1.Name = "txtPasswd1";
            txtPasswd1.PasswordChar = '*';
            txtPasswd1.Size = new Size(177, 23);
            txtPasswd1.TabIndex = 1;
            txtPasswd1.TextChanged += textBox1_TextChanged;
            // 
            // txtPasswd2
            // 
            txtPasswd2.Location = new Point(22, 73);
            txtPasswd2.Name = "txtPasswd2";
            txtPasswd2.PasswordChar = '*';
            txtPasswd2.Size = new Size(177, 23);
            txtPasswd2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "Repite tu contraseña:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 152);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPasswd2);
            Controls.Add(txtPasswd1);
            Controls.Add(btnValidar);
            Name = "Form1";
            Text = "Validador";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private TextBox txtPasswd1;
        private TextBox txtPasswd2;
        private Label label1;
        private Label label2;
    }
}
