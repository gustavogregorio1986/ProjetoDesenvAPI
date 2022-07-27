using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDesenvAPI.Dominio.Dominio
{
    [Table("tb_Endereco")]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public Pessoa Pessoa { get; set; }

        [ForeignKey("Pessoa")]
        public int Id_Pessoa { get; set; }
    }
}
