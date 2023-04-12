using System;
using System.ComponentModel.DataAnnotations;

namespace Shelter.Shared
{
    public class ShelterItem
    {
        public int Id { get; set; } = -1;

        public string navn { get; set; } = "";

        public string cvr_navn { get; set; } = "";

        public string facil_ty { get; set; } = "";

        public Boolean booked { get; set; } = false;
    }
}