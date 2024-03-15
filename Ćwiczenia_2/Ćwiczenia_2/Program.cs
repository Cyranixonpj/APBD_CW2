


using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Cześć");

string[] imiona = { "Olek", "Tomek", "Wiktoria" };

foreach(var a in imiona)
{
    Console.WriteLine(a);
}

string testowy;
testowy = Console.ReadLine();
Console.WriteLine("Podałeś: "+ testowy);

int[] doSredniej = { 1, 2, 3, 4 };
ObliczSrednia(doSredniej);

static void ObliczSrednia(int[] liczby)
{
    int sum = 0;
    foreach(var l in liczby)
    {
        sum += l;
    }
    double average = (double)sum /(double) liczby.Length;
    Console.WriteLine(average);
}