using AppModelo.Controller.Cadastros;
using AppModelo.View.Windows.Helpers;
using System;
using System.Windows.Forms;


namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var vazio = Helpers.CaixaVazia.NaoExisteTexto(txtDescricao.Text);
            var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);

            if (vazio)
            {
                MessageBox.Show("Caixa Vazia, entre com descrição!");
            }                   
            else if (salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados"); 

            }
        }

        private void gvNacionalidades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = gvNacionalidades.Rows[e.RowIndex];
            String mostrar = linha.Cells[0].Value.ToString();
            txtId.Text = mostrar;
            
            MessageBox.Show(mostrar);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var vazio = Helpers.CaixaVazia.NaoExisteTexto(txtDescricao.Text);

            var id = int.Parse(txtId.Text);

            _nacionalidadeController.Deletar(id);

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;

         }

        private void gvNacionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
