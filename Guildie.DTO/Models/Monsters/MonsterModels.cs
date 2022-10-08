using Guild.DTO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guild.DTO.Models.Monsters
{
    public class MonsterModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double HP { get; set; }
        public double CurrentHP { get; set; }
        public double Health { get; set; }
        public double Strength { get; set; }
        public double Agility { get; set; }
        public double Intelligence { get; set; }
        public double WeaponSkill { get; set; }
        public double MagicSkill { get; set; }
        public double ShieldSkill { get; set; }
        public int LootTableId { get; set; }
        public double LootChance { get; set; }
        public double Lifesteal { get; set; }
        public double AtkMod { get; set; }
        public double MagicMod { get; set; }
    }
}
