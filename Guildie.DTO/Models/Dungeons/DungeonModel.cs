using System.Collections.Generic;

namespace Guild.DTO.Models.Dungeons
{
    public class DungeonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<RoomModel> RoomList { get; set; }
    }
}