using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppModelo.View.Windows
{
    public partial class frmListadeFuncionarios : Form
    {
        public frmListadeFuncionarios()
        {
            InitializeComponent();
            FuncionarioController _controller = new FuncionarioController();
            var listaDeFuncionarios = _controller.ObterTodosFunc();
            dataGridView.DataSource = listaDeFuncionarios;
            gerirGrid();

        }
        /// <summary>
        /// Função para identar Data grid view, trazendo apenas as colunas nas quais ele gostaria de mostrar ao usuario 
        /// </summary>
        public void gerirGrid()
        {
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "nacionalidade";
            dataGridView.Columns[2].HeaderText = "naturalidade";
            dataGridView.Columns[3].HeaderText = "nome";
            dataGridView.Columns[4].HeaderText = "Data de nascimento";
            dataGridView.Columns[5].HeaderText = "sexo";
            dataGridView.Columns[6].HeaderText = "email";
            dataGridView.Columns[7].HeaderText = "telefone";
            dataGridView.Columns[8].HeaderText = "telefone_contato";
            dataGridView.Columns[9].HeaderText = "cep";
            dataGridView.Columns[10].HeaderText = "logradouro";
            dataGridView.Columns[11].HeaderText = "numero";
            dataGridView.Columns[12].HeaderText = "complemento";
            dataGridView.Columns[13].HeaderText = "bairro";
            dataGridView.Columns[14].HeaderText = "municipio";
            dataGridView.Columns[15].HeaderText = "uf";
           

            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].Visible = false;
            dataGridView.Columns[10].Visible = false;
            dataGridView.Columns[11].Visible = false;
            dataGridView.Columns[12].Visible = false;
            dataGridView.Columns[13].Visible = false;
            dataGridView.Columns[14].Visible = false;
            dataGridView.Columns[15].Visible = false;
        }

    }
}
