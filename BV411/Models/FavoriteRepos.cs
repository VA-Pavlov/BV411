namespace BV411.Models
{
    public static class FavoriteRepos
    {
        public static Favorite GetFavorite(int userId)
        {
            var user =
                UserRepos.Get(userId);

            return user.Favorite;
        }
    }
}