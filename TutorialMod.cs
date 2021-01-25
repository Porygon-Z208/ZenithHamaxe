using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace ZenithHamaxe
{
	public class ZenithHamaxe : Mod
	{
		public ZenithHamaxe()
	{		
	}
			public override void AddRecipeGroups()
{
	RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Lunar Hamaxe", new int[]
	{
		ItemID.LunarHamaxeSolar,
		ItemID.LunarHamaxeNebula,
		ItemID.LunarHamaxeVortex,
		ItemID.LunarHamaxeStardust
	});
	RecipeGroup.RegisterGroup("ZenithHamaxe:LunarHamaxe", group);

	RecipeGroup test = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Axe", new int[]
	{
		ItemID.BloodLustCluster,
		ItemID.WarAxeoftheNight
	});
	RecipeGroup.RegisterGroup("ZenithHamaxe:EvilAxe", test);

	RecipeGroup test2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Hammer", new int[]
	{
		ItemID.TheBreaker,
		ItemID.FleshGrinder
	});
	RecipeGroup.RegisterGroup("ZenithHamaxe:EvilHammer", test2);
}
	}
}