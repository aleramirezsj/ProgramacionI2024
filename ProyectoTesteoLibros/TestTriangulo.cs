using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestTriangulo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEquilatero() {
            string resultado=ProgramEjercicios.Triangulos(1,1,1);
            Assert.That(resultado, Is.EqualTo("equilatero"));
        }
        [Test]
        public void TestIsoceles()
        {
            string resultado = ProgramEjercicios.Triangulos(1, 1, 2);
            Assert.That(resultado, Is.EqualTo("isoceles"));
        }
        [Test]
        public void TestEscaleno()
        {
            string resultado = ProgramEjercicios.Triangulos(1, 2, 3);
            Assert.That(resultado, Is.EqualTo("escaleno"));
        }
    }
}
