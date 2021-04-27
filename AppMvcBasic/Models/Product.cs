using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasic.Models
{
    public class Product : Entity
    {
        public Guid ProviderId { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(200, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The field {0} is required.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(1000, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 7)]
        public string Image { get; set; }
        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(200, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 2)]
        public decimal Value { get; set; }
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }

        /*  EF Relation - One to One    */
        public Provider Provider { get; set; }
    }
}
