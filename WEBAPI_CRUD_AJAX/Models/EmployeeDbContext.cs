using System.Data.Entity;

namespace WEBAPI_CRUD_AJAX.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext()
            : base("EmployeeInfoDbConStr")  
       {
           Database.SetInitializer<EmployeeDbContext>(new CreateDatabaseIfNotExists<EmployeeDbContext>());  
       }  
  
     public  DbSet<Employee> Employees { get; set; }  
    }     
}