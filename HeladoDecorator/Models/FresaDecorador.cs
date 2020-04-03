using System;
namespace HeladoDecorator.Models
{
    public class FresaDecorador : IngredienteDecorador
    {
        public FresaDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Fresa";
            _precio = 5.00;
        }
    }
}
