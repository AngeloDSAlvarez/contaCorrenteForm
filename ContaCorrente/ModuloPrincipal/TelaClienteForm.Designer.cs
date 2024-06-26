using System.Windows.Forms;

namespace ContaCorrente.ModuloPrincipal
{
    partial class TelaClienteForm
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
            lblBemVindo = new Label();
            panel1 = new Panel();
            lblNome = new Label();
            panel2 = new Panel();
            lblLimite = new Label();
            label4 = new Label();
            lblSaldo = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSacar = new Button();
            btnDepositar = new Button();
            btnTransferir = new Button();
            btnExtrato = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnSair = new Button();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = Color.FromArgb(212, 193, 212);
            lblBemVindo.Location = new Point(12, 9);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(315, 32);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem vindo de volta ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblBemVindo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 570);
            panel1.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(212, 193, 212);
            lblNome.Location = new Point(317, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 32);
            lblNome.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblLimite);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblSaldo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1215, 359);
            panel2.TabIndex = 2;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLimite.ForeColor = Color.FromArgb(212, 193, 212);
            lblLimite.Location = new Point(95, 83);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(24, 23);
            lblLimite.TabIndex = 5;
            lblLimite.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(212, 193, 212);
            label4.Location = new Point(3, 83);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 4;
            label4.Text = "Limite:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.ForeColor = Color.Red;
            lblSaldo.Location = new Point(95, 51);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(24, 23);
            lblSaldo.TabIndex = 3;
            lblSaldo.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(212, 193, 212);
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 2;
            label2.Text = "Saldo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 193, 212);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(305, 29);
            label1.TabIndex = 1;
            label1.Text = "Informações da conta";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSacar);
            flowLayoutPanel1.Controls.Add(btnDepositar);
            flowLayoutPanel1.Controls.Add(btnTransferir);
            flowLayoutPanel1.Controls.Add(btnExtrato);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(12, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1215, 39);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSacar
            // 
            btnSacar.BackColor = Color.FromArgb(212, 193, 212);
            btnSacar.FlatAppearance.BorderColor = Color.White;
            btnSacar.FlatAppearance.BorderSize = 0;
            btnSacar.FlatStyle = FlatStyle.Flat;
            btnSacar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSacar.ForeColor = Color.FromArgb(114, 49, 114);
            btnSacar.Location = new Point(3, 3);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(104, 31);
            btnSacar.TabIndex = 6;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = false;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.FromArgb(212, 193, 212);
            btnDepositar.FlatAppearance.BorderColor = Color.White;
            btnDepositar.FlatAppearance.BorderSize = 0;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDepositar.ForeColor = Color.FromArgb(114, 49, 114);
            btnDepositar.Location = new Point(113, 3);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(104, 31);
            btnDepositar.TabIndex = 7;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.FromArgb(212, 193, 212);
            btnTransferir.FlatAppearance.BorderColor = Color.White;
            btnTransferir.FlatAppearance.BorderSize = 0;
            btnTransferir.FlatStyle = FlatStyle.Flat;
            btnTransferir.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransferir.ForeColor = Color.FromArgb(114, 49, 114);
            btnTransferir.Location = new Point(223, 3);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(104, 31);
            btnTransferir.TabIndex = 8;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnExtrato
            // 
            btnExtrato.BackColor = Color.FromArgb(212, 193, 212);
            btnExtrato.FlatAppearance.BorderColor = Color.White;
            btnExtrato.FlatAppearance.BorderSize = 0;
            btnExtrato.FlatStyle = FlatStyle.Flat;
            btnExtrato.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExtrato.ForeColor = Color.FromArgb(114, 49, 114);
            btnExtrato.Location = new Point(333, 3);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.Size = new Size(104, 31);
            btnExtrato.TabIndex = 9;
            btnExtrato.Text = "Extrato";
            btnExtrato.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnSair);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(443, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(769, 31);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(212, 193, 212);
            btnSair.FlatAppearance.BorderColor = Color.White;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.FromArgb(114, 49, 114);
            btnSair.Location = new Point(662, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(104, 31);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(959, 573);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 2;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 49, 114);
            ClientSize = new Size(1230, 570);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaClienteForm";
            Text = "BancoForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBemVindo;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSacar;
        private Button btnDepositar;
        private Button btnTransferir;
        private Button btnExtrato;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label lblLimite;
        private Label label4;
        private Label lblSaldo;
        private CheckedListBox checkedListBox1;
        private Label lblNome;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnSair;
    }
}