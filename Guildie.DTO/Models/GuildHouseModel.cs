using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guild.DTO.Models
{
    public class GuildHouseModel
    {
        public int Id { get; set; }
        [Required]
        public string HouseName { get; set; }
        [Required]
        public decimal Money { get; set; }
        public ICollection<HeroModel> HeroRooster { get; set; }
        public ICollection<CharmModel> Charms { get; set; }
        
    }
}
