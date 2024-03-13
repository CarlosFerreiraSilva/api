using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class EscolaridadeRepository:        IEscolaridadeRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Escolaridade motivo)
        {
            bdConexao.Add(motivo);
            bdConexao.SaveChanges();
        }
        public List<Escolaridade> GetAll()
        {
            return bdConexao.Escolaridade.ToList();
        }

        public void Delete(Escolaridade motivo)
        {
            bdConexao.Remove(motivo);
            bdConexao.SaveChanges();
        }

        public void Update(Escolaridade Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }
    }
}
