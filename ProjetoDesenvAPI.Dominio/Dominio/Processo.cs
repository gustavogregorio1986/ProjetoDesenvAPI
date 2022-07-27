using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDesenvAPI.Dominio.Dominio
{
    [Table("tb_Processo")]
    public class Processo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProcesso { get; set; }

        public string NomeProcesso { get; set; }

        public string NumeroProcesso { get; set; }

        public Pessoa Pessoa { get; set; }

        [ForeignKey("Pessoa")]
        public int Id_Pessoa { get; set; }
    }
}
