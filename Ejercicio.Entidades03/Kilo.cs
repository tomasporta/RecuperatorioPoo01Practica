using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Entidades03
{
    public class Kilo
    {
        private float _peso;

        // Constructor por defecto, inicializa _peso en 10
        public Kilo() : this(10) { }

        // Constructor que recibe un peso inicial
        public Kilo(float peso)
        {
            _peso = peso;
        }

        // Método para obtener el peso
        public float GetPeso()
        {
            return _peso;
        }

        // Conversión implícita de float a Kilo
        public static implicit operator Kilo(float peso)
        {
            return new Kilo(peso);
        }

        // Conversión explícita de Kilo a float
        public static explicit operator float(Kilo kilo)
        {
            return kilo._peso;
        }

        // Conversión explícita de Kilo a Libra
        public static explicit operator Libra(Kilo kilo)
        {
            return new Libra(kilo._peso * 2.2046226219f); // 1 Kilo = 2.2046226219 Libras
        }

        // Sobrecarga del operador de igualdad
        public static bool operator ==(Kilo k1, Kilo k2)
        {
            return k1._peso == k2._peso;
        }

        public static bool operator !=(Kilo k1, Kilo k2)
        {
            return !(k1 == k2);
        }

        // Sobrecarga del operador de suma
        public static Kilo operator +(Kilo k1, Kilo k2)
        {
            return new Kilo(k1._peso + k2._peso);
        }

        // Sobrecarga del operador de resta
        public static Kilo operator -(Kilo k1, Kilo k2)
        {
            return new Kilo(k1._peso - k2._peso);
        }

        // Sobrescribir Equals y GetHashCode para usar con ==
        public override bool Equals(object obj)
        {
            if (obj is Kilo)
            {
                return this == (Kilo)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _peso.GetHashCode();
        }
    }
}

