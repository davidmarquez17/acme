namespace acme_api_rest.Models
{
    public class EnviarPedidoRequest
    {
        public int pedido { get; set; }
        public int cantidad { get; set; }
        public int ean { get; set; }
        public string producto { get; set; }
        public int cedula { get; set; }
        public string direccion { get; set; }
    }
}
