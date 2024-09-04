namespace WebApi_Inventarios.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int Producto_id { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_actualizacion { get; set; }

    }
}
