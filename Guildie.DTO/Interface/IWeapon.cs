using Guild.DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guild.DTO.Interface
{
    public interface IWeapon
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Rarity { get; set; }
        [Required]
        public int minDamage { get; set; }
        [Required]
        public int maxDamage { get; set; }
        public decimal modStrength { get; set; }
        public decimal modAgility { get; set; }
        public decimal modIntelligence { get; set; }
        public decimal modHitChance { get; set; }
    }
}
