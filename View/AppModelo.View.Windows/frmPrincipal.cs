using AppModelo.Controller.Cadastros;
using AppModelo.View.Windows.Cadastros;
using AppModelo.View.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmPrincipal : Form
    {
        private FuncionarioController _controller = new FuncionarioController();

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void naturalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.MdiParent = this;
            form.Show();

        }

        private void ListaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmListadeFuncionarios();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarNovoFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }
    }
}
