using System.ComponentModel.DataAnnotations;

namespace testeef.Models {
    public class Category {
        [Key]
        public int Id {
            get;
            set;
        }

        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [MaxLength(60, ErrorMessage = "Este Campo Deve Conter Entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este Campo Deve Conter Entre 3 e 60 caracteres")]

        public string Title {
            get;
            set;
        }
    }
}