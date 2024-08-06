using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
namespace API_DFSK.AutoMapper
{
    public class ConcesionarioDFSKProfile:Profile
    {
        public ConcesionarioDFSKProfile()
        {
            CreateMap<Solicitude, SolicitudDTO>()
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.IdEstadoNavigation.Nombre))
            .ForMember(dest => dest.Repuesto, opt => opt.MapFrom(src => src.IdRepuestoNavigation.Nombre))
            .ForMember(dest => dest.Vendedor, opt => opt.MapFrom(src => src.IdVendedorNavigation.Nombre))
            .ForMember(dest => dest.Vehiculo, opt => opt.MapFrom(src => src.IdRepuestoNavigation.IdVehiculoNavigation.Marca + " " + src.IdRepuestoNavigation.IdVehiculoNavigation.Modelo))
            .ReverseMap();
            
        }
    }
}
