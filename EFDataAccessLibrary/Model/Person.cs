using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLibrary.Model
{
    public class Person : BaseModel
    {

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }
        public List<Address> Address { get; set; } = new List<Address>();
        public List<Email> EmailAddresses { get; set; } = new List<Email>();
    }
}
