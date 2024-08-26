using Ejercicio.Entidades;

namespace Ejercicio.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creación de un prisma con el constructor por defecto
                PrismaRectangularRecto prisma1 = new PrismaRectangularRecto();
                prisma1.InformarDatos();
                Console.WriteLine();

                // Creación de un prisma con valores específicos
                PrismaRectangularRecto prisma2 = new PrismaRectangularRecto(3, 4, 5);
                prisma2.InformarDatos();
                Console.WriteLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
