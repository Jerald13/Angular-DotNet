using System.ComponentModel.DataAnnotations;

namespace TestNew.Domain.Entities
{
    public record Booking
    (
       string PassengerEmail,
       byte NumberOfSeats
    );
}
