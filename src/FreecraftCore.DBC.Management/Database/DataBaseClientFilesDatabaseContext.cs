﻿using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FreecraftCore
{
	public sealed class DataBaseClientFilesDatabaseContext : DbContext
	{
		/// <summary>
		/// Represents the Spell.dbc table.
		/// </summary>
		public DbSet<SpellDBCEntry<string>> Spell { get; set; }

		public DataBaseClientFilesDatabaseContext([NotNull] DbContextOptions options) 
			: base(options)
		{

		}

		//TODO: Remove this
		/// <inheritdoc />
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("Server=localhost;Database=Client.DBC;Uid=root;Pwd=test;");

			base.OnConfiguring(optionsBuilder);
		}

		/// <inheritdoc />
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder
				.Entity<SpellDBCEntry<string>>()
				.OwnsOne(p => p.ReagentsRequired, builder =>
				{
					builder.OwnsOne(r => r.ReagentId);
					builder.OwnsOne(r => r.Totem);
					builder.OwnsOne(r => r.ReagentCount);
				})
				.OwnsOne(p => p.SpellEffectInformation, builder =>
				{
					builder.OwnsOne(r => r.Effect);
					builder.OwnsOne(r => r.EffectAmplitude);
					builder.OwnsOne(r => r.EffectChainTarget);
					builder.OwnsOne(r => r.EffectDieSides);
					builder.OwnsOne(r => r.EffectImplicitTargetA);
					builder.OwnsOne(r => r.EffectImplicitTargetB);
					builder.OwnsOne(r => r.EffectItemType);
					builder.OwnsOne(r => r.EffectMechanic);
					builder.OwnsOne(r => r.EffectMiscValue);
					builder.OwnsOne(r => r.EffectApplyAuraName);
					builder.OwnsOne(r => r.EffectBasePoints);
					builder.OwnsOne(r => r.EffectMiscValueB);
					builder.OwnsOne(r => r.EffectMultipleValue);
					builder.OwnsOne(r => r.EffectPointsPerComboPoint);
					builder.OwnsOne(r => r.EffectRadiusIndex);
					builder.OwnsOne(r => r.EffectRealPointsPerLevel);
					builder.OwnsOne(r => r.EffectSpellClassMaskA);
					builder.OwnsOne(r => r.EffectSpellClassMaskB);
					builder.OwnsOne(r => r.EffectSpellClassMaskC);
					builder.OwnsOne(r => r.EffectTriggerSpell);
				});
		}

		public DataBaseClientFilesDatabaseContext()
		{
			
		}
	}
}