namespace Carrito_X.Models
{
    public class Producto
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Double PrecioVigente { get; set; }
        public Boolean Activo { get; set; }
        public Categoria Categoria { get; set; }
        public String Imagen { get; set; }
    }
}
