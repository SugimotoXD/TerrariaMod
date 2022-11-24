using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using System.Collections.Generic;



namespace Gloryofgods.Content.Projectiles.Thrown
{
	public class ThrownAxe : ModProjectile
	{
		public override string Texture => "Gloryofgods/Content/Projectiles/Thrown/ThrownAxe";

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ghost Shuriken");

		}



		public override void SetDefaults()
		{

			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = false;
			projectile.timeLeft = 1000;
			projectile.aiStyle = 2;
			projectile.tileCollide = true;
			projectile.melee = true;
		}

        public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
        {
            if (targetHitbox.Width > 8 && targetHitbox.Height > 8)
            {
                targetHitbox.Inflate(-targetHitbox.Width / 8, -targetHitbox.Height / 8);
            }
            return projHitbox.Intersects(targetHitbox);
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 1, 1f, 0f);
            Vector2 usePos = projectile.position;
            Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2();
            usePos += rotVector * 16f;

            int item = 0;

            if (Main.netMode == 1 && item >= 0)
            {
                NetMessage.SendData(MessageID.KillProjectile);

            }


            if (Main.rand.NextFloat() < 0.18f)
            {
                item = Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, ModContent.ItemType<Content.Items.Weapons.Throwing.ThrownAxe> (), 1, false, 0, false, false);
            }

            if (Main.netMode == 1 && item >= 0)
            {
                NetMessage.SendData(Terraria.ID.MessageID.SyncItem, -1, -1, null, item, 1f, 0f, 0f, 0, 0, 0);
            }
        }
    }
}


	
