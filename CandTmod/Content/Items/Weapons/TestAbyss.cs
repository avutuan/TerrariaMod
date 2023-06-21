using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using CandTmod.Content.Projectiles;

namespace CandTmod.Content.Items.Weapons
{

	public class TestAbyss : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Testing Abyss");
			Tooltip.SetDefault("This is a modded sword that shoots Star Wrath-like projectiles. (testing)");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 64;
			Item.height = 64;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 139;
			Item.knockBack = 10f;
			Item.crit = 9;

			Item.value = Item.buyPrice(gold: 5);
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;

			Item.shoot = ModContent.ProjectileType<TestAbyssProjectile>(); // ID of the projectiles the sword will shoot
			Item.shootSpeed = 20f; // Speed of the projectiles the sword will shoot

		}

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			Vector2 target = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f) {
				ceilingLimit = player.Center.Y - 200f;
			}
			// Loop these functions 3 times.
			for (int i = 0; i < 3; i++) {
				position = player.Center - new Vector2(Main.rand.NextFloat(401) * player.direction, 600f);
				position.Y -= 100 * i;
				Vector2 heading = target - position;

				if (heading.Y < 0f) {
					heading.Y *= -1f;
				}

				if (heading.Y < 20f) {
					heading.Y = 20f;
				}

				heading.Normalize();
				heading *= velocity.Length();
				heading.Y += Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(source, position, heading, type, damage * 2, knockback, player.whoAmI, 0f, ceilingLimit);
			}

			return false;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(6) == 0)
            {
				Dust.NewDust(Item.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);

            }
        }
		// public override void AI()
		// {
		// 	int dust = Dust.NewDust(Item.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
		// 	Main.dust[dust].velocity *= 0.3f;
		// 	Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
		// 	Main.dust[dust].noGravity = true;

		// 	int dust2 = Dust.NewDust(Item.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
		// 	Main.dust[dust2].velocity *= 0.3f;
		// 	Main.dust[dust2].scale = (float)Main.rand.Next(80, 115) * 0.013f;
		// 	Main.dust[dust2].noGravity = true;

		// }	
	}
}