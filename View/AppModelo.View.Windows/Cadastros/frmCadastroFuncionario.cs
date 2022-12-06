using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);

        }



        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instancia do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //primeira regra nome < que 6 letras
            if (txtNome.Text.Length < 6 || txtNome.Text == "")
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }

            //verifica se digitou algum numero

            //SomenteLetras();
            //VerificarSeExisteNumeroNoTexto();

            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();


        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }


        /// <summary>
        /// Ação de Botão para Salvar elementos digitados pelo usuario
        /// </summary>
        /// <param object="sender"></param>
        /// <param evento="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            {

                if (ValidarForm())
                {
                    var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                    int numero = int.Parse(txtEnderecoNumero.Text);
                    var obterIndexNacionalidade = cmbNacionalidade.SelectedValue;
                    var obterIndexNaturalidade = cmbNacionalidade.SelectedValue;
                    int nacionalidade = Convert.ToInt32(obterIndexNacionalidade);
                    int naturalidade = Convert.ToInt32(obterIndexNaturalidade);


                    var salvou = _funcionarioController.Cadastrar(txtNome.Text, dataNascimento, rbMasculino.Checked,
                        txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text,
                        numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text,
                        nacionalidade, naturalidade);

                    MessageBox.Show("Salvo com sucesso");

                    LimparDadosfrm.VerificaTexto(this);
                }

            }
        }

        private void cmbNaturalidade_Click(object sender, EventArgs e)
        {
            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
            cmbNaturalidade.ValueMember = "id";
        }

        private void cmbNacionalidade_Click(object sender, EventArgs e)
        {
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "id";
        }

        private bool ValidarForm()
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo! ");
                txtNome.Focus();    
                return false;
            }
            else if (txtDataNascimento.Text == "  /  /    ")
            {
                MessageBox.Show("Preencha o campo! ");
                txtNome.Focus();
                return false;
            }
            else if (txtCpf.Text == "   .   .   -  ")
            {
                MessageBox.Show("Preencha o campo! ");
                txtNome.Focus();
                return false;
            }
            else if (cmbNacionalidade.Text == "")
            {
                MessageBox.Show("Preencha o campo! ");
                txtNome.Focus();
                return false;
            }
            else if (cmbNaturalidade.Text == "")
            {
                MessageBox.Show("Preencha o campo! ");
                txtNome.Focus();
                return false;
            }
            else if (txtEnderecoCep.Text == "")
            {
                MessageBox.Show("Preencha o campo! ");
                txtNome.Focus();
                return false;
            }
            return true;    

        } 
    }
}
