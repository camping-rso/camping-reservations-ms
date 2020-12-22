using CampingReservationsAPI.Models;
using CampingReservationsAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampingReservationsAPI.Services
{
    public class RezervacijeRepository : IRezervacijeRepository
    {
        private readonly avtokampiContext _db;

        public RezervacijeRepository(avtokampiContext db)
        {
            _db = db;
        }

        public async Task<Rezervacije> GetRezervacijaByID(int rez_id)
        {
            return await _db.Rezervacije.Where(o => o.RezervacijaId == rez_id).FirstOrDefaultAsync();
        }

        public async Task<bool> CreateRezervacija(Rezervacije rez)
        {
            await _db.Rezervacije.AddAsync(rez);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Rezervacije> UpdateRezervacija(Rezervacije rez, int rez_id)
        {
            _db.Entry(rez).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return await _db.Rezervacije.FindAsync(rez_id);
        }

        public async Task<bool> RemoveRezervacija(int rez_id)
        {
            _db.Rezervacije.Remove(await _db.Rezervacije.FindAsync(rez_id));
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<List<VrstaKampiranja>> GetVrstaKmapiranja()
        {
            return await _db.VrstaKampiranja.ToListAsync();
        }

        public async Task<List<StatusRezervacije>> GetStatusRezervacije()
        {
            return await _db.StatusRezervacije.ToListAsync();
        }
    }
}
