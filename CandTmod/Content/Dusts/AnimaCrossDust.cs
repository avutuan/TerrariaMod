using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CandTmod.Content.Dusts	
{
	public class AnimaCrossDust : ModDust
	{
		public override void SetStaticDefaults() {
			UpdateType = 110;
		}
		public override void OnSpawn(Dust dust) {
			dust.velocity *= 0.6f;
			dust.noGravity = false;
			dust.noLight = true;
			dust.scale = 1f;
		}
	}
}	