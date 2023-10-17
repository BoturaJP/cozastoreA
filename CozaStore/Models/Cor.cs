using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("Cor")]
    public class Cor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]

        public string Nome { get; set; }

        [Display(Name = "Código da cor")]
        [Required(ErrorMessage = "Informe o código de cor")]
        [StringLength(7, ErrorMessage = "O código de cor deve possuir no minimo 7 caracteres")]
        public string CodigoHexa { get; set; }
    }
