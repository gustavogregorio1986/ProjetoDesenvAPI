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
    public class OcorrenciaRepository : IOcorrenciaRepository
    {
        private readonly ProjetoDesenvAPIContexto _db;

        public void Deletar(int IdOcorrencia)
        {
            _db.Remove(IdOcorrencia);
        }

        public List<Ocorrencia> ListarOcorrencia(int IdOcorencia)
        {
            return _db.Ocorrencias.Where(x => x.IdOcorrencia == IdOcorencia).ToList();
        }

        public Ocorrencia OcorrenciaById(int IdOcorrencia)
        {
            return _db.Set<Ocorrencia>().Find(IdOcorrencia);
        }

        public void Salvar(Ocorrencia ocorrencia)
        {
            _db.Add(ocorrencia);
        }

        public void Update(Ocorrencia ocorrencia)
        {
            _db.Update(ocorrencia);
        }
    }
}
