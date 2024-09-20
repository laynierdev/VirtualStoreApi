namespace VirtualStoreApi.Models;

public class Order
{
    public int Id { get; set; }
    public int? UserId { get; set; }
    public User User { get; set; }
    public DateTime Date { get; set; }
    public StatusEnum Status { get; set; }
    public decimal Total { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

    public Order()
    {
        OrderDetails = new List<OrderDetail>();
    }
}

public enum StatusEnum
{
    Pending,
    Cancelled,
    Completed
}