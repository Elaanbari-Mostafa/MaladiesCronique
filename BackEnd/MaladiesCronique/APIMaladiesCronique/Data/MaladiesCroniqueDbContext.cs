using APIMaladiesCronique.Models.AuthenticationViewModel;
using APIMaladiesCronique.Models.HabilitationViewModel;
using APIMaladiesCronique.Models.PatientViewModel;
using Microsoft.EntityFrameworkCore;

namespace APIMaladiesCronique.Data
{
    public class MaladiesCroniqueDbContext: DbContext
    {
        public MaladiesCroniqueDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        //public DbSet<Patient> Patients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<AutorisationMenuUtilisateur> AutorisationMenuUtilisateurs { get; set; }
        
    }
}
