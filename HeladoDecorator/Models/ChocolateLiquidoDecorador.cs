using System;
namespace HeladoDecorator.Models
{
    public class ChocolateLiquidoDecorador : IngredienteDecorador
    {
        public ChocolateLiquidoDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Chocolate Líquido";
            _precio = 0.0;
        }
    }
}
