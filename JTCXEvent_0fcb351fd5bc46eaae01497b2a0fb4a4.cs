using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_0fcb351fd5bc46eaae01497b2a0fb4a4 : TaiwuEventItem
	{
		public JTCXEvent_0fcb351fd5bc46eaae01497b2a0fb4a4()
		{
			Guid = Guid.Parse("0fcb351f-d5bc-46ea-ae01-497b2a0fb4a4");
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
				OptionKey = "Option_836244852"
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
			Character taiwu = ArgBox.GetCharacter("RoleTaiwu");
			Character character = ArgBox.GetCharacter("ren");
			int tili1 = 0;
			ArgBox.Get("tili1", ref tili1);
			int xingfen1 = 0;
			ArgBox.Get("xingfen1", ref xingfen1);
			int kuaigan1 = 0;
			ArgBox.Get("kuaigan1", ref kuaigan1);
			int kuaigan2 = 0;
			ArgBox.Get("kuaigan12", ref kuaigan2);
			int arg = 0;
			ArgBox.Get("tili2", ref arg);
			int arg2 = 0;
			ArgBox.Get("xingfen2", ref arg2);
			int arg3 = 0;
			ArgBox.Get("kuaigan2", ref arg3);
			int arg4 = 0;
			ArgBox.Get("kuaigan22", ref arg4);
			int lingmin = EventHelper.GetRoleCurrentMainAttributes(character, 1);
			int num = -1;
			int num2 = -1;
			int id = taiwu.GetId();
			num = id % 23;
			string arg5 = "";
			int arg6 = 0;
			ArgBox.Get("sex1", ref arg6);
			int arg7 = 0;
			ArgBox.Get("sex2", ref arg7);
			if (arg6 != 1)
			{
				arg5 = "<Character key=ren str=Name/>用脚掌揉搓<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"";
				EventBackground = "";
				EventHelper.SetEventSeriesTexture("");
				if (xingfen1 < 50)
				{
					if (arg6 == 0)
					{
						ArgBox.Set("kuaigan1", Addkuaigan1(5));
					}
					else
					{
						ArgBox.Set("kuaigan1", Addkuaigan12(5));
					}
				}
				else if (arg6 == 0)
				{
					ArgBox.Set("kuaigan1", Addkuaigan1(10));
				}
				else
				{
					ArgBox.Set("kuaigan12", Addkuaigan12(10));
				}
			}
			if (arg6 == 1)
			{
				arg5 = "<Character key=ren str=Name/>用脚掌夹住<Character key=RoleTaiwu str=Name/>的肉棒上下撸动。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"";
				EventBackground = "zujiao1";
				EventHelper.SetEventSeriesTexture("zujiao1");
				if (xingfen1 < 50)
				{
					ArgBox.Set("kuaigan1", Addkuaigan1(5));
				}
				else
				{
					ArgBox.Set("kuaigan1", Addkuaigan1(10));
				}
			}
			ArgBox.Set("xingfen1", xingfen1 + 10);
			ArgBox.Set("xingfen2", arg2 + 5);
			if (num == 15)
			{
				ArgBox.Set("xingfen1", xingfen1 + 10);
				ArgBox.Set("kuaigan1", Addkuaigan1(10));
			}
			ArgBox.Set("zishi", 31);
			ArgBox.Set("rangzujiao", arg5);
			int Addkuaigan1(int jichu)
			{
				double num4 = (double)kuaigan1 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin * 0.0025);
				if (taiwu.HasVirginity())
				{
					num4 *= 2.0;
				}
				return (int)num4;
			}
			int Addkuaigan12(int jichu)
			{
				double num3 = (double)kuaigan2 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin * 0.0025);
				if (taiwu.HasVirginity())
				{
					num3 *= 2.0;
				}
				return (int)num3;
			}
		}

		public override void OnEventExit()
		{
		}

		public override string GetReplacedContentString()
		{
			string arg = "";
			ArgBox.Get("rangzujiao", ref arg);
			string targetString = string.Format(base.EventContent, arg);
			return EventHelper.HandleStringTag(targetString, ArgBox, TaiwuEvent);
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
			int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 3);
			int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 3);
			int arg = 0;
			ArgBox.Get("sex1", ref arg);
			int arg2 = 0;
			ArgBox.Get("sex2", ref arg2);
			int arg3 = 0;
			ArgBox.Get("kuaigan1", ref arg3);
			int arg4 = 0;
			ArgBox.Get("kuaigan12", ref arg4);
			int arg5 = 0;
			ArgBox.Get("kuaigan2", ref arg5);
			int arg6 = 0;
			ArgBox.Get("kuaigan22", ref arg6);
			if (arg != 2 && arg2 != 2)
			{
				if ((double)arg3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025) && (double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
				}
				if ((double)arg3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
				{
					return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
				}
				if ((double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
				}
			}
			if (arg == 2 && arg2 != 2)
			{
				if (((double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025) || (double)arg4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025)) && (double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
				}
				if ((double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
				{
					return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
				}
				if ((double)arg4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
				{
					return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
				}
				if ((double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
				}
			}
			if (arg != 2 && arg2 == 2)
			{
				if (((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) || (double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025)) && (double)arg3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
				{
					return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
				}
				if ((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
				}
				if ((double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
				}
				if ((double)arg3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
				{
					return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
				}
			}
			if (arg == 2 && arg2 == 2)
			{
				if (((double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025) || (double)arg4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025)) && ((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) || (double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025)))
				{
					return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
				}
				if ((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
				}
				if ((double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
				{
					return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
				}
				if ((double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
				{
					return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
				}
				if ((double)arg4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
				{
					return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
				}
			}
			return "dc222b89-ea26-4fc4-819f-0fd413ef41a2";
		}

		public List<string> Option1GetExtraFormatLanguageKeys()
		{
			return null;
		}
	}
}