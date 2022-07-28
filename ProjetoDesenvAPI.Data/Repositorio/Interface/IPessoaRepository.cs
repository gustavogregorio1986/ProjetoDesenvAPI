using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Data.Repositorio.Interface
{
    public interface IPessoaRepository
    {
        void Salvar(Pessoa pessoa);

        List<Pessoa> ListarPessoa(int IdPessoa);

        void Update(Pessoa pessoa);

        void Deletar(int IdPessoa);

        Pessoa PessoaById(int IdPessoa);
    }
}
