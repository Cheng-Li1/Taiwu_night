using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_07c5b0579be34234a3b32a60cfab0302 : TaiwuEventItem
	{
		public JTCXEvent_07c5b0579be34234a3b32a60cfab0302()
		{
			Guid = Guid.Parse("07c5b057-9be3-4234-a3b3-2a60cfab0302");
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
			EventOptions = new TaiwuEventOption[5]
			{
			new TaiwuEventOption
			{
				OptionKey = "Option_1102073434"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_1648675621"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-2092261697"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-1410099234"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_1282409344"
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
			EventOptions[4].OnOptionVisibleCheck = OnOption5VisibleCheck;
			EventOptions[4].OnOptionAvailableCheck = OnOption5AvailableCheck;
			EventOptions[4].GetReplacedContent = OnOption5GetReplacedContent;
			EventOptions[4].OnOptionSelect = OnOption5Select;
			EventOptions[4].GetExtraFormatLanguageKeys = Option5GetExtraFormatLanguageKeys;
			OnOption5Create();
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			int arg = 0;
			ArgBox.Get("sex1", ref arg);
			int arg2 = 0;
			ArgBox.Get("sex2", ref arg2);
			if (arg != 0 && arg2 != 1)
			{
				return true;
			}
			return false;
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
			ArgBox.Set("zishi", 11);
			return "e7d09713-b9f5-4b06-b8a9-5b1a53da7f63";
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			int arg = 0;
			ArgBox.Get("sex2", ref arg);
			if (arg != 0)
			{
				return true;
			}
			return false;
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
			ArgBox.Set("zishi", 16);
			return "e7d09713-b9f5-4b06-b8a9-5b1a53da7f63";
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
			ArgBox.Set("zishi", 12);
			return "e7d09713-b9f5-4b06-b8a9-5b1a53da7f63";
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			int arg = 0;
			ArgBox.Get("sex2", ref arg);
			if (arg != 0)
			{
				return true;
			}
			return false;
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
			ArgBox.Set("zishi", 14);
			return "e7d09713-b9f5-4b06-b8a9-5b1a53da7f63";
		}

		public List<string> Option4GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption5Create()
		{
		}

		private bool OnOption5VisibleCheck()
		{
			return true;
		}

		private bool OnOption5AvailableCheck()
		{
			return true;
		}

		private string OnOption5GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption5Select()
		{
			return "65979702-3cdd-49d4-bc5d-c8f095f3f81f";
		}

		public List<string> Option5GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}