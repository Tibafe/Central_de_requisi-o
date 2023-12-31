using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebReq_V1.Models
{
    [Table("Requisicoes")]
    public class Requisicao
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Data Atual")]
        [Column("Data Atual")]
        [DataType(DataType.Date)]
        public static DateTime Today { get; }

        [Required(ErrorMessage = "Informe a Data de necessidade do produto")]
        [Display(Name = "Data Necessidade")]
        [Column("Data de Necessidade")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Clientes { get; set; }
        public int SolicitanteId { get; set; }
        public virtual Solicitante Solicitantes { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produtos { get; set; }
    }
}