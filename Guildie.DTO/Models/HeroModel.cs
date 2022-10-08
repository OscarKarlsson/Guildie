using Guild.DTO.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guild.DTO.Models
{
    public class HeroModel
    {
        public int Id { get; set; }
        public int GuildHouseId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Class { get; set; }
        [Required] 
        public string ImgPath { get; set; }
        [Required] 
        public char Gender { get; set; }
        public int ClassId { get; set; }
        public virtual WeaponModel WeaponRight { get; set; }
        public virtual WeaponModel WeaponLeft { get; set; }
        public virtual GuildHouseModel GuildHouse { get; set; }
        public virtual ClassModel ClassModel { get; set; }
        public int WeaponIdRight { get; set; }
        public int WeaponIdLeft { get; set; }
        public double HP { get; set; }
        public double CurrentHP { get; set; }
        public double Health { get; set; }
        public double Strength { get; set; }
        public double Agility { get; set; }
        public double Intelligence { get; set; }
        public double WeaponSkill { get; set; }
        public double MagicSkill { get; set; }
        public double ShieldSkill { get; set; }
        public double Lifesteal { get; set; }
        public double AtkMod { get; set; }
        public double MagicMod { get; set; }
        public int UnusedAttributePoints { get; set; }
        public virtual ICollection<GroupModel> Groups { get; set; }
    }
}
