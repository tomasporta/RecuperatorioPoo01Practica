using Ejercicio.Entidades;

namespace PrismaRectanguloTests
{
    [TestClass]
    public class PrismaRectanguloTests
    {
        [TestMethod]
        public void Constructor_DefaultValues_ShouldSetAttributesToOne()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Assert.AreEqual(1, prisma.Largo);
            Assert.AreEqual(1, prisma.Altura);
            Assert.AreEqual(1, prisma.Ancho);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidValues_ShouldThrowArgumentException()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(-1, 0, 5);
        }

        [TestMethod]
        public void CalcularArea_ShouldReturnCorrectValue()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(3, 4, 5);
            int expectedArea = 2 * (3 * 5 + 4 * 5 + 4 * 3);
            Assert.AreEqual(expectedArea, prisma.CalcularArea());
        }

        [TestMethod]
        public void CalcularVolumen_ShouldReturnCorrectValue()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(3, 4, 5);
            int expectedVolumen = 3 * 4 * 5;
            Assert.AreEqual(expectedVolumen, prisma.CalcularVolumen());
        }

        [TestMethod]
        public void CalcularDiagonal_ShouldReturnCorrectValue()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(3, 4, 5);
            double expectedDiagonal = Math.Sqrt(3 * 3 + 4 * 4 + 5 * 5);
            Assert.AreEqual(expectedDiagonal, prisma.CalcularDiagonal(), 0.0001);
        }
    }
    }
