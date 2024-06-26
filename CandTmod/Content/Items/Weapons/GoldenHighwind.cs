using Terraria.ID;
using Terraria.ModLoader;

namespace CandTmod.Content.Items.Weapons
{
    internal class GoldenHighwind : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 320;
            Item.height = 320;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 200;
            Item.knockBack = 0f;
            Item.crit = 10;

            Item.rare = ItemRarityID.Red;

            Item.UseSound = SoundID.Item12;
        }
    }
}


