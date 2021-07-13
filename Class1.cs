using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using hibubsmod;
namespace hibubsmod.Items
{
	public class stringbreaker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The stringerbreaker");
			Tooltip.SetDefault("reeeeeeeeeeeeeeee");
		}
		public override void SetDefaults()
		{
			item.damage = 430;//check
			item.active = true;//check
			item.melee = true;
			item.useStyle = 1;
			item.width = 40;//check
			item.height = 40;//check
			item.useTime = 10;//check
			item.useAnimation = 20;//check
			item.knockBack = 6;//check
			item.value = 10000;//check
			item.rare = ItemRarityID.Green; //check
			item.UseSound = SoundID.Item1;//check
			item.crit = 6;
			item.autoReuse = true;
			item.shoot = 34;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.shootSpeed = 50f;
			item.scale = 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(null,"e");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}