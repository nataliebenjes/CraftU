﻿// <auto-generated />
using System;
using CraftU.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CraftU.Migrations
{
    [DbContext(typeof(CraftUContext))]
    partial class CraftUContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CraftU.Models.CraftCourse", b =>
                {
                    b.Property<int>("CraftCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseDate")
                        .HasColumnType("longtext");

                    b.Property<string>("CourseName")
                        .HasColumnType("longtext");

                    b.HasKey("CraftCourseId");

                    b.ToTable("CraftCourses");
                });

            modelBuilder.Entity("CraftU.Models.CraftCourseStudent", b =>
                {
                    b.Property<int>("CraftCourseStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CourseStudentId")
                        .HasColumnType("int");

                    b.Property<int?>("CraftCourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CraftCourseStudentId");

                    b.HasIndex("CraftCourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("CraftCourseStudent");
                });

            modelBuilder.Entity("CraftU.Models.CraftCourseSupply", b =>
                {
                    b.Property<int>("CraftCourseSupplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CraftCourseId")
                        .HasColumnType("int");

                    b.Property<int>("SupplyId")
                        .HasColumnType("int");

                    b.HasKey("CraftCourseSupplyId");

                    b.HasIndex("CraftCourseId");

                    b.HasIndex("SupplyId");

                    b.ToTable("CraftCourseSupply");
                });

            modelBuilder.Entity("CraftU.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CraftCourseId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("longtext");

                    b.HasKey("StudentId");

                    b.HasIndex("CraftCourseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CraftU.Models.Supply", b =>
                {
                    b.Property<int>("SupplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CraftCourseId")
                        .HasColumnType("int");

                    b.Property<int>("SupplyCost")
                        .HasColumnType("int");

                    b.Property<string>("SupplyName")
                        .HasColumnType("longtext");

                    b.HasKey("SupplyId");

                    b.HasIndex("CraftCourseId");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("CraftU.Models.CraftCourseStudent", b =>
                {
                    b.HasOne("CraftU.Models.CraftCourse", "CraftCourse")
                        .WithMany("JoinEntities")
                        .HasForeignKey("CraftCourseId");

                    b.HasOne("CraftU.Models.Student", "Student")
                        .WithMany("JoinEntities")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CraftCourse");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CraftU.Models.CraftCourseSupply", b =>
                {
                    b.HasOne("CraftU.Models.CraftCourse", "CraftCourse")
                        .WithMany("JoinMoreEntities")
                        .HasForeignKey("CraftCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CraftU.Models.Supply", "Supply")
                        .WithMany("JoinEntities")
                        .HasForeignKey("SupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CraftCourse");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("CraftU.Models.Student", b =>
                {
                    b.HasOne("CraftU.Models.CraftCourse", null)
                        .WithMany("Students")
                        .HasForeignKey("CraftCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CraftU.Models.Supply", b =>
                {
                    b.HasOne("CraftU.Models.CraftCourse", null)
                        .WithMany("Supplies")
                        .HasForeignKey("CraftCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CraftU.Models.CraftCourse", b =>
                {
                    b.Navigation("JoinEntities");

                    b.Navigation("JoinMoreEntities");

                    b.Navigation("Students");

                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("CraftU.Models.Student", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("CraftU.Models.Supply", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
