using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Servico.Servico.Interface
{
    public interface IOcorrenciaServico
    {
        void Salvar(Ocorrencia ocorrencia);

        List<Ocorrencia> ListarOcorrencia(int IdOcorencia);

        void Update(Ocorrencia ocorrencia);

        void Deletar(int IdOcorrencia);

        Endereco OcorrenciaById(int IdOcorrencia);
    }
}
