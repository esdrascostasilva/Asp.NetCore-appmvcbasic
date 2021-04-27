using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models
{
    public class Provider : Entity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(200, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(11, ErrorMessage = "The field {0} need contain between {2} and {1} characters.", MinimumLength = 14)]
        public string Document { get; set; }

        public TypeProvider TypeProvider { get; set; }

        public Address Address { get; set; }

        [DisplayName("Active?")]
        public bool Active { get; set; }

        /* Lista de produtos declarada aqui para o EF entender que essa relação é de 1 para muitos com Produtos */
        /* EF Relations - One to Many */
        public IEnumerable<Product> Products { get; set; }
    }
}
