﻿using System.ComponentModel.DataAnnotations;

namespace PassportApplicationWebApi.Models
{
    public class Passport
    {
        [Key]
        public int PassportId { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]\d{7}$", ErrorMessage = "{0} should have length 8")]
        public string PassportNumber { get; set; }
        [Required]
        [StringLength(55, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(55, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(55, MinimumLength = 2)]
        public string Country { get; set; }
        [Required]
        [StringLength(55, MinimumLength = 2)]
        public DateTime DateOfIssue { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}