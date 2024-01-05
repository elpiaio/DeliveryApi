using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DeliveryApi.Models
{
    public class Cliente 
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
    }
}
