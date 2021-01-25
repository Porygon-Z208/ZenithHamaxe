using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenithHamaxe.Items
{
	public class ZenithHamaxe : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("The Final Hammer");
		}

		public override void SetDefaults() {
			item.damage = 101;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 5;    
			item.axe = 60;
			item.hammer = 300;   
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}


		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperAxe);
			recipe.AddRecipeGroup("ZenithHamaxe:EvilHammer");
			recipe.AddRecipeGroup("ZenithHamaxe:EvilAxe");
			recipe.AddIngredient(ItemID.MeteorHamaxe);
			recipe.AddIngredient(ItemID.MoltenHamaxe);
			recipe.AddIngredient(ItemID.Pwnhammer);
			recipe.AddIngredient(ItemID.ChlorophyteGreataxe);
			recipe.AddIngredient(ItemID.SpectreHamaxe);
			recipe.AddRecipeGroup("ZenithHamaxe:LunarHamaxe"); 	
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}