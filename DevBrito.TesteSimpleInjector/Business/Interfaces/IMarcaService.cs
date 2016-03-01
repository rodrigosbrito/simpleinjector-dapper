using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Business.Interfaces
{
    public interface IMarcaService
    {
        Marca Get(int Id);
        IEnumerable<Marca> GetAll();
        void Adicionar(Marca carro);
    }
}
