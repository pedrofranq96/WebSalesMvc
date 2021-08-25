using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSalesMvc.Services
{
    public class DepartamentService
    {
        private readonly WebSalesMvcContext _context;

        public DepartamentService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
