using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Data.Repositorio.Interface
{
    public interface IOcorrenciaRepository
    {
        void Salvar(Ocorrencia ocorrencia);

        List<Ocorrencia> ListarOcorrencia(int IdOcorencia);

        void Update(Ocorrencia ocorrencia);

        void Deletar(int IdOcorrencia);

        Endereco OcorrenciaById(int IdOcorrencia);
    }
}
