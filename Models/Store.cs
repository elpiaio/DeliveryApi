using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace DeliveryApi.Models
{
    public class Store
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O titulo não pode ser nulo")]
        public string Name { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public string Description { get; set; }
        public List<Menu> Menus { get; set; }

    }
    public class Menu
    {
        public int Id { get; set; }
        
        [Required]
        public int IdMenu { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Produto> Produtos { get; set; }
    }
    public class Produto
    {
        public int Id { get; set; } 
        public int IdProduto { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
    }
}
