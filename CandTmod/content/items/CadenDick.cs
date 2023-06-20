using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CandTmod.content.items.weapons
{
    internal class CadenDick : ModItem
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Caden's Dick");
            Tooltip.SetDefault("The schlonger of Caden");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededbyItemId[Type] = 100;
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 5)
            Item.maxStack = 999;
        }
    }
}