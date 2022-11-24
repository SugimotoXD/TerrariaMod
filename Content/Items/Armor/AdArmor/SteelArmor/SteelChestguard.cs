using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using Gloryofgods.Content.Items.Materials;

namespace Gloryofgods.Content.Items.Armor.AdArmor.SteelArmor
{
    [AutoloadEquip(new EquipType[] { EquipType.Body })]
    public class SteelChestguard : ModItem
    {
        public override void SetDefaults() //Пишутся характеристики предмета.
        {
            item.width = 30;
            item.height = 20;
            item.rare = 1;
            item.defense = 3;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void SetStaticDefaults() //Пишется название предмета и его описание. Предусмотрен автоматический перевод.
        {
            DisplayName.SetDefault("Steel Chestguard");
            Tooltip.SetDefault("");
            DisplayName.AddTranslation(GameCulture.Russian, "Нагрудник из стали");
            Tooltip.AddTranslation(GameCulture.Russian, "");
        }

        public override bool IsArmorSet(Item head, Item body, Item legs) // Функция отвечающая за бафф игрока на которого надет сетт (Полный набор брони) 
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

        
        public override void UpdateEquip(Player player)//Пассивный бафф невоспреимчивость к отталкиванию 
        {
            player.noKnockback = true;
        }

        public override void AddRecipes() //Функция добавляющая крафт предмету из обычных/модовых предметов на обычном/модовом верстаке
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 15);   
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }


    }
}