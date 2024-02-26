using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IDepartamentoRepository
    {
        List<Departamento> GetAll();

        void Add(Departamento departamento);
    }
}
