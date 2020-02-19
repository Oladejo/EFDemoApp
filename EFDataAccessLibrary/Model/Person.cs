using System.Collections.Generic;

namespace EFDataAccessLibrary.Model
{
    public class Person : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Address> Address { get; set; } = new List<Address>();
        public List<Email> EmailAddresses { get; set; } = new List<Email>();
    }
}
