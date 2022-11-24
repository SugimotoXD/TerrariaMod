using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;


namespace Gloryofgods.Content.Items.Weapons.AdWeapon
{
	public class DraugrPoleaxe : ModItem
	{

		public override void SetStaticDefaults() // Название и описание предмета
		{
			DisplayName.SetDefault("Draugr Poleaxe");
			Tooltip.SetDefault("GHUJFDSHGKJ");
			DisplayName.AddTranslation(GameCulture.Russian, "Секира Драугра");
			Tooltip.AddTranslation(GameCulture.Russian, "Создан из оскольков брони");

		}

		public override void SetDefaults() //Характеристики предмета
		{
			item.damage = 14;//Урон от предмета
			item.melee = true;//Оружие ближнего боя
			item.width = 10;//Ширина
			item.height = 10;//Высота
			item.useTime = 30;//Время использования
			item.useAnimation = 40;//Анимация при ударе
			item.useStyle = 1;
			item.knockBack = 6;//Сила отталкивания
			item.value = 100000;
			item.rare = 2;//Редкость
			item.UseSound = SoundID.Item1; //Звук при использования
			item.autoReuse = false; // Автоматическая автуха 
			
			


		}

		public override void AddRecipes() // Добавление рецепта предмета
		{
			ModRecipe recipe = new ModRecipe(mod); // Объявляем новый рецепт
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 30); //Первый требуемый предмет и его количество (30)
			recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>() );//Место где будет создаваться предмет
			recipe.SetResult(this);//Получаемый предмет
			recipe.AddRecipe();//Добавляем рецепт
		}

	}
}
// By Sugimoto //


