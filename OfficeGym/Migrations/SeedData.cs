using OfficeGym.Data;
using OfficeGym.Models;

namespace OfficeGym.Migrations
{
    public class SeedData
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
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
                                    EquipmentGymName = "Stationary bicycle",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Abdominal crunch machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Bicep curl machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Cable bicep curl machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Cable tricep extension machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Chest press machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Shoulder press machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Lat pull down machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Rear delt fly machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Glute isolator machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Leg extension machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Seated cable row machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Seated fly machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Seated reverse fly machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Seated leg curl machine",
                                    AvailableEquipments = 2,
                                    MotorHorsePower = "",
                                    IsActive = true
                                },
                                new OfficeEquipmentGym()
                                {
                                    EquipmentGymName = "Seated leg press machine",
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
                                },
                                new Employee()
                                {
                                    FirstName = "Noah",
                                    LastName = "Williams",
                                    OfficePhone = "555-0107",
                                    Phone = "555-0182",
                                    Car = true,
                                    DepartmentName = "Operations",
                                    JobTitle = "Chief Operating Officer",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "M"
                                },
                                new Employee()
                                {
                                    FirstName = "Jacob",
                                    LastName = "Brown",
                                    OfficePhone = "555-0108",
                                    Phone = "555-0183",
                                    Car = true,
                                    DepartmentName = "Human Resources",
                                    JobTitle = "Chief Human Resources Officer",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "M"
                                },
                                new Employee()
                                {
                                    FirstName = "Michael",
                                    LastName = "Brown",
                                    OfficePhone = "555-0109",
                                    Phone = "555-0184",
                                    Car = true,
                                    DepartmentName = "Sales",
                                    JobTitle = "Salesperson",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "M"
                                },
                                new Employee()
                                {
                                    FirstName = "Charlotte",
                                    LastName = "Miller",
                                    OfficePhone = "555-0110",
                                    Phone = "555-0185",
                                    Car = true,
                                    DepartmentName = "Marketing",
                                    JobTitle = "Chief Marketing Officer",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "F"
                                },
                                new Employee()
                                {
                                    FirstName = "Madison",
                                    LastName = "Davis",
                                    OfficePhone = "555-0111",
                                    Phone = "555-0186",
                                    Car = true,
                                    DepartmentName = "Finance",
                                    JobTitle = "Chief Financial Officer",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "F"
                                },
                                new Employee()
                                {
                                    FirstName = "Emily",
                                    LastName = "Wilson",
                                    OfficePhone = "555-0112",
                                    Phone = "555-0187",
                                    Car = true,
                                    DepartmentName = "Operations",
                                    JobTitle = "Chief Operating Officer",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "F"
                                },
                                new Employee()
                                {
                                    FirstName = "Elizabeth",
                                    LastName = "Taylor",
                                    OfficePhone = "555-0113",
                                    Phone = "555-0188",
                                    Car = true,
                                    DepartmentName = "Sales",
                                    JobTitle = "Salesperson",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "F"
                                },
                                new Employee()
                                {
                                    FirstName = "Chloe",
                                    LastName = "Moore",
                                    OfficePhone = "555-0114",
                                    Phone = "555-0189",
                                    Car = true,
                                    DepartmentName = "Sales",
                                    JobTitle = "Salesperson",
                                    StartTime = new DateTime(2018, 1, 2),
                                    EndTime = new DateTime(2060, 1, 2),
                                    MaritalStatus = "Single",
                                    Gender = "F"
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
                                    StartDate = new DateTime(2024, 1, 2, 18, 0, 0),
                                    EndDate = new DateTime(2024, 1, 2, 18, 30, 0),
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
                                    StartDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    EndDate = new DateTime(2024, 1, 2, 19, 0, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 3);

                            employee = context.Employees
                                .First(e => e.EmployeeId == 2);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 3,
                                    EmployeeId = 2,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 0, 0),
                                    EndDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 4);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 4,
                                    EmployeeId = 2,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    EndDate = new DateTime(2024, 1, 2, 19, 0, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 5);

                            employee = context.Employees
                                .First(e => e.EmployeeId == 3);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 5,
                                    EmployeeId = 3,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 0, 0),
                                    EndDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 6);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 6,
                                    EmployeeId = 3,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    EndDate = new DateTime(2024, 1, 2, 19, 0, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 7);

                            employee = context.Employees
                                .First(e => e.EmployeeId == 6);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 7,
                                    EmployeeId = 6,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 0, 0),
                                    EndDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 8);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 8,
                                    EmployeeId = 6,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    EndDate = new DateTime(2024, 1, 2, 19, 0, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 9);

                            employee = context.Employees
                                .First(e => e.EmployeeId == 7);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 9,
                                    EmployeeId = 7,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 0, 0),
                                    EndDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 10);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 10,
                                    EmployeeId = 7,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    EndDate = new DateTime(2024, 1, 2, 19, 0, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 11);

                            employee = context.Employees
                                .First(e => e.EmployeeId == 8);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId = 11,
                                    EmployeeId = 8,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 0, 0),
                                    EndDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    IsActive = true,
                                    OfficeEquipmentGym = officeEquipmentGym,
                                    Employee = employee
                                }
                            );

                            officeEquipmentGym = context.OfficeEquipmentsGym
                                .First(o => o.OfficeEquipmentGymId == 12);

                            context.EmployeesOfficeEquipmentsGym.AddRange(
                                new EmployeeOfficeEquipmentGym()
                                {
                                    OfficeEquipmentGymId =12 ,
                                    EmployeeId = 8,
                                    EquipmentGymTime = "30 minutes",
                                    StartDate = new DateTime(2024, 1, 2, 18, 30, 0),
                                    EndDate = new DateTime(2024, 1, 2, 19, 0, 0),
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
                                    Year = 2023,
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
                                    Year = 2023,
                                    Month = 12,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 3);

                            context.EmployeesSales.AddRange(
                                new EmployeeSales()
                                {
                                    EmployeeId = 3,
                                    StoresQuantity = 420,
                                    ProductsQuantity = 21000,
                                    SalesTotal = 1260000,
                                    Year = 2023,
                                    Month = 12,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 6);

                            context.EmployeesSales.AddRange(
                                new EmployeeSales()
                                {
                                    EmployeeId = 6,
                                    StoresQuantity = 630,
                                    ProductsQuantity = 15600,
                                    SalesTotal = 1092000,
                                    Year = 2023,
                                    Month = 12,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 7);

                            context.EmployeesSales.AddRange(
                                new EmployeeSales()
                                {
                                    EmployeeId = 7,
                                    StoresQuantity = 840,
                                    ProductsQuantity = 25100,
                                    SalesTotal = 2008000,
                                    Year = 2023,
                                    Month = 12,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 8);

                            context.EmployeesSales.AddRange(
                                new EmployeeSales()
                                {
                                    EmployeeId = 8,
                                    StoresQuantity = 1050,
                                    ProductsQuantity = 28200,
                                    SalesTotal = 2397000,
                                    Year = 2023,
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
                                    Year = 2024,
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
                                    Year = 2024,
                                    AboutVacation = "Good price for the travel.",
                                    FunVacationCount = 84,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 3);

                            context.Vacations.AddRange(
                                new Vacation()
                                {
                                    EmployeeId = 3,
                                    VacationDescription = "Visiting Anchorage, Alaska",
                                    StateName = "Alaska",
                                    Year = 2024,
                                    AboutVacation = "It's wonderful.",
                                    FunVacationCount = 90,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 6);

                            context.Vacations.AddRange(
                                new Vacation()
                                {
                                    EmployeeId = 6,
                                    VacationDescription = "NHRA Top Fuel Thunder Valley Nationals Tennessee",
                                    StateName = "Tennessee",
                                    Year = 2024,
                                    AboutVacation = "Top fuel are fantastic.",
                                    FunVacationCount = 88,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 7);

                            context.Vacations.AddRange(
                                new Vacation()
                                {
                                    EmployeeId = 7,
                                    VacationDescription = "The Gateway Arch in St. Louis Missouri",
                                    StateName = "Missouri",
                                    Year = 2024,
                                    AboutVacation = "Very exciting.",
                                    FunVacationCount = 92,
                                    Employee = employee
                                }
                            );

                            employee = context.Employees
                                .First(e => e.EmployeeId == 8);

                            context.Vacations.AddRange(
                                new Vacation()
                                {
                                    EmployeeId = 8,
                                    VacationDescription = "Piscataway Park in Maryland",
                                    StateName = "Maryland",
                                    Year = 2024,
                                    AboutVacation = "Lovely park.",
                                    FunVacationCount = 96,
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
