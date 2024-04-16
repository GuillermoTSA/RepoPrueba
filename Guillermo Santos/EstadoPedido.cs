    internal class Program
    {
        enum EstadoPedido
        {
            Pendiente,
            EnProceso,
            Entregado
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("En que estado se encuentra su pedido?: ");
            String EstadoRead = Console.ReadLine();
            EstadoPedido Pedido;
            if (Enum.TryParse(EstadoRead, true, out Pedido))
            {
                MostrarEstadoPedido(Pedido);
             }
            else
            {
                Console.WriteLine("El estado ingresado no es valido");
            }

    }
        static void MostrarEstadoPedido(EstadoPedido Estados)
        {
            switch (Estados)
            {
                case EstadoPedido.EnProceso:
                    Console.WriteLine("Su pedido se encuentra en proceso");
                    break;
                case EstadoPedido.Pendiente:
                    Console.WriteLine("Su pedido está pendiente de aprobacion");
                    break;
                case EstadoPedido.Entregado:
                    Console.WriteLine("Su pedido ya fue entregado");
                    break;
            }
        }
    }
