namespace AppModelo.View.Windows
{
    partial class frmPrincipal
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
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarNovoFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nacionalidadesToolStripMenuItem,
            this.naturalidadesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // nacionalidadesToolStripMenuItem
            // 
            this.nacionalidadesToolStripMenuItem.Name = "nacionalidadesToolStripMenuItem";
            this.nacionalidadesToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.nacionalidadesToolStripMenuItem.Text = "Nacionalidades";
            // 
            // naturalidadesToolStripMenuItem
            // 
            this.naturalidadesToolStripMenuItem.Name = "naturalidadesToolStripMenuItem";
            this.naturalidadesToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.naturalidadesToolStripMenuItem.Text = "Naturalidades";
            this.naturalidadesToolStripMenuItem.Click += new System.EventHandler(this.naturalidadesToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListaDeFuncionariosToolStripMenuItem,
            this.cadastrarNovoFuncionarioToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // ListaDeFuncionariosToolStripMenuItem
            // 
            this.ListaDeFuncionariosToolStripMenuItem.Name = "ListaDeFuncionariosToolStripMenuItem";
            this.ListaDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.ListaDeFuncionariosToolStripMenuItem.Text = "lista de funcionarios";
            this.ListaDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.ListaDeFuncionariosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.funcionariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarNovoFuncionarioToolStripMenuItem
            // 
            this.cadastrarNovoFuncionarioToolStripMenuItem.Name = "cadastrarNovoFuncionarioToolStripMenuItem";
            this.cadastrarNovoFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.cadastrarNovoFuncionarioToolStripMenuItem.Text = "Cadastrar novo funcionario";
            this.cadastrarNovoFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoFuncionarioToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ListaDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoFuncionarioToolStripMenuItem;
    }
}