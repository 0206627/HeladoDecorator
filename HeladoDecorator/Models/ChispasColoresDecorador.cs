using System;
namespace HeladoDecorator.Models
{
    public class ChispasColoresDecorador : IngredienteDecorador
    {
        public ChispasColoresDecorador(IHelado helado) : base(helado)
        {
            _nombre = "Chispas Colores";
            _precio = 0.20;
        }
    }
}
