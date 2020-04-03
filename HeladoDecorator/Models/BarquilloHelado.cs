using System;
namespace HeladoDecorator.Models
{
    public class BarquilloHelado : IHelado
    {
        public BarquilloHelado()
        {
        }

        public double ObtenerCosto()
        {
            return 0.50;
        }

        public string ObtenerDescripcion()
        {
            return "Barquillo";
        }
    }
}
