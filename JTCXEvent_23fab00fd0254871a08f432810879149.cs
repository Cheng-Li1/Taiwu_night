using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_23fab00fd0254871a08f432810879149 : TaiwuEventItem
	{
		public JTCXEvent_23fab00fd0254871a08f432810879149()
		{
			Guid = Guid.Parse("23fab00f-d025-4871-a08f-432810879149");
			IsHeadEvent = false;
			EventGroup = "jutichunxiao";
			ForceSingle = false;
			EventType = EEventType.ModEvent;
			TriggerType = EventTrigger.None;
			EventSortingOrder = 500;
			MainRoleKey = "";
			TargetRoleKey = "";
			EventBackground = "";
			MaskControl = 0;
			MaskTweenTime = 0f;
			EscOptionKey = "";
			EventOptions = new TaiwuEventOption[0];
			InitOptions();
		}

		private void InitOptions()
		{
		}

		public override bool OnCheckEventCondition()
		{
			return true;
		}

		public override void OnEventEnter()
		{
			EventHelper.SetStopAutoNextEvent(stopFlag: false);
			int arg = 0;
			if (ArgBox.Get("CombatResult", ref arg))
			{
				switch (arg)
				{
					case 5:
						EventHelper.ToEvent("b41b6268-9bae-4a27-91fc-6dc07e97d73e");
						break;
					case 0:
						EventHelper.ToEvent("b41b6268-9bae-4a27-91fc-6dc07e97d73e");
						break;
					case 1:
						EventHelper.ToEvent("e4f78439-e923-41a1-800d-f7a0c4017cbe");
						break;
					case 4:
						EventHelper.ToEvent("e4f78439-e923-41a1-800d-f7a0c4017cbe");
						break;
					case 2:
						EventHelper.ToEvent("b41b6268-9bae-4a27-91fc-6dc07e97d73e");
						break;
					case 3:
						EventHelper.ToEvent("b41b6268-9bae-4a27-91fc-6dc07e97d73e");
						break;
				}
			}
		}

		public override void OnEventExit()
		{
		}

		public override string GetReplacedContentString()
		{
			return string.Empty;
		}

		public override List<string> GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}