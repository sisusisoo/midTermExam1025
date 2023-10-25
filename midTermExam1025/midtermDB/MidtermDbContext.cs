using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace midTermExam1025.midtermDB;

public partial class MidtermDbContext : DbContext
{
    public MidtermDbContext()
    {
    }

    public MidtermDbContext(DbContextOptions<MidtermDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order1> Order1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=midtermDB;uid=root;pwd=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order1>(entity =>
        {
            entity.HasKey(e => e.Date).HasName("PRIMARY");

            entity.ToTable("order1");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.OrderState)
                .HasMaxLength(20)
                .HasColumnName("orderState");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
