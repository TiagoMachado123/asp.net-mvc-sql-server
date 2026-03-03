using teste.Data;
using teste.Models;

namespace teste.Services
{
    public interface IFaturaService
    {
        List<Fatura> ObterTodas();
    }

    public class FaturaService : IFaturaService
    {
        // Variável para guardar a ponte para a base de dados
        private readonly AppDbContext _context;

        // INJEÇÃO DE DEPENDÊNCIA: O .NET entrega-nos o AppDbContext pronto a usar!
        public FaturaService(AppDbContext context)
        {
            _context = context;
        }

        public List<Fatura> ObterTodas()
        {
            // O ".ToList()" diz ao EF Core para executar o comando SQL (SELECT * FROM Faturas)
            return _context.Faturas.ToList();
        }
    }
}
