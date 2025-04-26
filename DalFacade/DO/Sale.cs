
namespace DO
{
    public record Sale
    (
        int SaleId,
        int? ProductId,
        int Count,
        double Price,
        bool? IsClub,
        DateTime? DateBeginSail,
        DateTime? DateEndSail
    )
    {
       

        // בנאי עם nullable
        public Sale(int saleId, int? productId, int? count, double? priceInSale, bool? isClub, DateTime? dateBeginSail, DateTime? dateEndSail)
            : this(saleId, productId, count ?? 0, priceInSale ?? 0.0, isClub, dateBeginSail, dateEndSail)
        {
        }
        public Sale() : this(0,0,0,0,false,null,null)
        {
            
        }
    }
}