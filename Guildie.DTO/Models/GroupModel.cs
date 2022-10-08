using System.Collections.Generic;

namespace Guild.DTO.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<HeroModel> Heroes { get; set; }
        
    }
}