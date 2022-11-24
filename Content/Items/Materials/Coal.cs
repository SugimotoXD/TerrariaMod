using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

namespace Gloryofgods.Content.Items.Materials
{
	public class Coal : ModItem
	{
		
			public override void SetStaticDefaults() //Название и описание
			{
			DisplayName.SetDefault("Coal");
			Tooltip.SetDefault("Used for basic crafting");
			DisplayName.AddTranslation(GameCulture.Russian, "Уголь");
			Tooltip.AddTranslation(GameCulture.Russian, "Используется в базовых рецептах.");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
			}

			public override void SetDefaults()
			{
				item.useStyle = ItemUseStyleID.SwingThrow; // Стиль используемоего материала
				item.useTurn = true;
				item.useAnimation = 15;
				item.useTime = 10;
				item.autoReuse = true;
				item.maxStack = 999; //Максимальное количество в инвентаре 
				item.consumable = true;
			    item.createTile = ModContent.TileType< Content.Tiles.WorldGen.CoalOre > (); // Ссылка на материал для генерации в мире
			    item.width = 22;
				item.height = 22;
				item.value = 3000;
				item.material = true; 
				item.rare = ItemRarityID.Orange; // Редкость предмета
			}

		
	}

}
                                                                                                                                                                              // By Sugimoto //