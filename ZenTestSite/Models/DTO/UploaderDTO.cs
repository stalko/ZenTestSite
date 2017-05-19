using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ZenTestSite.Models.DTO
{
    public class UploaderTextDTO
    {
        [Required]
        [Display(Name = "Text")]
        [DataType(DataType.Text)]
        [StringLength(1000, MinimumLength = 2)]
        public string Text { get; set; }
    }

    public class UploaderUrlDTO
    {
        [Required]
        [Display(Name = "Url")]
        [DataType(DataType.Url)]
        public string Url { get; set; }
    }

    public class UploaderFileDTO
    {
        [Required]
        [Display(Name = "File")]
        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }
    }
}
