using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstApplication.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool ResetPassword { get; set; }
    }
}
