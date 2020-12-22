using CampingReservationsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CampingReservationsAPI.Services.Interfaces
{
    public interface IRezervacijeRepository
    {
        Task<Rezervacije> GetRezervacijaByID(int rez_id);

        Task<bool> CreateRezervacija(Rezervacije rez);

        Task<Rezervacije> UpdateRezervacija(Rezervacije rez, int rez_id);

        Task<bool> RemoveRezervacija(int rez_id);

        Task<List<VrstaKampiranja>> GetVrstaKmapiranja();

        Task<List<StatusRezervacije>> GetStatusRezervacije();
    }
}
