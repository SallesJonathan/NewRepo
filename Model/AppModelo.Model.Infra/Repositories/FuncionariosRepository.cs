using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionariosRepository
    {
        public bool Inserir(string nome, DateTime dataNascimento, bool sexo,
            string email, string telefone, string telefone_contato,
            string cep, string logradouro, int numero, string complemento,
            string bairro, string municipio, string uf, int nacionalidade,
            int naturalidade)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (nome, data_nascimento, genero," +
                $" email, telefone, telefone_contato, cep, logradouro, numero," +
                $" complemento, bairro, municipio, uf, id_nacionalidade," +
                $" id_naturalidade) VALUES ('{nome}', '{dataConvertida}', {sexo}," +
                $" '{email}', '{telefone}', '{telefone_contato}', '{cep}'," +
                $" '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}'," +
                $" '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        public IEnumerable<FuncionariosEntity> ObterTodos()
        {
            var sql = $"SELECT * FROM funcionarios order by id";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<FuncionariosEntity>(sql);

            return resultado;
        }

    }
}
