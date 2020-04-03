using System;
namespace HeladoDecorator.Models
{
    public class FresasDecorador : IngredienteDecorador
    {
        public FresasDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Fresas";
            _precio = 7.00;
        }
    }
}
