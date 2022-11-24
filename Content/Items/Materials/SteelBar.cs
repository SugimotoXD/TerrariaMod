using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

namespace Gloryofgods.Content.Items.Materials
{
	public class SteelBar : ModItem
	{
		
			public override void SetStaticDefaults() //Название и описание
			{
			DisplayName.SetDefault("Steel Bar");
			Tooltip.SetDefault("Used for craft steel items");
			DisplayName.AddTranslation(GameCulture.Russian, "Стальной слиток");
			Tooltip.AddTranslation(GameCulture.Russian, "Используется для крафта стальных предметов.");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
			}

			public override void SetDefaults() // Характеристики предмета
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.useTurn = true;
				item.useAnimation = 15;
				item.useTime = 10;
				item.autoReuse = true;
				item.maxStack = 99; // максимальное количество предмета в инвентаре игрока
				item.consumable = true;	
				item.width = 22;
				item.height = 22;
				item.value = 3000;
				item.material = true;
				item.rare = ItemRarityID.Orange; // Редкость предмета
			}

		    public override void AddRecipes() //Добавляет рецепт крафта предмета
		    {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 8); // Количество требуемого предмета 1
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.Coal>(), 6); // Количество требуемого предмета 2
			recipe.AddIngredient(ItemID.IronBar); // ID Предмета который должен скрафтиться 
			recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>()); // Рабочая станция которая используется для крафта
			recipe.SetResult(this); // Получение прелмета
			recipe.AddRecipe(); // Добавление рецепта
		    }
	}

}