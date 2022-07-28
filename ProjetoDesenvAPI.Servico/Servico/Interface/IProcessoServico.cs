using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Servico.Servico.Interface
{
    public interface IProcessoServico
    {
        void Salvar(Processo processo);

        List<Processo> ListarPessoa(int IdProceso);

        void Update(Processo processo);

        void Deletar(int IdProcesso);

        Processo ProcesoById(int IdProcesso);
    }
}
