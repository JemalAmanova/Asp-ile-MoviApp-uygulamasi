using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
    }
}