using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Gloryofgods.Content.NPC
{ 

    public class Draugr : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Draugr");

            Main.npcFrameCount[npc.type] = 15;
        }

        public override void SetDefaults()
        {
            npc.width = 30;
            npc.height = 50;
            npc.damage = 15;
            npc.defense = 6;
            npc.lifeMax = 60;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 600f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 3;
            animationType = animationType = 269;
            aiType = 269; 
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++)
            {
                int dustType = Main.rand.Next(139, 143);
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
            }
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < .5023f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("ShardOfArmor"), -1 + Main.rand.Next(5)); // Выпадения лута

            }

            if (Main.rand.NextFloat() < .2023f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("ShardOfBlood"), -1 + Main.rand.Next(5)); // Выпадения лута
            }
        }
   


        public override void PostDraw(SpriteBatch spriteBatch, Color drawColor)
        {

            var GlowMask = mod.GetTexture("Content/Glow/GlowNPC/Draugr_GlowMask");
            var Effects = npc.direction == -1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally;
            spriteBatch.Draw(GlowMask, npc.Center - Main.screenPosition + new Vector2(0, npc.gfxOffY), npc.frame, Color.White, npc.rotation, npc.frame.Size() / 2, npc.scale, Effects, 0);

        }



        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.35f; // Шанс спавна Моба
        }

        
       
    }
}
	