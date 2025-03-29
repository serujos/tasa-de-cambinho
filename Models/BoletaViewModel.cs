namespace prac1_lab_cjjosmer.Models
{
    public class BoletaViewModel
    {
        // Datos personales
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;

        
        public decimal CantidadOrigen { get; set; }
        public string MonedaOrigen { get; set; } = string.Empty;
        public string MonedaDestino { get; set; } = string.Empty;
        public decimal Resultado { get; set; }
        public string Mensaje { get; set; } = string.Empty;
    }
}
