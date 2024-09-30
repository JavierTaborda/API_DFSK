using API_DFSK.DTOs;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.DTOs.DFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using API_DFSK.Models.DFSK;
using AutoMapper;
namespace API_DFSK.AutoMapper
{
    public class ConcesionarioDFSKProfile : Profile
    {
        public ConcesionarioDFSKProfile()
        {
            CreateMap<Solicitude, SolicitudDTO>()
            .ForMember(dest => dest.Responsable, opt => opt.MapFrom(src => src.IdResponsableSolicitudNavigation.Nombre))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.IdEstadoNavigation.Nombre))
            .ForMember(dest => dest.Repuesto, opt => opt.MapFrom(src => src.IdRepuestoNavigation.Nombre))
            .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.IdResumenSolicitudNavigation.IdUsuarioNavigation.Nombre))
            .ForMember(dest => dest.Vehiculo, opt => opt.MapFrom(src => src.IdRepuestoNavigation.IdVehiculoNavigation.Marca + " " + src.IdRepuestoNavigation.IdVehiculoNavigation.Modelo))
            ;

            //Mapeos de DTO para Insertar Solicitudes y Solicitud + Repuesto.
            CreateMap<SolicitudDTO, Solicitude>();
            CreateMap<ResumenSolicitud, ResumenSolicitudDTO>()
                            .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.IdUsuarioNavigation.Nombre));
            CreateMap<ResumenSolicitudDTO, ResumenSolicitud>();



            CreateMap<SolicitudRepuestoDTO, Solicitude>()
                .ForMember(dest => dest.IdRepuesto, opt => opt.MapFrom(src => src.IdRepuesto))
                .ForPath(dest => dest.IdRepuestoNavigation.IdVehiculo, opt => opt.MapFrom(src => src.IdVehiculo))
                .ForPath(dest => dest.IdRepuestoNavigation.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForPath(dest => dest.IdRepuestoNavigation.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ForPath(dest => dest.IdRepuestoNavigation.Precio, opt => opt.MapFrom(src => src.Precio))
                .ForPath(dest => dest.IdRepuestoNavigation.Estatus, opt => opt.MapFrom(src => src.Estatus))
                .ForPath(dest => dest.IdRepuestoNavigation.Marca, opt => opt.MapFrom(src => src.Marca))
                .ForPath(dest => dest.IdRepuestoNavigation.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ReverseMap();


            CreateMap<Estado, EstadoDTO>().ReverseMap();
            CreateMap<Repuesto, RepuestoDTO>().ReverseMap();

            CreateMap<Repuesto, RepuestoVehiculoDTO>()
                .ForMember(dest => dest.ModeloVehiculo, opt => opt.MapFrom(src => src.IdVehiculoNavigation.Modelo))
                .ForMember(dest => dest.MarcaVehiculo, opt => opt.MapFrom(src => src.IdVehiculoNavigation.Marca))
                .ReverseMap();

            CreateMap<Vehiculo, VehiculoDTO>().ReverseMap();
            CreateMap<Vendedore, VendedorDTO>().ReverseMap();
            CreateMap<Rol, RolDTO>().ReverseMap();

            CreateMap<Resumentxt, ResumentxtDTO>().ReverseMap();
            CreateMap<LineatxtDTO, Lineatxt>().ReverseMap();


            //Auth
            CreateMap<UserDTO, Usuario>()
                .ForMember(dest => dest.Username, src => src.MapFrom(sr => sr.Username))
                .ForMember(dest => dest.Nombre, src => src.MapFrom(sr => sr.Nombre))
                .ForMember(dest => dest.Email, src => src.MapFrom(sr => sr.Email))
                .ForMember(dest => dest.Telefono, src => src.MapFrom(sr => sr.Telefono))
                .ForMember(dest => dest.Clave, src => src.MapFrom(sr => sr.Clave))
                .ForMember(dest => dest.IdRol, src => src.MapFrom(sr => sr.IdRol))
                .ForMember(dest => dest.Estatus, src => src.MapFrom(sr => sr.Estatus));
                //.ForMember(dest => dest.IdRolNavigation.RolName, src => src.MapFrom(sr => sr.Rol));



        }
    }
}
