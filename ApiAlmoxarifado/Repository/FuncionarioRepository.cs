using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Models;

namespace ApiAlmoxarifado.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Funcionario funcionario)
        {
            bdConexao.Add(funcionario);
            bdConexao.SaveChanges();
        }
        public List<Funcionario> GetAll()
        {
            return bdConexao.Funcionario.ToList();
        }
    }
}
