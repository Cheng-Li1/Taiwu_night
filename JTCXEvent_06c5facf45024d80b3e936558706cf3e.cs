using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_06c5facf45024d80b3e936558706cf3e : TaiwuEventItem
	{
		public JTCXEvent_06c5facf45024d80b3e936558706cf3e()
		{
			Guid = Guid.Parse("06c5facf-4502-4d80-b3e9-36558706cf3e");
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
			EscOptionKey = "Option_1194813392";
			EventOptions = new TaiwuEventOption[9]
			{
			new TaiwuEventOption
			{
				OptionKey = "Option_1889321005"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-1138777858"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-1488486568"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-677958400"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_1042379533"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-1863127339"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-311881128"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-219441841"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_1194813392"
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
			EventOptions[5].OnOptionVisibleCheck = OnOption6VisibleCheck;
			EventOptions[5].OnOptionAvailableCheck = OnOption6AvailableCheck;
			EventOptions[5].GetReplacedContent = OnOption6GetReplacedContent;
			EventOptions[5].OnOptionSelect = OnOption6Select;
			EventOptions[5].GetExtraFormatLanguageKeys = Option6GetExtraFormatLanguageKeys;
			OnOption6Create();
			EventOptions[6].OnOptionVisibleCheck = OnOption7VisibleCheck;
			EventOptions[6].OnOptionAvailableCheck = OnOption7AvailableCheck;
			EventOptions[6].GetReplacedContent = OnOption7GetReplacedContent;
			EventOptions[6].OnOptionSelect = OnOption7Select;
			EventOptions[6].GetExtraFormatLanguageKeys = Option7GetExtraFormatLanguageKeys;
			OnOption7Create();
			EventOptions[7].OnOptionVisibleCheck = OnOption8VisibleCheck;
			EventOptions[7].OnOptionAvailableCheck = OnOption8AvailableCheck;
			EventOptions[7].GetReplacedContent = OnOption8GetReplacedContent;
			EventOptions[7].OnOptionSelect = OnOption8Select;
			EventOptions[7].GetExtraFormatLanguageKeys = Option8GetExtraFormatLanguageKeys;
			OnOption8Create();
			EventOptions[8].OnOptionVisibleCheck = OnOption9VisibleCheck;
			EventOptions[8].OnOptionAvailableCheck = OnOption9AvailableCheck;
			EventOptions[8].GetReplacedContent = OnOption9GetReplacedContent;
			EventOptions[8].OnOptionSelect = OnOption9Select;
			EventOptions[8].GetExtraFormatLanguageKeys = Option9GetExtraFormatLanguageKeys;
			OnOption9Create();
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
			ArgBox.Set("shoucaozuo", 1);
			ArgBox.Set("shoulidu", 1);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
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
			ArgBox.Set("shoucaozuo", 1);
			ArgBox.Set("shoulidu", 3);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
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
			ArgBox.Set("shoucaozuo", 2);
			ArgBox.Set("shoulidu", 1);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
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
			ArgBox.Set("shoucaozuo", 2);
			ArgBox.Set("shoulidu", 3);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
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
			ArgBox.Set("shoucaozuo", 3);
			ArgBox.Set("shoulidu", 1);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
		}

		public List<string> Option5GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption6Create()
		{
		}

		private bool OnOption6VisibleCheck()
		{
			return true;
		}

		private bool OnOption6AvailableCheck()
		{
			return true;
		}

		private string OnOption6GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption6Select()
		{
			ArgBox.Set("shoucaozuo", 3);
			ArgBox.Set("shoulidu", 3);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
		}

		public List<string> Option6GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption7Create()
		{
		}

		private bool OnOption7VisibleCheck()
		{
			return true;
		}

		private bool OnOption7AvailableCheck()
		{
			return true;
		}

		private string OnOption7GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption7Select()
		{
			ArgBox.Set("shoucaozuo", 4);
			ArgBox.Set("shoulidu", 1);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
		}

		public List<string> Option7GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption8Create()
		{
		}

		private bool OnOption8VisibleCheck()
		{
			return true;
		}

		private bool OnOption8AvailableCheck()
		{
			return true;
		}

		private string OnOption8GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption8Select()
		{
			ArgBox.Set("shoucaozuo", 4);
			ArgBox.Set("shoulidu", 3);
			return "b6e1dbee-17ef-43a0-9c0b-bb03da50747d";
		}

		public List<string> Option8GetExtraFormatLanguageKeys()
		{
			return null;
		}

		private void OnOption9Create()
		{
		}

		private bool OnOption9VisibleCheck()
		{
			return true;
		}

		private bool OnOption9AvailableCheck()
		{
			return true;
		}

		private string OnOption9GetReplacedContent()
		{
			return string.Empty;
		}

		private string OnOption9Select()
		{
			return "75b92dda-9abb-4b58-a65d-1bfacf728bd0";
		}

		public List<string> Option9GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}