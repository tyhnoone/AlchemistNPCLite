using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPCLite.Items.Summoning
{
	public class BrewerHorcrux : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brewer Horcrux");
			Tooltip.SetDefault("The piece of Brewer's soul is inside it.");
			DisplayName.AddTranslation(GameCulture.Russian, "Крестраж Варщицы Зелий");
			Tooltip.AddTranslation(GameCulture.Russian, "Часть души Варщицы Зелий находится внутри");

            DisplayName.AddTranslation(GameCulture.Chinese, "药剂师魂器");
            Tooltip.AddTranslation(GameCulture.Chinese, "里面有药剂师的一片灵魂");
        }

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.maxStack = 30;
			item.value = 15000;
			item.rare = 6;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
			item.UseSound = SoundID.Item37;
			item.makeNPC = (short)mod.NPCType("Brewer");
		}

		public override void HoldItem(Player player)
		{
		Player.tileRangeX += 600;
        Player.tileRangeY += 600;
		}
		
		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(mod.NPCType("Brewer"));
		}

		public override void OnConsumeItem(Player player)
		{
			Main.NewText("A Brewer is spawned.", 255, 255, 255);
		}
	}
}