using teste.Data;
using teste.Models;

namespace teste.Services
{
    public interface IFaturaService
    {
        List<Fatura> ObterTodas();
        void CriarFatura(Fatura novaFatura);

        int ObterQuantidade();
    }

    public class FaturaService : IFaturaService
    {
        private readonly AppDbContext _context;

        public FaturaService(AppDbContext context)
        {
            _context = context;
        }

        public void CriarFatura(Fatura novaFatura)
        {
            _context.Faturas.Add(novaFatura);

            _context.SaveChanges();
        }

        public List<Fatura> ObterTodas()
        {
            // O ".ToList()" diz ao EF Core para executar o comando SQL (SELECT * FROM Faturas)
            return _context.Faturas.ToList();
        }

        public int ObterQuantidade()
        {
            // O ".Count()" diz ao EF Core para executar o comando SQL (SELECT COUNT(*) FROM Faturas)
            return _context.Faturas.Count();
        }
    }
}
