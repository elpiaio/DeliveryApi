using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace DeliveryApi.Models
{
    public class Store
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome não pode ser nulo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Email não pode ser nulo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha não pode ser nulo")]
        public string Password { get; set; }

        [Required(ErrorMessage = "A descrição não pode ser nulo")]
        public string Description { get; set; }

        public List<Menu> Menus { get; set; } = new List<Menu>();
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
    public class Menu
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome não pode ser nulo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A descrição não pode ser nulo")]
        public string Description { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

    }
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int MenuId { get; set; }

        [Required(ErrorMessage = "O Nome não pode ser nulo")]
        public string Name { get; set; }
        public string UrlImage { get; set; } 
    }
}
