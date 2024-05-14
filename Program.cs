internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("inversor de numero!");
        string a;
        int b;
        Console.WriteLine("Ingrese un numero:");

        a = Console.ReadLine();
        char[] aux = a.ToCharArray();
        Array.Reverse(aux);
        a = string.Join("",aux);
        
        bool prueba = !int.TryParse(a, out b);
        
        if(prueba)
        {
            Console.WriteLine("Error");
            return;
        }
        
        Console.WriteLine($"El numero que ingresaste es:{a}. El numero invertido es: {b}");
        return;
    }
}