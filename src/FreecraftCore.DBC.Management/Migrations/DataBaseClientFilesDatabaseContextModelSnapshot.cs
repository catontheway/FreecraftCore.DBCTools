﻿// <auto-generated />
using FreecraftCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreecraftCore.DBC.Management.Migrations
{
    [DbContext(typeof(DataBaseClientFilesDatabaseContext))]
    partial class DataBaseClientFilesDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FreecraftCore.SpellDBCEntry<string>", b =>
                {
                    b.Property<uint>("SpellId")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("ActiveIconID");

                    b.Property<int>("AreaGroupId");

                    b.Property<uint>("Attributes");

                    b.Property<uint>("AttributesEx");

                    b.Property<uint>("AttributesEx2");

                    b.Property<uint>("AttributesEx3");

                    b.Property<uint>("AttributesEx4");

                    b.Property<uint>("AttributesEx5");

                    b.Property<uint>("AttributesEx6");

                    b.Property<uint>("AttributesEx7");

                    b.Property<uint>("AuraInterruptFlags");

                    b.Property<uint>("BaseLevel");

                    b.Property<uint>("CasterAuraSpell");

                    b.Property<int>("CasterAuraState");

                    b.Property<int>("CasterAuraStateNot");

                    b.Property<uint>("CastingTimeIndex");

                    b.Property<uint>("Category");

                    b.Property<uint>("CategoryRecoveryTime");

                    b.Property<uint>("ChannelInterruptFlags");

                    b.Property<uint>("Dispel");

                    b.Property<int>("DmgClass");

                    b.Property<uint>("DurationIndex");

                    b.Property<int>("EquippedItemClass");

                    b.Property<int>("EquippedItemInventoryTypeMask");

                    b.Property<int>("EquippedItemSubClassMask");

                    b.Property<uint>("ExcludeCasterAuraSpell");

                    b.Property<uint>("ExcludeTargetAuraSpell");

                    b.Property<uint>("FacingCasterFlags");

                    b.Property<uint>("InterruptFlags");

                    b.Property<uint>("ManaCost");

                    b.Property<uint>("ManaCostPercentage");

                    b.Property<uint>("ManaCostPerlevel");

                    b.Property<uint>("ManaPerSecond");

                    b.Property<uint>("ManaPerSecondPerLevel");

                    b.Property<uint>("MaxAffectedTargets");

                    b.Property<uint>("MaxLevel");

                    b.Property<uint>("MaxTargetLevel");

                    b.Property<int>("Mechanic");

                    b.Property<uint>("MinFactionId");

                    b.Property<uint>("MinReputation");

                    b.Property<uint>("ModalNextSpell");

                    b.Property<uint>("PowerDisplayId");

                    b.Property<uint>("PowerType");

                    b.Property<int>("PreventionType");

                    b.Property<uint>("ProcChance");

                    b.Property<uint>("ProcCharges");

                    b.Property<int>("ProcFlags");

                    b.Property<uint>("RangeIndex");

                    b.Property<uint>("RecoveryTime");

                    b.Property<uint>("RequiredAuraVision");

                    b.Property<uint>("RequiresSpellFocus");

                    b.Property<uint>("RuneCostID");

                    b.Property<int>("SchoolMask");

                    b.Property<float>("Speed");

                    b.Property<uint>("SpellDescriptionVariableID");

                    b.Property<uint>("SpellDifficultyId");

                    b.Property<int>("SpellFamilyName");

                    b.Property<uint>("SpellIconID");

                    b.Property<uint>("SpellLevel");

                    b.Property<uint>("SpellMissileID");

                    b.Property<uint>("SpellPriority");

                    b.Property<uint>("StackAmount");

                    b.Property<uint>("StanceBarOrder");

                    b.Property<ulong>("Stances");

                    b.Property<ulong>("StancesNot");

                    b.Property<uint>("StartRecoveryCategory");

                    b.Property<uint>("StartRecoveryTime");

                    b.Property<uint>("TargetAuraSpell");

                    b.Property<int>("TargetAuraState");

                    b.Property<int>("TargetAuraStateNot");

                    b.Property<int>("TargetCreatureType");

                    b.Property<uint>("Targets");

                    b.HasKey("SpellId");

                    b.ToTable("Spell");
                });

            modelBuilder.Entity("FreecraftCore.SpellDBCEntry<string>", b =>
                {
                    b.OwnsOne("FreecraftCore.Flags96<uint>", "SpellFamilyFlags", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<uint>("One");

                            b1.Property<uint>("Three");

                            b1.Property<uint>("Two");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("SpellFamilyFlags")
                                .HasForeignKey("FreecraftCore.Flags96<uint>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.RequiredReagentData", "ReagentsRequired", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("ReagentsRequired")
                                .HasForeignKey("FreecraftCore.RequiredReagentData", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.OwnsOne("FreecraftCore.ReagentDataChunk<int>", "ReagentId", b2 =>
                                {
                                    b2.Property<uint>("RequiredReagentDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Eight");

                                    b2.Property<int>("Five");

                                    b2.Property<int>("Four");

                                    b2.Property<int>("One");

                                    b2.Property<int>("Seven");

                                    b2.Property<int>("Six");

                                    b2.Property<int>("Three");

                                    b2.Property<int>("Two");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.RequiredReagentData")
                                        .WithOne("ReagentId")
                                        .HasForeignKey("FreecraftCore.ReagentDataChunk<int>", "RequiredReagentDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.ReagentDataChunk<uint>", "ReagentCount", b2 =>
                                {
                                    b2.Property<uint>("RequiredReagentDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Eight");

                                    b2.Property<uint>("Five");

                                    b2.Property<uint>("Four");

                                    b2.Property<uint>("One");

                                    b2.Property<uint>("Seven");

                                    b2.Property<uint>("Six");

                                    b2.Property<uint>("Three");

                                    b2.Property<uint>("Two");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.RequiredReagentData")
                                        .WithOne("ReagentCount")
                                        .HasForeignKey("FreecraftCore.ReagentDataChunk<uint>", "RequiredReagentDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellTotemDataChunk<uint>", "Totem", b2 =>
                                {
                                    b2.Property<uint>("RequiredReagentDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("One");

                                    b2.Property<uint>("Two");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.RequiredReagentData")
                                        .WithOne("Totem")
                                        .HasForeignKey("FreecraftCore.SpellTotemDataChunk<uint>", "RequiredReagentDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });
                        });

                    b.OwnsOne("FreecraftCore.SpellEffectData", "SpellEffectInformation", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("SpellEffectInformation")
                                .HasForeignKey("FreecraftCore.SpellEffectData", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<FreecraftCore.AuraType>", "EffectApplyAuraName", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectApplyAuraName")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<FreecraftCore.AuraType>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellEffect>", "Effect", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("Effect")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellEffect>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellMechanic>", "EffectMechanic", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectMechanic")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellMechanic>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<float>", "EffectMultipleValue", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<float>("Effect1");

                                    b2.Property<float>("Effect2");

                                    b2.Property<float>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectMultipleValue")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<float>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<float>", "EffectPointsPerComboPoint", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<float>("Effect1");

                                    b2.Property<float>("Effect2");

                                    b2.Property<float>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectPointsPerComboPoint")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<float>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<float>", "EffectRealPointsPerLevel", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<float>("Effect1");

                                    b2.Property<float>("Effect2");

                                    b2.Property<float>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectRealPointsPerLevel")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<float>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellTargetType>", "EffectImplicitTargetA", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectImplicitTargetA")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellTargetType>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellTargetType>", "EffectImplicitTargetB", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectImplicitTargetB")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<FreecraftCore.SpellTargetType>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<int>", "EffectBasePoints", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectBasePoints")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<int>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<int>", "EffectDieSides", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectDieSides")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<int>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<int>", "EffectMiscValue", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectMiscValue")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<int>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<int>", "EffectMiscValueB", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<int>("Effect1");

                                    b2.Property<int>("Effect2");

                                    b2.Property<int>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectMiscValueB")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<int>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectAmplitude", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectAmplitude")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectChainTarget", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectChainTarget")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectItemType", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectItemType")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectRadiusIndex", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectRadiusIndex")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectSpellClassMaskA", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectSpellClassMaskA")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectSpellClassMaskB", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectSpellClassMaskB")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectSpellClassMaskC", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectSpellClassMaskC")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });

                            b1.OwnsOne("FreecraftCore.SpellEffectDataChunk<uint>", "EffectTriggerSpell", b2 =>
                                {
                                    b2.Property<uint>("SpellEffectDataSpellDBCEntry<string>SpellId");

                                    b2.Property<uint>("Effect1");

                                    b2.Property<uint>("Effect2");

                                    b2.Property<uint>("Effect3");

                                    b2.ToTable("Spell");

                                    b2.HasOne("FreecraftCore.SpellEffectData")
                                        .WithOne("EffectTriggerSpell")
                                        .HasForeignKey("FreecraftCore.SpellEffectDataChunk<uint>", "SpellEffectDataSpellDBCEntry<string>SpellId")
                                        .OnDelete(DeleteBehavior.Cascade);
                                });
                        });

                    b.OwnsOne("FreecraftCore.SpellVisualData", "SpellVisual", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<uint>("One");

                            b1.Property<uint>("Two");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("SpellVisual")
                                .HasForeignKey("FreecraftCore.SpellVisualData", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.LocalizedStringDBC<string>", "Description", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<uint>("Flags");

                            b1.Property<string>("deDE");

                            b1.Property<string>("enCN");

                            b1.Property<string>("enTW");

                            b1.Property<string>("enUS");

                            b1.Property<string>("esES");

                            b1.Property<string>("esMX");

                            b1.Property<string>("frFR");

                            b1.Property<string>("itIT");

                            b1.Property<string>("koKR");

                            b1.Property<string>("ptPT");

                            b1.Property<string>("ruRU");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("Description")
                                .HasForeignKey("FreecraftCore.LocalizedStringDBC<string>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.LocalizedStringDBC<string>", "Rank", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<uint>("Flags");

                            b1.Property<string>("deDE");

                            b1.Property<string>("enCN");

                            b1.Property<string>("enTW");

                            b1.Property<string>("enUS");

                            b1.Property<string>("esES");

                            b1.Property<string>("esMX");

                            b1.Property<string>("frFR");

                            b1.Property<string>("itIT");

                            b1.Property<string>("koKR");

                            b1.Property<string>("ptPT");

                            b1.Property<string>("ruRU");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("Rank")
                                .HasForeignKey("FreecraftCore.LocalizedStringDBC<string>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.LocalizedStringDBC<string>", "SpellName", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<uint>("Flags");

                            b1.Property<string>("deDE");

                            b1.Property<string>("enCN");

                            b1.Property<string>("enTW");

                            b1.Property<string>("enUS");

                            b1.Property<string>("esES");

                            b1.Property<string>("esMX");

                            b1.Property<string>("frFR");

                            b1.Property<string>("itIT");

                            b1.Property<string>("koKR");

                            b1.Property<string>("ptPT");

                            b1.Property<string>("ruRU");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("SpellName")
                                .HasForeignKey("FreecraftCore.LocalizedStringDBC<string>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.LocalizedStringDBC<string>", "ToolTip", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<uint>("Flags");

                            b1.Property<string>("deDE");

                            b1.Property<string>("enCN");

                            b1.Property<string>("enTW");

                            b1.Property<string>("enUS");

                            b1.Property<string>("esES");

                            b1.Property<string>("esMX");

                            b1.Property<string>("frFR");

                            b1.Property<string>("itIT");

                            b1.Property<string>("koKR");

                            b1.Property<string>("ptPT");

                            b1.Property<string>("ruRU");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("ToolTip")
                                .HasForeignKey("FreecraftCore.LocalizedStringDBC<string>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.SpellEffectDataChunk<float>", "DamageCoeficient", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<float>("Effect1");

                            b1.Property<float>("Effect2");

                            b1.Property<float>("Effect3");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("DamageCoeficient")
                                .HasForeignKey("FreecraftCore.SpellEffectDataChunk<float>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.SpellEffectDataChunk<float>", "DmgMultiplier", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<float>("Effect1");

                            b1.Property<float>("Effect2");

                            b1.Property<float>("Effect3");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("DmgMultiplier")
                                .HasForeignKey("FreecraftCore.SpellEffectDataChunk<float>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("FreecraftCore.SpellTotemDataChunk<uint>", "TotemCategory", b1 =>
                        {
                            b1.Property<uint>("SpellDBCEntry<string>SpellId");

                            b1.Property<uint>("One");

                            b1.Property<uint>("Two");

                            b1.ToTable("Spell");

                            b1.HasOne("FreecraftCore.SpellDBCEntry<string>")
                                .WithOne("TotemCategory")
                                .HasForeignKey("FreecraftCore.SpellTotemDataChunk<uint>", "SpellDBCEntry<string>SpellId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}