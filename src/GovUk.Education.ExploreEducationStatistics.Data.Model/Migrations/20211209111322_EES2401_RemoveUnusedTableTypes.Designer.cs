﻿// <auto-generated />
using System;
using GovUk.Education.ExploreEducationStatistics.Data.Model.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GovUk.Education.ExploreEducationStatistics.Data.Model.Migrations
{
    [DbContext(typeof(StatisticsDbContext))]
    [Migration("20211209111322_EES2401_RemoveUnusedTableTypes")]
    partial class EES2401_RemoveUnusedTableTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Common.Model.Data.BoundaryLevel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BoundaryLevel");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Filter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Hint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("SubjectId");

                    b.ToTable("Filter");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterFootnote", b =>
                {
                    b.Property<Guid>("FilterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FootnoteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FilterId", "FootnoteId");

                    b.HasIndex("FootnoteId");

                    b.ToTable("FilterFootnote");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FilterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("FilterGroup");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterGroupFootnote", b =>
                {
                    b.Property<Guid>("FilterGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FootnoteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FilterGroupId", "FootnoteId");

                    b.HasIndex("FootnoteId");

                    b.ToTable("FilterGroupFootnote");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FilterGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterGroupId");

                    b.ToTable("FilterItem");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterItemFootnote", b =>
                {
                    b.Property<Guid>("FilterItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FootnoteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FilterItemId", "FootnoteId");

                    b.HasIndex("FootnoteId");

                    b.ToTable("FilterItemFootnote");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Footnote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Footnote");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Indicator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DecimalPlaces")
                        .HasColumnType("int");

                    b.Property<Guid>("IndicatorGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IndicatorGroupId");

                    b.HasIndex("Name");

                    b.ToTable("Indicator");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.IndicatorFootnote", b =>
                {
                    b.Property<Guid>("IndicatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FootnoteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IndicatorId", "FootnoteId");

                    b.HasIndex("FootnoteId");

                    b.ToTable("IndicatorFootnote");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.IndicatorGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("IndicatorGroup");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishDevolvedArea_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EnglishDevolvedArea_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Institution_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalAuthorityDistrict_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocalAuthorityDistrict_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalAuthority_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocalAuthority_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalAuthority_OldCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocalEnterprisePartnership_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocalEnterprisePartnership_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MayoralCombinedAuthority_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MayoralCombinedAuthority_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MultiAcademyTrust_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MultiAcademyTrust_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpportunityArea_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OpportunityArea_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParliamentaryConstituency_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParliamentaryConstituency_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanningArea_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PlanningArea_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Provider_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Region_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RscRegion_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("School_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("School_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sponsor_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sponsor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ward_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Country_Code");

                    b.HasIndex("EnglishDevolvedArea_Code");

                    b.HasIndex("Institution_Code");

                    b.HasIndex("LocalAuthorityDistrict_Code");

                    b.HasIndex("LocalAuthority_Code");

                    b.HasIndex("LocalAuthority_OldCode");

                    b.HasIndex("LocalEnterprisePartnership_Code");

                    b.HasIndex("MayoralCombinedAuthority_Code");

                    b.HasIndex("MultiAcademyTrust_Code");

                    b.HasIndex("OpportunityArea_Code");

                    b.HasIndex("ParliamentaryConstituency_Code");

                    b.HasIndex("PlanningArea_Code");

                    b.HasIndex("Provider_Code");

                    b.HasIndex("Region_Code");

                    b.HasIndex("RscRegion_Code");

                    b.HasIndex("School_Code");

                    b.HasIndex("Sponsor_Code");

                    b.HasIndex("Ward_Code");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Observation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("CsvRow")
                        .HasColumnType("bigint");

                    b.Property<string>("GeographicLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Measures")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TimeIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GeographicLevel");

                    b.HasIndex("LocationId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TimeIdentifier");

                    b.HasIndex("Year");

                    b.ToTable("Observation");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.ObservationFilterItem", b =>
                {
                    b.Property<Guid>("ObservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FilterItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FilterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ObservationId", "FilterItemId");

                    b.HasIndex("FilterId");

                    b.HasIndex("FilterItemId");

                    b.ToTable("ObservationFilterItem");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Release", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PreviousVersionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PublicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Published")
                        .HasColumnType("datetime2");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PreviousVersionId");

                    b.HasIndex("PublicationId");

                    b.ToTable("Release");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.ReleaseFootnote", b =>
                {
                    b.Property<Guid>("ReleaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FootnoteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReleaseId", "FootnoteId");

                    b.HasIndex("FootnoteId");

                    b.ToTable("ReleaseFootnote");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.ReleaseSubject", b =>
                {
                    b.Property<Guid>("ReleaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DataGuidance")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReleaseId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ReleaseSubject");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.SubjectFootnote", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FootnoteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubjectId", "FootnoteId");

                    b.HasIndex("FootnoteId");

                    b.ToTable("SubjectFootnote");
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Filter", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Subject", "Subject")
                        .WithMany("Filters")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterFootnote", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Filter", "Filter")
                        .WithMany("Footnotes")
                        .HasForeignKey("FilterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Footnote", "Footnote")
                        .WithMany("Filters")
                        .HasForeignKey("FootnoteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterGroup", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Filter", "Filter")
                        .WithMany("FilterGroups")
                        .HasForeignKey("FilterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterGroupFootnote", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterGroup", "FilterGroup")
                        .WithMany("Footnotes")
                        .HasForeignKey("FilterGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Footnote", "Footnote")
                        .WithMany("FilterGroups")
                        .HasForeignKey("FootnoteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterItem", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterGroup", "FilterGroup")
                        .WithMany("FilterItems")
                        .HasForeignKey("FilterGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterItemFootnote", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterItem", "FilterItem")
                        .WithMany("Footnotes")
                        .HasForeignKey("FilterItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Footnote", "Footnote")
                        .WithMany("FilterItems")
                        .HasForeignKey("FootnoteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Indicator", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.IndicatorGroup", "IndicatorGroup")
                        .WithMany("Indicators")
                        .HasForeignKey("IndicatorGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.IndicatorFootnote", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Footnote", "Footnote")
                        .WithMany("Indicators")
                        .HasForeignKey("FootnoteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Indicator", "Indicator")
                        .WithMany("Footnotes")
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.IndicatorGroup", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Subject", "Subject")
                        .WithMany("IndicatorGroups")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.Observation", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Subject", "Subject")
                        .WithMany("Observations")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.ObservationFilterItem", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Filter", "Filter")
                        .WithMany()
                        .HasForeignKey("FilterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.FilterItem", "FilterItem")
                        .WithMany()
                        .HasForeignKey("FilterItemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Observation", "Observation")
                        .WithMany("FilterItems")
                        .HasForeignKey("ObservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.ReleaseFootnote", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Footnote", "Footnote")
                        .WithMany("Releases")
                        .HasForeignKey("FootnoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Release", "Release")
                        .WithMany("Footnotes")
                        .HasForeignKey("ReleaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.ReleaseSubject", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Release", "Release")
                        .WithMany()
                        .HasForeignKey("ReleaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GovUk.Education.ExploreEducationStatistics.Data.Model.SubjectFootnote", b =>
                {
                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Footnote", "Footnote")
                        .WithMany("Subjects")
                        .HasForeignKey("FootnoteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GovUk.Education.ExploreEducationStatistics.Data.Model.Subject", "Subject")
                        .WithMany("Footnotes")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
