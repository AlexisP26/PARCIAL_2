public class Program
{
    private static void Main(string[] args)
    {
        //DEFINIR VARIABLES
        Random ALEATORIO = new Random();
        int NUMERO_ADIVINAR = 0;
        int CANT_JUGADORES = 0;
        bool VOLVER = true;
        //CON ESTE DO WHILE ME ASEGURE DE QUE SI HAY UN NUMERO FUERA
        //DEL RANGO SE DEVUELVA AL INICIO
        do
        {
            Console.WriteLine("INGRESE NUMERO DE JUGADORES (2-4):  ");
            CANT_JUGADORES = int.Parse(Console.ReadLine());
        } while (CANT_JUGADORES < 2 || CANT_JUGADORES > 4);
        //GENERAR NUMERO ALEATORIO
        switch (CANT_JUGADORES)
        {
            case 2:
                NUMERO_ADIVINAR = ALEATORIO.Next(0, 51);
                break;
            case 3:
                NUMERO_ADIVINAR = ALEATORIO.Next(0, 101);
                break;
            case 4:
                NUMERO_ADIVINAR = ALEATORIO.Next(0, 201);
                break;
        }
        //INICIAR JUEGO
        Console.WriteLine("LET'S GO!");
        bool NUMERO_ADIVINADO = false;
        int TURNO = 0;
        //BUCLE
        while (!NUMERO_ADIVINADO)
        {
            TURNO = TURNO % CANT_JUGADORES + 1;
            Console.WriteLine($"TE TOCA {TURNO}. INGRESA UN NUMERO: ");
            int NUM_TURNO = int.Parse(Console.ReadLine());
            if (NUM_TURNO > NUMERO_ADIVINAR)
            { Console.WriteLine("MENOR"); }
            else if (NUM_TURNO < NUMERO_ADIVINAR)
            { Console.WriteLine("MAYOR"); }
            else
            {
                Console.WriteLine($"CONGRATULATIONS, PLAYER {TURNO}");
                NUMERO_ADIVINADO = true;
            }
            //VOLVER A JUGAR
            Console.WriteLine("¡DESEAS VOLVER A JUGAR? (S/N):  ");
            string RESULTADO = Console.ReadLine().ToLower();
            if (RESULTADO != "S")
            { VOLVER = false; }
            else
            { Console.Clear(); }
            while (VOLVER) ;
            Console.WriteLine("HASTA LA PROXIMA");




        }
    }
}
