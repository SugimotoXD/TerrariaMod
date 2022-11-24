using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using Gloryofgods.Content.Items.Materials;



namespace Gloryofgods.Content.Items.Armor.AdArmor.SteelArmor
{
    [AutoloadEquip(new EquipType[] { EquipType.Head })]

    public class SteelHats : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 24;                                  //       //
            item.height = 24;                                // Статы //
            item.rare = 1;                                  //       //
            item.defense = 2;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Helmet"); 
            Tooltip.SetDefault("");                                                       //                     //
            DisplayName.AddTranslation(GameCulture.Russian, "Шлем из стали");            // Название и Описание //
            Tooltip.AddTranslation(GameCulture.Russian, "");                            //                     //
        }

        public override void UpdateEquip(Player player)

        {                                                                 //      //
                                                                         // Бафы //
        }                                                               //      //


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);                                                           //       //
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.SteelBar>(),10);               // Крафт //
            recipe.AddTile(TileID.Anvils);                                                                 //       //
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}