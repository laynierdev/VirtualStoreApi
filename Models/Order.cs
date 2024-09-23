namespace VirtualStoreApi.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public StatusEnum Status { get; set; }
    public decimal Total { get; set; }
    public int? UserId { get; set; }

}

public enum StatusEnum
{
    Pending,
    Cancelled,
    Completed
}