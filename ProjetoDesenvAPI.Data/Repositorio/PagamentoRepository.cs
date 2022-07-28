using ProjetoDesenvAPI.Data.Contexto;
using ProjetoDesenvAPI.Data.Repositorio.Interface;
using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Data.Repositorio
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly ProjetoDesenvAPIContexto _db;

        public void Deletar(int IdPagamento)
        {
            _db.Remove(IdPagamento);
        }

        public List<Pagamento> ListarPagamento(int IdPagamento)
        {
            return _db.Pagamentos.Where(x => x.IdPagamento == IdPagamento).ToList();
        }

        public Pagamento PagamentoById(int IdPagamento)
        {
            return _db.Set<Pagamento>().Find(IdPagamento);
        }

        public void Salvar(Pagamento pagamento)
        {
            _db.Add(pagamento);
        }

        public void Update(Pagamento pagamento)
        {
            _db.Update(pagamento);
        }
    }
}
