using Microsoft.EntityFrameworkCore;

namespace DemoGestionEmploye.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Mary",
                        Departement = Dept.IT,
                        Email = "Mary@mouha.com"
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "John",
                        Departement = Dept.IT,
                        Email = "John@mouha.com"
                    }
                );
        }
    }
}
