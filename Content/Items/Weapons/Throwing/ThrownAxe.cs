using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;


namespace Gloryofgods.Content.Items.Weapons.Throwing
{
	public class ThrownAxe : ModItem
	{

        public override void SetDefaults()
        {
            item.damage = 12;
            item.thrown = true;
            item.width = 14;
            item.height = 26;
            item.noUseGraphic = true;
            item.useTime = 12;
            item.useAnimation = 12;
            item.shoot = mod.ProjectileType("ThrownAxe");
            item.shootSpeed = 9f;
            item.useStyle = 1;
            item.knockBack = 3.5f;
            item.value = Item.sellPrice(0, 0, 0, 12);
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.maxStack = 999;
            item.consumable = true;

        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thrown Axe");
            DisplayName.AddTranslation(GameCulture.Russian, "Метательный топор");
        }


        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 12);
			recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>() );
			recipe.SetResult((this), 8);
			recipe.AddRecipe();
		}

	}
}



