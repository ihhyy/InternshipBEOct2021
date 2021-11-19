using System;
using DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandidateUser", b =>
                {
                    b.Property<int>("CandidatesId")
                        .HasColumnType("int");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CandidatesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("CandidateUser");
                });

            modelBuilder.Entity("CountryInternship", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("InternshipsId")
                        .HasColumnType("int");

                    b.HasKey("CountriesId", "InternshipsId");

                    b.HasIndex("InternshipsId");

                    b.ToTable("CountryInternship");
                });

            modelBuilder.Entity("DAL.Entities.BestContactTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BestContactTimes");
                });

            modelBuilder.Entity("DAL.Entities.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BestContactTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnglishLevelType")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InternshipId")
                        .HasColumnType("int");

                    b.Property<int?>("InternshipLanguage")
                        .HasColumnType("int");

                    b.Property<bool>("IsPlanningToJoin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Links")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimarySkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfessionalCertificates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Skype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StackType")
                        .HasColumnType("int");

                    b.Property<int>("StatusType")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("TestTaskEvaluation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InternshipId");

                    b.HasIndex("TeamId");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BestContactTime = new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(6471),
                            CurrentJob = "Student",
                            Education = "Harvard University",
                            Email = "j.snow@gmail.com",
                            EnglishLevelType = 4,
                            FirstName = "John",
                            InternshipId = 1,
                            IsPlanningToJoin = true,
                            LastName = "Snow",
                            Links = "-",
                            Location = "USA",
                            OtherInfo = "-",
                            Phone = "+123456789",
                            PrimarySkill = "OOP, C#",
                            ProfessionalCertificates = "-",
                            RegistrationDate = new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(8246),
                            Skype = "live:j.snow",
                            StackType = 1,
                            StatusType = 0,
                            TeamId = 1,
                            TestTaskEvaluation = 4
                        },
                        new
                        {
                            Id = 2,
                            BestContactTime = new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(9223),
                            CurrentJob = "Student",
                            Education = "Hogwarts",
                            Email = "h.granger@gmail.com",
                            EnglishLevelType = 5,
                            FirstName = "Hermione",
                            InternshipId = 2,
                            IsPlanningToJoin = true,
                            LastName = "Granger",
                            Links = "-",
                            Location = "UK",
                            OtherInfo = "-",
                            Phone = "+2356416789",
                            PrimarySkill = "C++, QA basics",
                            ProfessionalCertificates = "-",
                            RegistrationDate = new DateTime(2021, 11, 18, 12, 39, 58, 396, DateTimeKind.Utc).AddTicks(9228),
                            Skype = "live:h.granger",
                            StackType = 5,
                            StatusType = 0,
                            TeamId = 2,
                            TestTaskEvaluation = 4
                        });
                });

            modelBuilder.Entity("DAL.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Belarus"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Russia"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ukraine"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Evaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeedbackId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FeedbackId");

                    b.HasIndex("SkillId");

                    b.ToTable("Evaluations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FeedbackId = 1,
                            SkillId = 1,
                            Value = 4
                        },
                        new
                        {
                            Id = 2,
                            FeedbackId = 2,
                            SkillId = 2,
                            Value = 4
                        });
                });

            modelBuilder.Entity("DAL.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnglishLevelType")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CandidateId = 1,
                            Date = new DateTime(2021, 11, 18, 12, 39, 58, 397, DateTimeKind.Utc).AddTicks(3368),
                            Description = "Good knowledge of frameworks, oop, and db",
                            EnglishLevelType = 4,
                            UserId = "cacb6ec0-d46a-4560-8ae1-e7e813e48435"
                        },
                        new
                        {
                            Id = 2,
                            CandidateId = 2,
                            Date = new DateTime(2021, 11, 18, 12, 39, 58, 397, DateTimeKind.Utc).AddTicks(4353),
                            Description = "Excellent candidate",
                            EnglishLevelType = 5,
                            UserId = "cacb6ec0-d46a-4560-8ae1-e7e813e48435"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Internship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InternshipStatusType")
                        .HasColumnType("int");

                    b.Property<int>("LanguageType")
                        .HasColumnType("int");

                    b.Property<int>("MaxCandidateCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationFinishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RegistrationStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Internships");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(4364),
                            ImageLink = "https://drive.google.com/file/d/1tH7hcl7K2kM4HHC6QVXRdq0LPU8yZwd9/view?usp=sharing",
                            InternshipStatusType = 0,
                            LanguageType = 0,
                            MaxCandidateCount = 50,
                            Name = "JS/>NET",
                            RegistrationFinishDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(5671),
                            RegistrationStartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(5338),
                            Requirements = "OOP, JS, C#, .Net, Angular/React",
                            StartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(3949)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6945),
                            ImageLink = "https://drive.google.com/file/d/1bvaKnWq0XEuldc4zry3qnrFtZoNRtW5R/view?usp=sharing",
                            InternshipStatusType = 0,
                            LanguageType = 0,
                            MaxCandidateCount = 30,
                            Name = "QA Automation",
                            RegistrationFinishDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6948),
                            RegistrationStartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6947),
                            Requirements = "Any programming language, QA basics",
                            StartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6942)
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6951),
                            ImageLink = "https://drive.google.com/file/d/1kirFfIPPxUbgOFNGNAk4CL6jf_lEOSKc/view?usp=sharing",
                            InternshipStatusType = 0,
                            LanguageType = 1,
                            MaxCandidateCount = 30,
                            Name = "GameDev",
                            RegistrationFinishDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6953),
                            RegistrationStartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6952),
                            Requirements = "OOP, Unity, C#, SQL",
                            StartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6950)
                        },
                        new
                        {
                            Id = 4,
                            EndDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6956),
                            ImageLink = "https://drive.google.com/file/d/1t-eClTKmOY4asHZkT6y_vvJNR4SMzKbB/view?usp=sharing",
                            InternshipStatusType = 0,
                            LanguageType = 1,
                            MaxCandidateCount = 30,
                            Name = "Angular/>NET",
                            RegistrationFinishDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6958),
                            RegistrationStartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6957),
                            Requirements = "OOP, JS, C#, .Net, Angular/React",
                            StartDate = new DateTime(2021, 11, 18, 12, 39, 58, 394, DateTimeKind.Utc).AddTicks(6955)
                        });
                });

            modelBuilder.Entity("DAL.Entities.InternshipStack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InternshipId")
                        .HasColumnType("int");

                    b.Property<int>("TechnologyStackType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InternshipId");

                    b.ToTable("InternshipStacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TechnologyStackType = 0
                        },
                        new
                        {
                            Id = 2,
                            TechnologyStackType = 1
                        },
                        new
                        {
                            Id = 3,
                            TechnologyStackType = 2
                        },
                        new
                        {
                            Id = 4,
                            TechnologyStackType = 3
                        },
                        new
                        {
                            Id = 5,
                            TechnologyStackType = 4
                        },
                        new
                        {
                            Id = 6,
                            TechnologyStackType = 5
                        });
                });

            modelBuilder.Entity("DAL.Entities.InterviewInvite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("UserId");

                    b.ToTable("InterviewInvites");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CandidateId = 1,
                            ContactDate = new DateTime(2021, 11, 18, 12, 39, 58, 398, DateTimeKind.Utc).AddTicks(7841),
                            UserId = "cacb6ec0-d46a-4560-8ae1-e7e813e48435"
                        },
                        new
                        {
                            Id = 2,
                            CandidateId = 2,
                            ContactDate = new DateTime(2021, 11, 18, 12, 39, 58, 398, DateTimeKind.Utc).AddTicks(8237),
                            UserId = "cacb6ec0-d46a-4560-8ae1-e7e813e48435"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsHardSkill")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StackType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsHardSkill = true,
                            Name = "OOP",
                            StackType = 1
                        },
                        new
                        {
                            Id = 2,
                            IsHardSkill = true,
                            Name = "Java",
                            StackType = 5
                        });
                });

            modelBuilder.Entity("DAL.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InternshipId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InternshipId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InternshipId = 1,
                            Name = "Team 1 A"
                        },
                        new
                        {
                            Id = 2,
                            InternshipId = 2,
                            Name = "Team 1 B"
                        });
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleType")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "cacb6ec0-d46a-4560-8ae1-e7e813e48435",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8f0909c6-6abe-4bbe-b7f9-e5eb32f9cbe0",
                            Email = "li@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "LI@GMAIL.COM",
                            NormalizedUserName = "MASHA",
                            PasswordHash = "AQAAAAEAACcQAAAAEAlczfPSZ1tg5vaxky0aj09emZ8AyP43EtlgZ7h9lx/hgEwPiGHxlMYqIuWOBwjTTQ==",
                            PhoneNumber = "+123656787",
                            PhoneNumberConfirmed = false,
                            Position = "BA",
                            RoleType = 1,
                            SecurityStamp = "E5BBMDK3I3PX6MZCUDSP2TGQMJNHIOU7",
                            TwoFactorEnabled = false,
                            UserName = "Masha"
                        },
                        new
                        {
                            Id = "80ca2ca5-7b81-4ffd-aaa6-7ac71f6078ba",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "610d2b70-947e-4973-b8f3-0a41a4f9ff69",
                            Email = "max@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "MAX@GMAIL.COM",
                            NormalizedUserName = "MAXIM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHERjUNTwVhyAN9IqcUMpUxulpd1jmfJwMDZN6n67q/56cu5crizhEU2b4MU2qYQqQ==",
                            PhoneNumber = "+125656787",
                            PhoneNumberConfirmed = false,
                            Position = "Back",
                            RoleType = 2,
                            SecurityStamp = "M3ZDA3WQP6J2ZVGKBIZHOE7GKC4BR2ZF",
                            TwoFactorEnabled = false,
                            UserName = "Maxim"
                        },
                        new
                        {
                            Id = "f92f8a61-5ddd-4e2b-8226-2fe2b53869f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "59c21d0d-9b8d-46cc-a31d-5369cb103381",
                            Email = "user@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "USER@EXAMPLE.COM",
                            NormalizedUserName = "DASHA",
                            PasswordHash = "AQAAAAEAACcQAAAAEO51w21Ahsz67NlygVd0wvKPrjllZbuEPBk9XqxaU3Pw85Fdm6qkEPqw511Ulf5jcg==",
                            PhoneNumber = "+325656787",
                            PhoneNumberConfirmed = false,
                            Position = "Front",
                            RoleType = 3,
                            SecurityStamp = "YZYNYT3QR6FM5GVYL4VRT3EX3RIOZIFC",
                            TwoFactorEnabled = false,
                            UserName = "Dasha"
                        },
                        new
                        {
                            Id = "a4f8a920-c29e-4b7f-8dc8-5164bde5bf78",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd59b706-080a-4d9a-9af8-46910457e85c",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ALEXANDR",
                            PasswordHash = "AQAAAAEAACcQAAAAEJBFcG3s/0X7aD29Y3Y0Ei3AXDvfxYVEGUc8/IKJttJmaClSixXyuaFPkaKw+9elmQ==",
                            PhoneNumber = "+325659787",
                            PhoneNumberConfirmed = false,
                            Position = "PO",
                            RoleType = 4,
                            SecurityStamp = "UINKYYTOYHJBL2UH6XWJROSF5RXQPAGS",
                            TwoFactorEnabled = false,
                            UserName = "Alexandr"
                        });
                });

            modelBuilder.Entity("InternshipUser", b =>
                {
                    b.Property<int>("InternshipsId")
                        .HasColumnType("int");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InternshipsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("InternshipUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "3ec26d6f-99c8-4b47-8247-4193e6403e2a",
                            ConcurrencyStamp = "f9b42900-3edc-4c14-9ea0-53cd15e1b1e4",
                            Name = "Hr",
                            NormalizedName = "HR"
                        },
                        new
                        {
                            Id = "51ae656e-ca29-42e2-a639-06e1e6bb8443",
                            ConcurrencyStamp = "dfb80d9e-1aa8-4d10-8c8b-0234dcdcf58c",
                            Name = "Interviewer",
                            NormalizedName = "INTERVIEWER"
                        },
                        new
                        {
                            Id = "b93162a7-7a16-4c2b-872b-0106444cbbc3",
                            ConcurrencyStamp = "da3dffa5-923a-42d6-b95e-007ab3382f55",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "6fae81b4-7c58-44cf-9a31-c2454ce98283",
                            ConcurrencyStamp = "7ed64f20-699b-4940-bb51-73c33fa492ef",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "cacb6ec0-d46a-4560-8ae1-e7e813e48435",
                            RoleId = "3ec26d6f-99c8-4b47-8247-4193e6403e2a"
                        },
                        new
                        {
                            UserId = "80ca2ca5-7b81-4ffd-aaa6-7ac71f6078ba",
                            RoleId = "51ae656e-ca29-42e2-a639-06e1e6bb8443"
                        },
                        new
                        {
                            UserId = "f92f8a61-5ddd-4e2b-8226-2fe2b53869f7",
                            RoleId = "b93162a7-7a16-4c2b-872b-0106444cbbc3"
                        },
                        new
                        {
                            UserId = "a4f8a920-c29e-4b7f-8dc8-5164bde5bf78",
                            RoleId = "6fae81b4-7c58-44cf-9a31-c2454ce98283"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TeamUser", b =>
                {
                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TeamsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("TeamUser");
                });

            modelBuilder.Entity("CandidateUser", b =>
                {
                    b.HasOne("DAL.Entities.Candidate", null)
                        .WithMany()
                        .HasForeignKey("CandidatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CountryInternship", b =>
                {
                    b.HasOne("DAL.Entities.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Internship", null)
                        .WithMany()
                        .HasForeignKey("InternshipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.BestContactTime", b =>
                {
                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("BestContactTimes")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.Candidate", b =>
                {
                    b.HasOne("DAL.Entities.Internship", "Internship")
                        .WithMany("Candidates")
                        .HasForeignKey("InternshipId");

                    b.HasOne("DAL.Entities.Team", "Team")
                        .WithMany("Candidates")
                        .HasForeignKey("TeamId");

                    b.Navigation("Internship");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("DAL.Entities.Evaluation", b =>
                {
                    b.HasOne("DAL.Entities.Feedback", "Feedback")
                        .WithMany("Evaluations")
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Skill", "Skill")
                        .WithMany("Evaluations")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feedback");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("DAL.Entities.Feedback", b =>
                {
                    b.HasOne("DAL.Entities.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Candidate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.InternshipStack", b =>
                {
                    b.HasOne("DAL.Entities.Internship", "Internship")
                        .WithMany("InternshipStacks")
                        .HasForeignKey("InternshipId");

                    b.Navigation("Internship");
                });

            modelBuilder.Entity("DAL.Entities.InterviewInvite", b =>
                {
                    b.HasOne("DAL.Entities.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Candidate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.Team", b =>
                {
                    b.HasOne("DAL.Entities.Internship", "Internship")
                        .WithMany("Teams")
                        .HasForeignKey("InternshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Internship");
                });

            modelBuilder.Entity("InternshipUser", b =>
                {
                    b.HasOne("DAL.Entities.Internship", null)
                        .WithMany()
                        .HasForeignKey("InternshipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamUser", b =>
                {
                    b.HasOne("DAL.Entities.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Feedback", b =>
                {
                    b.Navigation("Evaluations");
                });

            modelBuilder.Entity("DAL.Entities.Internship", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("InternshipStacks");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Navigation("Evaluations");
                });

            modelBuilder.Entity("DAL.Entities.Team", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("BestContactTimes");
                });
#pragma warning restore 612, 618
        }
    }
}
