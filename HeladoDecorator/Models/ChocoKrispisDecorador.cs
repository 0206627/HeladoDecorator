using System;
namespace HeladoDecorator.Models
{
    public class ChocoKrispisDecorador : IngredienteDecorador
    {
        public ChocoKrispisDecorador(IHelado helado) : base(helado)
        {
            _nombre = "ChocoKrispis";
            _precio = 0.50;
        }
    }
}
