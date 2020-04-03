using System;
namespace HeladoDecorator.Models
{
    public class PlatanoDecorador : IngredienteDecorador
    {
        public PlatanoDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Plátano";
            _precio = 5.00;
        }
    }
}
