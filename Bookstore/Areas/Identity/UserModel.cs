using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Areas.Identity
{
    public class UserModel
    {
        [Key]
        public string Id { get; set; } //IDENTITY USER ID IS OF TYPE STRING !!!

        [Required]
        public string Name { get; set; }

        //ova dole najpoznatiot format za validacija na email
        [Required]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+(@[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Emaill is not valid!")]
        // ^ --> se sto pocnuva | emailot moze da pocnuva samo so ovie chars od a do z od A do Z od 0 do 9 pa posle nego ima chars _ --> ova _ znaci chars 
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public IQueryable<SelectListItem> Roles { get; set; }

        public string RoleId { get; set; } //IdentityRole --> TYPE STRING !!!

        public string RoleName { get; set; }

    }
}
