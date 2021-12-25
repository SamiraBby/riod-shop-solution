using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Riode.WebUI.Models.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad sahəsi boş buraxıla bilməz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "E-poçt sahəsi boş buraxıla bilməz")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şərh sahəsi boş buraxıla bilməz")]
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? AnswerDate { get; set; }
        public int? AnsweredByUserId { get; set; }

    }

}
