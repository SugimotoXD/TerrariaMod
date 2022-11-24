using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gloryofgods.Content.Projectiles
{
	public class DrakomireFlame : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Drakomire Flame");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.timeLeft = 60;
			projectile.penetrate = -1;
			projectile.hostile = false;
			projectile.melee = true;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.hide = true;
		}

		public override bool PreAI()
		{
			if (projectile.velocity.Y < 8f)
				projectile.velocity.Y += 0.1f;


			Vector2 next = projectile.position + projectile.velocity;
			Tile inside = Main.tile[((int)projectile.position.X + (projectile.width >> 1)) >> 4, ((int)projectile.position.Y + (projectile.height >> 1)) >> 4];
			if (inside.active() && Main.tileSolid[inside.type])
			{
				projectile.position.Y -= 16f;
				return false;
			}

			if (Collision.WetCollision(next, projectile.width, projectile.height))
			{
				if (Main.player[projectile.owner].waterWalk)
				{
					projectile.velocity.Y = 5f;
				}
				else
				{
					projectile.timeLeft = 0;
				}
			}

			int num = Dust.NewDust(projectile.position, projectile.width * 6, projectile.height, DustID.SolarFlare, (float)Main.rand.Next(-3, 4), (float)Main.rand.Next(-3, 4), 100, default, 1f);
			Dust dust = Main.dust[num];
			dust.position.X = dust.position.X - 2f;
			dust.position.Y = dust.position.Y + 2f;
			dust.scale += (float)Main.rand.Next(50) * 0.01f;
			dust.noGravity = true;
			return false;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) => false;

		
	}
}