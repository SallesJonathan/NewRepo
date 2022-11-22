using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    public class NaturalidadeEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
