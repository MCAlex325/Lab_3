namespace Lab_3
{
    public class Dish
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public RestaurantType Type { get; set; }

        public Dish(string name, double price, RestaurantType type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
        public static List<Dish> Dishes = new List<Dish>
        {
            new Dish("Гамбургери", 30, RestaurantType.FastFood),
            new Dish("Хот-доги", 25, RestaurantType.FastFood),
            new Dish("Фрі", 20, RestaurantType.FastFood),
            new Dish("Чікен-нагетси", 35, RestaurantType.FastFood),
            new Dish("Піцца", 40, RestaurantType.FastFood),
            new Dish("Фастфудові салати", 25, RestaurantType.FastFood),

            new Dish("Стейки", 100, RestaurantType.CasualDining),
            new Dish("Рибні страви", 90, RestaurantType.CasualDining),
            new Dish("Паста", 80, RestaurantType.CasualDining),
            new Dish("Бургери", 60, RestaurantType.CasualDining),
            new Dish("Страви з гриля", 85, RestaurantType.CasualDining),
            new Dish("Салати та закуски", 50, RestaurantType.CasualDining),

            new Dish("Кава", 40, RestaurantType.CoffeeShop),
            new Dish("Чай", 30, RestaurantType.CoffeeShop),
            new Dish("Печиво та кекси", 25, RestaurantType.CoffeeShop),
            new Dish("Сендвічі та паніні", 35, RestaurantType.CoffeeShop),
            new Dish("Круасани", 30, RestaurantType.CoffeeShop),
            new Dish("Мафіни та пиріжки", 25, RestaurantType.CoffeeShop),

            new Dish("Морозиво", 20, RestaurantType.IceCreamParlor),
            new Dish("Льодяники", 15, RestaurantType.IceCreamParlor),
            new Dish("Фруктові коктейлі з морозивом", 25, RestaurantType.IceCreamParlor),
            new Dish("Морозивні келихи та різноманітні топінги", 30, RestaurantType.IceCreamParlor),

            new Dish("Піцца", 45, RestaurantType.PizzaPlace),
            new Dish("Салати", 35, RestaurantType.PizzaPlace),
            new Dish("Коктейлі та напої", 40, RestaurantType.PizzaPlace),
            new Dish("Снеки", 30, RestaurantType.PizzaPlace)
        };
    }
}