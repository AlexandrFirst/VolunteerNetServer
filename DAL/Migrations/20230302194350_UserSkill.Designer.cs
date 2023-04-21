﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(VolunteerNetServerDBContext))]
    [Migration("20230302194350_UserSkill")]
    partial class UserSkill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0002442a-4113-4062-8a95-ed330c7fd247"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "vi"
                        },
                        new
                        {
                            Id = new Guid("cc471323-518d-4b46-9767-d237c58a4507"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "dn"
                        },
                        new
                        {
                            Id = new Guid("31269fce-05aa-49ce-9e70-5a46d2a72e8c"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "zhy"
                        },
                        new
                        {
                            Id = new Guid("72d55e79-4a16-49bb-9d5b-32c3ef293dd0"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "zp"
                        },
                        new
                        {
                            Id = new Guid("98acd004-1130-40f1-86ab-a84dc1f8ee8f"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "if"
                        },
                        new
                        {
                            Id = new Guid("5c0c07b1-ccc0-4183-972e-c529961c1944"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "ky"
                        },
                        new
                        {
                            Id = new Guid("a511e9f2-8dc0-4b14-bd19-8ab20e61bc10"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "kr"
                        },
                        new
                        {
                            Id = new Guid("e88f5937-1524-45f6-be7a-c3d5e661667a"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "lut"
                        },
                        new
                        {
                            Id = new Guid("637f6066-eb41-40c7-b939-8be595174659"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "lv"
                        },
                        new
                        {
                            Id = new Guid("49c9137e-5157-4b89-bd90-4f497cf7fe70"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "my"
                        },
                        new
                        {
                            Id = new Guid("9b5e1d0a-f04e-4153-bc5c-55333aa6ee2b"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "od"
                        },
                        new
                        {
                            Id = new Guid("776f9d28-00a2-4e9d-ac20-2018242b80e2"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "pol"
                        },
                        new
                        {
                            Id = new Guid("81ee5736-0edb-4c35-a2ff-6b0e946141c9"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "ri"
                        },
                        new
                        {
                            Id = new Guid("e2a85167-6cb3-4cbf-b1d4-8e46bdfb21a7"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "su"
                        },
                        new
                        {
                            Id = new Guid("d9c8c9b2-2cc9-47db-b626-9642b3a07741"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "ter"
                        },
                        new
                        {
                            Id = new Guid("f754bb58-dfbc-4e8a-a504-688fcb2bd7e0"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "uzh"
                        },
                        new
                        {
                            Id = new Guid("4e7748e0-e0be-4751-b75e-84e3319a5d0b"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "khar"
                        },
                        new
                        {
                            Id = new Guid("dbf42758-3c0f-437d-8ef9-f8c50561b33d"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "kher"
                        },
                        new
                        {
                            Id = new Guid("98f5e8d7-426c-4048-91db-afda1760c4dd"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "khm"
                        },
                        new
                        {
                            Id = new Guid("07db01c4-1edd-4f3d-97e0-e3ae63e97ebd"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "chk"
                        },
                        new
                        {
                            Id = new Guid("816dac04-bf2e-4a76-932c-cc722427a8ce"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "chv"
                        },
                        new
                        {
                            Id = new Guid("b1345f81-50e1-489a-8d19-ec140f03309c"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "chh"
                        },
                        new
                        {
                            Id = new Guid("b3786527-9bfb-459e-aba5-16580cb9b88b"),
                            CountryId = new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"),
                            ISO = "var"
                        },
                        new
                        {
                            Id = new Guid("194f9426-c406-492b-807f-b2928b499694"),
                            CountryId = new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"),
                            ISO = "lub"
                        });
                });

            modelBuilder.Entity("DAL.Entities.CityTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("CityTranslations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("58008907-15c9-4717-b526-9c8aac74633f"),
                            CityId = new Guid("0002442a-4113-4062-8a95-ed330c7fd247"),
                            Language = "uk",
                            Name = "Вінниця"
                        },
                        new
                        {
                            Id = new Guid("2714a416-b397-453c-8c82-185409c0fb0a"),
                            CityId = new Guid("cc471323-518d-4b46-9767-d237c58a4507"),
                            Language = "uk",
                            Name = "Дніпро"
                        },
                        new
                        {
                            Id = new Guid("6d110397-513b-4fae-bd23-73539566e218"),
                            CityId = new Guid("31269fce-05aa-49ce-9e70-5a46d2a72e8c"),
                            Language = "uk",
                            Name = "Житомир"
                        },
                        new
                        {
                            Id = new Guid("d92e19e9-1560-4937-bf2f-6e7338bbf4d3"),
                            CityId = new Guid("72d55e79-4a16-49bb-9d5b-32c3ef293dd0"),
                            Language = "uk",
                            Name = "Запоріжжя"
                        },
                        new
                        {
                            Id = new Guid("4c0a07a1-e63f-41f3-b3ab-bce2d14cdcbc"),
                            CityId = new Guid("98acd004-1130-40f1-86ab-a84dc1f8ee8f"),
                            Language = "uk",
                            Name = "Івано-Франківськ"
                        },
                        new
                        {
                            Id = new Guid("1887fb0a-653f-45ed-a1eb-e8337b899b41"),
                            CityId = new Guid("5c0c07b1-ccc0-4183-972e-c529961c1944"),
                            Language = "uk",
                            Name = "Київ"
                        },
                        new
                        {
                            Id = new Guid("936758bb-974d-462d-adaf-6c23317c3454"),
                            CityId = new Guid("a511e9f2-8dc0-4b14-bd19-8ab20e61bc10"),
                            Language = "uk",
                            Name = "Кропивницький"
                        },
                        new
                        {
                            Id = new Guid("8ccc2226-a942-444f-a316-5eda5ff84013"),
                            CityId = new Guid("e88f5937-1524-45f6-be7a-c3d5e661667a"),
                            Language = "uk",
                            Name = "Луцьк"
                        },
                        new
                        {
                            Id = new Guid("8e346fdf-0cd1-4a60-9f37-1cc5513fe841"),
                            CityId = new Guid("637f6066-eb41-40c7-b939-8be595174659"),
                            Language = "uk",
                            Name = "Львів"
                        },
                        new
                        {
                            Id = new Guid("644721fc-2a04-48eb-9958-564eb9c2b571"),
                            CityId = new Guid("49c9137e-5157-4b89-bd90-4f497cf7fe70"),
                            Language = "uk",
                            Name = "Миколаїв"
                        },
                        new
                        {
                            Id = new Guid("93d6b0eb-b6d7-4119-831c-8c3e87d83c8d"),
                            CityId = new Guid("9b5e1d0a-f04e-4153-bc5c-55333aa6ee2b"),
                            Language = "uk",
                            Name = "Одеса"
                        },
                        new
                        {
                            Id = new Guid("65a35577-f637-4581-8c7d-54d6673fd104"),
                            CityId = new Guid("776f9d28-00a2-4e9d-ac20-2018242b80e2"),
                            Language = "uk",
                            Name = "Полтава"
                        },
                        new
                        {
                            Id = new Guid("2a4d77da-724c-4c6c-bbda-bfb8f5d53851"),
                            CityId = new Guid("81ee5736-0edb-4c35-a2ff-6b0e946141c9"),
                            Language = "uk",
                            Name = "Рівне"
                        },
                        new
                        {
                            Id = new Guid("89bd8659-a5d1-4ecc-bc8b-8849e2e565d5"),
                            CityId = new Guid("e2a85167-6cb3-4cbf-b1d4-8e46bdfb21a7"),
                            Language = "uk",
                            Name = "Суми"
                        },
                        new
                        {
                            Id = new Guid("ac433634-0423-4e8e-88e6-9c717366c31f"),
                            CityId = new Guid("d9c8c9b2-2cc9-47db-b626-9642b3a07741"),
                            Language = "uk",
                            Name = "Тернопіль"
                        },
                        new
                        {
                            Id = new Guid("007c3aa3-2c13-4151-96d5-e3b334531548"),
                            CityId = new Guid("f754bb58-dfbc-4e8a-a504-688fcb2bd7e0"),
                            Language = "uk",
                            Name = "Ужгород"
                        },
                        new
                        {
                            Id = new Guid("129d7ec6-ee8b-44f7-839f-aa60766c5ba9"),
                            CityId = new Guid("4e7748e0-e0be-4751-b75e-84e3319a5d0b"),
                            Language = "uk",
                            Name = "Харків"
                        },
                        new
                        {
                            Id = new Guid("a4719972-547d-4c55-9c48-b9444543c710"),
                            CityId = new Guid("dbf42758-3c0f-437d-8ef9-f8c50561b33d"),
                            Language = "uk",
                            Name = "Херсон"
                        },
                        new
                        {
                            Id = new Guid("664b0aae-3156-4103-95ec-19638d281438"),
                            CityId = new Guid("98f5e8d7-426c-4048-91db-afda1760c4dd"),
                            Language = "uk",
                            Name = "Хмельницький"
                        },
                        new
                        {
                            Id = new Guid("ee05b82d-a9e0-4c79-af66-1ca5b716dd83"),
                            CityId = new Guid("07db01c4-1edd-4f3d-97e0-e3ae63e97ebd"),
                            Language = "uk",
                            Name = "Черкаси"
                        },
                        new
                        {
                            Id = new Guid("fb114c1f-5ceb-4491-aed9-898369ee8e11"),
                            CityId = new Guid("816dac04-bf2e-4a76-932c-cc722427a8ce"),
                            Language = "uk",
                            Name = "Чернівці"
                        },
                        new
                        {
                            Id = new Guid("9cc55bea-04b1-4e18-839e-8bd883f974d1"),
                            CityId = new Guid("b1345f81-50e1-489a-8d19-ec140f03309c"),
                            Language = "uk",
                            Name = "Чернігів"
                        },
                        new
                        {
                            Id = new Guid("3284f575-8f2c-4dbb-8660-b84caa0f4b7e"),
                            CityId = new Guid("0002442a-4113-4062-8a95-ed330c7fd247"),
                            Language = "en",
                            Name = "Vinnytsia"
                        },
                        new
                        {
                            Id = new Guid("6fecd8bc-ac43-4820-a8bc-c315eba8c0b2"),
                            CityId = new Guid("cc471323-518d-4b46-9767-d237c58a4507"),
                            Language = "en",
                            Name = "Dnipro"
                        },
                        new
                        {
                            Id = new Guid("ba5c6d04-06e9-48a4-a8d4-b04a02f370b5"),
                            CityId = new Guid("31269fce-05aa-49ce-9e70-5a46d2a72e8c"),
                            Language = "en",
                            Name = "Zhytomyr"
                        },
                        new
                        {
                            Id = new Guid("bc4991b6-1b54-41ef-9250-22486e9e9b39"),
                            CityId = new Guid("72d55e79-4a16-49bb-9d5b-32c3ef293dd0"),
                            Language = "en",
                            Name = "Zaporizhzhia"
                        },
                        new
                        {
                            Id = new Guid("e011ecaa-20ca-4b64-a207-5a2f70fba828"),
                            CityId = new Guid("98acd004-1130-40f1-86ab-a84dc1f8ee8f"),
                            Language = "en",
                            Name = "Ivano-Frankivsk"
                        },
                        new
                        {
                            Id = new Guid("82f4f3b7-ec95-4e2b-aa4e-14db1b37bd46"),
                            CityId = new Guid("5c0c07b1-ccc0-4183-972e-c529961c1944"),
                            Language = "en",
                            Name = "Kyiv"
                        },
                        new
                        {
                            Id = new Guid("aa3631a9-de42-469a-87cf-3c349034b606"),
                            CityId = new Guid("a511e9f2-8dc0-4b14-bd19-8ab20e61bc10"),
                            Language = "en",
                            Name = "Kropyvnytskyi"
                        },
                        new
                        {
                            Id = new Guid("1f58e495-5209-42d1-a279-a5015cf9948a"),
                            CityId = new Guid("e88f5937-1524-45f6-be7a-c3d5e661667a"),
                            Language = "en",
                            Name = "Lutsk"
                        },
                        new
                        {
                            Id = new Guid("9f62263d-ff82-4dc6-a6f1-57af2229811d"),
                            CityId = new Guid("637f6066-eb41-40c7-b939-8be595174659"),
                            Language = "en",
                            Name = "Lviv"
                        },
                        new
                        {
                            Id = new Guid("6a38dc1b-1cdf-460f-8b7a-d68a5950866a"),
                            CityId = new Guid("49c9137e-5157-4b89-bd90-4f497cf7fe70"),
                            Language = "en",
                            Name = "Mykolaiv"
                        },
                        new
                        {
                            Id = new Guid("e5f52f0e-457a-4ae4-b6c4-15db13583300"),
                            CityId = new Guid("9b5e1d0a-f04e-4153-bc5c-55333aa6ee2b"),
                            Language = "en",
                            Name = "Odesa"
                        },
                        new
                        {
                            Id = new Guid("c42f0ff1-6b71-4172-98d5-02718b0616c2"),
                            CityId = new Guid("776f9d28-00a2-4e9d-ac20-2018242b80e2"),
                            Language = "en",
                            Name = "Poltava"
                        },
                        new
                        {
                            Id = new Guid("80219b32-eaa3-4558-8b20-4d23b84844f7"),
                            CityId = new Guid("81ee5736-0edb-4c35-a2ff-6b0e946141c9"),
                            Language = "en",
                            Name = "Rivne"
                        },
                        new
                        {
                            Id = new Guid("99fef125-a4e7-4fc1-a0a0-8aeb68c781cf"),
                            CityId = new Guid("e2a85167-6cb3-4cbf-b1d4-8e46bdfb21a7"),
                            Language = "en",
                            Name = "Sumy"
                        },
                        new
                        {
                            Id = new Guid("1566132b-4e74-40de-87ce-7c5fba526a2a"),
                            CityId = new Guid("d9c8c9b2-2cc9-47db-b626-9642b3a07741"),
                            Language = "en",
                            Name = "Ternopil"
                        },
                        new
                        {
                            Id = new Guid("91d7b4c7-f445-456f-8ca2-af471bc4fda2"),
                            CityId = new Guid("f754bb58-dfbc-4e8a-a504-688fcb2bd7e0"),
                            Language = "en",
                            Name = "Uzhhorod"
                        },
                        new
                        {
                            Id = new Guid("a067bd97-fcb2-4bdc-a72f-f00e5547c5d6"),
                            CityId = new Guid("4e7748e0-e0be-4751-b75e-84e3319a5d0b"),
                            Language = "en",
                            Name = "Kharkiv"
                        },
                        new
                        {
                            Id = new Guid("b4056414-e4b6-41f7-98b3-089aa56ec194"),
                            CityId = new Guid("dbf42758-3c0f-437d-8ef9-f8c50561b33d"),
                            Language = "en",
                            Name = "Kherson"
                        },
                        new
                        {
                            Id = new Guid("f1f4b5e1-4618-4367-bae8-3ff447182525"),
                            CityId = new Guid("98f5e8d7-426c-4048-91db-afda1760c4dd"),
                            Language = "en",
                            Name = "Khmelnytskyi"
                        },
                        new
                        {
                            Id = new Guid("5ea502ee-8853-4a20-890d-ff56972cc022"),
                            CityId = new Guid("07db01c4-1edd-4f3d-97e0-e3ae63e97ebd"),
                            Language = "en",
                            Name = "Cherkasy"
                        },
                        new
                        {
                            Id = new Guid("1c5212e9-b96d-4ac1-b737-547ad6fcc2e9"),
                            CityId = new Guid("816dac04-bf2e-4a76-932c-cc722427a8ce"),
                            Language = "en",
                            Name = "Chernivtsi"
                        },
                        new
                        {
                            Id = new Guid("60ce010a-971c-4913-aeb5-5568ad5adf12"),
                            CityId = new Guid("b1345f81-50e1-489a-8d19-ec140f03309c"),
                            Language = "en",
                            Name = "Chernihiv"
                        },
                        new
                        {
                            Id = new Guid("bbaaa29a-c852-429b-9b3b-21105b0ff400"),
                            CityId = new Guid("b3786527-9bfb-459e-aba5-16580cb9b88b"),
                            Language = "uk",
                            Name = "Варшава"
                        },
                        new
                        {
                            Id = new Guid("7a500f11-2010-47de-bc5b-d10c9118bc53"),
                            CityId = new Guid("194f9426-c406-492b-807f-b2928b499694"),
                            Language = "uk",
                            Name = "Люблін"
                        },
                        new
                        {
                            Id = new Guid("65ba5c73-3128-407d-8e49-79562fea3589"),
                            CityId = new Guid("b3786527-9bfb-459e-aba5-16580cb9b88b"),
                            Language = "en",
                            Name = "Varshava"
                        },
                        new
                        {
                            Id = new Guid("14d14efc-48b2-4973-8fe7-17566de70d5b"),
                            CityId = new Guid("194f9426-c406-492b-807f-b2928b499694"),
                            Language = "en",
                            Name = "Lublin"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            ISO = "uk"
                        },
                        new
                        {
                            Id = new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"),
                            ISO = "pl"
                        });
                });

            modelBuilder.Entity("DAL.Entities.CountryTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("CountryTranslations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53add06f-3ab3-47be-84c2-7f685f2115db"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            Language = "en",
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = new Guid("129487bd-1eb6-41e9-87db-b3f1aaf7abed"),
                            CountryId = new Guid("63af5735-3b77-4d03-a67d-1e71176fb264"),
                            Language = "uk",
                            Name = "Україна"
                        },
                        new
                        {
                            Id = new Guid("552cbb91-5146-4d7d-838a-98a3859100d0"),
                            CountryId = new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"),
                            Language = "en",
                            Name = "Poland"
                        },
                        new
                        {
                            Id = new Guid("4871d8ea-b585-423d-b21f-6f627a23d214"),
                            CountryId = new Guid("ecc4522b-2c92-4680-b41b-dc69dc08cb34"),
                            Language = "uk",
                            Name = "Польша"
                        });
                });

            modelBuilder.Entity("DAL.Entities.ProfilePicture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ProfilePictures");
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2dacb2b5-3f59-40f5-998f-779d49b6d401"),
                            Title = "medicine"
                        },
                        new
                        {
                            Id = new Guid("649d816a-9e39-472a-b0fd-2fc8c3b0c6de"),
                            Title = "cook"
                        });
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("788eb2be-ec08-4eff-a132-a3c1cddbb959"),
                            CityId = new Guid("0002442a-4113-4062-8a95-ed330c7fd247"),
                            DateOfBirth = new DateTime(2023, 3, 2, 21, 43, 49, 988, DateTimeKind.Local).AddTicks(1973),
                            FirstName = "the first",
                            LastName = "admin",
                            Login = "ourfirstadmin",
                            Password = "Rk/ryiBNbnHx+s9i1IveCNNw4axYPQHm4T1eratfQlg=",
                            Phone = "+11111111111",
                            Role = "admin"
                        });
                });

            modelBuilder.Entity("DAL.Entities.UserSkill", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Document")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DocumentFormat")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("NULL");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("DAL.Entities.City", b =>
                {
                    b.HasOne("DAL.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DAL.Entities.CityTranslation", b =>
                {
                    b.HasOne("DAL.Entities.City", "City")
                        .WithMany("CityTranslations")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DAL.Entities.CountryTranslation", b =>
                {
                    b.HasOne("DAL.Entities.Country", "Country")
                        .WithMany("CountryTranslations")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DAL.Entities.ProfilePicture", b =>
                {
                    b.HasOne("DAL.Entities.User", "User")
                        .WithOne("ProfilePicture")
                        .HasForeignKey("DAL.Entities.ProfilePicture", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.HasOne("DAL.Entities.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DAL.Entities.UserSkill", b =>
                {
                    b.HasOne("DAL.Entities.Skill", "Skill")
                        .WithMany("UserSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("UserSkills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.City", b =>
                {
                    b.Navigation("CityTranslations");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAL.Entities.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("CountryTranslations");
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Navigation("UserSkills");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("ProfilePicture");

                    b.Navigation("UserSkills");
                });
#pragma warning restore 612, 618
        }
    }
}