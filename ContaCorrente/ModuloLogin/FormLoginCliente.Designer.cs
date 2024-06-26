namespace ContaCorrente.ModuloLogin
{
    partial class FormLoginCliente
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
            panel1 = new Panel();
            statusStripLogin = new StatusStrip();
            btnLogin = new Button();
            txtSenha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtCpf = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(statusStripLogin);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 383);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // statusStripLogin
            // 
            statusStripLogin.Location = new Point(0, 361);
            statusStripLogin.Name = "statusStripLogin";
            statusStripLogin.Size = new Size(403, 22);
            statusStripLogin.TabIndex = 6;
            statusStripLogin.Text = "statusStrip1";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(212, 193, 212);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(114, 49, 114);
            btnLogin.Location = new Point(151, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(212, 193, 212);
            txtSenha.Font = new Font("Segoe UI", 15F);
            txtSenha.ForeColor = Color.FromArgb(114, 49, 114);
            txtSenha.Location = new Point(171, 154);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(200, 34);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(212, 193, 212);
            label3.Location = new Point(55, 159);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(212, 193, 212);
            label2.Location = new Point(55, 30);
            label2.Name = "label2";
            label2.Size = new Size(316, 32);
            label2.TabIndex = 2;
            label2.Text = "Entre em sua conta!";
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.FromArgb(212, 193, 212);
            txtCpf.Font = new Font("Segoe UI", 15F);
            txtCpf.ForeColor = Color.FromArgb(114, 49, 114);
            txtCpf.Location = new Point(171, 104);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(200, 34);
            txtCpf.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 193, 212);
            label1.Location = new Point(55, 109);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // FormLoginCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 49, 114);
            ClientSize = new Size(403, 383);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLoginCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entre em sua conta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtCpf;
        private Label label2;
        private Button btnLogin;
        private TextBox txtSenha;
        private Label label3;
        private StatusStrip statusStripLogin;
    }
}