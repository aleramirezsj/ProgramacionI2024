using CiclismoDesktopPorCodigo.Modelos;
using CiclismoDesktopPorCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CiclismoDesktopPorCodigo.Views.Linq
{
    public partial class PruebasLinqView : Form
    {
        #region definimos el array Json
        JArray jsonArrayPeliculas = JArray.Parse("[\r\n  { \"title\": \"El laberinto del fauno\", \"director\": \"Guillermo del Toro\", \"year\": 2006, \"genre\": \"Fantasía\" },\r\n  { \"title\": \"Amores perros\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2000, \"genre\": \"Drama\" },\r\n  { \"title\": \"Mar adentro\", \"director\": \"Alejandro Amenábar\", \"year\": 2004, \"genre\": \"Drama\" },\r\n  { \"title\": \"Todo sobre mi madre\", \"director\": \"Pedro Almodóvar\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"El secreto de sus ojos\", \"director\": \"Juan José Campanella\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"Roma\", \"director\": \"Alfonso Cuarón\", \"year\": 2018, \"genre\": \"Drama\" },\r\n  { \"title\": \"Y tu mamá también\", \"director\": \"Alfonso Cuarón\", \"year\": 2001, \"genre\": \"Drama\" },\r\n  { \"title\": \"La lengua de las mariposas\", \"director\": \"José Luis Cuerda\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"Biutiful\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2010, \"genre\": \"Drama\" },\r\n  { \"title\": \"La vida secreta de las palabras\", \"director\": \"Isabel Coixet\", \"year\": 2005, \"genre\": \"Drama\" },\r\n  { \"title\": \"Relatos salvajes\", \"director\": \"Damián Szifron\", \"year\": 2014, \"genre\": \"Comedia negra\" },\r\n  { \"title\": \"Hable con ella\", \"director\": \"Pedro Almodóvar\", \"year\": 2002, \"genre\": \"Drama\" },\r\n  { \"title\": \"El orfanato\", \"director\": \"J.A. Bayona\", \"year\": 2007, \"genre\": \"Terror\" },\r\n  { \"title\": \"Volver\", \"director\": \"Pedro Almodóvar\", \"year\": 2006, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"Abre los ojos\", \"director\": \"Alejandro Amenábar\", \"year\": 1997, \"genre\": \"Ciencia ficción\" },\r\n  { \"title\": \"Celda 211\", \"director\": \"Daniel Monzón\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"El hijo de la novia\", \"director\": \"Juan José Campanella\", \"year\": 2001, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"El espinazo del diablo\", \"director\": \"Guillermo del Toro\", \"year\": 2001, \"genre\": \"Terror\" },\r\n  { \"title\": \"La piel que habito\", \"director\": \"Pedro Almodóvar\", \"year\": 2011, \"genre\": \"Thriller\" },\r\n  { \"title\": \"La historia oficial\", \"director\": \"Luis Puenzo\", \"year\": 1985, \"genre\": \"Drama\" }\r\n]\r\n");
        #endregion

        public PruebasLinqView()
        {
            InitializeComponent();
        }

        private void btnPruebaArray_Click(object sender, EventArgs e)
        {
            //creamos un array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //con linq filtramos los números pares y creamos un nuevo array
            var numerosPares = (from num in numbers
                                where num % 2 == 0
                                select new { Numero = num }).ToList();

            //lo asignamos a la grilla
            dataGridResultados.DataSource = numerosPares;
        }

        private void BtnPruebaSql_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoContext())
            {
                var query = from cliente in context.Clientes
                            select cliente;

                dataGridResultados.DataSource = query.ToList();
            }

        }

        private void btnPruebaXml_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("xml\\libros.xml");
            var libros = from book in doc.Descendants("book")
                         select new
                         {
                             Titulo = book.Element("title")?.Value,
                             Autor = book.Element("author")?.Value,
                             Año = book.Element("year")?.Value,
                             Genero = book.Element("genre")?.Value,
                         };

            dataGridResultados.DataSource = libros.ToList();

        }

        private void btnPruebaJson_Click(object sender, EventArgs e)
        {

            var peliculas = from pelicula in jsonArrayPeliculas
                            select new
                            {
                                Titulo = pelicula["title"],
                                Año = pelicula["year"],
                                Género = pelicula["genre"],
                                Director = pelicula["director"]
                            };
            dataGridResultados.DataSource = peliculas.ToList();
        }

        private void btnPruebaSelect_Click(object sender, EventArgs e)
        {
            var peliculas = jsonArrayPeliculas.Select(pelicula => new
            {
                Titulo = pelicula["title"],
                Año = pelicula["year"],
                Género = pelicula["genre"],
                Director = pelicula["director"]
            });

            dataGridResultados.DataSource = peliculas.ToList();
        }

        private void btnPruebaSelectMany_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoContext())
            {

                //dataGridResultados.DataSource = peliculas.ToList();
            }
        }

        private void btnPruebaWhere_Click(object sender, EventArgs e)
        {
            var pelis = jsonArrayPeliculas.ToObject<List<Pelicula>>();
            //var peliculas=pelis.Where(peli=>peli.year>2000);
            //var peliculas = pelis.Where(peli => peli.year.Equals(1985));
            //var peliculas = pelis.Where(peli => peli.year ==1985);
            var peliculas = pelis.Where(peli => peli.title.Contains("Roma"));
            dataGridResultados.DataSource = peliculas.ToList();
        }

        private void btnPruebaWhereAvanzado_Click(object sender, EventArgs e)
        {
            var pelis = jsonArrayPeliculas.ToObject<List<Pelicula>>();
            dataGridResultados.DataSource = pelis.Where(
                                p => p.title.Contains(txtFiltro.Text) ||
                                    p.director.Contains(txtFiltro.Text) ||
                                    p.genre.Contains(txtFiltro.Text)).ToList();
        }

        private void btnPruebaOrderBy_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoContext())
            {
                var clientes = context.Clientes.OrderBy(c => c.Nombre);
                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void btnPruebaOrderByAvanzado_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoContext())
            {
                var clientes = context.Clientes.OrderBy(c => c.Pais).ThenBy(c=>c.Nombre);
                dataGridResultados.DataSource = clientes.ToList();
            }
        }
    }
}
