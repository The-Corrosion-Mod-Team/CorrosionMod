
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace hibubsmod.Items
{
	public class e : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("e");
			Tooltip.SetDefault("very epic sword");
		}
		public override void SetDefaults()
		{
			item.damage = 200	;//check
			item.active = true;//check
			item.melee = true;
			item.useStyle = 3;
			item.width = 40;//check
			item.height = 40;//check
			item.useTime = 30;//check
			item.useAnimation = 20;//check
			item.knockBack = 6;//check
			item.value = 10000;//check
			item.rare = ItemRarityID.Green; //check
			item.UseSound = SoundID.Item1;//check
			item.crit = 6;
			item.autoReuse = true;
			item.shoot = 16;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.shootSpeed = 45f;
			item.scale = 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 10);
			recipe.AddIngredient(ItemID.Keybrand, 1);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}