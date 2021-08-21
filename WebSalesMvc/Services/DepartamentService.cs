using System;
using System.Collections.Generic;
using System.Linq;

using WebSalesMvc.Models;

namespace WebSalesMvc.Services
{
    public class DepartamentService
    {
        private readonly WebSalesMvcContext _context;

        public DepartamentService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
