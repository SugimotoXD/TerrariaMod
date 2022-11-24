using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Gloryofgods.Content.Items.Tools.Pickaxes
{
    public class DraugrPickaxe : ModItem
    {

        public override void SetStaticDefaults() //Название и описание предмета
        {
            DisplayName.SetDefault("Draugr Pickaxe");
            Tooltip.SetDefault("GHUJFDSHGKJ");
            DisplayName.AddTranslation(GameCulture.Russian, "Кирка Драугра");
            Tooltip.AddTranslation(GameCulture.Russian, "Создан из оскольков брони");
        
        }


        public override void SetDefaults() //Характеристики предмета
        {
            item.damage = 3; // Урон с предмета
            item.melee = true; // Оружие ближнего боя
            item.width = 32;//Ширина
            item.height = 32;//Высота
            item.useTime = 10;//Время испольования 
            item.useAnimation = 15;//Анимация предмета
            item.useStyle = 1;
            item.knockBack = 6; //Сила отталкивания
            item.value = Item.sellPrice(0, 0, 0, 21); //Цена продажи предмета
            item.rare = 0; //Редкость
            item.UseSound = SoundID.Item1; //Используемый звук
            item.autoReuse = true; //Автоматическое использование при зажатой кнопке
            item.useTurn = true;//Повторяющееся использование
            item.pick = 40;
        }

        

        public override void AddRecipes() //Рецепт предмета
        {
            ModRecipe recipe = new ModRecipe(mod); //Объявляем новый рецепт
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 20); //Первый требуемый предмет и его количество (20)
            recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>()); // На какой рабочей станции предмет будет создаваться
            recipe.SetResult(this);//После крафта получаем предмет
            recipe.AddRecipe();//Добавляем рецепт 
        }

    }
}
// By Sugimoto //