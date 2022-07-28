using ProjetoDesenvAPI.Data.Contexto;
using ProjetoDesenvAPI.Data.Repositorio.Interface;
using ProjetoDesenvAPI.Data.Servico.Interface;
using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Data.Repositorio
{
    public class ProcessoRepository : IProcessoRepository
    {
        private readonly ProjetoDesenvAPIContexto _db;

        public void Deletar(int IdProcesso)
        {
            _db.Remove(IdProcesso);
        }

        public List<Processo> ListarPessoa(int IdProceso)
        {
            return _db.Processos.Where(x => x.IdProcesso == IdProceso).ToList();
        }

        public Processo ProcesoById(int IdProcesso)
        {
            return _db.Set<Processo>().Find(IdProcesso);
        }

        public void Salvar(Processo processo)
        {
            _db.Add(processo);
        }

        public void Update(Processo processo)
        {
            _db.Update(processo);
        }
    }
}
