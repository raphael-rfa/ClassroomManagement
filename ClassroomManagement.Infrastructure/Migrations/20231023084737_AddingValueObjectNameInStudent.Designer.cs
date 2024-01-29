﻿// <auto-generated />
using System;
using ClassroomManagement.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassroomManagement.Infrastucture.Migrations
{
    [DbContext(typeof(ClassroomManagementContext))]
    [Migration("20231023084737_AddingValueObjectNameInStudent")]
    partial class AddingValueObjectNameInStudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exam", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Professor", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.ProfessorSubject", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "ProfessorId");

                    b.HasIndex("ProfessorId")
                        .IsUnique();

                    b.ToTable("ProfessorSubject", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Exam", b =>
                {
                    b.HasOne("ClassroomManagement.Domain.Entities.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassroomManagement.Domain.Entities.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Professor", b =>
                {
                    b.HasOne("ClassroomManagement.Domain.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.ProfessorSubject", b =>
                {
                    b.HasOne("ClassroomManagement.Domain.Entities.Professor", "Professor")
                        .WithOne("ProfessorSubject")
                        .HasForeignKey("ClassroomManagement.Domain.Entities.ProfessorSubject", "ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassroomManagement.Domain.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Student", b =>
                {
                    b.OwnsOne("ClassroomManagement.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<int>("StudentId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LastName");

                            b1.HasKey("StudentId");

                            b1.ToTable("Student");

                            b1.WithOwner()
                                .HasForeignKey("StudentId");
                        });

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Professor", b =>
                {
                    b.Navigation("ProfessorSubject");
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Student", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("ClassroomManagement.Domain.Entities.Subject", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
