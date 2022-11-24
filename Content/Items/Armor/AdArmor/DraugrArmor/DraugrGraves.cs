using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using Gloryofgods.Content.Items.Materials;

namespace Gloryofgods.Content.Items.Armor.AdArmor.DraugrArmor
{
    [AutoloadEquip(new EquipType[] { EquipType.Legs })]
    public class DraugrGraves : ModItem
    {
        public override void SetDefaults()  //Тут прописывают характеристики предмета - Отбрасывание, защита и т.д. зависит от самого предмета.
        {
            item.width = 22;
            item.height = 18;
            item.rare = 1;                                 
            item.defense = 1;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void SetStaticDefaults() //Отвечает за название предмета. 
        {
            DisplayName.SetDefault("Draugr Greaves");
            Tooltip.SetDefault("5% increased movement speed");
            DisplayName.AddTranslation(GameCulture.Russian, "Поножи Драугра");
            Tooltip.AddTranslation(GameCulture.Russian, "Увеличивает скорость передвижения"); //Так же параметр AddTranslation отвечает за автоматический перевод.
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;
        }

       


        public override void ArmorSetShadows(Player player) //Пассивный бафф 
        {
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawShadowLokis = true;
        }

        public override void AddRecipes()   // функция добавляющая рецепт предмета и позволяет его создавать его с помощью предметов в игре и с помощью стандартного верстака либо же собственного.      
        {
            ModRecipe recipe = new ModRecipe(mod); 
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }

    }
}