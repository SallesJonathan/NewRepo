using AppModelo.Model.Domain.Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {   
        //CRUD - create - read   - update - delete
        //       insert - select - update - delete  
        public bool Inserir(string descricao)
        {
            //string interpolation
            var sql = $"INSERT INTO nacionalidades (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Atualizar(string descricao, int id) 
        {
            var sql = $"UPDATE nacionalidades SET (descricao) = ('{descricao}') WHERE ID = ('{id}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
            
        }
        public bool Remover(int id) 
        {
            var sql = $"DELETE FROM nacionalidades WHERE ID = ('{id}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public IEnumerable<NacionalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM nacionalidades ORDER BY descricao DESC";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            
            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }
        public NacionalidadeEntity ObterPorId() 
        {
            return new NacionalidadeEntity();
        }

    }
}
