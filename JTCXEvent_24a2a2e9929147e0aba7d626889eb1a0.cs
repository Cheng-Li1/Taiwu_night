using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains;
using GameData.Domains.Character;
using GameData.Domains.Character.AvatarSystem;
using GameData.Domains.Item;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_24a2a2e9929147e0aba7d626889eb1a0 : TaiwuEventItem
	{
		public JTCXEvent_24a2a2e9929147e0aba7d626889eb1a0()
		{
			Guid = Guid.Parse("24a2a2e9-9291-47e0-aba7-d626889eb1a0");
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
				OptionKey = "Option_-534789099"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_1353063512"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_2099868581"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_-1084152488"
			},
			new TaiwuEventOption
			{
				OptionKey = "Option_292598818"
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
			int arg = 0;
			ArgBox.Get("mode", ref arg);
			if (arg != 2)
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
			ArgBox.Set("xinshenman", arg: true);
			Character character = ArgBox.GetCharacter("ren");
			AvatarData avatar = character.GetAvatar();
			avatar.Feature1Id = 9;
			avatar.ColorFeature1Id = 29;
			avatar.InitializeGrowableElementsShowingAbilitiesAndStates(character);
			character.SetAvatar(avatar, DomainManager.TaiwuEvent.MainThreadDataContext);
			return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
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
			int arg = 0;
			ArgBox.Get("mode", ref arg);
			if (arg != 2)
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
			ArgBox.Set("xinshenman", arg: true);
			return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
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
			int arg = 0;
			ArgBox.Get("mode", ref arg);
			if (arg == 2)
			{
				return true;
			}
			return false;
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			int arg = 0;
			ArgBox.Get("ren", ref arg);
			Character characterById = EventHelper.GetCharacterById(arg);
			if (ArgBox.Get("nvyifu", out ItemKey arg2))
			{
				characterById.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg2);
			}
			if (ArgBox.Get("nanyifu", out ItemKey arg3))
			{
				character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg3);
			}
			EventBackground = "";
			EventHelper.SetEventSeriesTexture("");
			EventHelper.KillCharacter(character.GetId(), characterById.GetId(), EKillCharacterType.KillInPrivate);
			return string.Empty;
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
			int arg = 0;
			ArgBox.Get("mode", ref arg);
			if (arg == 2)
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			int arg = 0;
			ArgBox.Get("ren", ref arg);
			Character characterById = EventHelper.GetCharacterById(arg);
			if (ArgBox.Get("nanyifu", out ItemKey arg2))
			{
				character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg2);
			}
			EventBackground = "";
			EventHelper.SetEventSeriesTexture("");
			ItemKey ropeItemKey = EventHelper.AddItemToRole(character, 12, 81, 1, -1);
			EventHelper.AddPrisonerToCharacter(characterById.GetId(), character.GetId(), ropeItemKey);
			return string.Empty;
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
			int arg = 0;
			ArgBox.Get("mode", ref arg);
			if (arg == 2)
			{
				return true;
			}
			return false;
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			int arg = 0;
			ArgBox.Get("ren", ref arg);
			Character characterById = EventHelper.GetCharacterById(arg);
			if (ArgBox.Get("nvyifu", out ItemKey arg2))
			{
				characterById.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg2);
			}
			if (ArgBox.Get("nanyifu", out ItemKey arg3))
			{
				character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg3);
			}
			EventBackground = "";
			EventHelper.SetEventSeriesTexture("");
			HashSet<int> relatedCharacters = EventHelper.GetRelatedCharacters(arg, 16384, aliveOnly: false);
			if (relatedCharacters != null)
			{
				foreach (int item in relatedCharacters)
				{
					EventHelper.EndRelation(arg, item, 16384);
				}
			}
			EventHelper.AddRelation(arg, character.GetId(), 16384);
			return string.Empty;
		}

		public List<string> Option5GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}