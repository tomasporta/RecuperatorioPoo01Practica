using Ejercicio.Entidades03;

namespace Ejercicio.Consola03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Kilo y Libra
            Kilo kilo1 = new Kilo(5);
            Kilo kilo2 = new Kilo(10);
            Libra libra1 = new Libra(2.20462f); // Equivalente a 1 kilo
            Libra libra2 = new Libra(4.40924f); // Equivalente a 2 kilos

            // Mostrar pesos iniciales
            Console.WriteLine($"Peso de kilo1: {kilo1.GetPeso()} kg");
            Console.WriteLine($"Peso de kilo2: {kilo2.GetPeso()} kg");
            Console.WriteLine($"Peso de libra1: {libra1.GetPeso()} lb");
            Console.WriteLine($"Peso de libra2: {libra2.GetPeso()} lb");

            // Comparaciones
            Console.WriteLine($"kilo1 == kilo2: {kilo1 == kilo2}");
            Console.WriteLine($"libra1 == libra2: {libra1 == libra2}");

            // Conversión entre clases
            Libra convertidoEnLibra = (Libra)kilo1;
            Kilo convertidoEnKilo = (Kilo)libra1;
            Console.WriteLine($"kilo1 convertido a libra: {convertidoEnLibra.GetPeso()} lb");
            Console.WriteLine($"libra1 convertido a kilo: {convertidoEnKilo.GetPeso()} kg");

            // Operaciones aritméticas
            Kilo sumaKilos = kilo1 + kilo2;
            Libra sumaLibras = libra1 + libra2;
            Console.WriteLine($"Suma de kilos: {sumaKilos.GetPeso()} kg");
            Console.WriteLine($"Suma de libras: {sumaLibras.GetPeso()} lb");

            Kilo restaKilos = kilo2 - kilo1;
            Libra restaLibras = libra2 - libra1;
            Console.WriteLine($"Resta de kilos: {restaKilos.GetPeso()} kg");
            Console.WriteLine($"Resta de libras: {restaLibras.GetPeso()} lb");
        }
    }
    }

