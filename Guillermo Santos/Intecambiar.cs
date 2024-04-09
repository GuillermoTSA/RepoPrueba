//09/04/2024
class Intercambiar
{
    static void Main(string[] args)
    {
        int valor1 = 40;
        int valor2 = 12;
        inter(ref valor1, ref valor2);
        Console.WriteLine("Valor 1: " + valor1 + " Valor 2: " + valor2);
    }
    static void inter(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
}
