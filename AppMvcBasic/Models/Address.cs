using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasic.Models
{
    public class Address : Entity 
    {
        public Guid ProviderId { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(200, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 2)]
        public string Street { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(5, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 1)]
        public string Number { get; set; }

        public string Complement { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(8, ErrorMessage = "The field {0} need contain {1} characters.", MinimumLength = 8)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(50, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 5)]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(200, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(2, ErrorMessage = "The field {0} need contain {1} characters.", MinimumLength = 2)]
        public string State { get; set; }

        /*  EF Relation - One to One    */
        public Provider Provider { get; set; }
    }
}
