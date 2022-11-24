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
	public class DraugrSword : ModItem
	{
		public override void SetStaticDefaults() //Название и описание предмета
		{
			DisplayName.SetDefault("Draugr Sword");
			Tooltip.SetDefault("GHUJFDSHGKJ");
			DisplayName.AddTranslation(GameCulture.Russian, "Меч Драугра");
			Tooltip.AddTranslation(GameCulture.Russian, "Создан из оскольков брони");

		
	    }
		// Эта функция отвечает за наложение свечения и наложения дополнительной текстуры на определенный предмет (В Данный момент наш предмет получил свечение синиго цвета)
		public override void HoldItem(Player player) { AntiarisGlowMask2.AddGlowMask(mod.ItemType(GetType().Name), "Gloryofgods/Content/Items/Weapons/AdWeapon/" + GetType().Name + "_Glow"); }
		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI) { AntiarisUtils.DrawItemGlowMaskWorld(spriteBatch, item, mod.GetTexture("Gloryofgods/Content/Items/Weapons/AdWeapon/" + GetType().Name + "_Glow"), rotation, scale); }


		public override void SetDefaults() //Характеристики предмета
		{
			item.damage = 10;//Урон предмета
			item.melee = true;//Оружие ближнего боя
			item.width = 40;//Ширина
			item.height = 40;//Высота
			item.useTime = 20;//Время использования
			item.useAnimation = 20; //Анимация предмета
			item.useStyle = 1;
			item.knockBack = 6;//Сила отталкивания
			item.value = 10000;
			item.rare = 2;//Редкость предмета
			item.UseSound = SoundID.Item1;// Звук при использовании
			item.autoReuse = true;//Атоматическая атака 
		}

		public override void AddRecipes() //Добавление рецепта 
		{
			ModRecipe recipe = new ModRecipe(mod);//Объявляем новый рецепт 
			recipe.AddIngredient(ModContent.ItemType<Content.Items.Materials.ShardOfArmor>(), 21);//Требуемый предмет и его количество (21)
			recipe.AddTile(ModContent.TileType<Content.Tiles.Tigel>()); //Место где создается предмет
			recipe.SetResult(this);//Получаемый предмет
			recipe.AddRecipe();//Добавить рецепт в игру
		}
	}
}
// By Sugimoto //