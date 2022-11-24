using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using Gloryofgods.Content.Items.Materials;

namespace Gloryofgods.Content.Items.Armor.AdArmor.SteelArmor
{
    [AutoloadEquip(new EquipType[] { EquipType.Legs })]
    public class SteelGraves : ModItem
    {
        public override void SetDefaults() //Пишутся характеристики предмета.
        {
            item.width = 22;
            item.height = 18;
            item.rare = 1;
            item.defense = 1;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void SetStaticDefaults() //Пишется название предмета и его описание. Предусмотрен автоматический перевод.
        {
            DisplayName.SetDefault("Steel Greaves");
            Tooltip.SetDefault("5% increased movement speed");
            DisplayName.AddTranslation(GameCulture.Russian, "Поножи из стали");
            Tooltip.AddTranslation(GameCulture.Russian, "Увеличивает скорость передвижения");
        }

        public override void UpdateEquip(Player player) //Пассивный бафф дающий скорость передвижения
        {
            player.moveSpeed += 0.05f;
        }

       


        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawShadowLokis = true;
        }

        public override void AddRecipes()  //Функция добавляющая крафт предмету из обычных/модовых предметов на обычном/модовом верстаке
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }

    }
}