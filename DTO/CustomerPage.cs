using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarnestsWebApi.DB;

namespace EarnestsWebApi.DTO
{
    public class CustomerPage : Page
    {
        public List<Customer> Customer { get; set; }
    }
}