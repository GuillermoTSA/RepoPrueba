//09/04/2024
class Descuento
{
    static void Main(string[] args)
    {
        int PrecioOriginal = 120;
        int PorcentajeDescuento = 20;
        bool EsVIP = false;
        int PrecioFinal = 0;
        Console.WriteLine("Valor final del producto: " + CalcularDescuento(PrecioOriginal, PorcentajeDescuento, PrecioFinal, EsVIP));
    }
    static int CalcularDescuento(int a, int b, int c, bool VIP = false)
    {
        int d = (b * a) / 100;
        c = a - d;
        if (VIP)
        {
            d = (c * 10) / 100;
            c = c - d;
        }
        return c;
    }
}
