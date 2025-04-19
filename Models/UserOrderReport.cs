namespace WebapiProject.Models
{
    public class UserOrderReport
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int OrderId { get; set; }
        public int TotalOrderedQuantity { get; set; }
    }
}
