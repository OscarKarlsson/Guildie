namespace Guild.DTO.Models.UserModels
{
    public class UserBusiness
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public int GuildHouseId { get; set; }
        public virtual GuildHouseModel GuildHouse { get; set; }
    }
}