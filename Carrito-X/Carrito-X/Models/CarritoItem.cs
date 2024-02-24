namespace Carrito_X.Models
{
    public class CarritoItem
    {
        public Carrito Carrito { get; set; }
        public Producto Producto { get; set; }
        public Double ValorUnitario { get; set; }
        public int Cantidad { get; set; }
        public Double Subtotal { get; set; }

    }
}
