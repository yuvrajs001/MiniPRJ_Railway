// OrderController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeChallange10.Models;


namespace CodeChallange10.Controllers
{
    public class OtherFunController : Controller
    {
        private readonly NorthwindContext _context;

        public OtherFunController(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult OrderDetails(int orderId)
        {
            var order = _context.Orders.Include(o => o.Customer).Include(o => o.OrderDetails).FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
            {
                return NotFound(); // Handle case where order ID does not exist
            }

            return View(order);
        }
        public IActionResult Bill(int orderId)
        {
            var orderSubtotal = _context.OrderSubtotals.FirstOrDefault(os => os.OrderId == orderId);

            if (orderSubtotal == null)
            {
                return NotFound(); // Handle case where order ID does not exist
            }

            return View(orderSubtotal);
        }

        public IActionResult CustomerDetailsByOrderDate(DateTime orderDate)
        {
            var customers = _context.Orders
                .Include(o => o.Customer)
                .Where(o => o.OrderDate == orderDate.Date)
                .Select(o => o.Customer)
                .Distinct()
                .ToList();

            ViewBag.OrderDate = orderDate.ToString("yyyy-MM-dd"); // Pass order date to view

            return View(customers);
        }
        public IActionResult HighestOrderCustomer()
        {
            var customerId = _context.Orders .GroupBy(o => o.CustomerId)
                .OrderByDescending(g => g.Sum(o => o.OrderDetails.Sum(od => od.UnitPrice * od.Quantity)))
                .Select(g => g.Key)
                .FirstOrDefault();

            var customer = _context.Customers.Find(customerId);
            return View(customer);
        }
    }
}
