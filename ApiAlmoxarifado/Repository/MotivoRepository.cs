using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class MotivoRepository:IMotivo
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Motivo motivo)
        {
            bdConexao.Add(motivo);
            bdConexao.SaveChanges();
        }
        public List<Motivo> GetAll()
        {
            return bdConexao.Motivo.ToList();
        }

        public void Delete(Motivo motivo)
        {
            bdConexao.Remove(motivo);
            bdConexao.SaveChanges();
        }

        public void Update(Motivo Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }
    }
}
