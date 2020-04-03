using System;
namespace HeladoDecorator.Models
{
    public abstract class IngredienteDecorador : IHelado
    {

        private IHelado _helado;
        protected string _nombre = "Sin definir";
        protected double _precio = 0.0;

        public IngredienteDecorador(IHelado helado)
        {
            _helado = helado;
        }

        public double ObtenerCosto()
        {
            return _helado.ObtenerCosto() + _precio;
        }

        public string ObtenerDescripcion()
        {
            return $"{_helado.ObtenerDescripcion()}, {_nombre}";
        }
    }
}
