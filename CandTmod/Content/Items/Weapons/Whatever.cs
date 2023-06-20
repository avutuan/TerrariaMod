using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CandTmod.Content.Items.Weapons
{
    internal class Whatever : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("What Ever");
            Tooltip.SetDefault("The What Ever");
        }
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 9999;
            Item.knockBack = 33f;
            Item.crit = 99;

            Item.value = Item.buyPrice(platinum: 1);
            Item.rare = ItemRarityID.Blue;

            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<CadenDick>(), 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }   
}