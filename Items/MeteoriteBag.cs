using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePandemoniummod.Items
{
	public class MeteoriteBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 11;
			item.expert = true;
			bossBagNPC = mod.NPCType("Moc");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			player.TryGettingDevArmor();
			int choice = Main.rand.Next(7);
			if (choice == 0)
			{
				player.QuickSpawnItem(mod.ItemType("MeteorBow"));
			}
			else if (choice == 1)
			{
				player.QuickSpawnItem(mod.ItemType("MeteoriteStaff"));
			}
			if (choice != 1)
			{
				player.QuickSpawnItem(ItemID.MeteoriteBar, 8);
			}
			player.QuickSpawnItem(mod.ItemType("MeteorLaser"));
		}
	}
}