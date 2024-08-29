using API_DFSK.Models.DFSK;

namespace API_DFSK.Interfaces.DFSK
{
    public interface ICrearTXTRepository
    {
        Task<Resumentxt> CreateTXT(Resumentxt data);
        Task<Resumentxt> GetTXT(int Id);
        Task<List<Resumentxt>> ListaTxt(string factura1, string factura2);
    }
}
