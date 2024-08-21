using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeApoyo.Clases
{
    public class Ventilador
    {
        private string color;
        private string marca;
        private bool encendido;
        public int Velocidad { get; set; }
        public bool MovimientoActivo { get; set; }

        public Ventilador(string color, string marca)
        {
            this.color = color;
            this.marca = marca;
            this.Velocidad = 0;
            this.MovimientoActivo = false;
        }
        public void Encender()
        {
            this.encendido = true;
        }
        public void Apagar()
        {
            this.encendido = false;
        }
        public void CambiarVelocidad(int velocidad)
        {
            this.Velocidad= velocidad;
        }
        public void ActivarDesactivarMovimiento()
        {
            this.MovimientoActivo=!this.MovimientoActivo;
        }
        public override string ToString()
        {
            string retorno = $"Ventilador: {this.marca}{Environment.NewLine}";
            retorno += $"Color: {this.color}{Environment.NewLine}";
            retorno += $"Velocidad: {this.Velocidad}{Environment.NewLine}";
            return retorno ;
                
        }
    }
}
