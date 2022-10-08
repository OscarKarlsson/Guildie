using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guild.DTO.Models
{
    public enum WeaponTypes
    {
        Sword,
        Dagger,
        Mace,
        Staff
    }

    public enum RarityEnum
    {
        Common,
        Uncommon,
        Rare,
        Legendary,
        Mythic
    }
    public class WeaponModel
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required] 
        public string ImgPath { get; set; }
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
        public decimal modHealth { get; set; }
        public decimal modLifeSteal { get; set; }
    }
}
