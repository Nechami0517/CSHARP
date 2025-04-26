

namespace BO;
public class Sale

{
    public int SaleId { get; init; }
    public int? ProductId  { get; set; }
    public int? Count { get; set; }
    public double? PriceInSale { get; set; }
    public bool? IsClub { get; set; }
    public DateTime? DateBeginSail { get; set; }
    public DateTime? DateEndSail { get; set; }
    public override string ToString() => this.ToStringProperty();

    public Sale(int SaleId, int? ProductId, int? Count, double PriceInSale,bool? IsClub, DateTime? DateBeginSail, DateTime? DateEndSale)
    {
        this.SaleId = SaleId;
        this.ProductId = ProductId;
        this.Count = Count;
        this.PriceInSale = PriceInSale; 
        this.IsClub = IsClub;
        this.DateBeginSail = DateBeginSail;
        this.DateEndSail = DateEndSail;
    }
}
