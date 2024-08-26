using Ejercicio.Entidades;

try
{
    // Crear una serie de Fibonacci con 10 términos
    Figonacci fibonacci = new Figonacci(10);

    // Mostrar la cantidad de términos
    Console.WriteLine($"Cantidad de términos: {fibonacci.GetCantidadTerminos()}");

    // Mostrar toda la serie de Fibonacci
    Console.Write("Serie de Fibonacci: ");
    fibonacci.MostrarSerie();

    // Obtener y mostrar un término específico
    int posicion = 5;
    Termino terminoEnPosicion = fibonacci.GetTermino(posicion);
    Console.WriteLine($"Término en la posición {posicion}: {terminoEnPosicion}");

    // Mostrar la suma de todos los términos de la serie
    int sumaDeTerminos = fibonacci;
    Console.WriteLine($"Suma de todos los términos de la serie: {sumaDeTerminos}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


