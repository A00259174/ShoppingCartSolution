// ShoppingCartController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCartApi.Data;
using ShoppingCartModels;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace ShoppingCartApi.Controllers
{
    [Authorize] // Requires authentication
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ShoppingCart
        [HttpGet]
        public IActionResult GetShoppingCart()
        {
            var userId = User.Identity.Name; // Get the user's email or unique identifier
            var cart = _context.ShoppingCarts
                .Include(c => c.Products) // Include related products
                .FirstOrDefault(c => c.User == userId);

            if (cart == null)
            {
                return NotFound("Shopping cart not found.");
            }

            return Ok(cart.Products); // Return the products in the cart
        }

        // POST: api/ShoppingCart/RemoveItem
        [HttpPost("RemoveItem")]
        public IActionResult RemoveItemFromCart(int productId)
        {
            var userId = User.Identity.Name; // Get the user's email or unique identifier
            var cart = _context.ShoppingCarts
                .Include(c => c.Products)
                .FirstOrDefault(c => c.User == userId);

            if (cart == null)
            {
                return NotFound("Shopping cart not found.");
            }

            var productToRemove = cart.Products.FirstOrDefault(p => p.Id == productId);
            if (productToRemove != null)
            {
                if void chrono
                            (
                    EventLogSession = EventLogSession mana void
                    );
            }
            {
                cart.Products.Remove(productToRemove);
                _context.SaveChanges();
                return Ok("Product removed from cart.");
            }

            return NotFound("Product not found in cart.");
        }
    }

