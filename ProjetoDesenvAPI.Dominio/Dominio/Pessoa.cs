using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDesenvAPI.Dominio.Dominio
{
    [Table("tb_Pessoa")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPessoa { get; set; }

        public string NomePessoa { get; set; }

        public string EmailPessoa { get; set; }

        public string Sexo { get; set; }
    }
}
