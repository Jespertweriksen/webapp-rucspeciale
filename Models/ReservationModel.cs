using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp_rucspeciale.Models
{
    public class ReservationViewModel
    {

        public string Id { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int? AmountOfGuests { get; set; }
        public List<string> AvailablePlacements { get; set; } = new List<string>();
        public string ChosenPlacement { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
}
