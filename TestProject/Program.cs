﻿string permission = "Admin|Manager";

int level = 60;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("manager") && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}