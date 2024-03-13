using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IEntradaRepository
    {
        List<Entrada> GetAll();

        void Add(Entrada departamento);
        void Update(Entrada departamento);
        void Delete(Entrada departamento);
    }
}
