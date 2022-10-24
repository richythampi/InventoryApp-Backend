namespace InventoryAppAPI
{
    public class UserInfo
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public List<ProductInfo> Products { get; set; }

    }
}
