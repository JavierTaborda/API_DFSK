using API_DFSK.DTOs.ConcesionarioDFSK;

namespace API_DFSK.Interfaces.ConcesionarioDFSK
{
    public interface IEstadoRepository
    {
        //GETS
        #region gets 
     
        Task<List<EstadoDTO>> GetEstados();
        Task<EstadoDTO?> GetEstadoById(int Id);

        #endregion

        //POST
        Task<bool> InsertEstado(List<EstadoDTO> Estados);

        //PUTS

        Task<EstadoDTO> UpdateEstado(EstadoDTO Estados);
    }
}
