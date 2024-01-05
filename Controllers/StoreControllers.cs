using DeliveryApi.Context;
using DeliveryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace DeliveryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreControllers : ControllerBase
    {
        private DeliveryContext _context;
        public StoreControllers(DeliveryContext context)
        {
            _context = context;
        }

      
        [HttpPost]
        public IActionResult InserirLoja([FromBody] Store store)
        {
            _context.Stores.Add(store);
            _context.SaveChanges();
            return Ok(store);
        }

        [HttpGet("login")]
        public IActionResult RetornaLoja([FromBody] Login login)
        {
            List<Store> store = _context.Stores.Include(store => store.Menus).Where(store => store.Email == login.Email && store.Password == login.Senha).ToList();

            foreach (var item in store)
            {
                foreach (var x in item.Menus)
                {
                    x.Produtos.AddRange(_context.Produtos.Where(ProdutosStore => ProdutosStore.MenuId == x.Id).ToList());
                }
            }

            if (store == null) return NotFound();
            return Ok(store);
        }
    }
}
