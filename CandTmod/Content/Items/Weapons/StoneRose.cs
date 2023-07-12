using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CandTmod.Content.Items.Weapons
{
    internal class StoneRose : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Rose");
            Tooltip.SetDefault("The stone flowers are beautiful");
        }
        public override void SetDefaults()
        {
            Item.width = 116;
            Item.height = 116;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 134;
            Item.knockBack = 0f;
            Item.crit = 10;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Red;

            Item.UseSound = SoundID.Item1;
        }
    }   
}