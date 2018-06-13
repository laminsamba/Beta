using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Web.DTO
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }    
    }
    public class StaffViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Address    
    {
        public int Id { get; set; }
        public string Town { get; set; }
        public string LastNCountryame { get; set; }
    }
}
