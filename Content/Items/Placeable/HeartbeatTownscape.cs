using Terraria.ID;
using Terraria.ModLoader;
namespace XDContentMod.Content.Items.Placeable
{
	public class HeartbeatTownscape : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heartbeat Townscape");
//			Tooltip.SetDefault("A view of Heartbeat Town Center buildings.");
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 50;
			Item.rare = ItemRarityID.White;

			Item.maxStack = 99;

			Item.useStyle = 1;
			Item.useTime = 10;
			Item.useAnimation = 15;

			Item.useTurn = true;
			Item.autoReuse = true;
			Item.consumable = true;

			Item.createTile = ModContent.TileType<Content.Tiles.Paintings.HeartbeatTownscape_Painting>();
		}

	}
}