using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeGym.Models
{
    public class OfficeEquipmentGym
    {
        [Key]
        [Display(Name = "Office equipment gym id")]
        public int OfficeEquipmentGymId { get; set; }

        [Display(Name = "Equipment gym name")]
        public required string EquipmentGymName { get; set; }

        [Display(Name = "Available equipments")]
        public required int AvailableEquipments { get; set; }

        [Display(Name = "Motor horse power")]
        public required string MotorHorsePower { get; set; }

        [Display(Name = "Is active")]
        public required bool IsActive { get; set; }

        public ICollection<EmployeeOfficeEquipmentGym> EmployeesOfficeEquipmentsGym { get; set; } =
            new List<EmployeeOfficeEquipmentGym>();
    }
}
