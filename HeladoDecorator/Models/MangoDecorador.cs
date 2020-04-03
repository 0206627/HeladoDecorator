using System;
namespace HeladoDecorator.Models
{
    public class MangoDecorador : IngredienteDecorador
    {
        public MangoDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Mango";
            _precio = 6.00;
        }
    }
}
