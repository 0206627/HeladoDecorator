using System;
namespace HeladoDecorator.Models
{
    public class CanastaHelado : IHelado
    {
        public CanastaHelado()
        {
        }

        public double ObtenerCosto()
        {
            return 1.00;
        }

        public string ObtenerDescripcion()
        {
            return "Canasta";
        }
    }
}
