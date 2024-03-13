using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class EntradaRepository:IEntradaRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Entrada funcionario)
        {
            bdConexao.Add(funcionario);
            bdConexao.SaveChanges();
        }
        public List<Entrada> GetAll()
        {
            return bdConexao.Entrada.ToList();
        }
        public void Delete(Entrada funcionario)
        {
            bdConexao.Remove(funcionario);
            bdConexao.SaveChanges();
        }
        public void Update(Entrada Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }
    }
}
