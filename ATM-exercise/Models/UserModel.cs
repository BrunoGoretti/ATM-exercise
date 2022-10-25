using System.ComponentModel.DataAnnotations;

namespace ATM_exercise.Models
{
    public class UserModel
    {
            [Key]
            public int Id { get; set; }
            [Required]
            public string? PinCode { get; set; }
            [Required]
            public string? PersonName { get; set; }
            [Required]
            public string? PersonSurname { get; set; }
            public string? CardId { get; set; }
            public decimal UserBalance { get; set; }
    }
}
