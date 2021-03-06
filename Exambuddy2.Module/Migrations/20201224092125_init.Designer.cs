﻿// <auto-generated />
using System;
using Exambuddy2.Module.BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exambuddy2.Module.Migrations
{
    [DbContext(typeof(Exambuddy2EFCoreDbContext))]
    [Migration("20201224092125_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DevExpress.ExpressApp.EFCore.Updating.ModuleInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AssemblyFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ModulesInfo");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.ModelDifference", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ContextId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ModelDifferences");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.ModelDifferenceAspect", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerID")
                        .HasColumnType("int");

                    b.Property<string>("Xml")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OwnerID");

                    b.ToTable("ModelDifferenceAspects");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyActionPermissionObject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("PermissionPolicyActionPermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyMemberPermissionsObject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Criteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Members")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReadState")
                        .HasColumnType("int");

                    b.Property<int?>("TypePermissionObjectID")
                        .HasColumnType("int");

                    b.Property<int?>("WriteState")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TypePermissionObjectID");

                    b.ToTable("PermissionPolicyMemberPermissionsObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyNavigationPermissionObject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ItemPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NavigateState")
                        .HasColumnType("int");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("TargetTypeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("PermissionPolicyNavigationPermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyObjectPermissionsObject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Criteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeleteState")
                        .HasColumnType("int");

                    b.Property<int?>("NavigateState")
                        .HasColumnType("int");

                    b.Property<int?>("ReadState")
                        .HasColumnType("int");

                    b.Property<int?>("TypePermissionObjectID")
                        .HasColumnType("int");

                    b.Property<int?>("WriteState")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TypePermissionObjectID");

                    b.ToTable("PermissionPolicyObjectPermissionsObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("CanEditModel")
                        .HasColumnType("bit");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdministrative")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAllowPermissionPriority")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermissionPolicy")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PermissionPolicyRoleBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PermissionPolicyRoleBase");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CreateState")
                        .HasColumnType("int");

                    b.Property<int?>("DeleteState")
                        .HasColumnType("int");

                    b.Property<int?>("NavigateState")
                        .HasColumnType("int");

                    b.Property<int?>("ReadState")
                        .HasColumnType("int");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("TargetTypeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WriteState")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("PermissionPolicyTypePermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ChangePasswordOnFirstLogon")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("StoredPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.ReportDataV2", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DataTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInplaceReport")
                        .HasColumnType("bit");

                    b.Property<string>("ParametersObjectTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PredefinedReportTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ReportDataV2");
                });

            modelBuilder.Entity("PermissionPolicyRolePermissionPolicyUser", b =>
                {
                    b.Property<int>("RolesID")
                        .HasColumnType("int");

                    b.Property<int>("UsersID")
                        .HasColumnType("int");

                    b.HasKey("RolesID", "UsersID");

                    b.HasIndex("UsersID");

                    b.ToTable("PermissionPolicyRolePermissionPolicyUser");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRole", b =>
                {
                    b.HasBaseType("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase");

                    b.HasDiscriminator().HasValue("PermissionPolicyRole");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.ModelDifferenceAspect", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.ModelDifference", "Owner")
                        .WithMany("Aspects")
                        .HasForeignKey("OwnerID");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyActionPermissionObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", "Role")
                        .WithMany("ActionPermissions")
                        .HasForeignKey("RoleID");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyMemberPermissionsObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", "TypePermissionObject")
                        .WithMany("MemberPermissions")
                        .HasForeignKey("TypePermissionObjectID");

                    b.Navigation("TypePermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyNavigationPermissionObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", "Role")
                        .WithMany("NavigationPermissions")
                        .HasForeignKey("RoleID");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyObjectPermissionsObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", "TypePermissionObject")
                        .WithMany("ObjectPermissions")
                        .HasForeignKey("TypePermissionObjectID");

                    b.Navigation("TypePermissionObject");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", "Role")
                        .WithMany("TypePermissions")
                        .HasForeignKey("RoleID");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PermissionPolicyRolePermissionPolicyUser", b =>
                {
                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRole", null)
                        .WithMany()
                        .HasForeignKey("RolesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyUser", null)
                        .WithMany()
                        .HasForeignKey("UsersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.ModelDifference", b =>
                {
                    b.Navigation("Aspects");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRoleBase", b =>
                {
                    b.Navigation("ActionPermissions");

                    b.Navigation("NavigationPermissions");

                    b.Navigation("TypePermissions");
                });

            modelBuilder.Entity("DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyTypePermissionObject", b =>
                {
                    b.Navigation("MemberPermissions");

                    b.Navigation("ObjectPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
