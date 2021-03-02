using System.ComponentModel.DataAnnotations;

namespace testeef.Models {
    public class Product {
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

        [MaxLength(1024, ErrorMessage = "Este Campo Deve Conter No Máximo 1024 caracteres")]
        public string Description {
            get;
            set;
        }

        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O Preço Deve Ser Maior Que Zero")]
        public decimal Price {
            get;
            set;
        }

        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]

        public int CategoryId {
            get;
            set;
        }

        public Category Category {
            get;
            set;
        }
    }
}