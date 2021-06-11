using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class ColegioContext : DbContext
    {
        public ColegioContext()
        {
        }

        public ColegioContext(DbContextOptions<ColegioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAbastecimiento> TbAbastecimientos { get; set; }
        public virtual DbSet<TbCliente> TbClientes { get; set; }
        public virtual DbSet<TbDetalleCompra> TbDetalleCompras { get; set; }
        public virtual DbSet<TbDetalleFactura> TbDetalleFacturas { get; set; }
        public virtual DbSet<TbDistrito> TbDistritos { get; set; }
        public virtual DbSet<TbFactura> TbFacturas { get; set; }
        public virtual DbSet<TbOrdenCompra> TbOrdenCompras { get; set; }
        public virtual DbSet<TbProducto> TbProductos { get; set; }
        public virtual DbSet<TbProveedor> TbProveedors { get; set; }
        public virtual DbSet<TbVendedor> TbVendedors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CN6T5DL\\SQLEXPRESS;Initial Catalog=VENTAS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TbAbastecimiento>(entity =>
            {
                entity.HasKey(e => new { e.CodPrv, e.CodPro })
                    .HasName("PK__TB_ABAST__6A35C189377FE133");

                entity.ToTable("TB_ABASTECIMIENTO");

                entity.Property(e => e.CodPrv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRV")
                    .IsFixedLength();

                entity.Property(e => e.CodPro)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRO")
                    .IsFixedLength();

                entity.Property(e => e.PreAba)
                    .HasColumnType("money")
                    .HasColumnName("PRE_ABA");

                entity.HasOne(d => d.CodProNavigation)
                    .WithMany(p => p.TbAbastecimientos)
                    .HasForeignKey(d => d.CodPro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_ABASTE__COD_P__403A8C7D");

                entity.HasOne(d => d.CodPrvNavigation)
                    .WithMany(p => p.TbAbastecimientos)
                    .HasForeignKey(d => d.CodPrv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_ABASTE__COD_P__3F466844");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.CodCli)
                    .HasName("PK__TB_CLIEN__151FF4821E2A30C6");

                entity.ToTable("TB_CLIENTE");

                entity.Property(e => e.CodCli)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_CLI")
                    .IsFixedLength();

                entity.Property(e => e.CodDis)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_DIS")
                    .IsFixedLength();

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTO");

                entity.Property(e => e.DirCli)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIR_CLI");

                entity.Property(e => e.FecReg)
                    .HasColumnType("date")
                    .HasColumnName("FEC_REG");

                entity.Property(e => e.RazSocCli)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RAZ_SOC_CLI");

                entity.Property(e => e.RucCli)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("RUC_CLI")
                    .IsFixedLength();

                entity.Property(e => e.TipCli)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIP_CLI");

                entity.Property(e => e.TlfCli)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TLF_CLI")
                    .IsFixedLength();

                entity.HasOne(d => d.CodDisNavigation)
                    .WithMany(p => p.TbClientes)
                    .HasForeignKey(d => d.CodDis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_CLIENT__COD_D__29572725");
            });

            modelBuilder.Entity<TbDetalleCompra>(entity =>
            {
                entity.HasKey(e => new { e.NumOco, e.CodPro })
                    .HasName("PK__TB_DETAL__955951007B7332BA");

                entity.ToTable("TB_DETALLE_COMPRA");

                entity.Property(e => e.NumOco)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NUM_OCO")
                    .IsFixedLength();

                entity.Property(e => e.CodPro)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRO")
                    .IsFixedLength();

                entity.Property(e => e.CanPed).HasColumnName("CAN_PED");

                entity.HasOne(d => d.CodProNavigation)
                    .WithMany(p => p.TbDetalleCompras)
                    .HasForeignKey(d => d.CodPro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_DETALL__COD_P__3C69FB99");

                entity.HasOne(d => d.NumOcoNavigation)
                    .WithMany(p => p.TbDetalleCompras)
                    .HasForeignKey(d => d.NumOco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_DETALL__NUM_O__3B75D760");
            });

            modelBuilder.Entity<TbDetalleFactura>(entity =>
            {
                entity.HasKey(e => new { e.NumFac, e.CodPro })
                    .HasName("PK__TB_DETAL__8BAEAEACA7D98112");

                entity.ToTable("TB_DETALLE_FACTURA");

                entity.Property(e => e.NumFac)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NUM_FAC")
                    .IsFixedLength();

                entity.Property(e => e.CodPro)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRO")
                    .IsFixedLength();

                entity.Property(e => e.CanVen).HasColumnName("CAN_VEN");

                entity.Property(e => e.PreVen)
                    .HasColumnType("money")
                    .HasColumnName("PRE_VEN");

                entity.HasOne(d => d.CodProNavigation)
                    .WithMany(p => p.TbDetalleFacturas)
                    .HasForeignKey(d => d.CodPro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_DETALL__COD_P__38996AB5");

                entity.HasOne(d => d.NumFacNavigation)
                    .WithMany(p => p.TbDetalleFacturas)
                    .HasForeignKey(d => d.NumFac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_DETALL__NUM_F__37A5467C");
            });

            modelBuilder.Entity<TbDistrito>(entity =>
            {
                entity.HasKey(e => e.CodDis)
                    .HasName("PK__TB_DISTR__2B2C6E8915829F84");

                entity.ToTable("TB_DISTRITO");

                entity.Property(e => e.CodDis)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_DIS")
                    .IsFixedLength();

                entity.Property(e => e.NomDis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_DIS");
            });

            modelBuilder.Entity<TbFactura>(entity =>
            {
                entity.HasKey(e => e.NumFac)
                    .HasName("PK__TB_FACTU__C9254C9783D91900");

                entity.ToTable("TB_FACTURA");

                entity.Property(e => e.NumFac)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NUM_FAC")
                    .IsFixedLength();

                entity.Property(e => e.CodCli)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_CLI")
                    .IsFixedLength();

                entity.Property(e => e.CodVen)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COD_VEN")
                    .IsFixedLength();

                entity.Property(e => e.EstFac)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EST_FAC");

                entity.Property(e => e.FecCan)
                    .HasColumnType("date")
                    .HasColumnName("FEC_CAN");

                entity.Property(e => e.FecFac)
                    .HasColumnType("date")
                    .HasColumnName("FEC_FAC");

                entity.Property(e => e.PorcIgv)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PORC_IGV");

                entity.HasOne(d => d.CodCliNavigation)
                    .WithMany(p => p.TbFacturas)
                    .HasForeignKey(d => d.CodCli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_FACTUR__COD_C__2F10007B");

                entity.HasOne(d => d.CodVenNavigation)
                    .WithMany(p => p.TbFacturas)
                    .HasForeignKey(d => d.CodVen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_FACTUR__COD_V__300424B4");
            });

            modelBuilder.Entity<TbOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.NumOco)
                    .HasName("PK__TB_ORDEN__D7D2B33B06057324");

                entity.ToTable("TB_ORDEN_COMPRA");

                entity.Property(e => e.NumOco)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NUM_OCO")
                    .IsFixedLength();

                entity.Property(e => e.CodPrv)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRV")
                    .IsFixedLength();

                entity.Property(e => e.EstOco)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EST_OCO")
                    .IsFixedLength();

                entity.Property(e => e.FecAte)
                    .HasColumnType("date")
                    .HasColumnName("FEC_ATE");

                entity.Property(e => e.FecOco)
                    .HasColumnType("date")
                    .HasColumnName("FEC_OCO");

                entity.HasOne(d => d.CodPrvNavigation)
                    .WithMany(p => p.TbOrdenCompras)
                    .HasForeignKey(d => d.CodPrv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_ORDEN___COD_P__32E0915F");
            });

            modelBuilder.Entity<TbProducto>(entity =>
            {
                entity.HasKey(e => e.CodPro)
                    .HasName("PK__TB_PRODU__28BE23B574D8F735");

                entity.ToTable("TB_PRODUCTO");

                entity.Property(e => e.CodPro)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRO")
                    .IsFixedLength();

                entity.Property(e => e.DesPro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DES_PRO");

                entity.Property(e => e.Importado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTADO");

                entity.Property(e => e.LinPro)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LIN_PRO");

                entity.Property(e => e.PrePro)
                    .HasColumnType("money")
                    .HasColumnName("PRE_PRO");

                entity.Property(e => e.StkAct).HasColumnName("STK_ACT");

                entity.Property(e => e.StkMin).HasColumnName("STK_MIN");

                entity.Property(e => e.UniMed)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UNI_MED");
            });

            modelBuilder.Entity<TbProveedor>(entity =>
            {
                entity.HasKey(e => e.CodPrv)
                    .HasName("PK__TB_PROVE__28BE23B2A3BDC5A4");

                entity.ToTable("TB_PROVEEDOR");

                entity.Property(e => e.CodPrv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_PRV")
                    .IsFixedLength();

                entity.Property(e => e.CodDis)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_DIS")
                    .IsFixedLength();

                entity.Property(e => e.DirPrv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIR_PRV");

                entity.Property(e => e.RazSocPrv)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("RAZ_SOC_PRV");

                entity.Property(e => e.RepVen)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("REP_VEN");

                entity.Property(e => e.TelPrv)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("TEL_PRV")
                    .IsFixedLength();

                entity.HasOne(d => d.CodDisNavigation)
                    .WithMany(p => p.TbProveedors)
                    .HasForeignKey(d => d.CodDis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_PROVEE__COD_D__2C3393D0");
            });

            modelBuilder.Entity<TbVendedor>(entity =>
            {
                entity.HasKey(e => e.CodVen)
                    .HasName("PK__TB_VENDE__283E0CC20425EAF6");

                entity.ToTable("TB_VENDEDOR");

                entity.Property(e => e.CodVen)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COD_VEN")
                    .IsFixedLength();

                entity.Property(e => e.ApeVen)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APE_VEN");

                entity.Property(e => e.CodDis)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("COD_DIS")
                    .IsFixedLength();

                entity.Property(e => e.FecIng)
                    .HasColumnType("date")
                    .HasColumnName("FEC_ING");

                entity.Property(e => e.NomVen)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_VEN");

                entity.Property(e => e.SueldoVen)
                    .HasColumnType("money")
                    .HasColumnName("SUELDO_VEN");

                entity.Property(e => e.TipVen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TIP_VEN");

                entity.HasOne(d => d.CodDisNavigation)
                    .WithMany(p => p.TbVendedors)
                    .HasForeignKey(d => d.CodDis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_VENDED__COD_D__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
