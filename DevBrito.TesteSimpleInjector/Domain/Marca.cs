using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Marca
    {
        public Marca()
        {
            Carros = new List<Carro>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Carro> Carros { get; set; }
    }
}
