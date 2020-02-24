using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace firstApplication.Models
{
    public partial class TheseusRDContext : DbContext
    {
        public TheseusRDContext()
        {
        }

        public TheseusRDContext(DbContextOptions<TheseusRDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveArticles> ActiveArticles { get; set; }
        public virtual DbSet<ActiveArticles001> ActiveArticles001 { get; set; }
        public virtual DbSet<ActiveArticles0011> ActiveArticles0011 { get; set; }
        public virtual DbSet<ActiveArticles002> ActiveArticles002 { get; set; }
        public virtual DbSet<ActiveArticles0021> ActiveArticles0021 { get; set; }
        public virtual DbSet<ActiveArticles003> ActiveArticles003 { get; set; }
        public virtual DbSet<ActiveArticles0031> ActiveArticles0031 { get; set; }
        public virtual DbSet<ActiveArticles005> ActiveArticles005 { get; set; }
        public virtual DbSet<ActiveArticles0051> ActiveArticles0051 { get; set; }
        public virtual DbSet<ActiveArticles006> ActiveArticles006 { get; set; }
        public virtual DbSet<ActiveArticles0061> ActiveArticles0061 { get; set; }
        public virtual DbSet<ActiveArticles010> ActiveArticles010 { get; set; }
        public virtual DbSet<ActiveArticles0101> ActiveArticles0101 { get; set; }
        public virtual DbSet<ActiveArticles011> ActiveArticles011 { get; set; }
        public virtual DbSet<ActiveArticles0111> ActiveArticles0111 { get; set; }
        public virtual DbSet<ActiveArticles012> ActiveArticles012 { get; set; }
        public virtual DbSet<ActiveArticles0121> ActiveArticles0121 { get; set; }
        public virtual DbSet<ActiveArticles013> ActiveArticles013 { get; set; }
        public virtual DbSet<ActiveArticles0131> ActiveArticles0131 { get; set; }
        public virtual DbSet<ActiveArticles014> ActiveArticles014 { get; set; }
        public virtual DbSet<ActiveArticles0141> ActiveArticles0141 { get; set; }
        public virtual DbSet<ActiveArticles015> ActiveArticles015 { get; set; }
        public virtual DbSet<ActiveArticles0151> ActiveArticles0151 { get; set; }
        public virtual DbSet<ActiveArticles1> ActiveArticles1 { get; set; }
        public virtual DbSet<ActiveBrands> ActiveBrands { get; set; }
        public virtual DbSet<ActiveBrands1> ActiveBrands1 { get; set; }
        public virtual DbSet<ActiveCollections> ActiveCollections { get; set; }
        public virtual DbSet<ActiveCollections1> ActiveCollections1 { get; set; }
        public virtual DbSet<ActiveNavigationStatistics> ActiveNavigationStatistics { get; set; }
        public virtual DbSet<ActiveNavigationStatistics1> ActiveNavigationStatistics1 { get; set; }
        public virtual DbSet<ActiveProductAttributes> ActiveProductAttributes { get; set; }
        public virtual DbSet<ActiveProductAttributes1> ActiveProductAttributes1 { get; set; }
        public virtual DbSet<ActiveProducts> ActiveProducts { get; set; }
        public virtual DbSet<ActiveProducts1> ActiveProducts1 { get; set; }
        public virtual DbSet<BlogAuthors> BlogAuthors { get; set; }
        public virtual DbSet<BlogPostLabels> BlogPostLabels { get; set; }
        public virtual DbSet<BlogPosts> BlogPosts { get; set; }
        public virtual DbSet<BlogPostsV2> BlogPostsV2 { get; set; }
        public virtual DbSet<BlogTags> BlogTags { get; set; }
        public virtual DbSet<CacheManager> CacheManager { get; set; }
        public virtual DbSet<Collections> Collections { get; set; }
        public virtual DbSet<Collections1> Collections1 { get; set; }
        public virtual DbSet<CollectionsProperties> CollectionsProperties { get; set; }
        public virtual DbSet<CollectionsProperties1> CollectionsProperties1 { get; set; }
        public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
        public virtual DbSet<GlobalParameters> GlobalParameters { get; set; }
        public virtual DbSet<GlobalParametersBackEndMapping> GlobalParametersBackEndMapping { get; set; }
        public virtual DbSet<GlobalParametersGroupTypes> GlobalParametersGroupTypes { get; set; }
        public virtual DbSet<GlobalParametersMessages> GlobalParametersMessages { get; set; }
        public virtual DbSet<Import> Import { get; set; }
        public virtual DbSet<LocalContent> LocalContent { get; set; }
        public virtual DbSet<LocalContentPages> LocalContentPages { get; set; }
        public virtual DbSet<PaperCatalogues> PaperCatalogues { get; set; }
        public virtual DbSet<ProductMixer> ProductMixer { get; set; }
        public virtual DbSet<ProductRules> ProductRules { get; set; }
        public virtual DbSet<ProductTags> ProductTags { get; set; }
        public virtual DbSet<ProductVendors> ProductVendors { get; set; }
        public virtual DbSet<RankingManager> RankingManager { get; set; }
        public virtual DbSet<RankingManagerExplode> RankingManagerExplode { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<SearchAssociationFilters> SearchAssociationFilters { get; set; }
        public virtual DbSet<SearchAssociations> SearchAssociations { get; set; }
        public virtual DbSet<SiteTags> SiteTags { get; set; }
        public virtual DbSet<SizeCharts> SizeCharts { get; set; }
        public virtual DbSet<StaticPages> StaticPages { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<VLocalContent> VLocalContent { get; set; }
        public virtual DbSet<ZzzLocalContent02102014> ZzzLocalContent02102014 { get; set; }
        public virtual DbSet<ZzzLocalcontent20140606> ZzzLocalcontent20140606 { get; set; }
        public virtual DbSet<ZzzStaticPages20140716> ZzzStaticPages20140716 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=laredouteosp,9004;Database=TheseusRD;User Id= anthony borg; Password=rem;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveArticles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActiveArticles", "rd1");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActiveArticles001>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_001");

                entity.ToTable("ActiveArticles_001", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_001");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_001_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_001_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_001_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_001_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorFamily, e.ColorImage, e.ColorName, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_001_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceBefore, e.DocumentId, e.SalePriceAfter, e.DiscountPercentage, e.ColorName, e.ColorFamily, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_001_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0011>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_001");

                entity.ToTable("ActiveArticles_001", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_001");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_001_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_001_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_001_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_001_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.Dimension1, e.PresCode, e.ColorFamily, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_001_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceAfter, e.DiscountPercentage, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.SalePriceBefore, e.DocumentId, e.FriendlySize, e.ColorName, e.ColorFamily, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_001_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles002>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_002");

                entity.ToTable("ActiveArticles_002", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_002");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_002_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_002_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_002_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_002_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.Dimension1, e.PresCode, e.ColorFamily, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_002_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceAfter, e.DiscountPercentage, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.DocumentId, e.SalePriceBefore, e.ColorName, e.ColorFamily, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_002_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0021>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_002");

                entity.ToTable("ActiveArticles_002", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_002");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_002_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_002_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_002_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceBefore, e.DiscountPercentage, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_002_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorFamily, e.ColorImage, e.ColorName, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_002_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.DocumentId, e.ColorName, e.ColorFamily, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_002_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles003>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_003");

                entity.ToTable("ActiveArticles_003", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_003");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_003_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_003_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_003_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_003_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.Dimension1, e.PresCode, e.ColorFamily, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_003_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceAfter, e.DiscountPercentage, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.DocumentId, e.SalePriceBefore, e.ColorName, e.ColorFamily, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_003_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0031>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_003");

                entity.ToTable("ActiveArticles_003", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_003");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_003_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_003_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_003_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_003_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorFamily, e.ColorImage, e.ColorName, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_003_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceBefore, e.DocumentId, e.SalePriceAfter, e.DiscountPercentage, e.ColorName, e.ColorFamily, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_003_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles005>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_005");

                entity.ToTable("ActiveArticles_005", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_005");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_005_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_005_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_005_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_005_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.ColorFamily, e.PresCode, e.Dimension1, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_005_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.FriendlySize, e.ColorName, e.ColorFamily, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_005_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0051>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_005");

                entity.ToTable("ActiveArticles_005", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_005");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_005_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_005_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.ColorImage, e.Dimension2, e.PresCode, e.Dimension1, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_005_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_005_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorName, e.ColorFamily, e.ColorImage, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_005_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.ColorName, e.ColorImage, e.ColorFamily, e.FriendlySize, e.DocumentId, e.DiscountPercentage, e.SalePriceAfter, e.SalePriceBefore, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_005_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles006>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_006");

                entity.ToTable("ActiveArticles_006", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_006");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_006_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_006_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_006_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_006_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorName, e.ColorFamily, e.ColorImage, e.PresCode, e.Dimension1, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_006_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceBefore, e.SalePriceAfter, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.DocumentId, e.ColorImage, e.DiscountPercentage, e.ColorName, e.ColorFamily, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_006_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0061>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_006");

                entity.ToTable("ActiveArticles_006", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_006");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_006_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_006_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension2, e.PresCode, e.Dimension1, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_006_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_006_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorFamily, e.ColorName, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_006_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SalePriceBefore, e.DiscountPercentage, e.SalePriceAfter, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.FriendlySize, e.ColorName, e.ColorFamily, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_006_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles010>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_010");

                entity.ToTable("ActiveArticles_010", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_010");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_010_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_010_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_010_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_010_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.Dimension1, e.PresCode, e.ColorName, e.ColorFamily, e.ColorImage, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_010_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.DocumentId, e.ProductId, e.ColorImage, e.ColorName, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ColorFamily, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_010_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0101>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_010");

                entity.ToTable("ActiveArticles_010", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_010");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_010_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_010_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_010_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_010_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.ColorFamily, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_010_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorFamily, e.FriendlySize, e.ColorImage, e.ColorName, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_010_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles011>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_011");

                entity.ToTable("ActiveArticles_011", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_011");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_011_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_011_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_011_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_011_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorFamily, e.ColorImage, e.ColorName, e.PresCode, e.Dimension1, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_011_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.SalePriceBefore, e.DocumentId, e.DiscountPercentage, e.SalePriceAfter, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.FriendlySize, e.ColorName, e.ColorFamily, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_011_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0111>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_011");

                entity.ToTable("ActiveArticles_011", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_011");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_011_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_011_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension2, e.PresCode, e.Dimension1, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_011_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_011_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorFamily, e.ColorName, e.ColorImage, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_011_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ColorName, e.ColorFamily, e.FriendlySize, e.SalePriceBefore, e.DiscountPercentage, e.SalePriceAfter, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.ProductId, e.DocumentId, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_011_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles012>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_012");

                entity.ToTable("ActiveArticles_012", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_012");

                entity.HasIndex(e => new { e.SiteId, e.PresCode })
                    .HasName("IX_rd1_ActiveArticles_012_SiteId_PresCode");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_012_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_012_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_012_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_012_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorFamily, e.ColorName, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_012_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SalePriceBefore, e.SalePriceAfter, e.ColorName, e.ColorFamily, e.DiscountPercentage, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_012_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0121>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_012");

                entity.ToTable("ActiveArticles_012", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_012");

                entity.HasIndex(e => new { e.SiteId, e.PresCode })
                    .HasName("IX_rd2_ActiveArticles_012_SiteId_PresCode");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_012_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_012_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_012_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_012_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.ColorFamily, e.PresCode, e.Dimension1, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_012_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.DiscountPercentage, e.SalePriceAfter, e.SalePriceBefore, e.ColorImage, e.ColorFamily, e.FriendlySize, e.ColorName, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_012_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles013>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_013");

                entity.ToTable("ActiveArticles_013", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_013");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_013_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_013_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_013_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_013_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorName, e.ColorFamily, e.ColorImage, e.PresCode, e.Dimension1, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_013_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.ColorName, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ColorFamily, e.FriendlySize, e.ColorImage, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_013_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0131>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_013");

                entity.ToTable("ActiveArticles_013", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_013");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_013_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_013_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_013_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_013_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorName, e.ColorFamily, e.ColorImage, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_013_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.DocumentId, e.ProductId, e.DiscountPercentage, e.ColorName, e.ColorFamily, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_013_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles014>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_014");

                entity.ToTable("ActiveArticles_014", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_014");

                entity.HasIndex(e => new { e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_014_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_014_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_014_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_014_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.PresCode, e.Dimension1, e.ColorFamily, e.ColorName, e.ColorImage, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_014_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.DocumentId, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorImage, e.ColorName, e.ColorFamily, e.FriendlySize, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_014_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0141>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_014");

                entity.ToTable("ActiveArticles_014", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_014");

                entity.HasIndex(e => new { e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_014_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_014_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension2, e.PresCode, e.Dimension1, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_014_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceAfter, e.DiscountPercentage, e.SalePriceBefore, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_014_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.ColorFamily, e.Dimension1, e.PresCode, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_014_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SalePriceBefore, e.DiscountPercentage, e.SalePriceAfter, e.AvailabilityCode, e.AvailabilityMessage, e.AvailabilityPeriod, e.MiniPrice, e.RedPage, e.GreenPage, e.SmartPrice, e.ColorFamily, e.FriendlySize, e.ColorName, e.ColorImage, e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_014_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles015>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd1_ActiveArticles_015");

                entity.ToTable("ActiveArticles_015", "rd1");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd1_ActiveArticles_015");

                entity.HasIndex(e => new { e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd1_ActiveArticles_015_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_015_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_015_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_015_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd1_ActiveArticles_015_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.ColorFamily, e.PresCode, e.Dimension1, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveArticles_015_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles0151>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SiteId })
                    .HasName("PK_rd2_ActiveArticles_015");

                entity.ToTable("ActiveArticles_015", "rd2");

                entity.HasIndex(e => e.LangCode)
                    .HasName("IX_rd2_ActiveArticles_015");

                entity.HasIndex(e => new { e.SiteId, e.PresCode, e.BasketSize })
                    .HasName("IX_rd2_ActiveArticles_015_SiteId_PresCode_BasketSize");

                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_015_SiteId_LangCode_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.DiscountPercentage, e.SalePriceBefore, e.SalePriceAfter, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_015_ProductId_PresCode_BasketSize_CurrencySymbol");

                entity.HasIndex(e => new { e.Dimension1, e.Dimension2, e.PresCode, e.ColorImage, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_015_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.SalePriceBefore, e.SalePriceAfter, e.DiscountPercentage, e.ProductId, e.PresCode, e.BasketSize, e.CurrencySymbol, e.SiteId })
                    .HasName("IX_rd2_ActiveArticles_015_ProductId_PresCode_BasketSize_CurrencySymbol_SiteId");

                entity.HasIndex(e => new { e.ColorImage, e.ColorName, e.ColorFamily, e.PresCode, e.Dimension1, e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveArticles_015_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ActiveArticles1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActiveArticles", "rd2");

                entity.Property(e => e.AlphaSizeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AssociatedService)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomaticDisplay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvailabilityCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilityMessage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvailabilityPeriod)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BruteMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BulkyItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ckgcode).HasColumnName("CKGCode");

                entity.Property(e => e.Ckgprice)
                    .HasColumnName("CKGPrice")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorFamily).HasMaxLength(100);

                entity.Property(e => e.ColorHighDefinitionImage).HasMaxLength(400);

                entity.Property(e => e.ColorImage).HasMaxLength(400);

                entity.Property(e => e.ColorName).HasMaxLength(100);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCharges).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.D3efee)
                    .HasColumnName("D3EFee")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DeliverableInPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Dimension1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DisplayingSimulatorFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressDeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family).HasMaxLength(250);

                entity.Property(e => e.FriendlySize).HasMaxLength(100);

                entity.Property(e => e.GreenPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InstallmentValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemOfferId)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MadeToMeasureItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiniPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiniSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoreductBrand)
                    .IsRequired()
                    .HasColumnName("Noreduct_brand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlaceExpressDelivery)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrixType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.RedPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SmartPrice)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SoldbyMetre)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCommItem)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StkRef)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StkRefSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Substitution)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UniqueProdId)
                    .IsRequired()
                    .HasMaxLength(115)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ActiveBrands>(entity =>
            {
                entity.ToTable("ActiveBrands", "rd1");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CollectionId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Gnvbrand)
                    .HasColumnName("GNVBrand")
                    .HasMaxLength(50);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastPublishedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActiveBrands1>(entity =>
            {
                entity.ToTable("ActiveBrands", "rd2");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CollectionId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Gnvbrand)
                    .HasColumnName("GNVBrand")
                    .HasMaxLength(50);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastPublishedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActiveCollections>(entity =>
            {
                entity.ToTable("ActiveCollections", "rd1");

                entity.HasIndex(e => new { e.BottomLevel, e.SiteId, e.ProductId, e.DocumentId })
                    .HasName("IX_rd1_ActiveCollections_SiteId_ProductId_DocumentId");

                entity.HasIndex(e => new { e.Level3, e.SiteId, e.ProductId, e.Level1 })
                    .HasName("IX_rd1_Activecollections_siteid_productid_level1");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.SiteId, e.BottomLevel })
                    .HasName("IX_rd1_ActiveCollections_SiteId_BottomLevel");

                entity.HasIndex(e => new { e.ProductId, e.NavigationId, e.BottomLevel, e.DocumentId, e.SiteId })
                    .HasName("IX_rd1_ActiveCollections_ProductId_DocumentId");

                entity.HasIndex(e => new { e.SiteId, e.ProductId, e.BottomLevel, e.DocumentId, e.NavigationId })
                    .HasName("IX_rd1_ActiveCollections_ProductId_DocumentId_SiteId");

                entity.HasIndex(e => new { e.NavigationId, e.ProductId, e.DocumentId, e.BottomLevel, e.Level5, e.SiteId })
                    .HasName("IX_rd1_ActiveCollections_Level5");

                entity.HasIndex(e => new { e.NavigationId, e.ProductId, e.DocumentId, e.Level2, e.BottomLevel, e.SiteId })
                    .HasName("IX_rd1_ActiveCollections_Level2");

                entity.HasIndex(e => new { e.NavigationId, e.ProductId, e.DocumentId, e.Level3, e.BottomLevel, e.SiteId })
                    .HasName("IX_rd1_ActiveCollections_Level3");

                entity.HasIndex(e => new { e.ProductId, e.NavigationId, e.BottomLevel, e.Level4, e.DocumentId, e.SiteId })
                    .HasName("IX_rd1_ActiveCollections_Level4");

                entity.HasIndex(e => new { e.ProductId, e.Id, e.Level3, e.DocumentId, e.Level1, e.Level2, e.Levels, e.SiteId })
                    .HasName("IX_rd1_ActiveCollections_SiteId");

                entity.HasIndex(e => new { e.Levels, e.Level1, e.Level2, e.Level3, e.Level4, e.Level5, e.BottomLevel, e.SiteId, e.NavigationId, e.ProductId, e.DocumentId })
                    .HasName("IX_rd1_ActiveCollections_SiteId_ProductId_DocumentId_NavigationId");

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActiveCollections1>(entity =>
            {
                entity.ToTable("ActiveCollections", "rd2");

                entity.HasIndex(e => new { e.BottomLevel, e.SiteId, e.ProductId, e.DocumentId })
                    .HasName("IX_rd2_ActiveCollections_SiteId_ProductId_DocumentId");

                entity.HasIndex(e => new { e.DocumentId, e.ProductId, e.SiteId, e.BottomLevel })
                    .HasName("IX_rd2_ActiveCollections_SiteId_BottomLevel");

                entity.HasIndex(e => new { e.Level3, e.SiteId, e.ProductId, e.Level1 })
                    .HasName("IX_rd2_Activecollections_siteid_productid_level1");

                entity.HasIndex(e => new { e.NavigationId, e.ProductId, e.BottomLevel, e.DocumentId, e.SiteId })
                    .HasName("IX_rd2_ActiveCollections_ProductId_DocumentId");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.BottomLevel, e.SiteId, e.NavigationId })
                    .HasName("IX_rd2_ActiveCollections_ProductId_DocumentId_SiteId");

                entity.HasIndex(e => new { e.NavigationId, e.DocumentId, e.ProductId, e.BottomLevel, e.Level3, e.SiteId })
                    .HasName("IX_rd2_ActiveCollections_Level3");

                entity.HasIndex(e => new { e.NavigationId, e.ProductId, e.DocumentId, e.BottomLevel, e.Level5, e.SiteId })
                    .HasName("IX_rd2_ActiveCollections_Level5");

                entity.HasIndex(e => new { e.NavigationId, e.ProductId, e.DocumentId, e.Level2, e.BottomLevel, e.SiteId })
                    .HasName("IX_rd2_ActiveCollections_Level2");

                entity.HasIndex(e => new { e.NavigationId, e.ProductId, e.Level4, e.BottomLevel, e.DocumentId, e.SiteId })
                    .HasName("IX_rd2_ActiveCollections_Level4");

                entity.HasIndex(e => new { e.ProductId, e.NavigationId, e.BottomLevel, e.DocumentId, e.Level1, e.SiteId })
                    .HasName("IX_rd2_ActiveCollections_Level1");

                entity.HasIndex(e => new { e.SiteId, e.DocumentId, e.Level1, e.Level2, e.Level3, e.BottomLevel, e.ProductId })
                    .HasName("IX_rd2_ActiveCollections_BottomLevel");

                entity.HasIndex(e => new { e.Id, e.ProductId, e.Level3, e.Level1, e.Level2, e.Levels, e.DocumentId, e.SiteId })
                    .HasName("IX_rd2_ActiveCollections_SiteId");

                entity.HasIndex(e => new { e.BottomLevel, e.Level4, e.Level5, e.Levels, e.Level1, e.Level2, e.Level3, e.SiteId, e.NavigationId, e.ProductId, e.DocumentId })
                    .HasName("IX_rd2_ActiveCollections_SiteId_ProductId_DocumentId_NavigationId");

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActiveNavigationStatistics>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActiveNavigationStatistics", "rd1");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("IX_rd1_ActiveNavigationStatistics_CollectionId");

                entity.HasIndex(e => new { e.CollectionId, e.NoOfProducts, e.NavigationId, e.SiteId })
                    .HasName("IX_rd1_ActiveNavigationStatistics_NavigationId_SiteId");

                entity.HasIndex(e => new { e.TopLevelId, e.NoOfProducts, e.SiteId, e.CollectionId })
                    .HasName("IX_rd1_ActiveNavigationStatistics_SiteId_CollectionId");

                entity.HasIndex(e => new { e.NoOfProducts, e.CollectionId, e.TopLevelId, e.NavigationId, e.SiteId })
                    .HasName("IX_rd1_ActiveNavigationStatistics_TopLevelId_NavigationId_SiteId");

                entity.HasIndex(e => new { e.CollectionId, e.NoOfProducts, e.TopLevelId, e.NavigationId, e.SiteId, e.CollectionLevel })
                    .HasName("IX_rd1_ActiveNavigationStatistics_TopLevelId_NavigationId_SiteId_CollectionLevel");
            });

            modelBuilder.Entity<ActiveNavigationStatistics1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActiveNavigationStatistics", "rd2");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("IX_rd2_ActiveNavigationStatistics_CollectionId");

                entity.HasIndex(e => new { e.CollectionId, e.NoOfProducts, e.NavigationId, e.SiteId })
                    .HasName("IX_rd2_ActiveNavigationStatistics_NavigationId_SiteId");

                entity.HasIndex(e => new { e.TopLevelId, e.NoOfProducts, e.SiteId, e.CollectionId })
                    .HasName("IX_rd2_ActiveNavigationStatistics_SiteId_CollectionId");

                entity.HasIndex(e => new { e.NoOfProducts, e.CollectionId, e.TopLevelId, e.NavigationId, e.SiteId })
                    .HasName("IX_rd2_ActiveNavigationStatistics_TopLevelId_NavigationId_SiteId");

                entity.HasIndex(e => new { e.NoOfProducts, e.CollectionId, e.TopLevelId, e.NavigationId, e.SiteId, e.CollectionLevel })
                    .HasName("IX_rd2_ActiveNavigationStatistics_TopLevelId_NavigationId_SiteId_CollectionLevel");
            });

            modelBuilder.Entity<ActiveProductAttributes>(entity =>
            {
                entity.ToTable("ActiveProductAttributes", "rd1");

                entity.HasIndex(e => e.AttributeType)
                    .HasName("IX_rd1_ActiveProductAttributes_AttributeType");

                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.ProductId, e.AttributeType })
                    .HasName("IX_rd1_ActiveProductAttributes_SiteId_LangCode_ProductId_AttributeType");

                entity.HasIndex(e => new { e.AttributeType, e.SiteId, e.ProductDimension1, e.ProductId, e.LangCode })
                    .HasName("IX_rd1_ActiveProductAttributes_SiteId_ProductDimension1_ProductId");

                entity.HasIndex(e => new { e.Value3, e.ProductId, e.LangCode, e.SiteId, e.AttributeType })
                    .HasName("IX_rd1_ActiveProdutAttributes_SiteId_AttributeType");

                entity.HasIndex(e => new { e.Value3, e.ProductId, e.SiteId, e.LangCode, e.AttributeType })
                    .HasName("ActiveProductAttributes_SiteId_LangCode_AttributType");

                entity.HasIndex(e => new { e.AttributeType, e.Value3, e.LangCode, e.SiteId, e.ProductId, e.Id })
                    .HasName("IX_rd1_ActiveProductAttributes_ProductId_SiteId");

                entity.HasIndex(e => new { e.DocumentId, e.ProductDimension1, e.ProductDimension2, e.PresCode, e.AttributeType, e.AttributeRank, e.AttributeRank2, e.IsVisible, e.Value1, e.Value2, e.Value3, e.Value4, e.ProductId, e.SiteId, e.LangCode })
                    .HasName("IX_rd1_ActiveProductAttributes_ProductId_SiteId_LangCode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttributeType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDimension1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDimension2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1).HasMaxLength(100);

                entity.Property(e => e.Value2).HasMaxLength(100);

                entity.Property(e => e.Value3).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Value3Hash).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Value3UrlHash).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Value4).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<ActiveProductAttributes1>(entity =>
            {
                entity.ToTable("ActiveProductAttributes", "rd2");

                entity.HasIndex(e => e.AttributeType)
                    .HasName("IX_rd2_ActiveProductAttributes_AttributeType");

                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.ProductId, e.AttributeType })
                    .HasName("IX_rd2_ActiveProductAttributes_SiteId_LangCode_ProductId_AttributeType");

                entity.HasIndex(e => new { e.AttributeType, e.SiteId, e.ProductDimension1, e.ProductId, e.LangCode })
                    .HasName("IX_rd2_ActiveProductAttributes_SiteId_ProductDimension1_ProductId");

                entity.HasIndex(e => new { e.LangCode, e.ProductId, e.Value3, e.SiteId, e.AttributeType })
                    .HasName("IX_rd2_ActiveProdutAttributes_SiteId_AttributeType");

                entity.HasIndex(e => new { e.ProductId, e.Value3, e.SiteId, e.LangCode, e.AttributeType })
                    .HasName("ActiveProductAttributes_SiteId_LangCode_AttributType");

                entity.HasIndex(e => new { e.ProductId, e.AttributeType, e.Value3, e.LangCode, e.SiteId, e.Id })
                    .HasName("IX_rd2_ActiveProductAttributes_ProductId_SiteId");

                entity.HasIndex(e => new { e.Value4, e.DocumentId, e.ProductDimension1, e.ProductDimension2, e.PresCode, e.AttributeType, e.AttributeRank, e.AttributeRank2, e.IsVisible, e.Value1, e.Value2, e.Value3, e.ProductId, e.SiteId, e.LangCode })
                    .HasName("IX_rd2_ActiveProductAttributes_ProductId_SiteId_LangCode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttributeType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDimension1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDimension2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1).HasMaxLength(100);

                entity.Property(e => e.Value2).HasMaxLength(100);

                entity.Property(e => e.Value3).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Value3Hash).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Value3UrlHash).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Value4).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<ActiveProducts>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CollectionId, e.CurrencySymbol })
                    .HasName("PK_rd1_ActiveProducts");

                entity.ToTable("ActiveProducts", "rd1");

                entity.HasIndex(e => e.Brand)
                    .HasName("IX_rd1_ActiveProducts_Brand");

                entity.HasIndex(e => new { e.SiteId, e.MinSalePriceAfter })
                    .HasName("ActiveProducts_SiteId_MinSalePriceAfter");

                entity.HasIndex(e => new { e.SiteId, e.ProductId })
                    .HasName("IX_rd1_ActiveProducts_SiteId_ProductId");

                entity.HasIndex(e => new { e.Brand, e.ProductId, e.SiteId, e.LangCode })
                    .HasName("IX_rd1_ActiveProducts_SiteId_LangCode");

                entity.HasIndex(e => new { e.ProductId, e.DefaultImage, e.SiteId, e.MinSalePriceAfter })
                    .HasName("IX_rd1_ActiveProducts_SiteId_MinSalePriceAfter");

                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveProducts_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DefaultImage, e.DocumentId, e.MinSalePriceBefore, e.MinSalePriceAfter, e.MaxSalePriceBefore, e.DiscountPercentage, e.MaxDiscountPercentage, e.NumberOfSalePriceBefore, e.NumberOfSalePriceAfter, e.NumberOfDiscounts, e.IsLot, e.Title, e.ShortDescription, e.Brand, e.SiteId, e.LangCode, e.CurrencySymbol })
                    .HasName("IX_rd1_ActiveProducts_SiteId_LangCode_CurrencySymbol");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol).HasMaxLength(5);

                entity.Property(e => e.AverageRating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultCatWalkVideo)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultHighDefinitionImage)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultImage)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultImageOrientation)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultThreeSixtyVideo)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LongDescription).IsRequired();

                entity.Property(e => e.MaxDateCreated).HasColumnType("datetime");

                entity.Property(e => e.MaxDiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaxSalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaxSalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinDateCreated).HasColumnType("datetime");

                entity.Property(e => e.MinSalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinSalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.SubFamily)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<ActiveProducts1>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CollectionId, e.CurrencySymbol })
                    .HasName("PK_rd2_ActiveProducts");

                entity.ToTable("ActiveProducts", "rd2");

                entity.HasIndex(e => e.Brand)
                    .HasName("IX_rd2_ActiveProducts_Brand");

                entity.HasIndex(e => new { e.SiteId, e.MinSalePriceAfter })
                    .HasName("ActiveProducts_SiteId_MinSalePriceAfter");

                entity.HasIndex(e => new { e.SiteId, e.ProductId })
                    .HasName("IX_rd2_ActiveProducts_SiteId_ProductId");

                entity.HasIndex(e => new { e.Brand, e.ProductId, e.SiteId, e.LangCode })
                    .HasName("IX_rd2_ActiveProducts_SiteId_LangCode");

                entity.HasIndex(e => new { e.DefaultImage, e.ProductId, e.SiteId, e.MinSalePriceAfter })
                    .HasName("IX_rd2_ActiveProducts_SiteId_MinSalePriceAfter");

                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.ProductId, e.DocumentId, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveProducts_SiteId_LangCode_ProductId_DocumentId_CurrencySymbol");

                entity.HasIndex(e => new { e.ProductId, e.DocumentId, e.DefaultImage, e.MinSalePriceBefore, e.MinSalePriceAfter, e.Title, e.ShortDescription, e.Brand, e.MaxSalePriceBefore, e.DiscountPercentage, e.MaxDiscountPercentage, e.NumberOfSalePriceBefore, e.NumberOfSalePriceAfter, e.NumberOfDiscounts, e.IsLot, e.SiteId, e.LangCode, e.CurrencySymbol })
                    .HasName("IX_rd2_ActiveProducts_SiteId_LangCode_CurrencySymbol");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol).HasMaxLength(5);

                entity.Property(e => e.AverageRating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BasketSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultCatWalkVideo)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultHighDefinitionImage)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultImage)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DefaultImageOrientation)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultThreeSixtyVideo)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Family)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LongDescription).IsRequired();

                entity.Property(e => e.MaxDateCreated).HasColumnType("datetime");

                entity.Property(e => e.MaxDiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaxSalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaxSalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinDateCreated).HasColumnType("datetime");

                entity.Property(e => e.MinSalePriceAfter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinSalePriceBefore).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PresCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.SubFamily)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<BlogAuthors>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<BlogPostLabels>(entity =>
            {
                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlogPosts>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.PostId })
                    .IsUnique();

                entity.Property(e => e.DateImported)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatePublished).HasColumnType("datetime");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MetaData).HasColumnType("xml");

                entity.Property(e => e.PostContent).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.Url).IsRequired();
            });

            modelBuilder.Entity<BlogPostsV2>(entity =>
            {
                entity.Property(e => e.AssociatedProducts)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Categories).IsRequired();

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CoverImageAlt)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoverImageUrl)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.HeaderTags).IsRequired();

                entity.Property(e => e.HomePageImageAlt)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HomePageImageUrl)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription).HasMaxLength(1000);

                entity.Property(e => e.MetaTags)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.PublishStartDate).HasColumnType("datetime");

                entity.Property(e => e.RedirectUrl).IsRequired();

                entity.Property(e => e.Seoscore).HasColumnName("SEOScore");

                entity.Property(e => e.ShowInHp).HasColumnName("ShowInHP");

                entity.Property(e => e.ShowInPdpcategories).HasColumnName("ShowInPDPCategories");

                entity.Property(e => e.ShowInPdpproducts).HasColumnName("ShowInPDPProducts");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlogTags>(entity =>
            {
                entity.Property(e => e.CreatedById).HasDefaultValueSql("((6))");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.H1).HasMaxLength(1000);

                entity.Property(e => e.HeaderTags)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedById).HasDefaultValueSql("((6))");

                entity.Property(e => e.MetaDescription).HasMaxLength(1000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(1000);

                entity.Property(e => e.MetaTags)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Seotext)
                    .IsRequired()
                    .HasColumnName("SEOText")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShowInHp).HasColumnName("ShowInHP");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CacheManager>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CacheManage")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CacheKeyHash, e.CacheType, e.DateExpires, e.Id })
                    .IsClustered();

                entity.Property(e => e.CacheKey).IsRequired();

                entity.Property(e => e.CacheType)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateExpires).HasColumnType("datetime");

                entity.Property(e => e.Hits).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Collections>(entity =>
            {
                entity.ToTable("Collections", "rd1");

                entity.HasIndex(e => e.CollectionTitle)
                    .HasName("IX_rd1_Collections_CollectionTitle");

                entity.HasIndex(e => e.NavigationId)
                    .HasName("IX_rd1_Collections_NavigationId");

                entity.HasIndex(e => new { e.Id, e.ParentId })
                    .HasName("IX_rd1_Collections_ParentId");

                entity.HasIndex(e => new { e.Id, e.ParentId, e.Activated })
                    .HasName("IX_rd1_Collections_Activated");

                entity.HasIndex(e => new { e.ParentId, e.Id, e.CollectionLevel })
                    .HasName("IX_rd1_Collections_CollectionLevel");

                entity.HasIndex(e => new { e.ParentId, e.Id, e.NavigationId, e.CollectionLevel, e.MainCollectionType })
                    .HasName("IX_rd1_NavigationId_CollectionLevel_MainCollectionType");

                entity.HasIndex(e => new { e.CollectionTitle, e.NavigationId, e.CollectionLevel, e.MainCollectionType, e.Id, e.ParentId, e.Activated })
                    .HasName("IX_rd1_Collections_ParentId_Activated");

                entity.HasIndex(e => new { e.CollectionTitle, e.NavigationId, e.CollectionLevel, e.ParentId, e.CollectionCount, e.Activated, e.MainCollectionType, e.Id })
                    .HasName("IX_rd1_Collections_Id");

                entity.Property(e => e.Activated)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.CollectionTitle)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.CollectionsTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.MainCollectionType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Collections1>(entity =>
            {
                entity.ToTable("Collections", "rd2");

                entity.HasIndex(e => e.CollectionTitle)
                    .HasName("IX_rd2_Collections_CollectionTitle");

                entity.HasIndex(e => e.NavigationId)
                    .HasName("IX_rd2_Collections_NavigationId");

                entity.HasIndex(e => new { e.Id, e.ParentId })
                    .HasName("IX_rd2_Collections_ParentId");

                entity.HasIndex(e => new { e.Id, e.ParentId, e.Activated })
                    .HasName("IX_rd2_Collections_Activated");

                entity.HasIndex(e => new { e.ParentId, e.Id, e.CollectionLevel })
                    .HasName("IX_rd2_Collections_CollectionLevel");

                entity.HasIndex(e => new { e.ParentId, e.Id, e.NavigationId, e.CollectionLevel, e.MainCollectionType })
                    .HasName("IX_rd2_NavigationId_CollectionLevel_MainCollectionType");

                entity.HasIndex(e => new { e.CollectionTitle, e.NavigationId, e.CollectionLevel, e.MainCollectionType, e.Id, e.ParentId, e.Activated })
                    .HasName("IX_rd2_Collections_ParentId_Activated");

                entity.HasIndex(e => new { e.ParentId, e.CollectionLevel, e.NavigationId, e.CollectionTitle, e.CollectionCount, e.Activated, e.MainCollectionType, e.Id })
                    .HasName("IX_rd2_Collections_Id");

                entity.Property(e => e.Activated)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.CollectionTitle)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.CollectionsTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.MainCollectionType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CollectionsProperties>(entity =>
            {
                entity.ToTable("CollectionsProperties", "rd1");

                entity.HasIndex(e => new { e.CollectionType, e.Id })
                    .HasName("IX_rd1_CollectionsProperties_Id");

                entity.HasIndex(e => new { e.CollectionId, e.DisplayPosition, e.SiteId })
                    .HasName("IX_rd1_CollectionsProperties_SiteId");

                entity.HasIndex(e => new { e.Activated, e.SiteId, e.CollectionType, e.CollectionId })
                    .HasName("IX_rd1_CollectionsProperties_SiteId_Activated");

                entity.HasIndex(e => new { e.CollectionId, e.DisplayPosition, e.SiteId, e.ShowInMenu })
                    .HasName("IX_rd1_CollectionsProperties_SiteId_ShowInMenu");

                entity.HasIndex(e => new { e.HasNavigationBar, e.CollectionType, e.DisplayPosition, e.SiteId, e.CollectionId })
                    .HasName("IX_rd1_CollectionsProperties_SiteId_HasNavigationBar");

                entity.HasIndex(e => new { e.Activated, e.ShowInMenu, e.HideSearch, e.CollectionStatus, e.CollectionLayout, e.StyleAttribute, e.Mobile, e.HasLandingPage, e.DynamicLandingPage, e.HasNavigationBar, e.DisplayPosition, e.CollectionType, e.CollectionId, e.SiteId })
                    .HasName("IX_rd1_CollectionsProperties_SiteId_CollectionId");

                entity.Property(e => e.Activated)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AutomaticTagId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CollectionLayout)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionType).HasMaxLength(10);

                entity.Property(e => e.CollectionsPropertiesTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DynamicLandingPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.HasLandingPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HasNavigationBar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HideSearch)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxDiscount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ShowInMenu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StyleAttribute)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CollectionsProperties1>(entity =>
            {
                entity.ToTable("CollectionsProperties", "rd2");

                entity.HasIndex(e => new { e.CollectionType, e.Id })
                    .HasName("IX_rd2_CollectionsProperties_Id");

                entity.HasIndex(e => new { e.CollectionId, e.DisplayPosition, e.SiteId })
                    .HasName("IX_rd2_CollectionsProperties_SiteId");

                entity.HasIndex(e => new { e.Activated, e.SiteId, e.CollectionType, e.CollectionId })
                    .HasName("IX_rd2_CollectionsProperties_SiteId_Activated");

                entity.HasIndex(e => new { e.CollectionId, e.DisplayPosition, e.SiteId, e.ShowInMenu })
                    .HasName("IX_rd2_CollectionsProperties_SiteId_ShowInMenu");

                entity.HasIndex(e => new { e.SiteId, e.HasNavigationBar, e.DisplayPosition, e.CollectionType, e.CollectionId })
                    .HasName("IX_rd2_CollectionsProperties_SiteId_HasNavigationBar");

                entity.HasIndex(e => new { e.Activated, e.DisplayPosition, e.HasLandingPage, e.DynamicLandingPage, e.HasNavigationBar, e.ShowInMenu, e.HideSearch, e.CollectionType, e.CollectionStatus, e.CollectionLayout, e.StyleAttribute, e.Mobile, e.CollectionId, e.SiteId })
                    .HasName("IX_rd2_CollectionsProperties_SiteId_CollectionId");

                entity.Property(e => e.Activated)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AutomaticTagId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CollectionLayout)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionType).HasMaxLength(10);

                entity.Property(e => e.CollectionsPropertiesTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DynamicLandingPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.HasLandingPage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HasNavigationBar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HideSearch)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxDiscount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ShowInMenu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StyleAttribute)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EmailTemplates>(entity =>
            {
                entity.Property(e => e.Bcc)
                    .IsRequired()
                    .HasColumnName("BCC")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTemplateType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Recipient)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<GlobalParameters>(entity =>
            {
                entity.HasKey(e => new { e.GroupType, e.Code, e.Variant });

                entity.Property(e => e.GroupType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Variant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlobalParametersBackEndMapping>(entity =>
            {
                entity.HasKey(e => new { e.Siteid, e.BackEndName, e.GroupType, e.BackendCode, e.BackendVariant });

                entity.Property(e => e.Siteid).HasDefaultValueSql("((-1))");

                entity.Property(e => e.BackEndName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BackendCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackendVariant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TheseusCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheseusVariant)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlobalParametersGroupTypes>(entity =>
            {
                entity.HasKey(e => e.GroupType);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDescription).HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTranslatable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GlobalParametersMessages>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.LangCode, e.GroupType, e.Code, e.Variant })
                    .HasName("PK_GlobalParametersDescriptions");

                entity.Property(e => e.SiteId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Variant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PrimaryDescription).IsRequired();
            });

            modelBuilder.Entity<Import>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("import");

                entity.Property(e => e.CreatedById)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.H1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderTags)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LangCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedById)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaTags)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Seotext)
                    .HasColumnName("SEOText")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TagName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocalContent>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.PageName, e.LabelName, e.LabelFriendlyName, e.Interface, e.Id })
                    .HasName("IX_LocalContent_SiteId_LangCode_PageNameHash_LabelNameHash_Interface");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Interface)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LabelFriendlyName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LabelName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LabelNameHash).HasComputedColumnSql("(checksum([LabelName]))");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageNameHash).HasComputedColumnSql("(checksum([PageName]))");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.PageNameNavigation)
                    .WithMany(p => p.LocalContent)
                    .HasPrincipalKey(p => p.PageName)
                    .HasForeignKey(d => d.PageName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocalContent_LocalContentPages");
            });

            modelBuilder.Entity<LocalContentPages>(entity =>
            {
                entity.HasIndex(e => e.PageName)
                    .IsUnique();

                entity.HasIndex(e => new { e.PageName, e.PageFriendlyName })
                    .IsUnique();

                entity.Property(e => e.PageDescription)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageFriendlyName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaperCatalogues>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.LangCode, e.CatalogueId });

                entity.Property(e => e.CatalogueId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<ProductMixer>(entity =>
            {
                entity.HasIndex(e => new { e.Rank, e.ProductId, e.SiteId, e.AttributeId, e.AttributeType })
                    .HasName("IX_ProductMixer_SiteId_AttributeId_AttributeType");

                entity.HasIndex(e => new { e.Id, e.Rank, e.CollectionId, e.Brand, e.SiteId, e.AttributeId, e.AttributeType, e.ProductId })
                    .HasName("IX_ProductMixer_SiteId_AttributeId_AttributeType_ProductId");

                entity.Property(e => e.AttributeType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ProductRules>(entity =>
            {
                entity.HasIndex(e => new { e.RuleType, e.SiteId, e.ProductId, e.DocumentId })
                    .HasName("IX_ProductRules_SiteId_ProductId_DocumentId");

                entity.HasIndex(e => new { e.SiteId, e.CategoryId, e.Family, e.SubFamily, e.Size, e.MiniSize, e.ProductId, e.DocumentId, e.RuleType })
                    .HasName("IX_ProductRules_RuleType");

                entity.Property(e => e.Brand).HasMaxLength(1000);

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Family).HasMaxLength(500);

                entity.Property(e => e.LangCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MiniSize)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PdpseoText)
                    .HasColumnName("PDPSeoText")
                    .HasMaxLength(4000);

                entity.Property(e => e.Pdptitle)
                    .HasColumnName("PDPTitle")
                    .HasMaxLength(2000);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Size).HasMaxLength(500);

                entity.Property(e => e.SubFamily).HasMaxLength(500);
            });

            modelBuilder.Entity<ProductTags>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("PK_ProductTagsTEMP")
                    .IsUnique();

                entity.HasIndex(e => new { e.LangCode, e.TagId })
                    .HasName("IX_ProductTags_ProductId_DocumentId_SiteId_EndDate")
                    .IsClustered();

                entity.HasIndex(e => new { e.TagId, e.SiteId });

                entity.HasIndex(e => new { e.DocumentId, e.SiteId, e.EndDate, e.ProductId })
                    .HasName("IX_ProductTags_SiteId_EndDate");

                entity.HasIndex(e => new { e.ProductId, e.SiteId, e.TagId, e.EndDate })
                    .HasName("IX_ProductTags_TagId_SiteId_EndDate");

                entity.Property(e => e.DocumentId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProductVendors>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.LangCode });

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LogoUrl)
                    .IsRequired()
                    .HasColumnName("LogoURL")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZanoxCid)
                    .HasColumnName("ZanoxCID")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<RankingManager>(entity =>
            {
                entity.HasIndex(e => e.SiteId);

                entity.HasIndex(e => new { e.TypeId, e.RankType, e.RankSet })
                    .HasName("IX_RankingManager_TypeId");

                entity.HasIndex(e => new { e.RankSet, e.CanUseToRank, e.TypeId, e.RankType })
                    .HasName("IX_RankingManager_RankSet");

                entity.HasIndex(e => new { e.RankType, e.TypeId, e.RankSet, e.SiteId })
                    .HasName("IX_RankingManager_RankType");

                entity.HasIndex(e => new { e.Id, e.TypeId, e.RankSet, e.CanUseToRank, e.RankType })
                    .HasName("IX_RankingManager_Id");

                entity.HasIndex(e => new { e.Id, e.SiteId, e.RankType, e.TypeId, e.RankSet, e.CanUseToRank })
                    .HasName("IX_RankingManager_SiteId_RankType_TypeId_CanUseToRank");

                entity.Property(e => e.CanUseToRank).HasComment("Indicates whether the ranking set attached to an item can be used to rank products. True if the ranking set contains products.");

                entity.Property(e => e.RankType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TypeId).HasMaxLength(200);
            });

            modelBuilder.Entity<RankingManagerExplode>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.RankingManagerId, e.Level, e.Rankset, e.Segment, e.SiteId, e.CollectionId })
                    .HasName("IX_RankingManagerExplode_SiteId_CollectionId");

                entity.Property(e => e.Segment)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SearchAssociationFilters>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FilterLabel)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.FilterUrl)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdModified).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<SearchAssociations>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.LangCode });

                entity.HasIndex(e => new { e.SiteId, e.SearchTerm, e.Value, e.Priority, e.LangCode, e.Type })
                    .HasName("IX_SearchAssociations_LangCode_Type");

                entity.HasIndex(e => new { e.Id, e.Value, e.Priority, e.SearchTerm, e.SiteId, e.Type, e.LangCode })
                    .HasName("IX_SearchAssociations_SiteId_Type");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTerm)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Redirection')");

                entity.Property(e => e.UserIdCreated).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UserIdModified).HasDefaultValueSql("((1))");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<SiteTags>(entity =>
            {
                entity.HasKey(e => new { e.TagId, e.SiteId, e.LangCode });

                entity.Property(e => e.LangCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SizeCharts>(entity =>
            {
                entity.HasIndex(e => new { e.CollectionId, e.SiteId })
                    .HasName("IX_SizeCharts_SiteId_CollectionId");

                entity.HasIndex(e => new { e.CollectionLevel, e.SiteId, e.SizeChart, e.CollectionId, e.Id })
                    .HasName("IX_SizeCharts_SiteId");

                entity.Property(e => e.SizeChart)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<StaticPages>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Title, e.MetaDescription, e.Url, e.ShowHeader, e.ShowMainOptions, e.ShowFooter, e.MetaKeywords, e.MasterPage, e.Breadcrumb, e.PageType, e.SiteId, e.LangCode })
                    .HasName("IX_StaticPages_SiteId_LangCode");

                entity.Property(e => e.Breadcrumb).HasMaxLength(1000);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Footer).HasColumnType("ntext");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MasterPage)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'mstMain.master')");

                entity.Property(e => e.MetaDescription).HasMaxLength(1000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(1000);

                entity.Property(e => e.MetaTags)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageDescription)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageType).HasMaxLength(50);

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.PublishStartDate).HasColumnType("datetime");

                entity.Property(e => e.RedirectUrl)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Seotext).HasColumnName("SEOText");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasIndex(e => new { e.SiteId, e.Name, e.Value, e.Duration, e.Priority, e.PositionProductPage, e.TagType, e.IsAutomatic, e.ParentTagId, e.Id, e.PositionProductList })
                    .HasName("IX_Tags_Id_PositionProductList");

                entity.Property(e => e.Duration).HasDefaultValueSql("((90))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ParentTagId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PositionProductList)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DescriptionTopLeft')");

                entity.Property(e => e.PositionProductPage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DescriptionLeft')");

                entity.Property(e => e.TagType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<VLocalContent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLocalContent");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Interface)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabelFriendlyName).IsRequired();

                entity.Property(e => e.LabelName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PageFriendlyName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<ZzzLocalContent02102014>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZZZ_LocalContent_02102014");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Interface)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabelFriendlyName).IsRequired();

                entity.Property(e => e.LabelName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<ZzzLocalcontent20140606>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzz_localcontent_20140606");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Interface)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LabelFriendlyName).IsRequired();

                entity.Property(e => e.LabelName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<ZzzStaticPages20140716>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzz_StaticPages_20140716");

                entity.Property(e => e.Breadcrumb).HasMaxLength(1000);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Footer).HasColumnType("ntext");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MasterPage)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.MetaDescription).HasMaxLength(1000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(1000);

                entity.Property(e => e.MetaTags)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PageDescription)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PageType).HasMaxLength(50);

                entity.Property(e => e.Seotext).HasColumnName("SEOText");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(1000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
