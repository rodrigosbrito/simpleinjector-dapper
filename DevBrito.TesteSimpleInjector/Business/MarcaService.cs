using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaService(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public Domain.Marca Get(int Id)
        {
            return _marcaRepository.Get(Id);
        }

        public IEnumerable<Domain.Marca> GetAll()
        {
            return _marcaRepository.GetAll();
        }

        public void Adicionar(Domain.Marca marca)
        {
            _marcaRepository.Adicionar(marca);
        }
    }
}
