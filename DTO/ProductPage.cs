using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarnestsWebApi.DB;

namespace EarnestsWebApi.DTO
{
    public class ProductPage : Page
    {
        public List<Product> Products { get; set; }
    }
}