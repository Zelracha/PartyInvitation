using System.ComponentModel.DataAnnotations;
namespace PartyInvite.Models
{
    public class GuestResponse
    {

        [Required(ErrorMessage = "Please Enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please Enter your email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please Enter your mobile Number")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Specify whether you'll attend the party")]
        public bool? WillAttend { get; set; }

    }
}
