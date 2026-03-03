using teste.Models;

namespace teste.Services
{
    public interface IFaturaService
    {
        List<Fatura> ObterTodas();
    }

    public class FaturaService : IFaturaService
    {
        public List<Fatura> ObterTodas()
        {
            return new List<Fatura>
            {
                new Fatura { Id = 1, NomeCliente = "Empresa A", ValorTotal = 1500.50m },
                new Fatura { Id = 2, NomeCliente = "Empresa B", ValorTotal = 300.00m },
                new Fatura { Id = 3, NomeCliente = "Cliente Final", ValorTotal = 45.99m },
                new Fatura { Id = 3, NomeCliente = "Empresa C", ValorTotal = 47.34m }
            };
        }
    }
}
