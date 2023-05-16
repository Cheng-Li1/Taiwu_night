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

	public class JTCXEvent_33e4e24879da43b18e1cd3279bfbe55f : TaiwuEventItem
	{
		public JTCXEvent_33e4e24879da43b18e1cd3279bfbe55f()
		{
			Guid = Guid.Parse("33e4e248-79da-43b1-8e1c-d3279bfbe55f");
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
				OptionKey = "Option_-800898620"
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
			Character character = ArgBox.GetCharacter("RoleTaiwu");
			Character character2 = ArgBox.GetCharacter("ren");
			int arg5 = 0;
			ArgBox.Get("zishi", ref arg5);
			int arg6 = 0;
			ArgBox.Get("qianhou", ref arg6);
			int arg7 = 0;
			ArgBox.Get("sex1", ref arg7);
			int arg8 = 0;
			ArgBox.Get("sex2", ref arg8);
			if (!character.GetFeatureIds().Contains(196))
			{
				character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
			}
			if (!character2.GetFeatureIds().Contains(196))
			{
				character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
			}
			if (arg5 != 21 && arg5 != 0 && arg5 < 30 && arg6 == 1 && character2.GetCreatingType() == 1)
			{
				if (arg7 == 1 && arg8 == 0)
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
				if (arg7 == 0 && arg8 == 1)
				{
					int val2 = 0;
					DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val2);
					int random2 = EventHelper.GetRandom(1, 101);
					if (!character.GetFeatureIds().Contains(197) && random2 <= val2)
					{
						DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
						character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
					}
				}
				if (arg7 == 1 && arg8 == 2)
				{
					int val3 = 0;
					DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val3);
					int random3 = EventHelper.GetRandom(1, 101);
					if (!character2.GetFeatureIds().Contains(197) && random3 <= val3)
					{
						DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character2, character, isRaped: false);
						character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
					}
				}
				if (arg7 == 2 && arg8 == 1)
				{
					int val4 = 0;
					DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val4);
					int random4 = EventHelper.GetRandom(1, 101);
					if (!character.GetFeatureIds().Contains(197) && random4 <= val4)
					{
						DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
						character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
					}
				}
				if (arg7 == 0 && arg8 == 2)
				{
					int val5 = 0;
					DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val5);
					int random5 = EventHelper.GetRandom(1, 101);
					if (!character.GetFeatureIds().Contains(197) && random5 <= val5)
					{
						DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
						character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
					}
				}
				if (arg7 == 2 && arg8 == 0)
				{
					int val6 = 0;
					DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val6);
					int random6 = EventHelper.GetRandom(1, 101);
					if (!character2.GetFeatureIds().Contains(197) && random6 <= val6)
					{
						DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character2, character, isRaped: false);
						character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
					}
				}
				if (arg7 == 2 && arg8 == 2)
				{
					if (arg5 < 6 || (arg5 > 21 && arg5 < 30))
					{
						int val7 = 0;
						DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val7);
						int random7 = EventHelper.GetRandom(1, 101);
						if (!character2.GetFeatureIds().Contains(197) && random7 <= val7)
						{
							DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character2, character, isRaped: false);
							character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
						}
					}
					else
					{
						int val8 = 0;
						DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val8);
						int random8 = EventHelper.GetRandom(1, 101);
						if (!character.GetFeatureIds().Contains(197) && random8 <= val8)
						{
							DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
							character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
						}
					}
				}
			}
			ArgBox.Set("zishi", 0);
			ArgBox.Set("ppzishi", "无");
			ArgBox.Set("gaochao", 3);
			int arg9 = 0;
			ArgBox.Get("gaochao1count", ref arg9);
			int arg10 = 0;
			ArgBox.Get("gaochao2count", ref arg10);
			int arg11 = 0;
			if (ArgBox.Get("gaochaotuichu1", ref arg11) && arg9 >= arg11)
			{
				string arg12 = "";
				if (ArgBox.Get("fanhui", ref arg12))
				{
					EventBackground = "";
					EventHelper.SetEventSeriesTexture("");
					Character character3 = character2;
					if (ArgBox.Get("nvyifu", out ItemKey arg13))
					{
						character3.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg13);
					}
					if (ArgBox.Get("nanyifu", out ItemKey arg14))
					{
						character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg14);
					}
					return arg12;
				}
			}
			int arg15 = 0;
			if (ArgBox.Get("gaochaotuichu2", ref arg15) && arg10 >= arg15)
			{
				string arg16 = "";
				if (ArgBox.Get("fanhui", ref arg16))
				{
					EventBackground = "";
					EventHelper.SetEventSeriesTexture("");
					Character character4 = character2;
					if (ArgBox.Get("nvyifu", out ItemKey arg17))
					{
						character4.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg17);
					}
					if (ArgBox.Get("nanyifu", out ItemKey arg18))
					{
						character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg18);
					}
					return arg16;
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