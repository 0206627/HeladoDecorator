using System;
namespace HeladoDecorator.Models
{
    public class ChocolateDecorador : IngredienteDecorador
    {
        public ChocolateDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Chocolate";
            _precio = 8.00;
        }
    }
}
