namespace ContaCorrente.ModuloPrincipal
{
    partial class ValorOperacaoForm
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Size = new Size(357, 236);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 214);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(357, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(212, 193, 212);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.FromArgb(114, 49, 114);
            btnConfirmar.Location = new Point(124, 170);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(124, 33);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(212, 193, 212);
            txtSenha.Font = new Font("Segoe UI", 15F);
            txtSenha.ForeColor = Color.FromArgb(114, 49, 114);
            txtSenha.Location = new Point(140, 115);
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
            lblSenha.Location = new Point(24, 120);
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
            txtValor.Location = new Point(140, 65);
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
            label1.Location = new Point(24, 70);
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
            lblValorOperacao.Location = new Point(12, 9);
            lblValorOperacao.Name = "lblValorOperacao";
            lblValorOperacao.Size = new Size(328, 32);
            lblValorOperacao.TabIndex = 1;
            lblValorOperacao.Text = "Confirme a operação";
            // 
            // ValorOperacaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 49, 114);
            ClientSize = new Size(357, 236);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ValorOperacaoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ValorOperacaoForm";
            Load += ValorOperacaoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblValorOperacao;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtValor;
        private Label label1;
        private StatusStrip statusStrip1;
        private Button btnConfirmar;
    }
}