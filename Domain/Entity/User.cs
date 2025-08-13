using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
