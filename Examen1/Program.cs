using System.Drawing;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruleta ruleta = new Ruleta();
            Jugador jugador = new Jugador(300);

            Console.WriteLine("Bienvenido a la ruleta de ElTeban, espero y te diviertas usandola");
            Console.WriteLine("Pulsa Enter para comenzar a jugar ");
            Console.ReadLine();

            while (jugador.Dinero > 0)
            {
                Console.Clear();
                Console.WriteLine($"Tienes ${jugador.Dinero}. Cuanto deseas apostar? (Te recomiendo que apuestes mutliplos de 10 ;D)");

                if(int.TryParse(Console.ReadLine(), out int apuesta) && apuesta % 10 == 0 && apuesta <= jugador.Dinero)
                {
                    Console.WriteLine("Como quieres apostar tu dinero");
                    Console.WriteLine("1. Número en especifico (0-36)");
                    Console.WriteLine("2. Color en especial(Rojo/Negro)");
                    Console.WriteLine("3. Elige entre Par/Impar");

                    int opcion = int.Parse(Console.ReadLine());
                    int numeroGanador = ruleta.Girar();
                    Color colorGanador = ruleta.obtenerColor(numeroGanador);

                    switch( opcion )
                    {
                        case 1:
                            Console.WriteLine("Cual es tu numero de la suerte?:");
                            int respuesta;
                            respuesta = int.Parse(Console.ReadLine());  
                            Console.WriteLine($"Numero ganador: {numeroGanador}");
                            
                            if (respuesta == numeroGanador)
                            {
                                jugador.Dinero += apuesta * 10;
                                Console.WriteLine($"FELICIDADES!! Ganaste esta vez, Ahora tienes ${jugador.Dinero}");
                                Console.ReadLine();
                            }
                            else
                            {
                                jugador.Dinero -= apuesta;
                                Console.WriteLine($"Tristemente Perdiste. Ahora tienes ${jugador.Dinero}");
                                Console.ReadLine();
                            }
                            break;

                        case 2:
                            Console.WriteLine("Elije el colorque mas te llame la atencion Rojo o Negro:");
                            Color colorElegido = Enum.Parse<Color>(Console.ReadLine(), true);
                            Console.WriteLine($"El color ganador es: {colorGanador}");

                            if (colorElegido == colorGanador)
                            {
                                jugador.Dinero += apuesta * 5;
                                Console.WriteLine($"FELICIDADES!! Tu color te trajo suerte, ahora tienes: ${jugador.Dinero}");
                                Console.ReadLine();
                            }
                            else
                            {
                                jugador.Dinero -= apuesta;
                                Console.WriteLine($"Hoy no es tu dia de suerte :/ perdiste, ahora tienes:{jugador.Dinero}");
                                Console.ReadLine();
                            }
                            break;
                        
                        
                        case 3:
                            Console.WriteLine("Haz tu prediccion, Par o Impar??");
                            bool eleccion = Console.ReadLine().ToLower() == "par";
                            if((numeroGanador % 2 == 0 && eleccion) || (numeroGanador % 2 != 0 && !eleccion))
                            {
                                jugador.Dinero += apuesta * 2;
                                Console.WriteLine($"WOW!! Eres adivino, ganaste. ahora tienes ${jugador.Dinero}");
                                Console.ReadLine();
                            }
                            else
                            {
                                jugador.Dinero -= apuesta;
                                Console.WriteLine($"Mala suerte, perdiste. Ahora tienes: ${jugador.Dinero}");
                                Console.ReadLine();
                            }
                            break;

                        default:
                            Console.WriteLine("ERRO 404");
                            Console.ReadLine();
                            break;
                    }

                }
                Console.WriteLine("Haz perdido todo :'(. Fin del juego, Hasta la prxima :D");
            } 
        }
    }
}
