﻿// See https://aka.ms/new-console-template for more information
using Conceptos_POO;
using ConceptosPOO;

Console.WriteLine("Conceptos POO");
Console.WriteLine("========================");
Employees employee1 = new SalaryEmpleyee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary= 1815453.45M
};
//Console.WriteLine(employee1);

Employees employee2 = new CommissionEmployee()
{
    Id = 1010,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales=320000000M,
    CommissionPercentaje=0.03F
};
//Console.WriteLine(employee2);

Employees employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F
};
//Console.WriteLine(employee3);
Employees employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jennifer",
    LastName = "Rivera",
    BirthDate = new Date(1988, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales=58000000M,
    CommissionPercentaje=0.015F
};
//Console.WriteLine(employee4);

ICollection<Employees> employees = new List<Employees>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;    

foreach (Employees employee in employees)
{
    Console.WriteLine(employee);
    payroll+= employee.GetValueToPay();
}

Console.WriteLine("                              ===================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Descripcion = "iPhone 13",
    Id=1,
    Price=5300000M,
    Quantity=6
};

Invoice invoice2 = new Invoice()
{
    Descripcion = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F

};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
