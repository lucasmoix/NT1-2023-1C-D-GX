namespace Carrito_X.Models
{
    public class Carrito
    {
        public Boolean Activo { get; set; }
        public Cliente Cliente { get; set; }
        public CarritoItem CarritoItem { get; set; }
        public Double SubTotal { get; set; }

    }
}
