using OfficeGym.Data;
using OfficeGym.Models;

namespace OfficeGym.Migrations
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MvcOfficeGymDbContext>();
                if (context is not null)
                {
                    try
                    {


                        if (!context.OfficeEquipmentsGym.Any())
                        {
                            context.OfficeEquipmentsGym.AddRange(
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Treadmill",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "20",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Stationary Bicycle",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                }
                            );

                            context.SaveChanges();
                        }

                        if (!context.Employees.Any())
                        {
                            context.Employees.AddRange(
                                new Employee()
                                {
                                    FirstName = "William",
                                    LastName = "Smith",
                                    OfficePhone = "555-0105",
                                    Phone = "555-0180",
                                    Car = true,
                                    DepartmentName = "Marketing",
                                    JobTitle = "Chief Marketing Officer",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "M"
                                },
                                new Employee()
                                {
                                    FirstName = "Liam",
                                    LastName = "Johnson",
                                    OfficePhone = "555-0106",
                                    Phone = "555-0181",
                                    Car = true,
                                    DepartmentName = "Finance",
                                    JobTitle = "Chief Financial Officer",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "M"
                                }
                            );

                            context.SaveChanges();

                        }

                        if (!context.EmployeesOfficeEquipmentsGym.Any())
                        {
                            OfficeEquipmentGym officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 1);

                            Employee employee = context.Employees
                                .First(e => e.EmployeeId == 1);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 1,
                                    EmployeeId = 1,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2021, 1, 2, 18, 0, 0),
                                    EndDate = new DateTime(2018, 1, 2, 18, 30, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 2);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 2,
                                    EmployeeId = 1,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2021, 1, 2, 18, 30, 0),
                                    EndDate = new DateTime(2018, 1, 2, 19, 0, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            context.SaveChanges();
                        }

                        if (!context.EmployeesSales.Any())
                        {
                            Employee employee = context.Employees
                                .First(e => e.EmployeeId == 1);

                            context.EmployeesSales.AddRange(
                                new EmployeeSales()
                                {
                                    EmployeeId = 1,
                                    StoresQuantity = 20100,
                                    ProductsQuantity = 502500,
                                    SalesTotal = 1005010,
                                    Year = 2020,
                                    Month = 12,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 2);

                            context.EmployeesSales.AddRange(
                                new EmployeeSales()
                                {
                                    EmployeeId = 2,
                                    StoresQuantity = 210,
                                    ProductsQuantity = 10500,
                                    SalesTotal = 1575000,
                                    Year = 2020,
                                    Month = 12,
                                    Employee = employee
                                }
                            );

                            context.SaveChanges();
                        }

                        if (!context.Vacations.Any())
                        {
                            Employee employee = context.Employees
                                .First(e => e.EmployeeId == 1);

                            context.Vacations.AddRange(
                                new Vacation()
                                {
                                    EmployeeId = 1,
                                    VacationDescription = "Exploring Hawaii Island",
                                    StateName = "Hawaii",
                                    Year = 2020,
                                    AboutVacation = "Excellent, very enjoyable.",
                                    FunVacationCount = 80,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 2);

                            context.Vacations.AddRange(
                                new Vacation()
                                {
                                    EmployeeId = 2,
                                    VacationDescription = "Christmas in New York",
                                    StateName = "New York",
                                    Year = 2020,
                                    AboutVacation = "Good price for the travel.",
                                    FunVacationCount = 84,
                                    Employee = employee
                                }
                            );

                            context.SaveChanges();
                        }

                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }

        }
    }
}
