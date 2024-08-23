using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeGym.Models
{
    public class EmployeeSales
    {
        [Key]
        [Display(Name = "Employee sales id")]
        public int EmployeeSalesId { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "Employee id")]
        public required int EmployeeId { get; set; }

        [Display(Name = "Stores quantity")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
        public required int StoresQuantity { get; set; }

        [Display(Name = "Products quantity")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
        public required int ProductsQuantity { get; set; }

        [Display(Name = "Sales total")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(18, 2)")]
        public required decimal SalesTotal { get; set; }

        [Display(Name = "Year")]
        public required int Year { get; set; }

        [Display(Name = "Month")]
        public required int Month { get; set; }

        public required Employee Employee { get; set; }
    }
}
