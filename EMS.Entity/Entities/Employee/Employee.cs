﻿namespace EMS.Entity.Entities.Employee;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsCurrentlyEmployed { get; set; }
}

