public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public int CustomerId { get; set; }
    /// <summary>
    /// 1 - Draft,
    /// 2 - Submitted,
    /// 3 - Completed,
    /// 4 - Archived
    /// </summary>
    public int Status { get; set; }
}