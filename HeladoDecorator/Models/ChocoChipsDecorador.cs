using System;
namespace HeladoDecorator.Models
{
    public class ChocoChipsDecorador : IngredienteDecorador
    {
        public ChocoChipsDecorador(IHelado helado) : base(helado)
        {
            _nombre = "ChocoChips";
            _precio = 8.00;
        }
    }
}
