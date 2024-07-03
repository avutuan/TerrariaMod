//Caden
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Terraria.GameContent.Creative;

namespace CandTmod.Content.Items.Weapons
{
    internal class Chancla : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 128;
            Item.height = 128;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 50;
            Item.knockBack = 100f;
            Item.crit = 100;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Blue;

            Item.UseSound = SoundID.Item1;
        }
    }   
}