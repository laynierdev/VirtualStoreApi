using System.Runtime.InteropServices.JavaScript;

namespace VirtualStoreApi.Models;

public class OrderDetail
{
    public int Id { get; set; }
    public int? OrderId { get; set; }
    public int? ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
