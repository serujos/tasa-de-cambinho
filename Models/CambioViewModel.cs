namespace prac1_lab_cjjosmer.Models{
    public class CambioViewModel
    {
    public decimal CantidadOrigen { get; set; } = 0;
    public string MonedaOrigen { get; set; } = string.Empty; 
    public string MonedaDestino { get; set; } = string.Empty; 
    public decimal Resultado { get; set; } = 0;
     public string Mensaje { get; set; } = string.Empty;
    }

}