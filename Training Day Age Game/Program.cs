// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello buddy, enter your age?");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age > 25 && age <= 30)
//{
//    Console.WriteLine("You are on your way to adulthood");
//}

//else if (age < 1)
//{
//    Console.WriteLine("You are not born");
//}
//else if (age >= 30 && age < 70)
//{
//    Console.WriteLine("You are a grown ass adult");
//}
//else if (age > 71)
//{
//    Console.WriteLine("You are rock solid buddy"); 
//}
//else if (age >= 18)
//{
//    Console.WriteLine("You are an adult");
//}
//else
//{
//    Console.WriteLine("You are a minor");
//}


string[] Strawhats = { "Luffy", "Zorro", "Sanji", "Chopper" };

Strawhats[2] = "Nami";

for (int i = 0; i < Strawhats.Length; i++)
{
    Console.WriteLine(Strawhats [i]);
}

char[] charArray = { 'F', 'O', 'U', 'R' };

Console.WriteLine(charArray[0]);
Console.WriteLine(charArray[1]);
Console.WriteLine(charArray[2]);
Console.WriteLine(charArray[3]);

string[] index = new string[7];

string[] StrawhatsFull = { "Robin", "Franky", "Jimbei", "Brook", "Ussopp", "Luffy", "Zorro", "Chopper" };

for (int i = 0;i < StrawhatsFull.Length;i++)
{
    Console.WriteLine (StrawhatsFull [i]);
}



