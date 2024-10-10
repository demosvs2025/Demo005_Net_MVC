using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace OfficeGym.Models
{
    public class Vacation
    {
        [Key]
        [Display(Name = "Vacation id")]
        public int VacationId { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "Employee id")]
        public required int EmployeeId { get; set; }

        [Display(Name = "Vacation description")]
        public required string VacationDescription { get; set; }

        [Display(Name = "State name")]
        public required string StateName { get; set; }

        [Display(Name = "Year")]
        public required int Year { get; set; }

        [Display(Name = "About vacation")]
        public required string AboutVacation { get; set; }

        [Display(Name = "Funniest vacation counter")]
        public required int FunVacationCount { get; set; }

        [ValidateNever]
        public required Employee Employee { get; set; }
    }
}
