using ProyectoWeb24AM_NET._7.Entities;

namespace ProyectoWeb24AM_NET._7.Services.IServices
{
    public interface IArticuloServices
    {
        public Task<List<Articulo>> GetArticulos();
        public Task<Articulo> GetByIdArticulo(int id);
        public Task<Articulo> CrearArticulo(Articulo i);

    }
}

