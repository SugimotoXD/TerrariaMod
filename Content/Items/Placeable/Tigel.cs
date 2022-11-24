using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

namespace Gloryofgods.Content.Items.Placeable
{
	public class Tigel : ModItem
	{
		public override void SetStaticDefaults() // Название и описание предмета
		{
			DisplayName.SetDefault("Tigel");
			Tooltip.SetDefault("Used for smelting ore and basic crafting");
			DisplayName.AddTranslation(GameCulture.Russian, "Тигель");
			Tooltip.AddTranslation(GameCulture.Russian, "Используется для переплавки руды и базовых рецептов.");
			
		}

		public override void SetDefaults() // Характеристики предмета
		{
			item.width = 54;
			item.height = 26;
			item.maxStack = 99; //Максимальное количество 
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.CloneDefaults(ItemID.Furnace);   // ID Предмета который он взаимозаменяет 
			item.CloneDefaults(ItemID.WorkBench); // ID Предмета который он взаимозаменяет
			item.createTile = ModContent.TileType<Tiles.Tigel>(); // Tile который отображается в мире и имеет анимацию


		}



		public override void AddRecipes() // Крафт предмета
		{
			ModRecipe recipe = new ModRecipe(mod); //Объявляем новый рецепт 
			recipe.AddIngredient(ItemID.WorkBench); // Первый требуемый предмет
			recipe.AddIngredient(ItemID.Furnace); // Второй требуемые предмет
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 26); // Третий требуемый предмет и его количество (26)
			recipe.SetResult(this); // При крафте получаем этот предмет 
			recipe.AddRecipe(); // Добавляем рецепт
		}
	}
}