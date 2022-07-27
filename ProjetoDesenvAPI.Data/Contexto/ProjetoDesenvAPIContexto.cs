using Microsoft.EntityFrameworkCore;
using ProjetoDesenvAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesenvAPI.Data.Contexto
{
    public class ProjetoDesenvAPIContexto : DbContext
    {
        public ProjetoDesenvAPIContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Processo> Processos { get; set; }

        public DbSet<Ocorrencia> Ocorrencias { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
