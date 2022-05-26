using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CarRentals.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string FirstMidName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(50)]
         public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int ModelNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
