using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Gloryofgods.Content.Items.Equipables
{
    public class FoxRing : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 34;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 15, 0);
            item.rare = 8;
            item.UseSound = SoundID.Item81;
            item.noMelee = true;
            item.mountType = mod.MountType("Drakomire");
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Drakomire Ring");
            Tooltip.SetDefault("Summons a rideable Drakomire mount");
            DisplayName.AddTranslation(GameCulture.Russian, "Drakomire Ring");
            Tooltip.AddTranslation(GameCulture.Russian, "Призывает наездного Drakomire");
        }

        public override void AddRecipes() //Добавление рецепта 
        {
            ModRecipe recipe = new ModRecipe(mod);//Объявляем новый рецепт 
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 100);//Требуемый предмет и его количество (100)
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.SteelBar>(), 100);//Требуемый предмет и его количество (100)
            recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>()); //Место где создается предмет
            recipe.SetResult(this);//Получаемый предмет
            recipe.AddRecipe();//Добавить рецепт в игру
        }

    }
}