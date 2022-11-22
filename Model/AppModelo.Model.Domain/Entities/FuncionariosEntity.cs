using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    public class FuncionariosEntity
    {
        public int Id { get; set; }
        public int id_naturalidade { get; set; }
        public int id_nacionalidade { get; set; }
        public String nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public int genero { get; set; }
        public String cpf { get; set; }
        public String email { get; set; }
        public String telefone { get; set; }
        public String telefone_contato { get; set; }
        public String cep { get; set; }
        public String logradouro { get; set; }
        public int numero { get; set; }
        public String complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }


    }
}
