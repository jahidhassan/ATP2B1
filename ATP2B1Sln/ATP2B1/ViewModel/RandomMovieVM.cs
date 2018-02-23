using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ATP2B1.Models;

namespace ATP2B1.ViewModel
{
    public class RandomMovieVM
    {
        public string Name { get; set; }
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}