using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICarroService
    {
        Carro Get(int Id);
        IEnumerable<Carro> GetAll();
        void Adicionar(Carro carro);

    }
}
