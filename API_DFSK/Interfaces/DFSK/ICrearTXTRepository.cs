using API_DFSK.DTOs.DFSK;

namespace API_DFSK.Interfaces.DFSK
{
    public interface ICrearTXTRepository
    {
        Task<ResumentxtDTO> CreateTXT(ResumentxtDTO data);
        Task<ResumentxtDTO> GetTXT(int Id);
        Task<List<ResumentxtDTO>> ListaTxt(string factura1, string factura2);
    }
}
