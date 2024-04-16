internal class Program
{
    enum Direccion
    {
        Norte,
        Sur,
        Este,
        Oeste
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un punto cardinal: ");
        String Dir1 = Console.ReadLine();
        String Dir2 = "";
        Direccion Direc1;
        Direccion Direc2;
        String DirecFinal = "";
        if (Enum.TryParse(Dir1, true, out Direc1))
        {
            Console.WriteLine("Ingrese otro punto cardinal: ");
            Dir2 = Console.ReadLine();
            if (Enum.TryParse(Dir2, true, out Direc2))
            {
                Console.WriteLine("La direccion final es: " + ConjuntoDireccion(Direc1, Direc2, DirecFinal));
            }
            else
            {
                Console.WriteLine("La segunda direccion ingresada no es valida");
            }
        }
        else
        {
            Console.WriteLine("La primer direccion ingresada no es valida");
        }
    }
    static string ConjuntoDireccion(Direccion Direc1, Direccion Direc2, String DirecFinal)
    {
        switch (Direc1)
        {
            case Direccion.Norte:
                if (Direc2 != Direccion.Sur && Direc2 != Direccion.Norte)
                {
                    Console.WriteLine(Direc2);
                    if (Direc2 == Direccion.Este)
                    {
                        DirecFinal = "Noreste";
                    }
                    else
                    {
                        DirecFinal = "Noroeste";
                    }
                }
                else
                {
                    DirecFinal = "Error";
                }
                break;

            case Direccion.Sur:
                if (Direc2 != Direccion.Sur && Direc2 != Direccion.Norte)
                {
                    if (Direc2 == Direccion.Este)
                    {
                        DirecFinal = "Sureste";
                    }
                    else
                    {
                        DirecFinal = "Suroeste";
                    }
                }
                else
                {
                    DirecFinal = "Error";
                }
                break;

            case Direccion.Este:
                if (Direc2 != Direccion.Este && Direc2 != Direccion.Oeste)
                {
                    if (Direc2 == Direccion.Norte)
                    {
                        DirecFinal = "Noreste";
                    }
                    else
                    {
                        DirecFinal = "Sureste";
                    }
                }
                else
                {
                    DirecFinal = "Error";
                }
                break;

            case Direccion.Oeste:
                if (Direc2 != Direccion.Este && Direc2 != Direccion.Oeste)
                {
                    if (Direc2 == Direccion.Norte)
                    {
                        DirecFinal = "Noroeste";
                    }
                    else
                    {
                        DirecFinal = "Suroeste";
                    }
                }
                else
                {
                    DirecFinal = "Error";
                }
                break;
        }
        return DirecFinal;
    }
}
