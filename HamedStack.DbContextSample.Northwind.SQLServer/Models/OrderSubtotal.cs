namespace HamedStack.DbContextSample.Northwind.SQLServer.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
