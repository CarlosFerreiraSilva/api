using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class ItensEntradaRepository:IItensEntradaRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(ItensEntrada departamento)
        {
            bdConexao.Add(departamento);
            bdConexao.SaveChanges();
        }
        public List<ItensEntrada> GetAll()
        {
            return bdConexao.ItensEntrada.ToList();
        }

        public void Delete(ItensEntrada departamento)
        {
            bdConexao.Remove(departamento);
            bdConexao.SaveChanges();
        }

        public void Update(ItensEntrada Model)
        {
            bdConexao.Update(Model);
            bdConexao.SaveChanges();
        }
    }
}
