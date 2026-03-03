namespace teste.Models
{
    //Ckass Fatura
    public class Fatura
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorTotal { get; set; } =  0;
    }
}
