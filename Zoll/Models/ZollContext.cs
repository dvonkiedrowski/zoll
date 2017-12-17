namespace Zoll
{
    using System;
    using System.Data.Entity;

    public partial class ZollContext : DbContext
    {
        public ZollContext()
            : base("name=ZollContext")
        {
        }

        public virtual DbSet<Filiale> FILIALE { get; set; }
        public virtual DbSet<Min_Steu> MIN_STEU { get; set; }
        public virtual DbSet<Zoll> ZOLL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filiale>()
                .Property(e => e.BEZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Filiale>()
                .Property(e => e.KURZ_BEZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Filiale>()
                .Property(e => e.OLGA_NR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Filiale>()
                .Property(e => e.Handel_NR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Min_Steu>()
                .Property(e => e.BEZEICHNUNG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Min_Steu>()
                .Property(e => e.BETRAG_TO)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.LIEF_NR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.KU_NR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.RECH_NR)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.ZOLL_KZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.MNG_KG_AUSG)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.CUBEWARE_KZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.ANG_BEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.AEN_BEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zoll>()
                .Property(e => e.MNG_KG_EING)
                .HasPrecision(10, 2);
        }
    }
}
