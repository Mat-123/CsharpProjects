// See https://aka.ms/new-console-template for more information
Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
int roll1 = 6;
int roll2 = 6;
int roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if((roll1 == roll2) && (roll2 == roll3))
    {
    Console.WriteLine("You rolled triples! +6 bonus to total.");
    total += 6;
    }
    else
    {
    Console.WriteLine("You are really lucky rolling doubles, you get a +2 bonus!");
    total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("Wagliò hai vinto una macchina!");
}
else if (total >= 10)
{
    Console.WriteLine("Cuccioloooooo prendi sto portatile.");
}
else if (total == 7)
{
    Console.WriteLine("Cuoreeee hai vinto una pizza margherita.");
}
else 
{
    Console.WriteLine("Mi dispiace mister, torni a casa a mani vuote.");
}