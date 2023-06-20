using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CandTmod.Content.Items.Weapons
{
    internal class GardenScythe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Garden Scythe");
            Tooltip.SetDefault("The flowers are beautiful");
        }
        public override void SetDefaults()
        {
            Item.width = 320;
            Item.height = 320;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 8;
            Item.useAnimation = 8;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 1;
            Item.knockBack = 90f;
            Item.crit = 100;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
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