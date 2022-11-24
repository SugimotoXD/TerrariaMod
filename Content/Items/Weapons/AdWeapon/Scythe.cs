using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.Localization;
namespace Gloryofgods.Content.Items.Weapons.AdWeapon
{
	public class Scythe : ModItem
	{

		public override void SetStaticDefaults() //Название и описание предмета
		{
			DisplayName.SetDefault("Hel Skythe");
			Tooltip.SetDefault("Scythe of the Death God");
			DisplayName.AddTranslation(GameCulture.Russian, "Коса Хеля");
			Tooltip.AddTranslation(GameCulture.Russian, "Коса бога смерти");
		}


		public override void HoldItem(Player player) { AntiarisGlowMask2.AddGlowMask(mod.ItemType(GetType().Name), "Gloryofgods/Content/Items/Weapons/AdWeapon/" + GetType().Name + "_Glow"); }
		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI) { AntiarisUtils.DrawItemGlowMaskWorld(spriteBatch, item, mod.GetTexture("Gloryofgods/Content/Items/Weapons/AdWeapon/" + GetType().Name + "_Glow"), rotation, scale); }



		

		public override void SetDefaults()
		{
			item.damage = 150;
			item.melee = true;
			item.width = 14;
			item.height = 14;
			item.useTime = 20;
			item.useAnimation = 23;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() //Добавление рецепта 
		{
			ModRecipe recipe = new ModRecipe(mod);//Объявляем новый рецепт 
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfBlood>(), 100);//Требуемый предмет и его количество (100)
			recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>()); //Место где создается предмет
			recipe.SetResult(this);//Получаемый предмет
			recipe.AddRecipe();//Добавить рецепт в игру
		}
	}
}



