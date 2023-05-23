namespace GamesWebAppDB.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Game Game { get; set; }
        public int NoOfItems { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
