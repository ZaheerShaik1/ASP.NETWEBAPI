using WebApplicationDemo.Controller;

namespace WebApplicationDemo.Model.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>
        {
            new Shirt{ShirtId=1,Brand="Puma",Color="Blue",Gender="men",Price=2999,Size=8},
            new Shirt{ShirtId=2,Brand="Nike",Color="Red",Gender="women",Price=4999,Size=9},
            new Shirt{ShirtId=3,Brand="Asian",Color="Black",Gender="men",Price=699,Size=9},
            new Shirt{ShirtId=4,Brand="Reebok",Color="Pink",Gender="women",Price=1283,Size=10},
            new Shirt{ShirtId=5,Brand="Skechers",Color="Green",Gender="men",Price=6999,Size=12},
            new Shirt{ShirtId=6,Brand="Bata",Color="Grey",Gender="women",Price=599,Size=8}

        };

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x=> x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
