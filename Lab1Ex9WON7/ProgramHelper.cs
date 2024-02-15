partial class Program
{
    static int[] ReadNumbers()
    {
        Console.WriteLine("Introduceti 2 numere pentru a le interschimba");
        var numereRaw=Console.ReadLine().Split(" ");
        var numere=new int[2];
        if (numereRaw.Length == 2 &&
            int.TryParse(numereRaw[0], out numere[0]) &&
            int.TryParse(numereRaw[1], out numere[1]))
            return numere;
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
        return ReadNumbers();
    }
    static int[] InterchangeNumbers(int[] numere)
    {
        Array.Reverse(numere);
        return numere;
    }
    static void ShowNumbers(int[] numere)
    {
        Console.WriteLine($"Numerele inversate sunt {numere[0]} si {numere[1]}");
    }
}