
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Gloryofgods
{
    public class OreWorldGen : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(x => x.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("NewMod Ore Generation", OreGeneration));
            }
            
        }

        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "NewMod Mod Ores";

            for (int i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00009); i++) // ���� ��������, ��� 7E-04 = 0.0007 � ��� ���� ����� ������, �� ���� ������� ��� ����
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh - 7, (int)WorldGen.rockLayerHigh + 50);   // "worldSurfaceLow" ������������ ������ ������ ����, ������ �� ������ ������ (���� ����� ��� ������� ��� � �����������)

                Tile tile = Framing.GetTileSafely(x, y);
             //if (tile.active() && tile.type == TileID.SnowBlock)    //TileID.SnowBlock - ����� ������ � ������� �����, ��� ������ �� ����� ���� ���� ������ ���� if
             //{
             WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 10), WorldGen.genRand.Next(3, 6), ModContent.TileType< Content.Tiles.WorldGen.CoalOre > ()); //������ �����, ����� �������� ������ ���������.
             //}

            }
        }
    }
}