﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportApplicationWebApi.Models
{
    public class Complaint
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]\d{7}$", ErrorMessage = "{0} should have length 8")]
        public string PassportNumber { get; set; }  
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Required]
        [StringLength(55, MinimumLength = 2)]
        public string ComplaintType { get; set; }
        [Required]
        [StringLength(500)]
        public string ComplaintDetails { get; set; }
        [Required]
        public ComplaintStatus ComplaintStatus { get; set; }
    }

    public enum ComplaintStatus
    {
        Pending,
        Resolved
    }
}