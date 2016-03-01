using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class CarroRepository : ICarroRepository
    {

        private SqlConnection _connection;

        private const string _insert = @"INSERT INTO Carros(Nome, Marca_Id) VALUES(@Nome, @Marca_Id)";
        private const string _update = @"UPDATE Carros SET Description = @Description, Completed = @Completed WHERE Id = @Id";

        public CarroRepository()
        {
            _connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\admin\documents\visual studio 2012\Projects\DevBrito.TesteSimpleInjector\DevBrito.TesteSimpleInjector\App_Data\Database.mdf;Integrated Security=True");
        }
        public Domain.Carro Get(int Id)
        {
            return  new Carro();
        }

        public IEnumerable<Domain.Carro> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Domain.Carro carro)
        {
            throw new NotImplementedException();
        }
    }
}
