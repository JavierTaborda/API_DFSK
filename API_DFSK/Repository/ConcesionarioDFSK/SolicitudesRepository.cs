using API_DFSK.Context;
using API_DFSK.DTOs.ConcesionarioDFSK;
using API_DFSK.Interfaces.ConcesionarioDFSK;
using API_DFSK.Models.ConcesionarioDFSK;
using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API_DFSK.Repository.ConcesionarioDFSK
{
    public class SolicitudesRepository(ConcesionarioDfskContext context, IMapper mapper) : ISolicitudesRepository
    {
        private readonly ConcesionarioDfskContext _context=context;
        private readonly IMapper _mapper=mapper;

        //GET
        #region GETS
      
        

        public async Task<SolicitudDTO?> GetSolicitudById(int Id)
        {
            var solicitud = await _context.Solicitudes
                .Include(ven => ven.IdResumenSolicitudNavigation.IdUsuarioNavigation)
                .Include(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
                .Include(rep => rep.IdEstadoNavigation)
                .FirstOrDefaultAsync(id => id.IdSolicitud == Id);

            if (solicitud == null)
                return null;

            return _mapper.Map<SolicitudDTO>(solicitud);
        }
        public async Task<List<SolicitudDTO>> GetSolicitudes(DateTime f1, DateTime f2, int idestado, int iduser)
        {

            IQueryable<Solicitude> query = _context.Solicitudes
                .Include(ven => ven.IdResumenSolicitudNavigation.IdUsuarioNavigation)
                .Include(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
                .Include(rep => rep.IdEstadoNavigation)
                .AsNoTracking();

            query = query.Where(f => f.FechaSolicitud!.Value.Date >= f1.Date && f.FechaSolicitud.Value.Date <= f2.Date);

            //switch (tipofecha)
            //{
            //    case 0:
            //        query = query.Where(f => f.FechaSolicitud.Value.Date >= f1.Date && f.FechaSolicitud.Value.Date <= f2.Date);
            //        break;
            //    case 1:
            //        query = query.Where(f => f.FechaCompra.Value.Date >= f1.Date && f.FechaCompra.Value.Date <= f2.Date);
            //        break;
            //    case 2:
            //        query = query.Where(f => f.FechaLlegada.Value.Date >= f1.Date && f.FechaLlegada.Value.Date <= f2.Date);
            //        break;
            //    default:
            //        throw new ArgumentException("tipofecha no válido");
            //}

            query = query.Where(f => f.IdEstado == idestado
                                     && f.IdResumenSolicitudNavigation.IdUsuario == iduser);

            var solicitudes = await query.ToListAsync();

            return _mapper.Map<List<SolicitudDTO>>(solicitudes) ?? [];
        }

        public async Task<List<ResumenSolicitudDTO>> GetResumenSolicitudes(DateTime f1, DateTime f2, string estado, int iduser)
        {
            IQueryable<ResumenSolicitud> query = _context.ResumenSolicituds
                .AsNoTracking()
                .Include(ven => ven.IdUsuarioNavigation)
                .Include(f => f.Solicitudes).ThenInclude(rep => rep.IdRepuestoNavigation).ThenInclude(rep => rep.IdVehiculoNavigation)
                .Include(rep => rep.Solicitudes).ThenInclude(e => e.IdEstadoNavigation)
                .Include(r => r.Solicitudes).ThenInclude(re => re.IdResponsableSolicitudNavigation);

            query = query.Where(f => f.FechaCreacion!.Value.Date >= f1.Date && f.FechaCreacion!.Value.Date <= f2.Date);

            if (estado != "Todos")
            {
                if (bool.TryParse(estado, out bool esta))
                {
                    query = query.Where(f => f.Estatus == esta);
                }
            }
            if (iduser > 0)
            {
                query = query.Where(v => v.IdUsuario == iduser);
            }
            var resumen = await query.ToListAsync();

            return _mapper.Map<List<ResumenSolicitudDTO>>(resumen);
        }

       
 

        public async Task<Dictionary<string, int>> GetIdsSolicitudIncial()
        {
            var idestadoinicial = await _context.Estados
                    .Where(c => c.Descripcion!.Contains("Registro Inicial"))
                    .Select(id => id.IdEstado)
                    .FirstOrDefaultAsync();

            var idresponsableinicial = await _context.ResponsableSolicituds
             .Where(c => c.Nombre!.Contains("Sin Definir"))
             .Select(id => id.IdResponsableSolicitud)
             .FirstOrDefaultAsync();

            Dictionary<string, int> ids = [];
            if (idestadoinicial != 0)
            {
                ids.Add("Estado", idestadoinicial);
            }


            if (idresponsableinicial != 0)
            {
                ids.Add("Responsable", idresponsableinicial);
            }
            return ids;
        }

        #endregion

        // POST

        #region POST

        public async Task<bool> InsertResumenSolicitud(ResumenSolicitudDTO Solicitud)
        {
            var insert = _mapper.Map<ResumenSolicitud>(Solicitud);
            await _context.ResumenSolicituds.AddAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertSolicitud(List<SolicitudDTO> solicitudes)
        {
            var insert = _mapper.Map<List<Solicitude>>(solicitudes);
            await _context.Solicitudes.AddRangeAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertSolicitudRepuesto(SolicitudRepuestoDTO solicitud)
        {
            var insert = _mapper.Map<Solicitude>(solicitud);
            await _context.Solicitudes.AddAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
       

        #endregion

        //PUTS
        #region PUTS
        public async Task<bool> UpdateSolicitud(List<SolicitudDTO> solicitudes)
        {
            var entity = _mapper.Map<List<Solicitude>>(solicitudes);
            _context.UpdateRange(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<SolicitudRepuestoDTO> UpdateSolicitudRepuesto(SolicitudRepuestoDTO solicitud)
        {
            var soli = await _context.Solicitudes.AsNoTracking().FirstOrDefaultAsync(s => s.IdSolicitud == solicitud.IdSolicitud);

            if (soli == null)
            {
                return null!;
            }

            var entity = _mapper.Map<Solicitude>(solicitud);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<SolicitudRepuestoDTO>(entity);
            return result;
        }

   
        #endregion
    }
}
