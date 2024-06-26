using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CandTmod.Content.Projectiles
{
	// This Example show how to implement simple homing projectile
	// Can be tested with ExampleCustomAmmoGun
	public class TestAbyssProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			ProjectileID.Sets.CultistIsResistantTo[Projectile.type] = true; // Make the cultist resistant to this projectile, as it's resistant to all homing projectiles.
		}

		// Setting the default parameters of the projectile
		// You can check most of Fields and Properties here https://github.com/tModLoader/tModLoader/wiki/Projectile-Class-Documentation
		public override void SetDefaults() {
			Projectile.width = 128; // The width of projectile hitbox
			Projectile.height = 128; // The height of projectile hitbox

			Projectile.aiStyle = 0; // The ai style of the projectile (0 means custom AI). For more please reference the source code of Terraria
			Projectile.DamageType = DamageClass.Melee; // What type of damage does this projectile affect?
			Projectile.friendly = true; // Can the projectile deal damage to enemies?
			Projectile.hostile = false; // Can the projectile deal damage to the player?
			Projectile.ignoreWater = true; // Does the projectile's speed be influenced by water?
			Projectile.light = 5f; // How much light emit around the projectile
			Projectile.tileCollide = false; // Can the projectile collide with tiles?
			Projectile.timeLeft = 300; // The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
		}
		public override void AI()
		{
			int dust = Dust.NewDust(Projectile.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity *= 0.3f;
			Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust].noGravity = true;

			int dust2 = Dust.NewDust(Projectile.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust2].velocity *= 0.3f;
			Main.dust[dust2].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust2].noGravity = true;

		}	
	}
}