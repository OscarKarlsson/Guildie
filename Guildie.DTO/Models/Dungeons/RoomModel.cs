using System.Collections.Generic;
using Guild.DTO.Models.Monsters;

namespace Guild.DTO.Models.Dungeons
{
    public class RoomModel
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int DungeonId { get; set; }
        public virtual DungeonModel Dungeon { get; set; }
        public virtual List<MonsterModels> MonsterList { get; set; }
    }
}