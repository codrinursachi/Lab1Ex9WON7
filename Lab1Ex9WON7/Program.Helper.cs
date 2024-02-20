partial class Program
{
    static (int, int) ReadNumbers()
    {
        Console.WriteLine("Introduceti 2 numere pentru a le interschimba");
        var numereRaw=Console.ReadLine()?.Split(" ");
        (int,int) numere;
        if (numereRaw?.Length == 2 &&
            int.TryParse(numereRaw[0], out numere.Item1) &&
            int.TryParse(numereRaw[1], out numere.Item2))
            return numere;
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
        return ReadNumbers();
    }
    static (int, int) InterchangeNumbers((int,int) numere)
    {
        numere=(numere.Item2,numere.Item1);
        return numere;
    }
    static void ShowNumbers((int,int) numere)
    {
        Console.WriteLine($"Numerele interschimbate sunt {numere.Item1} si {numere.Item2}");
    }
}