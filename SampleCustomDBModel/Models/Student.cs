using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace SampleCustomDBModel.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = " Enter Name")]
        [DataType(DataType.Text)]

        public string Name { get; set; }
        [Required]
        [Display(Name = "Enter Age")]
        [Range(0,100)]
        public string Age { get; set; }
        [Required]
        [Display(Name = "Your Qualification")]
        public string Qualification { get; set; }
        [Required]
        [Display(Name = "Your  Email")]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required]
        [Display(Name = " Marital Status")]
        public string MaritalStatus { get; set; }

      
     

    }
}