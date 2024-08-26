using Ejercicio.Entidades02;

namespace Ejercicio.Consola02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la fecha de nacimiento al usuario
            Console.Write("Ingrese su fecha de nacimiento (formato: YYYY-MM-DD): ");
            DateTime fechaNacimiento;
            if (DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
            {
                string signoZodiacal = Horoscopo.SignoZodiacal(fechaNacimiento);
                Console.WriteLine($"Tu signo zodiacal es: {signoZodiacal}");
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento no válida.");
            }

            // Solicitar el año de nacimiento al usuario
            Console.Write("Ingrese su año de nacimiento: ");
            int anioNacimiento;
            if (int.TryParse(Console.ReadLine(), out anioNacimiento))
            {
                string signoChino = Horoscopo.SignoChino(anioNacimiento);
                Console.WriteLine($"Tu signo chino es: {signoChino}");
            }
            else
            {
                Console.WriteLine("Año de nacimiento no válido.");
            }
        }
    }
    }

