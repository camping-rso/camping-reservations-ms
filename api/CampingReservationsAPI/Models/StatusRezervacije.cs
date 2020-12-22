using System;
using System.Collections.Generic;

namespace CampingReservationsAPI.Models
{
    public partial class StatusRezervacije
    {
        public StatusRezervacije()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int StatusRezervacijeId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
