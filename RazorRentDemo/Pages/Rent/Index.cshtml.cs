using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorRentDemo.Data;
using RazorRentDemo.Model;

namespace RazorRentDemo.Pages.Rent
{
    public class IndexModel : PageModel
    {
        private readonly RentDbContext _context;
        public IList<Car> Cars { get;set; } = default!;

        public IndexModel(RentDbContext context)
        {
            _context = context;
        }


        public async Task OnGetAsync()
        {
            if (_context.Car!= null)
            {
                // Cars = await _context.Car.Where(p=>p.Avaliable==true).ToListAsync();
                Cars = await _context.Car.ToListAsync();
            }
        }
    }
}
