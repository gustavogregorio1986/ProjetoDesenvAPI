using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Data.Repositorio.Interface
{
    public interface IEnderecoRepository
    {
        void Salvar(Endereco endereco);

        List<Endereco> ListarEndereco(int IdEndereco);

        void Update(Endereco endereco);

        void Deletar(int IdEndereco);

        Endereco EnderecoById(int IdEndereco);
    }
}
