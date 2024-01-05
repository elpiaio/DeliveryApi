namespace DeliveryApi.Models
{
    public class Login
    {
        public bool Cliente { get; set; } = false;
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
