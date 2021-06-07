using System;
using DataService.BaseConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class NCTTContext : BaseDbContext
    {
        public NCTTContext()
        {
        }

        public NCTTContext(DbContextOptions<NCTTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FileResponse> FileResponses { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationFormSetting> LocationFormSettings { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<Response> Responses { get; set; }
        public virtual DbSet<ResponseDetail> ResponseDetails { get; set; }
        public virtual DbSet<ResponseQuestion> ResponseQuestions { get; set; }
        public virtual DbSet<ResponseSection> ResponseSections { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleClaim> RoleClaims { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAssign> UserAssigns { get; set; }
        public virtual DbSet<UserClaim> UserClaims { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserToken> UserTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FileResponse>(entity =>
            {
                entity.HasIndex(e => e.ResponseDetailId, "IX_FileResponses_ResponseDetailId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.HasOne(d => d.ResponseDetail)
                    .WithMany(p => p.FileResponses)
                    .HasForeignKey(d => d.ResponseDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasIndex(e => e.ProjectId, "IX_Forms_ProjectId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Gps).HasColumnName("GPS");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.Province).HasMaxLength(255);

                entity.Property(e => e.Ward).HasMaxLength(255);
            });

            modelBuilder.Entity<LocationFormSetting>(entity =>
            {
                entity.HasIndex(e => e.FormId, "IX_LocationFormSettings_FormId");

                entity.HasIndex(e => e.LocationId, "IX_LocationFormSettings_LocationId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.LocationFormSettings)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationFormSettings)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("Option");

                entity.HasIndex(e => e.NextQuestionId, "IX_Option_NextQuestionId");

                entity.HasIndex(e => e.NextSectionId, "IX_Option_NextSectionId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupName).HasMaxLength(255);

                entity.Property(e => e.TextValue).HasMaxLength(1000);

                entity.HasOne(d => d.NextQuestion)
                    .WithMany(p => p.Options)
                    .HasForeignKey(d => d.NextQuestionId);

                entity.HasOne(d => d.NextSection)
                    .WithMany(p => p.Options)
                    .HasForeignKey(d => d.NextSectionId);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => e.CreatedUserId, "IX_Projects_CreatedUserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedId).HasColumnName("CreatedID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CreatedUserId);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasIndex(e => e.PreQuestionId, "IX_Questions_PreQuestionId");

                entity.HasIndex(e => e.QuestionTypeId, "IX_Questions_QuestionTypeId");

                entity.HasIndex(e => e.SectionId, "IX_Questions_SectionId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptedExtension).HasMaxLength(255);

                entity.Property(e => e.AllowGps).HasColumnName("AllowGPS");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TimesEmotion).HasMaxLength(255);

                entity.HasOne(d => d.PreQuestion)
                    .WithMany(p => p.InversePreQuestion)
                    .HasForeignKey(d => d.PreQuestionId);

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Response>(entity =>
            {
                entity.HasIndex(e => e.FormId, "IX_Responses_FormId");

                entity.HasIndex(e => e.LocationId, "IX_Responses_LocationId");

                entity.HasIndex(e => e.UserId, "IX_Responses_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnableCameraOn).HasColumnName("EnableCameraON");

                entity.Property(e => e.MicrophoneOn).HasColumnName("MicrophoneON");

                entity.Property(e => e.RecordOn).HasColumnName("RecordON");

                entity.Property(e => e.RecordValue).HasMaxLength(255);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ResponseDetail>(entity =>
            {
                entity.HasIndex(e => e.ResponseQuestionId, "IX_ResponseDetails_ResponseQuestionId");

                entity.HasIndex(e => e.ValueOptionColumnId, "IX_ResponseDetails_ValueOptionColumnId");

                entity.HasIndex(e => e.ValueOptionRowId, "IX_ResponseDetails_ValueOptionRowId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Emotion).HasMaxLength(255);

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.MeasureEmotion).HasMaxLength(255);

                entity.HasOne(d => d.ResponseQuestion)
                    .WithMany(p => p.ResponseDetails)
                    .HasForeignKey(d => d.ResponseQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ValueOptionColumn)
                    .WithMany(p => p.ResponseDetailValueOptionColumns)
                    .HasForeignKey(d => d.ValueOptionColumnId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ValueOptionRow)
                    .WithMany(p => p.ResponseDetailValueOptionRows)
                    .HasForeignKey(d => d.ValueOptionRowId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ResponseQuestion>(entity =>
            {
                entity.HasIndex(e => e.QuestionId, "IX_ResponseQuestions_QuestionId");

                entity.HasIndex(e => e.ResponseId, "IX_ResponseQuestions_ResponseId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ResponseQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Response)
                    .WithMany(p => p.ResponseQuestions)
                    .HasForeignKey(d => d.ResponseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ResponseSection>(entity =>
            {
                entity.HasIndex(e => e.ResponseId, "IX_ResponseSections_ResponseId");

                entity.HasIndex(e => e.SectionId, "IX_ResponseSections_SectionId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Response)
                    .WithMany(p => p.ResponseSections)
                    .HasForeignKey(d => d.ResponseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.ResponseSections)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<RoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_RoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasIndex(e => e.FormId, "IX_Sections_FormId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.Sections)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<UserAssign>(entity =>
            {
                entity.HasIndex(e => e.ProjectId, "IX_UserAssigns_ProjectId");

                entity.HasIndex(e => e.UserId, "IX_UserAssigns_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.UserAssigns)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAssigns)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_UserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_UserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
