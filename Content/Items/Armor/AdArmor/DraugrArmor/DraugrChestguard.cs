using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using Gloryofgods.Content.Items.Materials;

namespace Gloryofgods.Content.Items.Armor.AdArmor.DraugrArmor
{
    [AutoloadEquip(new EquipType[] { EquipType.Body })]
    public class DraugrChestguard : ModItem
    {
        public override void SetDefaults() //Тут прописывают характеристики предмета - Отбрасывание, защита и т.д. зависит от самого предмета.
        {
            item.width = 30;
            item.height = 20;
            item.rare = 1;                 
            item.defense = 3;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void SetStaticDefaults()                                        
        {
            DisplayName.SetDefault("Draugr Chestguard");//Отвечает за название предмета. 
            Tooltip.SetDefault("Immune to knockback");
            DisplayName.AddTranslation(GameCulture.Russian, "Нагрудник Драугра");
            Tooltip.AddTranslation(GameCulture.Russian, "Невосприимчивость к отбрасыванию"); //Так же параметр AddTranslation отвечает за автоматический перевод.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs) // Функция позволяющая давать игроку определенный бафф который усидяет его если он надевает на себя все доспехи из этого материала.
        {
            return  head.type == mod.ItemType("DraugrHats") && legs.type == mod.ItemType("DraugrGraves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.buffImmune[46] = true;

            
            player.setBonus = "При низком уровне здоровья повышает броню";
            if (player.statLife <= player.statLifeMax2 * 0.5)
            {
                player.statDefense += 5;
            }
 
        }

        
        public override void UpdateEquip(Player player) //Пассивный бафф дающий невоспреимчивость к отталкиванию который дается всегда.
        {
            player.noKnockback = true;
        }

        public override void AddRecipes() // функция добавляющая рецепт предмета и позволяет его создавать его с помощью предметов в игре и с помощью стандартного верстака либо же собственного.
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 15);   
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }


    }
}
// By Sugimoto //