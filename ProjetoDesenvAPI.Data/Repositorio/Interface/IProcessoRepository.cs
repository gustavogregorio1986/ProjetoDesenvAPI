using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Data.Repositorio.Interface
{
    public interface IProcessoRepository
    {
        void Salvar(Processo processo);

        List<Processo> ListarPessoa(int IdProceso);

        void Update(Processo processo);

        void Deletar(int IdProcesso);

        Processo ProcesoById(int IdProcesso);
    }
}
