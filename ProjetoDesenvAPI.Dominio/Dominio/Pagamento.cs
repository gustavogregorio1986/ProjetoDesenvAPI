using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDesenvAPI.Dominio.Dominio
{
    [Table("tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }

        public double ValorHora { get; set; }

        public int QtdeProcesso { get; set; }

        public Ocorrencia Ocorrencia { get; set; }

        [ForeignKey("Ocorrencia")]
        public int Id_Ocorrencia { get; set; }
    }
}
