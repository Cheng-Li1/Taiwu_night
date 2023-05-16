using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains;
using GameData.Domains.Character;
using GameData.Domains.Item;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_281f53baf1d441bb95e7056e52854e25 : TaiwuEventItem
	{
		public JTCXEvent_281f53baf1d441bb95e7056e52854e25()
		{
			Guid = Guid.Parse("281f53ba-f1d4-41bb-95e7-056e52854e25");
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
				OptionKey = "Option_831486761"
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
			int arg = 0;
			ArgBox.Get("neishecount", ref arg);
			ArgBox.Set("neishecount", arg + 1);
			EventBackground = "neishe";
			EventHelper.SetEventSeriesTexture("neishe");
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
			int arg = 0;
			ArgBox.Get("kuaigan1", ref arg);
			int arg2 = 0;
			ArgBox.Get("kuaigan12", ref arg2);
			if (arg > 0)
			{
				ArgBox.Set("kuaigan1", 0);
			}
			if (arg2 > 0)
			{
				ArgBox.Set("kuaigan12", 0);
			}
			ArgBox.Set("xingfen1", 30);
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			Character character2 = ArgBox.GetCharacter("ren");
			int arg3 = 0;
			ArgBox.Get("zishi", ref arg3);
			int arg4 = 0;
			ArgBox.Get("qianhou", ref arg4);
			int arg5 = 0;
			ArgBox.Get("sex1", ref arg5);
			int arg6 = 0;
			ArgBox.Get("sex2", ref arg6);
			if (!character.GetFeatureIds().Contains(196))
			{
				character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
			}
			if (!character2.GetFeatureIds().Contains(196))
			{
				character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
			}
			if (arg3 != 21 && arg3 != 0 && arg3 < 30 && arg4 == 1 && character2.GetCreatingType() == 1 && arg5 != 0 && arg6 != 1)
			{
				int val = 0;
				DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val);
				int random = EventHelper.GetRandom(1, 101);
				if (!character2.GetFeatureIds().Contains(197) && random <= val)
				{
					DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character2, character, isRaped: false);
					character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
				}
			}
			ArgBox.Set("zishi", 0);
			ArgBox.Set("ppzishi", "无");
			ArgBox.Set("gaochao", 1);
			int arg7 = 0;
			ArgBox.Get("gaochao1count", ref arg7);
			int arg8 = 0;
			if (ArgBox.Get("gaochaotuichu1", ref arg8) && arg7 >= arg8)
			{
				string arg9 = "";
				if (ArgBox.Get("fanhui", ref arg9))
				{
					EventBackground = "";
					EventHelper.SetEventSeriesTexture("");
					Character character3 = character2;
					if (ArgBox.Get("nvyifu", out ItemKey arg10))
					{
						character3.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg10);
					}
					if (ArgBox.Get("nanyifu", out ItemKey arg11))
					{
						character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg11);
					}
					return arg9;
				}
			}
			return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
		}

		public List<string> Option1GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}