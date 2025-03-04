using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesgriots.Domain
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profile { get; set; }
    }
}
