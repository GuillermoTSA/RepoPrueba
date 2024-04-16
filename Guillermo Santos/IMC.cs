internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su altura");
        float Alt = float.Parse(Console.ReadLine());
        //Utilizamos Console.ReadLine para capturar la cadena de caracteres que el usuario ingrese en la consola, la parseamos y la guardamos en una variable
        Console.WriteLine("Ingrese su peso");
        float Wgh = float.Parse(Console.ReadLine());

        float Cuenta = Wgh / (Alt * Alt);
        //Realizamos la cuenta necesaria para conocer nuestro situacion con respecto a los límites del índice de masa corporal

        if (Cuenta < 18.5)
            Console.WriteLine("Usted está por debajo de el indice de masa corporal recomendado");
        if (Cuenta > 25.0)
            Console.WriteLine("Usted está por sobre el índice de masa corporal recomendado");
        if (Cuenta > 18.5 && Cuenta < 25.0)
            Console.WriteLine("Usted está dentro del índice de masa recomendado");
        //Utilizamos la estructura de bifurcación if para condicionar nuestro resultado a los datos ingresados por el usuario
    }

}
