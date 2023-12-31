﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PTCData
{
    public class TrainingProduct
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name must be fill in.")]
        [Display(Description = "Product Name")]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "Product Name must be greater than {2} characters and less than {1} characters.")]
        public string ProductName { get; set; }
        [Range(typeof(DateTime), "1/1/2000", "31/12/2025", ErrorMessage = "Introduction Date must be between {1} and {2}")]
        [Display(Description = "Introduction Date")]
        public DateTime IntroductionDate { get; set; }
        [Required(ErrorMessage = "Url must be fill in.")]
        [Display(Description = "URL")]
        [StringLength(2000, MinimumLength = 5, ErrorMessage = "URL must be greater than {2} characters and less than {1} characters.")]
        public string Url { get; set; }
        [Range(1,9999,ErrorMessage ="{0} must be between {1} and {2}")]
        public Decimal Price { get; set; }
    }
}