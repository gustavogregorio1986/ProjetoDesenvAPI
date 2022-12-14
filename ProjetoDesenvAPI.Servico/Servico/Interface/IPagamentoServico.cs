using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Servico.Servico.Interface
{
    public interface IPagamentoServico
    {
        void Salvar(Pagamento pagamento);

        List<Pagamento> ListarPagamento(int IdPagamento);

        void Update(Pagamento pagamento);

        void Deletar(int IdPagamento);

        Pagamento PagamentoById(int IdPagamento);
    }
}
