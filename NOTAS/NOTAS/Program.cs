public class Program
{
    private static void Main(string[] args)
    {
        bool NUEVOGRUPO = true;
        do
        {
            //SOLICITAR CANTIDAD DE ESTUDIANTES
            Console.Write("INGRESE NUMERO DE ESTUDIANTES: ");
            int NUMERO_ESTUDIANTES = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NUMERO_ESTUDIANTES; i++)
            {
                Console.WriteLine($"\nESTUDIANTE {i}:");
                // SOLICITAR NOTAS ESTUDIANTES
                Console.Write("INGRESE NUMERO DE NOTAS: ");
                int CANT_NOTAS = int.Parse(Console.ReadLine());
                double SUMA_NOTAS = 0;
                for (int j = 1; j <= CANT_NOTAS; j++)
                {
                    Console.Write($"INGRESE LA NOTA {j}: ");
                    double nota = double.Parse(Console.ReadLine());
                    SUMA_NOTAS += nota;
                }
                // CALCULAR PROMEDIO
                double PROMEDIO = SUMA_NOTAS / CANT_NOTAS;
                Console.WriteLine($"PROMEDIO DEL ESTUDIANTE {i}: {PROMEDIO:F2}");
                // CLASIFICAR AL ESTUDIANTE
                switch (PROMEDIO)
                {
                    case var _ when PROMEDIO >= 4.5:
                        Console.WriteLine("CATEGORIA EXCELENTE");
                        break;
                    case var _ when PROMEDIO >= 4.0 && PROMEDIO < 4.5:
                        Console.WriteLine("CATEGORIA SOBRESALIENTE");
                        break;
                    case var _ when PROMEDIO >= 3.5 && PROMEDIO < 4.0:
                        Console.WriteLine("CATEGORIA BUENO");
                        break;
                    default:
                        Console.WriteLine("CATEGORIA INSUFICIENTE");
                        break;
                }
            }

            //PREGUNTAR POR OTRO GRUPO
            Console.Write("\nDESEA INGRESAR OTRO GRUPO DE ESTUDIANTES? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            { NUEVOGRUPO = false; }
            else
            { Console.Clear(); }
        } while (NUEVOGRUPO);
        Console.WriteLine("ESPERAMOS QUE VUELVAS PRONTO");
    }
}
