using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IItensEntradaRepository
    {
        List<ItensEntrada> GetAll();

        void Add(ItensEntrada categoria);

        void Delete(ItensEntrada categoria);
        void Update(ItensEntrada categoria);
    }
}
