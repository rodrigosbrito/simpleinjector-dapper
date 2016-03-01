using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using System.Data.SqlClient;
using Dapper;
using Domain;
using System.Data;

namespace Data
{
    public class MarcaRepository : IMarcaRepository
    {
        private IDbConnection _connection;

        private const string _insert = @"INSERT INTO Marcas(Nome) VALUES(@Nome)";
        private const string _update = @"UPDATE Marcas SET Nome = @Nome WHERE Id = @Id";
        private const string _select = @"SELECT Id, Nome FROM Marcas WHERE Id = @Id";
        private const string _selectAll = @"SELECT Id, Nome FROM Marcas";

        public MarcaRepository()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Documents\Visual Studio 2013\Projects\TesteSimpleInjector\DevBrito.TesteSimpleInjector\DevBrito.TesteSimpleInjector\App_Data\Database.mdf;Integrated Security=True");
        }
        public Domain.Marca Get(int id)
        {
            _connection.Open();
            return _connection.Query<Marca>(_select, new { Id = id }).SingleOrDefault();
        }

        public IEnumerable<Domain.Marca> GetAll()
        {
            _connection.Open();
            return _connection.Query(_selectAll) as IEnumerable<Marca>;
        }

        public void Adicionar(Domain.Marca marca)
        {
            _connection.Open();

            if (marca.Id > 0)
                _connection.Execute(_update, new { Nome = marca.Nome, Id = marca.Id });
            else
                _connection.Execute(_insert, new { Nome = marca.Nome });
        }
    }
}
