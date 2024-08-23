using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeGym.Models
{
    public class EmployeeOfficeEquipmentGym
    {
        [Key]
        [Display(Name = "Employee office equipment gym id")]
        public int EmployeeOfficeEquipmentGymId { get; set; }

        [ForeignKey("OfficeEquipmentGym")]
        [Display(Name = "Office equipment gym id")]
        public required int OfficeEquipmentGymId { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "Employee id")]
        public required int EmployeeId { get; set; }

        [Display(Name = "Equipment gym time")]
        public required string EquipmentGymTime { get; set; }

        [Display(Name = "Start date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = false)]
        [DataType(DataType.DateTime)]
        public required DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = false)]
        [DataType(DataType.DateTime)]
        public required DateTime EndDate { get; set; }

        [Display(Name = "Is active")]
        public required bool IsActive { get; set; }

        public required OfficeEquipmentGym OfficeEquipmentGym { get; set; }
        public required Employee Employee { get; set; }
    }
}
