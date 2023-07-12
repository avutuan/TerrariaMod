using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using CandTmod.Content.Projectiles;
using CandTmod.Content.Dusts;

namespace CandTmod.Content.Items.Weapons
{

	public class AnimaCross : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Anima Cross");
			Tooltip.SetDefault("This is a modded sword that shoots Star Wrath-like projectiles. (testing)");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 96;
			Item.height = 96;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 21;
			Item.useAnimation = 21;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 250;
			Item.knockBack = 5f;
			Item.crit = 12;

			Item.value = Item.buyPrice(gold: 5);
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
		}
		
		public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(6) == 0)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<AnimaCrossDust>());
            }
        }
	}
}