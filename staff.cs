using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Hibubsmod.projectiles;

namespace Hibubsmod.Items
{
	public class staff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("e");
		}

		public override void SetDefaults()
		{
			item.damage = 99999;
			item.magic = true;
			item.mana = 14;
			item.width = 26;
			item.height = 26;
			item.useTime = 120;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.noMelee = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.knockBack = 8;
			item.value = Item.sellPrice(silver: 50);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item9; ;
			item.shoot = ModContent.ProjectileType<Hibubsmod.projectiles.MagicMissile>();
			item.shootSpeed = 10f;
		}
	}
}
