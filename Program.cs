using System.Drawing;

//Console.WriteLine("Hello, World!");
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

System.Random random = new System.Random();

//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer

while (true)
{

    Console.WriteLine("Welcome al P l a t z i n o");
    Console.WriteLine("¿Cuántos PlatziCoins deseas? \n" +
                       "Ingresa un número entero \n" +
                       "Recuerda que necesitas 1 por ronda");
    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("Escriba ‘21’ para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1; //para que me vaya descontando las platzicoins :3

                break;
            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta, jugador,");
                    Console.WriteLine($"Te salió el número: {num} ");
                    Console.WriteLine("¿Deseas otra carta ?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "Si" ||
                         controlOtraCarta == "si" ||
                         controlOtraCarta == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades";
                    i++;
                    switchControl = "menu";
                    Console.Clear();
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs el dealer, te pasaste de 21";
                    switchControl = "menu";
                    Console.Clear();
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el dealer, lo siento";
                    switchControl = "menu";
                    Console.Clear();
                }
                else
                {
                    message = "condición no válida";
                }
                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresa no válido en el  C A S I N O");
                break;
        }
    }
}