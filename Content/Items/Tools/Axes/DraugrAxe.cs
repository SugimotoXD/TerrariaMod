using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;


namespace Gloryofgods.Content.Items.Tools.Axes
{
    public class DraugrAxe : ModItem
    {
        public override void SetDefaults() // Характеристики предмета
        {
            item.damage = 7; // Наносимый урон
            item.melee = true; // Оружие ближнего боя
            item.width = 32; // Ширина 
            item.height = 28; // Высота
            item.useTime = 10; //Время использования
            item.useAnimation = 20; // Используемая анимация
            item.useStyle = 1;
            item.knockBack = 4; //Отталкиваие
            item.value = Item.sellPrice(0, 0, 0, 19); // Стоимость продажи
            item.rare = 0; // Редкость
            item.UseSound = SoundID.Item1; //Звуковой эффект
            item.autoReuse = true; //Автоматическое использование при зажатой кнопки мыши
            item.useTurn = true; // Повторное использование 
            item.axe = 8; // Сила рубки топором (Внутриигровая шкала которая определяет эффективность того или иного предмета)
        }

        public override void SetStaticDefaults() // Название предмета и его описание
        {
            DisplayName.SetDefault("Draugr Axe");
            Tooltip.SetDefault("GHUJFDSHGKJ");
            DisplayName.AddTranslation(GameCulture.Russian, "Топор Драугра");
            Tooltip.AddTranslation(GameCulture.Russian, "Создан из оскольков брони");

        }


        public override void AddRecipes() // Крафт предмета
        {
            ModRecipe recipe = new ModRecipe(mod); //Объявляем новый рецепт
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 18); //Первый требуемый предмет и его количество (18)
            recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>()); // На какой рабочей станции оно создается.
            recipe.SetResult(this);//После крафта получаем этот предмет
            recipe.AddRecipe();//Добавляем рецепт 
        }
    }
}