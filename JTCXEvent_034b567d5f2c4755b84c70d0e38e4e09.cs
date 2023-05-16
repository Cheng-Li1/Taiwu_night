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

	public class JTCXEvent_034b567d5f2c4755b84c70d0e38e4e09 : TaiwuEventItem
	{
		public JTCXEvent_034b567d5f2c4755b84c70d0e38e4e09()
		{
			Guid = Guid.Parse("034b567d-5f2c-4755-b84c-70d0e38e4e09");
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
				OptionKey = "Option_873452837"
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
			EventBackground = "";
			EventHelper.SetEventSeriesTexture("");
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			Character character2 = ArgBox.GetCharacter("ren");
			int arg = 0;
			ArgBox.Get("kuaigan1", ref arg);
			int arg2 = 0;
			ArgBox.Get("kuaigan2", ref arg2);
			int arg3 = 0;
			ArgBox.Get("kuaigan12", ref arg3);
			int arg4 = 0;
			ArgBox.Get("kuaigan22", ref arg4);
			if (arg > 0)
			{
				ArgBox.Set("kuaigan1", 0);
			}
			if (arg2 > 0)
			{
				ArgBox.Set("kuaigan2", 0);
			}
			if (arg3 > 0)
			{
				ArgBox.Set("kuaigan12", 0);
			}
			if (arg4 > 0)
			{
				ArgBox.Set("kuaigan22", 0);
			}
			ArgBox.Set("xingfen1", 30);
			ArgBox.Set("xingfen2", 30);
			ArgBox.Set("zishi", 0);
			ArgBox.Set("ppzishi", "无");
			ArgBox.Set("gaochao", 3);
			if (!character.GetFeatureIds().Contains(196))
			{
				character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
			}
			if (!character2.GetFeatureIds().Contains(196))
			{
				character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
			}
			int arg5 = 0;
			ArgBox.Get("gaochao1count", ref arg5);
			int arg6 = 0;
			ArgBox.Get("gaochao2count", ref arg6);
			int arg7 = 0;
			if (ArgBox.Get("gaochaotuichu1", ref arg7) && arg5 >= arg7)
			{
				string arg8 = "";
				if (ArgBox.Get("fanhui", ref arg8))
				{
					EventBackground = "";
					EventHelper.SetEventSeriesTexture("");
					Character character3 = character2;
					if (ArgBox.Get("nvyifu", out ItemKey arg9))
					{
						character3.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg9);
					}
					if (ArgBox.Get("nanyifu", out ItemKey arg10))
					{
						character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg10);
					}
					return arg8;
				}
			}
			int arg11 = 0;
			if (ArgBox.Get("gaochaotuichu2", ref arg11) && arg6 >= arg11)
			{
				string arg12 = "";
				if (ArgBox.Get("fanhui", ref arg12))
				{
					EventBackground = "";
					EventHelper.SetEventSeriesTexture("");
					Character character4 = character2;
					if (ArgBox.Get("nvyifu", out ItemKey arg13))
					{
						character4.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg13);
					}
					if (ArgBox.Get("nanyifu", out ItemKey arg14))
					{
						character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg14);
					}
					return arg12;
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