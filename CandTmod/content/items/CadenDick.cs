using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CandTmod.Content.Items
{
    public class CadenDick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caden's Dick");
            Tooltip.SetDefault("The schlonger of Caden");
        }
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.value = Item.buyPrice(copper: 5);
            Item.maxStack = 999;
        }
    }
}