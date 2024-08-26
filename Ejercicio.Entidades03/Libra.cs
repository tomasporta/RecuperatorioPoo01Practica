using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades03
{
    public class Libra
    {
        private float _peso;

        // Constructor por defecto, inicializa _peso en 10
        public Libra() : this(10) { }

        // Constructor que recibe un peso inicial
        public Libra(float peso)
        {
            _peso = peso;
        }

        // Método para obtener el peso
        public float GetPeso()
        {
            return _peso;
        }

        // Conversión implícita de float a Libra
        public static implicit operator Libra(float peso)
        {
            return new Libra(peso);
        }

        // Conversión explícita de Libra a float
        public static explicit operator float(Libra libra)
        {
            return libra._peso;
        }

        // Conversión explícita de Libra a Kilo
        public static explicit operator Kilo(Libra libra)
        {
            return new Kilo(libra._peso * 0.45359237f); // 1 Libra = 0.45359237 Kilos
        }

        // Sobrecarga del operador de igualdad
        public static bool operator ==(Libra l1, Libra l2)
        {
            return l1._peso == l2._peso;
        }

        public static bool operator !=(Libra l1, Libra l2)
        {
            return !(l1 == l2);
        }

        // Sobrecarga del operador de suma
        public static Libra operator +(Libra l1, Libra l2)
        {
            return new Libra(l1._peso + l2._peso);
        }

        // Sobrecarga del operador de resta
        public static Libra operator -(Libra l1, Libra l2)
        {
            return new Libra(l1._peso - l2._peso);
        }

        // Sobrescribir Equals y GetHashCode para usar con ==
        public override bool Equals(object obj)
        {
            if (obj is Libra)
            {
                return this == (Libra)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _peso.GetHashCode();
        }
    }
}
