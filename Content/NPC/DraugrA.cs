using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace Gloryofgods.Content.NPC
{
    public class DraugrA : ModNPC
    {

        private int frame = 0;
        private int timer = 0;
        private bool threw = false;
        private bool attacking = false;

        public override void SetDefaults()
        {
            npc.lifeMax = 250;
            npc.damage = 20;
            npc.defense = 8;
            npc.knockBackResist = 0.3f;
            npc.width = 36;
            npc.height = 50;
            npc.aiStyle = 3;
            aiType = NPCID.GoblinScout;
            npc.npcSlots = 0.5f;
            npc.HitSound = SoundID.NPCHit51;
            npc.noGravity = false;
            npc.DeathSound = SoundID.NPCDeath54;
            npc.value = Item.buyPrice(0, 0, 4, 0);
            
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("DraugrA");
            DisplayName.AddTranslation(GameCulture.Chinese, "");
            DisplayName.AddTranslation(GameCulture.Russian, "ДраугрА");
            Main.npcFrameCount[npc.type] = 7;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 1);
            npc.damage = (int)(npc.damage * 1);
        }

        

        public override void AI()
        {
            timer++;
            if (timer % 10 == 0)
            {
                frame++;
            }
            if (Main.rand.Next(100) == 0 && npc.HasPlayerTarget && Main.player[npc.target].statLife > 0)
            {
                if (Collision.CanHit(npc.Center, 1, 1, Main.player[npc.target].Center, 1, 1))
                {
                    attacking = true;
                }
            }
            if (!attacking && frame > 6)
            {
                frame = 0;
            }
            if (frame < 6 && attacking)
            {
                frame = 6;
            }
            if (attacking && frame > 6)
            {
                attacking = false;
                timer = 0;
                frame = 0;
                threw = false;
            }
            if (attacking)
            {
                Player player = Main.player[npc.target];
                npc.position.X = npc.oldPosition.X;
                if ((double)player.position.X > (double)npc.position.X)
                    npc.spriteDirection = 1;
                else if ((double)player.position.X < (double)npc.position.X)
                    npc.spriteDirection = -1;
                if (frame == 0 && !threw)
                {
                    threw = true;
                    Main.PlaySound(SoundID.Item1, npc.position);
                    Vector2 player2 = player.Center;
                    Vector2 vector2_1 = player2;
                    float speed = 10f;
                    Vector2 vector2_2 = vector2_1 - npc.Center;
                    float distance = (float)System.Math.Sqrt((double)vector2_2.X * (double)vector2_2.X + (double)vector2_2.Y * (double)vector2_2.Y);
                    vector2_2 *= speed / distance;
                    Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vector2_2.X, vector2_2.Y, mod.ProjectileType("ThrownAxe"), 80, 5.0f, 0, 0.0f, 0.0f);
                }
            }
            
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frame.Y = frameHeight * frame;
        }

        public override void NPCLoot()
        {
            if (Main.netMode != 1)
            {
                int centerX = (int)(npc.position.X + (float)(npc.width / 2)) / 16;
                int centerY = (int)(npc.position.Y + (float)(npc.height / 2)) / 16;
                int halfLength = npc.width / 2 / 16 + 1;
                if (Main.rand.Next(10) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ThrownAxe"), 1, false, 0, false, false);
                }
                if (Main.rand.Next(20) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ThrownAxe"), 1, false, 0, false, false);
                }
            }
        }
    }
}