internal class Program
{
    enum DiasSemana
    {
        Domingo,
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un dia de la semana: ");
        String DiaIngresado = Console.ReadLine();
        DiasSemana Dia;
        String Laborable = "";
        if (Enum.TryParse(DiaIngresado, true, out Dia))
        {
         Console.WriteLine(Dia + " es un dia " + DiaLaborable(Dia, Laborable));
        }
        else
        {
            Console.WriteLine("El dia ingresado no es valido");
        }
    }
    static string DiaLaborable(DiasSemana Dia, String Laborable) {
        switch (Dia)
        {
            case DiasSemana.Domingo:
                Laborable = "No Laborable";
                break;

            case DiasSemana.Lunes:
                Laborable = "Laborable";
                break;

            case DiasSemana.Martes:
                Laborable = "Laborable";
                break;

            case DiasSemana.Miercoles:
                Laborable = "Laborable";
                break;

            case DiasSemana.Jueves:
                Laborable = "Laborable";
                break;

            case DiasSemana.Viernes:
                Laborable = "Laborable";
                break;

            case DiasSemana.Sabado:
                Laborable = "No Laborable";
                break;
        }
        return Laborable;
    }
}
