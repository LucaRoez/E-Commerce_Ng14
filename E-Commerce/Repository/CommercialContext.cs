using E_Commerce.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Repository;

public partial class CommercialContext : DbContext
{
    public CommercialContext()
    {
    }

    public CommercialContext(DbContextOptions<CommercialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CCategory> CCategories { get; set; }

    public virtual DbSet<CCurrency> CCurrencies { get; set; }

    public virtual DbSet<CGender> CGenders { get; set; }

    public virtual DbSet<DAuthor> DAuthors { get; set; }

    public virtual DbSet<DCommentary> DCommentaries { get; set; }

    public virtual DbSet<DImage> DImages { get; set; }

    public virtual DbSet<DProduct> DProducts { get; set; }

    public virtual DbSet<DReview> DReviews { get; set; }

    public virtual DbSet<DUser> DUsers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__c.Catego__3214EC0751EA94C0");

            entity.ToTable("c.Categories");

            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__c.Curren__3214EC074F1EFCAE");

            entity.ToTable("c.Currencies");

            entity.Property(e => e.Issuer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Symbol)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CGender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__c.Gender__3214EC0706B41330");

            entity.ToTable("c.Gender");

            entity.Property(e => e.Name)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__d.Author__3214EC07B84AAD28");

            entity.ToTable("d.Authors");

            entity.Property(e => e.AuthorName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Presentation)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DCommentary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__d.Commen__3214EC07EF67BD2C");

            entity.ToTable("d.Commentaries");

            entity.Property(e => e.Body)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__d.Images__3214EC07C6C4AD04");

            entity.ToTable("d.Images");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Alt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Src)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__d.Produc__3214EC0765F2893C");

            entity.ToTable("d.Products");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("smallmoney");
            entity.Property(e => e.Rate).HasColumnType("decimal(2, 1)");

            entity.HasOne(d => d.Category).WithMany(p => p.DProducts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__d.Product__Categ__412EB0B6");

            entity.HasOne(d => d.Currency).WithMany(p => p.DProducts)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("FK__d.Product__Curre__403A8C7D");

            entity.HasOne(d => d.Gender).WithMany(p => p.DProducts)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK__d.Product__Gende__4222D4EF");
        });

        modelBuilder.Entity<DReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__d.Review__3214EC07945FCD0F");

            entity.ToTable("d.Reviews");

            entity.Property(e => e.Author)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Body)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("decimal(2, 1)");

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.DReviews)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__d.Reviews__Autho__46E78A0C");
        });

        modelBuilder.Entity<DUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__d.Users__3214EC075C03343B");

            entity.ToTable("d.Users");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
