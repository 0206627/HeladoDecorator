using System;
namespace HeladoDecorator.Models
{
    public class VasoHelado : IHelado
    {
        public VasoHelado()
        {
        }

        public double ObtenerCosto()
        {
            return 0.0;
        }

        public string ObtenerDescripcion()
        {
            return "Vaso";
        }
    }
}
