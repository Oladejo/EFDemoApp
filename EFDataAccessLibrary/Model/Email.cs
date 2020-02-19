using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLibrary.Model
{

    public class Email : BaseModel
    {
        [Required]
        [MaxLength(200)]
        public string EmailAddress { get; set; }
    }
}
