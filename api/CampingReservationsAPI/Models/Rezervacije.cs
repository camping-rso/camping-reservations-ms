using System;
using System.Collections.Generic;

namespace CampingReservationsAPI.Models
{
    public partial class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public DateTime? TrajanjeOd { get; set; }
        public DateTime? TrajanjeDo { get; set; }
        public int Uporabnik { get; set; }
        public int Avtokamp { get; set; }
        public int KampirnoMesto { get; set; }
        public int VrstaKampiranja { get; set; }
        public int StatusRezervacije { get; set; }

        public virtual StatusRezervacije StatusRezervacijeNavigation { get; set; }
        public virtual VrstaKampiranja VrstaKampiranjaNavigation { get; set; }
    }
}
