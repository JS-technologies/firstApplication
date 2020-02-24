using System;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public partial class ActiveProducts1
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string LangCode { get; set; }
        public string ProductId { get; set; }
        public string DocumentId { get; set; }
        public int CollectionId { get; set; }
        public int NavigationId { get; set; }
        public DateTime? MinDateCreated { get; set; }
        public DateTime? MaxDateCreated { get; set; }
        public decimal MinSalePriceBefore { get; set; }
        public decimal MinSalePriceAfter { get; set; }
        public decimal MaxSalePriceBefore { get; set; }
        public decimal MaxSalePriceAfter { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal MaxDiscountPercentage { get; set; }
        public int NumberOfSalePriceBefore { get; set; }
        public int NumberOfSalePriceAfter { get; set; }
        public int NumberOfDiscounts { get; set; }
        public bool IsLot { get; set; }
        public string CurrencySymbol { get; set; }
        public string Family { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int ArticleCount { get; set; }
        public string PresCode { get; set; }
        public string BasketSize { get; set; }
        public string Brand { get; set; }
        public string DefaultImage { get; set; }
        public string DefaultHighDefinitionImage { get; set; }
        public string DefaultImageOrientation { get; set; }
        public string DefaultThreeSixtyVideo { get; set; }
        public string DefaultCatWalkVideo { get; set; }
        public decimal AverageRating { get; set; }
        public string SubFamily { get; set; }
    }
}
