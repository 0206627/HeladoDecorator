using System;
namespace HeladoDecorator.Models
{
    public class VainillaDecorador : IngredienteDecorador
    {
        public VainillaDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Vainilla";
            _precio = 7.00;
        }
    }
}
