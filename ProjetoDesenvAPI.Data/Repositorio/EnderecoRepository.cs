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
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ProjetoDesenvAPIContexto _db;

        public void Deletar(int IdEndereco)
        {
            _db.Remove(IdEndereco);
        }

        public Endereco EnderecoById(int IdEndereco)
        {
            return _db.Set<Endereco>().Find(IdEndereco);
        }

        public List<Endereco> ListarEndereco(int IdEndereco)
        {
            return _db.Enderecos.Where(x => x.IdEndereco == IdEndereco).ToList();
        }

        public void Salvar(Endereco endereco)
        {
            _db.Add(endereco);
        }

        public void Update(Endereco endereco)
        {
            _db.Update(endereco);
        }
    }
}
