namespace AllFitnessAPI.Models
{
    public class Seguidores
    {
        public int FollowerId { get; set; }
        public int FolloweeId { get; set; }
        public Usuario Follower { get; set; }
        public Usuario Followee { get; set; }
    }
}
