namespace Marat.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextModels : DbContext
    {
        public ContextModels()
            : base("name=ContextModels")
        {
        }

        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Frame> Frames { get; set; }
        public virtual DbSet<Playment> Playments { get; set; }
        public virtual DbSet<Postiton> Postitons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>()
                .HasMany(e => e.Frames)
                .WithRequired(e => e.Applicant)
                .HasForeignKey(e => e.ApplicantsID);

            modelBuilder.Entity<Playment>()
                .HasMany(e => e.Frames)
                .WithRequired(e => e.Playment)
                .HasForeignKey(e => e.PlaymentsID);

            modelBuilder.Entity<Postiton>()
                .HasMany(e => e.Frames)
                .WithRequired(e => e.Postiton)
                .HasForeignKey(e => e.PositionID);
        }
    }
}
