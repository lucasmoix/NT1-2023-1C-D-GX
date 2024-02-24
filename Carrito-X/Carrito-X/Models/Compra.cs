namespace Carrito_X.Models
{
    public class Compra
    {
        public Cliente Cliente { get; set; }
        public Carrito Carrito { get; set; }
        public Double Total { get; set; }

    }
}
