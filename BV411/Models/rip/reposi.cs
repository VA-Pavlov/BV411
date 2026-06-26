using BV411.Models.main;

namespace BV411.Models.rip
{
    public static class reposi
    {
        static public List<product> products = new List<product>()
        {
            new product() { Id = 0, Name = "d", Description = "f" , favor = true, price = 100},
            new product() { Id = 1, Name = "f", Description = "d" , favor = true, price = 100},
            new product() { Id = 2, Name = "ff", Description = "dd" , favor = false, price = 100},
            new product() { Id = 3, Name = "каната", Description = "ddd" , favor = true, price = 100, limq = "https://avatars.mds.yandex.net/i?id=32d0917f2ea866e29e21119f0abf13b93d1b5463-12421862-images-thumbs&n=13"},
            new product() { Id = 4, Name = "изуми", Description = "dddd" , favor = true, price = 100, limq = "https://avatars.mds.yandex.net/i?id=ab2f0839aa9ce9d596061d92dcf462ec_l-4248389-images-thumbs&n=13&n=13&w=230&h=230"},
            new product() { Id = 5, Name = "fffff", Description = "ddddd" , favor = false, price = 100},
        };
    }
}
