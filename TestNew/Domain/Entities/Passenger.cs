using System.ComponentModel.DataAnnotations;

namespace TestNew.Domain.Entities
{
    
    public record Passenger(
       string Email, 
       string FirstName, 
       string LastName, 
       bool Gender);
}
