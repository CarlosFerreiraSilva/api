using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IEscolaridadeRepository
    {
        List<Escolaridade> GetAll();

        void Add(Escolaridade categoria);

        void Delete(Escolaridade categoria);
        void Update(Escolaridade categoria);
    }
}
