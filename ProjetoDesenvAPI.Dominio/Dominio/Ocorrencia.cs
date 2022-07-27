using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDesenvAPI.Dominio.Dominio
{
    [Table("tb_Ocorrencia")]
    public class Ocorrencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOcorrencia { get; set; }

        public string NomeOcorrencia { get; set; }

        public int NumeroOcorrencia { get; set; }

        public string Observacao { get; set; }

        public Processo Processo { get; set; }

        [ForeignKey("Processo")]
        public int Id_Processo { get; set; }
    }
}
