﻿// <auto-generated />
using System;
using ClassroomManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassroomManagement.Migrations
{
    [DbContext(typeof(ClassroomManagementContext))]
    [Migration("20231020085026_rename_class")]
    partial class renameclass
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassroomManagement.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Provas", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Professores", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Models.ProfessorSubject", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId", "ProfessorId");

                    b.HasIndex("ProfessorId")
                        .IsUnique();

                    b.ToTable("ProfessorMateria", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alunos", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Models.SubJect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubjectName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Materias", (string)null);
                });

            modelBuilder.Entity("ClassroomManagement.Models.Exam", b =>
                {
                    b.HasOne("ClassroomManagement.Models.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassroomManagement.Models.SubJect", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ClassroomManagement.Models.Professor", b =>
                {
                    b.HasOne("ClassroomManagement.Models.SubJect", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ClassroomManagement.Models.ProfessorSubject", b =>
                {
                    b.HasOne("ClassroomManagement.Models.Professor", "Professor")
                        .WithOne("ProfessorSubject")
                        .HasForeignKey("ClassroomManagement.Models.ProfessorSubject", "ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassroomManagement.Models.SubJect", "Subject")
                        .WithMany("ProfessorSubject")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("ClassroomManagement.Models.Professor", b =>
                {
                    b.Navigation("ProfessorSubject");
                });

            modelBuilder.Entity("ClassroomManagement.Models.Student", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("ClassroomManagement.Models.SubJect", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("ProfessorSubject");
                });
#pragma warning restore 612, 618
        }
    }
}
