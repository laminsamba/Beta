using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.MVC.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public Name Name { get; set; }  
        public Address Address { get; set; }
        public Contact Contact { get; set; }    
    }


    public class Name   
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
    }

    public class Contact
    {
        public string Mobile { get; set; }
        public string Phone { get; set; }
    }
}