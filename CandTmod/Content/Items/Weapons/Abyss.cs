using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CandTmod.Content.Items.Weapons
{
    internal class Abyss : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Abyss");
            Tooltip.SetDefault("The abyssal damnation");
        }
        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 139;
            Item.knockBack = 10f;
            Item.crit = 9;

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