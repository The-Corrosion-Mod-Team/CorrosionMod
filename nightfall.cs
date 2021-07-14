using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Hibubsmod.Projectiles;
namespace Hibubsmod.Buffs

{
	public class nightfall : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Nightfall");
			Description.SetDefault("placeholder");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (player.ownedProjectileCounts[ModContent.ProjectileType<feller>()] > 0)
			{
				player.buffTime[buffIndex] = 18000;
			}
			else
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}