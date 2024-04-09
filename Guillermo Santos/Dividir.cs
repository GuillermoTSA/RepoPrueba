//09/04/2024
class Intercambiar
{
    static void Main(string[] args)
    {
        int valor1 = 50;
        int valor2 = 10;
        int div;
        int res;
        dividir(valor1, valor2, out div, out res);
        Console.WriteLine(valor1 + " / " + valor2 + " = " + div + "\n" + valor1 + " % " + valor2 + " = " + res);
    }
    static void dividir(int a, int b, out int div, out int res)
    {
        div = a / b;
        res = a % b;
    }
}
