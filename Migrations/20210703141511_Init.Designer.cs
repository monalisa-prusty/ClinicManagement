// <auto-generated />
using System;
using ClinicManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicManagementProject.Migrations
{
    [DbContext(typeof(ClinicManagementContext))]
    [Migration("20210703141511_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClinicManagementProject.Models.Admin", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("username");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ClinicManagementProject.Models.ConsultationDetail", b =>
                {
                    b.Property<int>("Consultation_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bill")
                        .HasColumnType("int");

                    b.Property<string>("Consultation_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Consultation_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.HasKey("Consultation_Id");

                    b.HasIndex("Doctor_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("ConsultationDetails");

                    b.HasData(
                        new
                        {
                            Consultation_Id = 1,
                            Bill = 0,
                            Consultation_Remarks = "",
                            Consultation_Status = "Öpened",
                            Date = new DateTime(2021, 7, 3, 22, 15, 11, 90, DateTimeKind.Local).AddTicks(4600),
                            Doctor_Id = 1,
                            Patient_Id = 1
                        });
                });

            modelBuilder.Entity("ClinicManagementProject.Models.Doctor", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Doctor_Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Doctor_Id = 1,
                            Age = 30,
                            Gender = "Male",
                            Name = "TimDoc",
                            Password = new byte[] { 0 },
                            PasswordSalt = new byte[] { 0 },
                            Phone = "323524523",
                            Username = "docabc"
                        },
                        new
                        {
                            Doctor_Id = 2,
                            Age = 30,
                            Gender = "Male",
                            Name = "TiDoc",
                            Password = new byte[] { 0, 0 },
                            PasswordSalt = new byte[] { 0, 0 },
                            Phone = "323524523",
                            Username = "docoof"
                        });
                });

            modelBuilder.Entity("ClinicManagementProject.Models.DoctorSchedule", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<int>("Timeslot_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Doctor_Id", "Timeslot_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("DoctorSchedule");

                    b.HasData(
                        new
                        {
                            Doctor_Id = 1,
                            Timeslot_Id = 1,
                            Time = "930-1030"
                        },
                        new
                        {
                            Doctor_Id = 1,
                            Timeslot_Id = 2,
                            Time = "1330-1430"
                        },
                        new
                        {
                            Doctor_Id = 2,
                            Timeslot_Id = 1,
                            Time = "930-1030"
                        },
                        new
                        {
                            Doctor_Id = 2,
                            Timeslot_Id = 2,
                            Time = "1330-1430"
                        });
                });

            modelBuilder.Entity("ClinicManagementProject.Models.Patient", b =>
                {
                    b.Property<int>("Patient_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Password")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Patient_Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Patient_Id = 1,
                            Age = 30,
                            Gender = "Male",
                            Name = "Tim",
                            Password = new byte[] { 0 },
                            PasswordSalt = new byte[] { 0 },
                            Phone = "32423434",
                            Username = "abc"
                        });
                });

            modelBuilder.Entity("ClinicManagementProject.Models.ConsultationDetail", b =>
                {
                    b.HasOne("ClinicManagementProject.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("Doctor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagementProject.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicManagementProject.Models.DoctorSchedule", b =>
                {
                    b.HasOne("ClinicManagementProject.Models.Doctor", "Doctor")
                        .WithMany("DoctorScheduleSlots")
                        .HasForeignKey("Doctor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagementProject.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("Patient_Id");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicManagementProject.Models.Doctor", b =>
                {
                    b.Navigation("DoctorScheduleSlots");
                });
#pragma warning restore 612, 618
        }
    }
}
