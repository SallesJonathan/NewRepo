using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //1 passo validar o e-mail
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if(emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está errado");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuarioEncontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@admin.com";
            txtSenha.Text = "admin";
        }
    }
}
