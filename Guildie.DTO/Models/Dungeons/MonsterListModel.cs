using Guild.DTO.Models.Dungeons;
using Guild.DTO.Models.Monsters;

namespace Guild.DTO.Models
{
    public class MonsterListModel
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int MonsterId { get; set; }
        public virtual MonsterModels Monster { get; set; }
        public virtual RoomModel Room { get; set; }
    }
}