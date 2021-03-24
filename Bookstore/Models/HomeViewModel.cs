using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Book> AllBooksList { get; set; }
    }
}
