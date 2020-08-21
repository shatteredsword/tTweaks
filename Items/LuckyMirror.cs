using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tTweaks.Items
{
	public class LuckyMirror : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Don't break this");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.useAnimation = 90;
			item.useTime = 90;
			item.useTurn = true;
			item.value = 1300000;
			item.rare = 1;
			item.UseSound = SoundID.Item6;
		}

		public override bool UseItem(Player player)
		{
			wait(1000);
			player.Spawn();
			return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.MagicMirror);
			//recipe.AddIngredient(ItemID.GreaterHealingPotion);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}