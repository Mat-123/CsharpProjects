﻿// See https://aka.ms/new-console-template for more information
string[] fraudulentOrderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];

foreach ( string fraudulentOrderFiltered in fraudulentOrderIDs)
{
    if ( fraudulentOrderFiltered.StartsWith("B"))
    {
        Console.WriteLine($"This is a fraudulent order: {fraudulentOrderFiltered}");
    }
}