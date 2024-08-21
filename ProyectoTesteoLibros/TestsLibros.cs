
using EjerciciosDePrueba.Repositories;

namespace ProyectoTesteoLibros
{
    public class TestsLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestObtenerLibros()
        {
            LibrosRepository librosRepository=new LibrosRepository();
            var libros = await librosRepository.ObtenerLibrosAsync();
            
            Assert.That(libros.Count, Is.Not.EqualTo(0));
        }
        [Test]
        public async Task TestAgregarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            //var libro = await librosRepository.AgregarAsync("LibroTest", "autoTest", "EditorialTest", "portadaTest", "sinopsisTest", 100, "generoTest");
            //Assert.That(libro.nombre, Is.EqualTo("LibroTest"));
        }
        [Test]
        public async Task TestEliminarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var borrado = await librosRepository.EliminarAsync("665a14ac5b0cfb0b00006581");
            Assert.That(borrado, Is.EqualTo(true));

        }
        [Test]
        public async Task TestObtenerLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.ObtenerPorIdAsync("663b5915aa9e29220000686f");
            Assert.That(libro.nombre, Is.EqualTo("Cien años de soledad"));
        }
        [Test]
        public async Task ActualizarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            //var libro = await librosRepository.ActualizarAsync("LibroActualizado", "autoTest", "EditorialTest", "portadaTest", "sinopsisTest", 100, "generoTest", "665a1d285b0cfb0b000065b8");
            //Assert.That(libro.nombre, Is.EqualTo("LibroActualizado"));
        }
    }
}