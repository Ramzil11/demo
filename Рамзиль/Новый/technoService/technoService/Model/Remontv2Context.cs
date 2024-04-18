using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace technoServise.Model;

public partial class Remontv2Context : DbContext
{
    public Remontv2Context()
    {
    }

    public Remontv2Context(DbContextOptions<Remontv2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ClientsTable> ClientsTables { get; set; }

    public virtual DbSet<PerformersTable> PerformersTables { get; set; }

    public virtual DbSet<RequestsTable> RequestsTables { get; set; }

    public virtual DbSet<RolesTable> RolesTables { get; set; }

    public virtual DbSet<ServicesTable> ServicesTables { get; set; }

    public virtual DbSet<StaffsTable> StaffsTables { get; set; }

    public virtual DbSet<StatusTable> StatusTables { get; set; }

    public virtual DbSet<TypeFaultTable> TypeFaultTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseLazyLoadingProxies().UseMySql("server=localhost;user=root;password=2424213571;database=remontv2", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<ClientsTable>(entity =>
        {
            entity.HasKey(e => e.IdClient).HasName("PRIMARY");

            entity.ToTable("clients_table");

            entity.Property(e => e.IdClient).HasColumnName("id_client");
            entity.Property(e => e.ClientName)
                .HasMaxLength(45)
                .HasColumnName("clientName");
            entity.Property(e => e.ClientPhone)
                .HasMaxLength(45)
                .HasColumnName("clientPhone");
            entity.Property(e => e.ClientSurname)
                .HasMaxLength(45)
                .HasColumnName("clientSurname");
        });

        modelBuilder.Entity<PerformersTable>(entity =>
        {
            entity.HasKey(e => e.StuffId).HasName("PRIMARY");

            entity.ToTable("performers_table");

            entity.HasIndex(e => e.RequestId, "request_fkey_idx");

            entity.HasIndex(e => e.StuffId, "stuff_fkey_idx");

            entity.Property(e => e.StuffId)
                .ValueGeneratedNever()
                .HasColumnName("stuffId");
            entity.Property(e => e.RequestId).HasColumnName("requestId");

            entity.HasOne(d => d.Request).WithMany(p => p.PerformersTables)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("request_fkey");

            entity.HasOne(d => d.Stuff).WithOne(p => p.PerformersTable)
                .HasForeignKey<PerformersTable>(d => d.StuffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("stuff_fkey");
        });

        modelBuilder.Entity<RequestsTable>(entity =>
        {
            entity.HasKey(e => e.IdRequest).HasName("PRIMARY");

            entity.ToTable("requests_table");

            entity.HasIndex(e => e.RequestClietnId, "client_fk_idx");

            entity.HasIndex(e => e.RequestStatusId, "status_fk_idx");

            entity.HasIndex(e => e.RequestTypeFaultId, "type_fk_idx");

            entity.Property(e => e.IdRequest).HasColumnName("id_request");
            entity.Property(e => e.RequestClietnId).HasColumnName("requestClietnId");
            entity.Property(e => e.RequestComment)
                .HasColumnType("text")
                .HasColumnName("requestComment");
            entity.Property(e => e.RequestCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("requestCreateDate");
            entity.Property(e => e.RequestFinishedDate)
                .HasColumnType("datetime")
                .HasColumnName("requestFinishedDate");
            entity.Property(e => e.RequestPriority)
                .HasColumnType("enum('Низкое','Среднее','Высокое')")
                .HasColumnName("requestPriority");
            entity.Property(e => e.RequestStatusId).HasColumnName("requestStatusId");
            entity.Property(e => e.RequestTypeFaultId).HasColumnName("requestTypeFaultId");
            entity.Property(e => e.RequestsDescription)
                .HasColumnType("text")
                .HasColumnName("requestsDescription");
            entity.Property(e => e.ReuestEquipment)
                .HasMaxLength(45)
                .HasColumnName("reuestEquipment");

            entity.HasOne(d => d.RequestClietn).WithMany(p => p.RequestsTables)
                .HasForeignKey(d => d.RequestClietnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_fk");

            entity.HasOne(d => d.RequestStatus).WithMany(p => p.RequestsTables)
                .HasForeignKey(d => d.RequestStatusId)
                .HasConstraintName("status_fk");

            entity.HasOne(d => d.RequestTypeFault).WithMany(p => p.RequestsTables)
                .HasForeignKey(d => d.RequestTypeFaultId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("type_fk");
        });

        modelBuilder.Entity<RolesTable>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("roles_table");

            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.RoleName)
                .HasMaxLength(45)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<ServicesTable>(entity =>
        {
            entity.HasKey(e => e.IdServices).HasName("PRIMARY");

            entity.ToTable("services_table");

            entity.HasIndex(e => e.ServicesRequestId, "req_fk_idx");

            entity.Property(e => e.IdServices).HasColumnName("id_services");
            entity.Property(e => e.ServicesCost)
                .HasPrecision(19, 2)
                .HasColumnName("servicesCost");
            entity.Property(e => e.ServicesCount).HasColumnName("servicesCount");
            entity.Property(e => e.ServicesDate)
                .HasColumnType("datetime")
                .HasColumnName("servicesDate");
            entity.Property(e => e.ServicesName)
                .HasMaxLength(45)
                .HasColumnName("servicesName");
            entity.Property(e => e.ServicesRequestId).HasColumnName("servicesRequestId");

            entity.HasOne(d => d.ServicesRequest).WithMany(p => p.ServicesTables)
                .HasForeignKey(d => d.ServicesRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("req_fk");
        });

        modelBuilder.Entity<StaffsTable>(entity =>
        {
            entity.HasKey(e => e.IdStaff).HasName("PRIMARY");

            entity.ToTable("staffs_table");

            entity.HasIndex(e => e.StaffRoleId, "role_fkey_idx");

            entity.HasIndex(e => e.StuffLogin, "stuffLogin_UNIQUE").IsUnique();

            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.StaffName)
                .HasMaxLength(45)
                .HasColumnName("staffName");
            entity.Property(e => e.StaffPassword)
                .HasMaxLength(45)
                .HasColumnName("staffPassword");
            entity.Property(e => e.StaffPhone)
                .HasMaxLength(45)
                .HasColumnName("staffPhone");
            entity.Property(e => e.StaffRoleId).HasColumnName("staffRoleId");
            entity.Property(e => e.StaffSurname)
                .HasMaxLength(45)
                .HasColumnName("staffSurname");
            entity.Property(e => e.StuffLogin)
                .HasMaxLength(45)
                .HasColumnName("stuffLogin");

            entity.HasOne(d => d.StaffRole).WithMany(p => p.StaffsTables)
                .HasForeignKey(d => d.StaffRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("role_fkey");
        });

        modelBuilder.Entity<StatusTable>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("status_table");

            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.StatusName)
                .HasMaxLength(45)
                .HasColumnName("statusName");
        });

        modelBuilder.Entity<TypeFaultTable>(entity =>
        {
            entity.HasKey(e => e.IdTypeFault).HasName("PRIMARY");

            entity.ToTable("type_fault_table");

            entity.Property(e => e.IdTypeFault).HasColumnName("id_typeFault");
            entity.Property(e => e.TypeFaultName)
                .HasMaxLength(45)
                .HasColumnName("typeFaultName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
