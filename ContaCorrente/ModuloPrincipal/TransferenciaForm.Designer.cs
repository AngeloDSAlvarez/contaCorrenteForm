namespace ContaCorrente.ModuloPrincipal
{
    partial class TransferenciaForm
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
            statusStrip1 = new StatusStrip();
            btnConfirmar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtValor = new TextBox();
            label1 = new Label();
            lblValorOperacao = new Label();
            txtAgencia = new TextBox();
            label2 = new Label();
            txtConta = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtConta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAgencia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblValorOperacao);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 370);
            panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 348);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(378, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(212, 193, 212);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.FromArgb(114, 49, 114);
            btnConfirmar.Location = new Point(140, 288);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(124, 33);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Transferir";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(212, 193, 212);
            txtSenha.Font = new Font("Segoe UI", 15F);
            txtSenha.ForeColor = Color.FromArgb(114, 49, 114);
            txtSenha.Location = new Point(140, 215);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(200, 34);
            txtSenha.TabIndex = 8;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.FromArgb(212, 193, 212);
            lblSenha.Location = new Point(24, 220);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(76, 25);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(212, 193, 212);
            txtValor.Font = new Font("Segoe UI", 15F);
            txtValor.ForeColor = Color.FromArgb(114, 49, 114);
            txtValor.Location = new Point(140, 166);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(200, 34);
            txtValor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 193, 212);
            label1.Location = new Point(24, 171);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 5;
            label1.Text = "Valor";
            // 
            // lblValorOperacao
            // 
            lblValorOperacao.AutoSize = true;
            lblValorOperacao.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorOperacao.ForeColor = Color.FromArgb(212, 193, 212);
            lblValorOperacao.Location = new Point(64, 9);
            lblValorOperacao.Name = "lblValorOperacao";
            lblValorOperacao.Size = new Size(239, 32);
            lblValorOperacao.TabIndex = 1;
            lblValorOperacao.Text = "Transferir para";
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = Color.FromArgb(212, 193, 212);
            txtAgencia.Font = new Font("Segoe UI", 15F);
            txtAgencia.ForeColor = Color.FromArgb(114, 49, 114);
            txtAgencia.Location = new Point(140, 66);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.PasswordChar = '*';
            txtAgencia.Size = new Size(200, 34);
            txtAgencia.TabIndex = 12;
            txtAgencia.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(212, 193, 212);
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 11;
            label2.Text = "Agência";
            // 
            // txtConta
            // 
            txtConta.BackColor = Color.FromArgb(212, 193, 212);
            txtConta.Font = new Font("Segoe UI", 15F);
            txtConta.ForeColor = Color.FromArgb(114, 49, 114);
            txtConta.Location = new Point(140, 118);
            txtConta.Name = "txtConta";
            txtConta.PasswordChar = '*';
            txtConta.Size = new Size(200, 34);
            txtConta.TabIndex = 14;
            txtConta.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(212, 193, 212);
            label3.Location = new Point(24, 123);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 13;
            label3.Text = "Conta";
            // 
            // TransferenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 49, 114);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(378, 370);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TransferenciaForm";
            Text = "TransferenciaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtConta;
        private Label label3;
        private TextBox txtAgencia;
        private Label label2;
        private StatusStrip statusStrip1;
        private Button btnConfirmar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtValor;
        private Label label1;
        private Label lblValorOperacao;
    }
}