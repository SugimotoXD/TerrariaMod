using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;

namespace Gloryofgods.Content.Tiles
{
	public class Tigel : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileTable[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.StyleWrapLimit = 89;
			animationFrameHeight = 54;
			TileObjectData.addTile(Type);
			adjTiles = new int[] { TileID.Furnaces };
			adjTiles = new int[] { TileID.WorkBenches };
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Тигель");
			name.AddTranslation(GameCulture.Russian, "Тигель");
			AddMapEntry(new Color(260, 270, 295), name);
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.8f;
			g = 0.6f;
			b = 0.6f;
		}


		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			frameCounter++;
			if (frameCounter >= 15)
			{
				frameCounter = 0;
				frame++;
				if (frame >= 4)
				{
					frame = 0;
				}
			}
		}
	}
}