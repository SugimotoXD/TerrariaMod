using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using Gloryofgods.Content.Items.Materials;



namespace Gloryofgods.Content.Items.Armor.AdArmor.DraugrArmor
{
    [AutoloadEquip(new EquipType[] { EquipType.Head })]
    public class DraugrHats : ModItem
    {
        public override void SetDefaults() //Тут прописывают характеристики предмета - Отбрасывание, защита и т.д. зависит от самого предмета.
        {
            item.width = 24;
            item.height = 24;
            item.rare = 1;
            item.defense = 2;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void SetStaticDefaults() //Отвечает за название предмета.
        {
            DisplayName.SetDefault("Draug Helmet");
            Tooltip.SetDefault("increase melee damage by 25%");
            DisplayName.AddTranslation(GameCulture.Russian, "Шлем Драугра");
            Tooltip.AddTranslation(GameCulture.Russian, "Увеличивает урон в ближнем бою на 25%"); //Так же параметр AddTranslation отвечает за автоматический перевод.
        }

        public override void UpdateEquip(Player player) // Пассивный бафф дающий + 25% к урону при надетом на игроке шлеме
        {
            player.meleeDamage += 0.25f;
        }

        public override void AddRecipes() // функция добавляющая рецепт предмета и позволяет его создавать его с помощью предметов в игре и с помощью стандартного верстака либо же собственного.    
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(),10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}