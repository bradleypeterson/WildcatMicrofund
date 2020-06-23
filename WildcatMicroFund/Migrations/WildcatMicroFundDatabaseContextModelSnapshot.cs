﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WildcatMicroFund.Data.Context;

namespace WildcatMicrofund.Migrations
{
    [DbContext(typeof(WildcatMicroFundDatabaseContext))]
    partial class WildcatMicroFundDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Application", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AttendedWorkshop")
                        .HasColumnType("bit");

                    b.Property<int>("BusinessID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateApplied")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfDecision")
                        .HasColumnType("datetime2");

                    b.Property<int>("SurveyID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BusinessID");

                    b.HasIndex("SurveyID");

                    b.HasIndex("UserID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Business", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Choice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChoiceText")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.DateResponse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResponseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("ResponseID")
                        .IsUnique();

                    b.ToTable("DateResponses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Ethnicity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EthnicityDescription")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Ethnicities");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Gender", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.MultipleChoiceResponse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChoiceID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("ResponseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ChoiceID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("ResponseID");

                    b.ToTable("MultipleChoiceResponses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.NumericResponse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("ResponseID")
                        .HasColumnType("int");

                    b.Property<int>("ResponseNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("ResponseID")
                        .IsUnique();

                    b.ToTable("NumericResponses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionNumber")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("QuestionTypeID")
                        .HasColumnType("int");

                    b.Property<int>("SurveyCodeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionTypeID");

                    b.HasIndex("SurveyCodeID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.QuestionType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("QuestionTypeHasChoices")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionTypeName")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.HasKey("ID");

                    b.ToTable("QuestionTypes");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Response", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ResponseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SurveyID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SurveyID");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.SingleChoiceResponse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChoiceID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("ResponseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ChoiceID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("ResponseID")
                        .IsUnique();

                    b.ToTable("SingleChoiceResponses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Survey", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SurveyCodeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SurveyCodeID");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.SurveyCode", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SurveyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SurveyCodes");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.TextResponse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("ResponseID")
                        .HasColumnType("int");

                    b.Property<string>("ResponseText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("ResponseID")
                        .IsUnique();

                    b.ToTable("TextResponses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<int>("EthnicityID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("GenderID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EthnicityID");

                    b.HasIndex("GenderID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.UserBusiness", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BusinessID");

                    b.HasIndex("UserID");

                    b.ToTable("UserBusinesses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.UserRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.YesNoResponse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("ResponseID")
                        .HasColumnType("int");

                    b.Property<bool>("YesNoResponseValue")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("ResponseID")
                        .IsUnique();

                    b.ToTable("YesNoResponses");
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Application", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Business", "Business")
                        .WithMany("Applications")
                        .HasForeignKey("BusinessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Survey", "Survey")
                        .WithMany("Applications")
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.User", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Choice", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Question", null)
                        .WithMany("Choices")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.DateResponse", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Question", "Question")
                        .WithMany("DateResponses")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Response", "Response")
                        .WithOne("DateResponse")
                        .HasForeignKey("WildcatMicroFund.Data.Models.DateResponse", "ResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.MultipleChoiceResponse", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Choice", "Choice")
                        .WithMany()
                        .HasForeignKey("ChoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Question", "Question")
                        .WithMany("MultipleChoiceResponses")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Response", "Response")
                        .WithMany("MultipleChoiceResponses")
                        .HasForeignKey("ResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.NumericResponse", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Question", "Question")
                        .WithMany("NumericResponses")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Response", "Response")
                        .WithOne("NumericResponse")
                        .HasForeignKey("WildcatMicroFund.Data.Models.NumericResponse", "ResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Question", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.QuestionType", "QuestionType")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.SurveyCode", "SurveyCode")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyCodeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Response", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Survey", "Survey")
                        .WithMany("Responses")
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.SingleChoiceResponse", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Choice", "Choice")
                        .WithMany()
                        .HasForeignKey("ChoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Question", "Question")
                        .WithMany("SingleChoiceResponses")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Response", "Response")
                        .WithOne("SingleChoiceResponse")
                        .HasForeignKey("WildcatMicroFund.Data.Models.SingleChoiceResponse", "ResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.Survey", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.SurveyCode", "SurveyCode")
                        .WithMany("Surveys")
                        .HasForeignKey("SurveyCodeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.TextResponse", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Question", "Question")
                        .WithMany("TextResponses")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Response", "Response")
                        .WithOne("TextResponse")
                        .HasForeignKey("WildcatMicroFund.Data.Models.TextResponse", "ResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.User", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Ethnicity", "Ethnicity")
                        .WithMany("Users")
                        .HasForeignKey("EthnicityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.UserBusiness", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Business", "Business")
                        .WithMany("UserBusinesses")
                        .HasForeignKey("BusinessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.User", "User")
                        .WithMany("UserBusinesses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.UserRole", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildcatMicroFund.Data.Models.YesNoResponse", b =>
                {
                    b.HasOne("WildcatMicroFund.Data.Models.Question", "Question")
                        .WithMany("YesNoResponses")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildcatMicroFund.Data.Models.Response", "Response")
                        .WithOne("YesNoResponse")
                        .HasForeignKey("WildcatMicroFund.Data.Models.YesNoResponse", "ResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
