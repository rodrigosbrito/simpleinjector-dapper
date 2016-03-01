using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business
{
    public class CarroService : ICarroService
    {
        private readonly ICarroRepository _carroRepository;

        public CarroService(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public Domain.Carro Get(int Id)
        {
            return _carroRepository.Get(Id);
        }

        public IEnumerable<Domain.Carro> GetAll()
        {
            return _carroRepository.GetAll();
        }

        public void Adicionar(Domain.Carro carro)
        {
            _carroRepository.Adicionar(carro);
        }
    }
}
