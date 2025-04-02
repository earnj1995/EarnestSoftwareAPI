using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarnestsWebApi.DB;
using EarnestsWebApi.DTO;
using Microsoft.EntityFrameworkCore;

namespace EarnestsWebApi.DAL
{
    public class DAL
    {
        private EarnestSoftwareContext _context;
        public DAL(EarnestSoftwareContext context)
        {
            _context = context;
        }
        public async Task<ProductPage> GetProducts(Page page)
        {
            var TotalProductCount = await _context.Products.CountAsync();
            var ProductList = await _context.Products.Skip(page.PageSize * page.CurrentPage).Take(page.PageSize).ToListAsync();


            return new ProductPage { Products = ProductList, CurrentPage = page.CurrentPage, PageSize = page.PageSize, TotalCount = TotalProductCount };
        }
        public async Task<CustomerPage> GetCustomers(Page page)
        {
            
            var TotalCustomerCount = await _context.Products.CountAsync();
            var CustomerList = await _context.Customers.Skip(page.PageSize * page.CurrentPage).Take(page.PageSize).ToListAsync();

            return new CustomerPage { Customer = CustomerList, CurrentPage = page.CurrentPage, PageSize = page.PageSize, TotalCount = TotalCustomerCount };
        }
    }
}