using System;

using SMLHelper.V2.Handlers;



namespace EggInfo
{
	// Token: 0x02000003 RID: 3
	public class QPatch
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
		public static void Patch()
		{
			Logger.Log("Started Patching BonesharkEgg");
			QPatch.egg1tt = TechTypeHandler.AddTechType("Boneshark Egg", "Boneshark Egg", "Required to hatch: Spotted Dockleaf.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg1tt);
			LanguageHandler.SetTechTypeTooltip(TechType.BonesharkEgg, "Required to hatch: Spotted Dockleaf");
			KnownTechHandler.UnlockOnStart(QPatch.egg1tt);
			Atlas.Sprite sprite = SpriteManager.Get(TechType.BonesharkEgg);
			SpriteHandler.RegisterSprite(QPatch.egg1tt, sprite);
			Logger.Log("Started Patching CrabsnakeEgg");
			QPatch.egg2tt = TechTypeHandler.AddTechType("Crabsnake Egg", "Crabsnake Egg", "Required to hatch: Jellyshroom.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg2tt);
			LanguageHandler.SetTechTypeTooltip(TechType.CrabsnakeEgg, "Required to hatch: Jellyshroom.");
			KnownTechHandler.UnlockOnStart(QPatch.egg2tt);
			Atlas.Sprite sprite2 = SpriteManager.Get(TechType.CrabsnakeEgg);
			SpriteHandler.RegisterSprite(QPatch.egg2tt, sprite2);
			Logger.Log("Started Patching CrabsquidEgg");
			QPatch.egg3tt = TechTypeHandler.AddTechType("Crabsquid Egg", "Crabsquid Egg", "Required to hatch: Bloodvine.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg3tt);
			LanguageHandler.SetTechTypeTooltip(TechType.CrabsquidEgg, "Required to hatch: Bloodvine.");
			KnownTechHandler.UnlockOnStart(QPatch.egg3tt);
			Atlas.Sprite sprite3 = SpriteManager.Get(TechType.CrabsquidEgg);
			SpriteHandler.RegisterSprite(QPatch.egg3tt, sprite3);
			Logger.Log("Started Patching CrashfishEgg");
			QPatch.egg4tt = TechTypeHandler.AddTechType("Crashfish Egg", "Crashfish Egg", "Required to hatch: Spiked Horn Grass.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg4tt);
			LanguageHandler.SetTechTypeTooltip(TechType.CrashEgg, "Required to hatch: Spiked Horn Grass.");
			KnownTechHandler.UnlockOnStart(QPatch.egg4tt);
			Atlas.Sprite sprite4 = SpriteManager.Get(TechType.CrashEgg);
			SpriteHandler.RegisterSprite(QPatch.egg4tt, sprite4);
			Logger.Log("Started Patching GasopodEgg");
			QPatch.egg5tt = TechTypeHandler.AddTechType("Gasopod Egg", "Gasopod Egg", "Required to hatch: Creepvine.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg5tt);
			LanguageHandler.SetTechTypeTooltip(TechType.GasopodEgg, "Required to hatch: Creepvine.");
			KnownTechHandler.UnlockOnStart(QPatch.egg5tt);
			Atlas.Sprite sprite5 = SpriteManager.Get(TechType.GasopodEgg);
			SpriteHandler.RegisterSprite(QPatch.egg5tt, sprite5);
			Logger.Log("Started Patching JellyrayEgg");
			QPatch.egg6tt = TechTypeHandler.AddTechType("Jellyray Egg", "Jellyray Egg", "Required to hatch: Jellyshroom.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg6tt);
			LanguageHandler.SetTechTypeTooltip(TechType.JellyrayEgg, "Required to hatch: Jellyshroom.");
			KnownTechHandler.UnlockOnStart(QPatch.egg6tt);
			Atlas.Sprite sprite6 = SpriteManager.Get(TechType.JellyrayEgg);
			SpriteHandler.RegisterSprite(QPatch.egg6tt, sprite6);
			Logger.Log("Started Patching LavaLizardEgg");
			QPatch.egg7tt = TechTypeHandler.AddTechType("Lavalizard Egg", "Lavalizard Egg", "Required to hatch: Deep Shroom.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg7tt);
			LanguageHandler.SetTechTypeTooltip(TechType.LavaLizardEgg, "Required to hatch: Deep Shroom.");
			KnownTechHandler.UnlockOnStart(QPatch.egg7tt);
			Atlas.Sprite sprite7 = SpriteManager.Get(TechType.LavaLizardEgg);
			SpriteHandler.RegisterSprite(QPatch.egg7tt, sprite7);
			Logger.Log("Started Patching MesmerEgg");
			QPatch.egg8tt = TechTypeHandler.AddTechType("Mesmer Egg", "Mesmer Egg", "Required to hatch: Violet Beau.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg8tt);
			LanguageHandler.SetTechTypeTooltip(TechType.MesmerEgg, "Required to hatch: Violet Beau.");
			KnownTechHandler.UnlockOnStart(QPatch.egg8tt);
			Atlas.Sprite sprite8 = SpriteManager.Get(TechType.MesmerEgg);
			SpriteHandler.RegisterSprite(QPatch.egg8tt, sprite8);
			Logger.Log("Started Patching RabbitRayEgg");
			QPatch.egg9tt = TechTypeHandler.AddTechType("Rabbitray Egg", "Rabbitray Egg", "Required to hatch: Veined Nettle.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg9tt);
			LanguageHandler.SetTechTypeTooltip(TechType.RabbitrayEgg, "Required to hatch: Veined Nettle.");
			KnownTechHandler.UnlockOnStart(QPatch.egg9tt);
			Atlas.Sprite sprite9 = SpriteManager.Get(TechType.RabbitrayEgg);
			SpriteHandler.RegisterSprite(QPatch.egg9tt, sprite9);
			Logger.Log("Started Patching SandsharkEgg");
			QPatch.egg10tt = TechTypeHandler.AddTechType("Sandshark Egg", "Sandshark Egg", "Required to hatch: Writhing Weed.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg10tt);
			LanguageHandler.SetTechTypeTooltip(TechType.SandsharkEgg, "Required to hatch: Writhing Weed.");
			KnownTechHandler.UnlockOnStart(QPatch.egg10tt);
			Atlas.Sprite sprite10 = SpriteManager.Get(TechType.SandsharkEgg);
			SpriteHandler.RegisterSprite(QPatch.egg10tt, sprite10);
			Logger.Log("Started Patching ShockerEgg");
			QPatch.egg11tt = TechTypeHandler.AddTechType("Shocker Egg", "Shocker Egg", "Required to hatch: Bulb Bush.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg11tt);
			LanguageHandler.SetTechTypeTooltip(TechType.ShockerEgg, "Required to hatch: Bulb Bush.");
			KnownTechHandler.UnlockOnStart(QPatch.egg11tt);
			Atlas.Sprite sprite11 = SpriteManager.Get(TechType.ShockerEgg);
			SpriteHandler.RegisterSprite(QPatch.egg11tt, sprite11);
			Logger.Log("Started Patching SpadefishEgg");
			QPatch.egg12tt = TechTypeHandler.AddTechType("Spadefish Egg", "Spadefish Egg", "Required to hatch: Blue Palm.");
			LanguageHandler.SetTechTypeTooltip(TechType.SpadefishEgg, "Required to hatch: Blue Palm.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg12tt);
			KnownTechHandler.UnlockOnStart(QPatch.egg12tt);
			Atlas.Sprite sprite12 = SpriteManager.Get(TechType.SpadefishEgg);
			SpriteHandler.RegisterSprite(QPatch.egg12tt, sprite12);
			Logger.Log("Started Patching StalkerEgg");
			QPatch.egg13tt = TechTypeHandler.AddTechType("Stalker Egg", "Stalker Egg", "Required to hatch: Creepvine.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg13tt);
			LanguageHandler.SetTechTypeTooltip(TechType.StalkerEgg, "Required to hatch: Creepvine.");
			KnownTechHandler.UnlockOnStart(QPatch.egg13tt);
			Atlas.Sprite sprite13 = SpriteManager.Get(TechType.StalkerEgg);
			SpriteHandler.RegisterSprite(QPatch.egg13tt, sprite13);
			Logger.Log("Started Patching CutefishEgg");
			QPatch.egg14tt = TechTypeHandler.AddTechType("Cutefish Egg", "Cutefish Egg", "Required to hatch: AcidMushroom.");
			LanguageHandler.SetTechTypeTooltip(TechType.CutefishEgg, "Required to hatch: AcidMushroom.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg14tt);
			KnownTechHandler.UnlockOnStart(QPatch.egg14tt);
			Atlas.Sprite sprite14 = SpriteManager.Get(TechType.CutefishEgg);
			SpriteHandler.RegisterSprite(QPatch.egg14tt, sprite14);
			Logger.Log("Started Patching ReefbackEgg");
			QPatch.egg15tt = TechTypeHandler.AddTechType("Reefback Egg", "Reefback Egg", "Required to hatch: AcidMushroom.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg15tt);
			LanguageHandler.SetTechTypeTooltip(TechType.ReefbackEgg, "Required to hatch: AcidMushroom.");
			KnownTechHandler.UnlockOnStart(QPatch.egg15tt);
			Atlas.Sprite sprite15 = SpriteManager.Get(TechType.ReefbackEgg);
			SpriteHandler.RegisterSprite(QPatch.egg15tt, sprite15);
			Logger.Log("Started Patching JumperEgg");
			QPatch.egg16tt = TechTypeHandler.AddTechType("Jumper Egg", "Jumper Egg", "Required to hatch: AcidMushroom.");
			LanguageHandler.SetTechTypeTooltip(TechType.JumperEgg, "Required to hatch: AcidMushroom.");
			LanguageHandler.SetTechTypeTooltip(egg16tt, "Required to hatch: AcidMushroom.");
			CraftDataHandler.AddToGroup(TechGroup.Miscellaneous, TechCategory.Misc, QPatch.egg16tt);
			KnownTechHandler.UnlockOnStart(QPatch.egg16tt);
			Atlas.Sprite sprite16 = SpriteManager.Get(TechType.JumperEgg);
			SpriteHandler.RegisterSprite(QPatch.egg16tt, sprite16);
		}

	
		

		// Token: 0x04000002 RID: 2
		private static string _egg1_tooltip = "tooltip1";

		// Token: 0x04000003 RID: 3
		private static string _egg2_tooltip = "tooltip2";

		// Token: 0x04000004 RID: 4
		private static string _egg3_tooltip = "tooltip3";

		// Token: 0x04000005 RID: 5
		private static string _egg4_tooltip = "tooltip4";

		// Token: 0x04000006 RID: 6
		private static string _egg5_tooltip = "tooltip5";

		// Token: 0x04000007 RID: 7
		private static string _egg6_tooltip = "tooltip6";

		// Token: 0x04000008 RID: 8
		private static string _egg7_tooltip = "tooltip7";

		// Token: 0x04000009 RID: 9
		private static string _egg8_tooltip = "tooltip8";

		// Token: 0x0400000A RID: 10
		private static string _egg9_tooltip = "tooltip9";

		// Token: 0x0400000B RID: 11
		private static string _egg10_tooltip = "tooltip10";

		// Token: 0x0400000C RID: 12
		private static string _egg11_tooltip = "tooltip11";

		// Token: 0x0400000D RID: 13
		private static string _egg12_tooltip = "tooltip12";

		// Token: 0x0400000E RID: 14
		private static string _egg13_tooltip = "tooltip13";

		// Token: 0x0400000F RID: 15
		private static string _egg14_tooltip = "tooltip14";

		// Token: 0x04000010 RID: 16
		private static string _egg15_tooltip = "tooltip15";

		// Token: 0x04000011 RID: 17
		private static string _egg16_tooltip = "tooltip16";

		// Token: 0x04000012 RID: 18
		public static TechType egg1tt;

		// Token: 0x04000013 RID: 19
		public static TechType egg2tt;

		// Token: 0x04000014 RID: 20
		public static TechType egg3tt;

		// Token: 0x04000015 RID: 21
		public static TechType egg4tt;

		// Token: 0x04000016 RID: 22
		public static TechType egg5tt;

		// Token: 0x04000017 RID: 23
		public static TechType egg6tt;

		// Token: 0x04000018 RID: 24
		public static TechType egg7tt;

		// Token: 0x04000019 RID: 25
		public static TechType egg8tt;

		// Token: 0x0400001A RID: 26
		public static TechType egg9tt;

		// Token: 0x0400001B RID: 27
		public static TechType egg10tt;

		// Token: 0x0400001C RID: 28
		public static TechType egg11tt;

		// Token: 0x0400001D RID: 29
		public static TechType egg12tt;

		// Token: 0x0400001E RID: 30
		public static TechType egg13tt;

		// Token: 0x0400001F RID: 31
		public static TechType egg14tt;

		// Token: 0x04000020 RID: 32
		public static TechType egg15tt;

		// Token: 0x04000021 RID: 33
		public static TechType egg16tt;

		// Token: 0x04000022 RID: 34
		
	}
}
