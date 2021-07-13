using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace hibubsmod.projectiles
{
	public class starts : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("starter item");
		}

		public override void SetDefaults()
		{
			projectile.aiStyle = 3;
			projectile.width = 20;
			projectile.height = 20;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.light = 10f;
		}
	}
}