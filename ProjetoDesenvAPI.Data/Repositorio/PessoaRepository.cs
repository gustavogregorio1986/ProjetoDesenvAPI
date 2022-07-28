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
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ProjetoDesenvAPIContexto _db;

        public void Deletar(int IdPessoa)
        {
            _db.Remove(IdPessoa);
        }

        public List<Pessoa> ListarPessoa(int IdPessoa)
        {
            return _db.Pessoas.Where(x => x.IdPessoa == IdPessoa).ToList();
        }

        public Pessoa PessoaById(int IdPessoa)
        {
            return _db.Set<Pessoa>().Find(IdPessoa);
        }

        public void Salvar(Pessoa pessoa)
        {
            _db.Add(pessoa);
        }

        public void Update(Pessoa pessoa)
        {
            _db.Update(pessoa);
        }
    }
}
