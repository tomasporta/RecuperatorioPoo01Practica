using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades
{
    public  class PrismaRectangularRecto
    {
       


    
        // Atributos privados
        private int largo;
        private int altura;
        private int ancho;

        // Propiedades de solo lectura
        public int Largo => largo;
        public int Altura => altura;
        public int Ancho => ancho;

        // Constructor por defecto
        public PrismaRectangularRecto()
        {
            largo = 1;
            altura = 1;
            ancho = 1;
        }

        // Constructor con parámetros
        public PrismaRectangularRecto(int largo, int altura, int ancho)
        {
            if (largo <= 0 || altura <= 0 || ancho <= 0)
            {
                throw new ArgumentException("Los valores de largo, altura y ancho deben ser mayores a cero.");
            }
            this.largo = largo;
            this.altura = altura;
            this.ancho = ancho;
        }

        // Método privado para calcular el área de la base
        private int AreaBase()
        {
            return largo * ancho;
        }

        // Método privado para calcular el área de la altura
        private int AreaAltura()
        {
            return altura * ancho;
        }

        // Método privado para calcular el área del ancho
        private int AreaAncho()
        {
            return altura * largo;
        }

        // Método para calcular el área total del prisma
        public int CalcularArea()
        {
            return 2 * (AreaBase() + AreaAltura() + AreaAncho());
        }

        // Método para calcular el volumen del prisma
        public int CalcularVolumen()
        {
            return largo * altura * ancho;
        }

        // Método para calcular la diagonal del prisma
        public double CalcularDiagonal()
        {
            return Math.Sqrt(largo * largo + altura * altura + ancho * ancho);
        }

        // Método para informar todos los datos
        public void InformarDatos()
        {
            Console.WriteLine($"Largo: {largo}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Ancho: {ancho}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Volumen: {CalcularVolumen()}");
            Console.WriteLine($"Diagonal: {CalcularDiagonal():F2}");
        }
    }

}

