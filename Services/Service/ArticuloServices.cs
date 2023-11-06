using Microsoft.EntityFrameworkCore;
using ProyectoWeb24AM_NET._7.Context;
using ProyectoWeb24AM_NET._7.Entities;

namespace ProyectoWeb24AM_NET._7.Services.IServices.Service
{
    public class ArticuloServices : IArticuloServices
    {
        private readonly ApplicationDbContext _context;
        public ArticuloServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Articulo>> GetArticulos()
        {
            try
            {
                List<Articulo> articulos = await _context.Articulos.ToListAsync();
                return articulos;

            }
            catch (Exception ex)
            {

                throw new Exception("Surgió un error" + ex.Message);
            }

        }

        public async Task <Articulo> GetByIdArticulo(int id)
        {
            try
            {
                //Articulo response = _context.Articulos.FirstOrDefault()
                Articulo response = await _context.Articulos.FirstOrDefaultAsync(x => x.PkArticulo == id);
                return response;

            }
            catch (Exception ex)
            {

                throw new Exception("Surgión un error"+ex.Message);
            }
        }

        public async Task<Articulo> CrearArticulo(Articulo i)
        {
            try
            {
                Articulo request = new Articulo()
                {
                    Nombre = i.Nombre,
                    Descripcion = i.Descripcion,
                    Precio = i.Precio,

                };

                var result = _context.Articulos.Add(request);
                await _context.SaveChangesAsync();

                return request;
            }
            catch (Exception ex)
            {

                throw new Exception("Surgión un error" + ex.Message);
            }
        }
    }
}