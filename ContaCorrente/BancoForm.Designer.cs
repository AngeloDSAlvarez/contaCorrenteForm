namespace ContaCorrente
{
    partial class BancoForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSacar = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnSair = new Button();
            checkedListBox1 = new CheckedListBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSacar);
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
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnSair);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(113, 3);
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
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(959, 573);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1215, 359);
            panel2.TabIndex = 2;
            // 
            // BancoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 49, 114);
            ClientSize = new Size(1230, 570);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BancoForm";
            Text = "BancoForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBemVindo;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSacar;
        private CheckedListBox checkedListBox1;
        private Label lblNome;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnSair;
        private Panel panel2;
    }
}