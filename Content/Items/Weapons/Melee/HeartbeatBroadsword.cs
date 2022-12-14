using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XDContentMod.Content.Items.Weapons.Melee
{
	public class HeartbeatBroadsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heartbeat Broadsword");
//			Tooltip.SetDefault("At that time, that sword was only 0.01 cm away from me, but 4 seconds later, the Empress of Light completely fell in love with me");
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.PlatinumBroadsword);
			//Item.damage = 16;
			//Item.DamageType = DamageClass.Melee;
			//Item.width = 24;
			//Item.height = 28;
			//Item.useTime = 17;
			//Item.useAnimation = 19;
			//Item.useStyle = 1;
			//Item.knockBack = 6.5;
			//Item.value = Item.buyPrice(silver: 135);
			Item.rare = 0;
			//Item.UseSound = SoundID.Item1;
			//Item.autoReuse = false;
		}

		public override void AddRecipes()
		{

		}
	}
}