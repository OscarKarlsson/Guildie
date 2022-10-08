using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guild.DTO.Interface
{
    public interface IMonster
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int CurrentHP { get; set; }
        public decimal Health { get; set; }
        public decimal Strength { get; set; }
        public decimal Agility { get; set; }
        public decimal Intelligence { get; set; }
        public decimal WeaponSkill { get; set; }
        public decimal MagicSkill { get; set; }
        public decimal ShieldSkill { get; set; }
        public int LootTableId { get; set; }
        public double LootChance { get; set; }
    }
}
