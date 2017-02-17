using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace AdminLTE.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Email { get; set; }
        public int Phno { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("AdminLTEContext")
        {
        }

        public virtual IDbSet<ProductModels> Products { get; set; }

    }

}