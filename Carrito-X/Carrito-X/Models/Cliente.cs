namespace Carrito_X.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int Telefono { get; set; }
        public String Dirreccion { get; set; }
        public DateTime FechaAlta { get; set; }
        public String Email { get; set; }
        public Compra Compra { get; set; }
        public Carrito Carrrito { get; set; }

    }
}
