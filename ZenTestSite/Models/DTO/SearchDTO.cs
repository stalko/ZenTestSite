using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenTestSite.Models.DTO
{
    public class SearchDTO
    {
        [Required]
        [Range(1, 100)]
        [Display(Name = "Age")]
        public int Age { get; set; }
    }
}
