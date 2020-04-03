using System;
namespace HeladoDecorator.Models
{
    public class LunetasDecorador : IngredienteDecorador
    {
        public LunetasDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Lunetas";
            _precio = 0.70;
        }
    }
}
