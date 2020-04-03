using System;
namespace HeladoDecorator.Models
{
    public class LimonDecorador : IngredienteDecorador
    {

        public LimonDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Limón";
            _precio = 5.00;
        }
    }
}
