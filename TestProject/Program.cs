﻿// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;

//     case "02":
//         type = "T-Shirt";
//         break;

//     case "03":
//         type = "Sweat pants";
//         break;

//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;

//     case "MN":
//         color = "Maroon";
//         break;

//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;

//     case "M":
//         size = "Medium";
//         break;

//     case "L":
//         size = "Large";
//         break;

//     default:
//         size = "One size fits all.";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");


for (int number = 0; number < 100; number++)
{
    string type = "";

    if (number % 3 == 0 && number % 5 == 0)
        type = "FizzBuzz";

    else if (number % 3 == 0)
        type = "Fizz";

    else if (number % 5 == 0)
        type = "Buzz";

    Console.WriteLine(type == "" ? $"{number}" : $"{number} - {type}");
}