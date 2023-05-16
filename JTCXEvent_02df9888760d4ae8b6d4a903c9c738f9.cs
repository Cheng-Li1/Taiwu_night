using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.DisplayEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_02df9888760d4ae8b6d4a903c9c738f9 : TaiwuEventItem
	{
		public JTCXEvent_02df9888760d4ae8b6d4a903c9c738f9()
		{
			Guid = Guid.Parse("02df9888-760d-4ae8-b6d4-a903c9c738f9");
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
				OptionKey = "Option_169978204"
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
			EventInputRequestData eventInputRequestData = new EventInputRequestData();
			eventInputRequestData.DataKey = "InputResult";
			eventInputRequestData.InputDataType = 3;
			eventInputRequestData.NumberRange = new int[2] { 1, 10 };
			ArgBox.Set("InputRequestData", eventInputRequestData);
			EventHelper.AddEventInListenWithActionName(Guid.ToString(), ArgBox, "InputActionComplete");
		}

		public override void OnEventExit()
		{
			EventHelper.AddEventInListen(string.Empty, null);
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
			string arg = string.Empty;
			if (ArgBox.Get("InputResult", ref arg))
			{
				ArgBox.Set("chengweitaiwu", arg);
			}
			return "0e71ec55-e577-4b76-af55-78bfbad46b6e";
		}

		public List<string> Option1GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}