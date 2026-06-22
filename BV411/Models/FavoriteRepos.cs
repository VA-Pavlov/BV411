public static class FavoriteRepos
{
    private static Favorite favorite = new Favorite();

    public static Favorite GetFavorite()
    {
        return favorite;
    }
}