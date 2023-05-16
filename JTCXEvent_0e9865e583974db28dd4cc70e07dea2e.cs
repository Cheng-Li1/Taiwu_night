using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_0e9865e583974db28dd4cc70e07dea2e : TaiwuEventItem
	{
		public JTCXEvent_0e9865e583974db28dd4cc70e07dea2e()
		{
			Guid = Guid.Parse("0e9865e5-8397-4db2-8dd4-cc70e07dea2e");
			IsHeadEvent = false;
			EventGroup = "jutichunxiao";
			ForceSingle = false;
			EventType = EEventType.ModEvent;
			TriggerType = EventTrigger.None;
			EventSortingOrder = 500;
			MainRoleKey = "RoleTaiwu";
			TargetRoleKey = "ren";
			EventBackground = "";
			MaskControl = 0;
			MaskTweenTime = 0f;
			EscOptionKey = "";
			EventOptions = new TaiwuEventOption[1]
			{
			new TaiwuEventOption
			{
				OptionKey = "Option_243714369"
			}
			};
			InitOptions();
		}

		private void InitOptions()
		{
			EventOptions[0].OnOptionVisibleCheck = OnOption1VisibleCheck;
			EventOptions[0].OnOptionAvailableCheck = OnOption1AvailableCheck;
			EventOptions[0].GetReplacedContent = OnOption1GetReplacedContent;
			EventOptions[0].OnOptionSelect = OnOption1Select;
			EventOptions[0].GetExtraFormatLanguageKeys = Option1GetExtraFormatLanguageKeys;
			OnOption1Create();
		}

		public override bool OnCheckEventCondition()
		{
			return true;
		}

		public override void OnEventEnter()
		{
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

		private void OnOption1Create()
		{
		}

		private bool OnOption1VisibleCheck()
		{
			return true;
		}

		private bool OnOption1AvailableCheck()
		{
			return true;
		}

		private string OnOption1GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption1Select()
		{
			return string.Empty;
		}

		public List<string> Option1GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}