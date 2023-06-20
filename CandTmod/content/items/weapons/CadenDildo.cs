using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CandTmod.content.items.weapons
{
    internal class CadenDildo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caden's Dildo");
            Tooltip.SetDefault("The dildo made from Caden's Dick");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededbyItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyle.ID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 5000;
            Item.knockBack = 30f;
            Item.crit = 90;

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