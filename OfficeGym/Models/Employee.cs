using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeGym.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }

        [Display(Name = "First  name")]
        public required string FirstName { get; set; }

        [Display(Name = "Last name")]
        public required string LastName { get; set; }

        [Display(Name = "Office phone")]
        public required string OfficePhone { get; set; }

        [Display(Name = "Phone")]
        public required string Phone { get; set; }

        [Display(Name = "Car")]
        public required bool Car { get; set; }

        [Display(Name = "Department name")]
        public required string DepartmentName { get; set; }

        [Display(Name = "Job title")]
        public required string JobTitle { get; set; }

        [Display(Name = "Start time")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public required DateTime StartTime { get; set; }

        [Display(Name = "End time")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public required DateTime EndTime { get; set; }

        [Display(Name = "Marital status")]
        public required string MaritalStatus { get; set; }

        [Display(Name = "Gender")]
        public required string Gender { get; set; }

        public ICollection<EmployeeOfficeEquipmentGym> EmployeesOfficeEquipmentsGym { get; set; } =
            new List<EmployeeOfficeEquipmentGym>();

        public ICollection<EmployeeSales> EmployeesSales { get; set; } =
            new List<EmployeeSales>();

        public ICollection<Vacation> Vacations { get; set; } =
            new List<Vacation>();
    }
}
