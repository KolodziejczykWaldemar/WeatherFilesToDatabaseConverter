using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WheatherToDatabaseConverter;

namespace WheatherToDatabaseConverter.Migrations
{
    [DbContext(typeof(WheatherDataContext))]
    partial class WheatherDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("WheatherToDatabaseConverter.RegionModel", b =>
                {
                    b.Property<int>("RegionModelId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("RegionLatitude");

                    b.Property<float>("RegionLongitude");

                    b.Property<int>("WheatherModelId");

                    b.HasKey("RegionModelId");

                    b.HasIndex("WheatherModelId")
                        .IsUnique();

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("WheatherToDatabaseConverter.WheatherModel", b =>
                {
                    b.Property<int>("WheatherModelId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("DBT");

                    b.Property<int>("Day");

                    b.Property<float>("E_30");

                    b.Property<float>("E_45");

                    b.Property<float>("E_60");

                    b.Property<float>("E_90");

                    b.Property<float>("HR");

                    b.Property<int>("Hour");

                    b.Property<float>("IDH");

                    b.Property<float>("ISH");

                    b.Property<float>("ITH");

                    b.Property<int>("Month");

                    b.Property<float>("NE_30");

                    b.Property<float>("NE_45");

                    b.Property<float>("NE_60");

                    b.Property<float>("NE_90");

                    b.Property<float>("NW_30");

                    b.Property<float>("NW_45");

                    b.Property<float>("NW_60");

                    b.Property<float>("NW_90");

                    b.Property<float>("N_0");

                    b.Property<float>("N_30");

                    b.Property<float>("N_45");

                    b.Property<float>("N_60");

                    b.Property<float>("N_90");

                    b.Property<int>("RH");

                    b.Property<float>("SE_30");

                    b.Property<float>("SE_45");

                    b.Property<float>("SE_60");

                    b.Property<float>("SE_90");

                    b.Property<float>("SW_30");

                    b.Property<float>("SW_45");

                    b.Property<float>("SW_60");

                    b.Property<float>("SW_90");

                    b.Property<float>("S_30");

                    b.Property<float>("S_45");

                    b.Property<float>("S_60");

                    b.Property<float>("S_90");

                    b.Property<float>("TSKY");

                    b.Property<float>("WD");

                    b.Property<float>("WS");

                    b.Property<float>("W_30");

                    b.Property<float>("W_45");

                    b.Property<float>("W_60");

                    b.Property<float>("W_90");

                    b.HasKey("WheatherModelId");

                    b.ToTable("WheatherRecords");
                });

            modelBuilder.Entity("WheatherToDatabaseConverter.RegionModel", b =>
                {
                    b.HasOne("WheatherToDatabaseConverter.WheatherModel", "WheatherModel")
                        .WithOne("RegionModel")
                        .HasForeignKey("WheatherToDatabaseConverter.RegionModel", "WheatherModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
