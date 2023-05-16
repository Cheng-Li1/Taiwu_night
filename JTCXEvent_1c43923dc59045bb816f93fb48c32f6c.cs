using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_1c43923dc59045bb816f93fb48c32f6c : TaiwuEventItem
	{
		public JTCXEvent_1c43923dc59045bb816f93fb48c32f6c()
		{
			Guid = Guid.Parse("1c43923d-c590-45bb-816f-93fb48c32f6c");
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
			EventOptions = new TaiwuEventOption[4]
			{
			new TaiwuEventOption
			{
				OptionKey = "Option_-1620887589"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_1824242141"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-344964762"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-846069583"
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
			EventOptions[1].OnOptionVisibleCheck = OnOption2VisibleCheck;
			EventOptions[1].OnOptionAvailableCheck = OnOption2AvailableCheck;
			EventOptions[1].GetReplacedContent = OnOption2GetReplacedContent;
			EventOptions[1].OnOptionSelect = OnOption2Select;
			EventOptions[1].GetExtraFormatLanguageKeys = Option2GetExtraFormatLanguageKeys;
			OnOption2Create();
			EventOptions[2].OnOptionVisibleCheck = OnOption3VisibleCheck;
			EventOptions[2].OnOptionAvailableCheck = OnOption3AvailableCheck;
			EventOptions[2].GetReplacedContent = OnOption3GetReplacedContent;
			EventOptions[2].OnOptionSelect = OnOption3Select;
			EventOptions[2].GetExtraFormatLanguageKeys = Option3GetExtraFormatLanguageKeys;
			OnOption3Create();
			EventOptions[3].OnOptionVisibleCheck = OnOption4VisibleCheck;
			EventOptions[3].OnOptionAvailableCheck = OnOption4AvailableCheck;
			EventOptions[3].GetReplacedContent = OnOption4GetReplacedContent;
			EventOptions[3].OnOptionSelect = OnOption4Select;
			EventOptions[3].GetExtraFormatLanguageKeys = Option4GetExtraFormatLanguageKeys;
			OnOption4Create();
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
			return "33e4e248-79da-43b1-8e1c-d3279bfbe55f";
		}

		public List<string> Option1GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption2Create()
		{
		}

		private bool OnOption2VisibleCheck()
		{
			return true;
		}

		private bool OnOption2AvailableCheck()
		{
			return true;
		}

		private string OnOption2GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption2Select()
		{
			return "034b567d-5f2c-4755-b84c-70d0e38e4e09";
		}

		public List<string> Option2GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption3Create()
		{
		}

		private bool OnOption3VisibleCheck()
		{
			return true;
		}

		private bool OnOption3AvailableCheck()
		{
			return true;
		}

		private string OnOption3GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption3Select()
		{
			return "3457e54a-d258-4e47-9dc9-d3e05ed3372c";
		}

		public List<string> Option3GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption4Create()
		{
		}

		private bool OnOption4VisibleCheck()
		{
			return true;
		}

		private bool OnOption4AvailableCheck()
		{
			return true;
		}

		private string OnOption4GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption4Select()
		{
			return "79453a62-27b5-4d38-b925-9f277cd69248";
		}

		public List<string> Option4GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}