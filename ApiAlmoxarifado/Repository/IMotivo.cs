using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public interface IMotivo
    {
        List<Motivo> GetAll();
        void Add (Motivo motivo);
        void Update(Motivo motivo);
    }
}
