using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Gloryofgods.Content.Tiles.WorldGen
{
    public class CoalOre : ModTile
    {
        public override void SetDefaults()
        {

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            drop = ModContent.ItemType< Content.Items.Materials.Coal > ();
            AddMapEntry(Microsoft.Xna.Framework.Color.Black);
        }
    }
}
