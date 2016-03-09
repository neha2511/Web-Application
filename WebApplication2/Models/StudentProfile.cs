using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace WebApplication2.Models
{
    public class StudentProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int id { get; set; }
        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(8)]
        public string CWID { get; set; }
        [Required]
        [Display(Name = "Email ID")]
        public string  EmailID { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }

        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserID { get; set; }

    }
}
    
