using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{

	public class JTCXEvent_0e94043bebc2457db4da8b7ef152cdea : TaiwuEventItem
	{
		public JTCXEvent_0e94043bebc2457db4da8b7ef152cdea()
		{
			Guid = Guid.Parse("0e94043b-ebc2-457d-b4da-8b7ef152cdea");
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
				OptionKey = "Option_-751460176"
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
			Character ren = ArgBox.GetCharacter("ren");
			int xingfen1 = 0;
			ArgBox.Get("xingfen1", ref xingfen1);
			int kuaigan1 = 0;
			ArgBox.Get("kuaigan1", ref kuaigan1);
			int kuaigan2 = 0;
			ArgBox.Get("kuaigan12", ref kuaigan2);
			int xingfen2 = 0;
			ArgBox.Get("xingfen2", ref xingfen2);
			int kuaigan3 = 0;
			ArgBox.Get("kuaigan2", ref kuaigan3);
			int kuaigan4 = 0;
			ArgBox.Get("kuaigan22", ref kuaigan4);
			int tili1 = 0;
			ArgBox.Get("tili1", ref tili1);
			int tili2 = 0;
			ArgBox.Get("tili2", ref tili2);
			int arg = 0;
			ArgBox.Get("zishi", ref arg);
			int arg2 = 0;
			ArgBox.Get("qianhou", ref arg2);
			int num = xingfen2;
			int arg3 = 0;
			ArgBox.Get("xinshen2", ref arg3);
			int lingmin = EventHelper.GetRoleCurrentMainAttributes(taiwu, 1);
			int lingmin2 = EventHelper.GetRoleCurrentMainAttributes(ren, 1);
			int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(taiwu, 5);
			int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(ren, 5);
			int num2 = -1;
			int num3 = -1;
			int id = ren.GetId();
			if (id % 5 == 2)
			{
				num2 = id % 3;
			}
			int arg4 = 0;
			ArgBox.Get("mode", ref arg4);
			if (arg4 == 1)
			{
				int arg5 = 0;
				ArgBox.Get("juedouxp", ref arg5);
				if (arg5 % 5 == 2)
				{
					num2 = arg5 % 3;
				}
			}
			int teshutizhi = id % 100;
			string val = "1";
			List<int> list = new List<int>();
			if (TaiwuEvent.GetModData("JHXP", isArchive: true, ref val) && arg4 == 0)
			{
				string[] array = val.Split(',');
				if (array.Length > 1)
				{
					for (int i = 1; i < array.Length; i++)
					{
						string[] array2 = array[i].Split('|');
						int num4 = int.Parse(array2[0]);
						if (num4 == ren.GetId())
						{
							for (int j = 1; j < array2.Length; j++)
							{
								list.Add(int.Parse(array2[j]));
							}
						}
					}
				}
			}
			int arg6 = 0;
			ArgBox.Get("sex1", ref arg6);
			int arg7 = 0;
			ArgBox.Get("sex2", ref arg7);
			int arg8 = 0;
			ArgBox.Get("cha", ref arg8);
			string arg9 = "";
			ArgBox.Get("chengweiduifang", ref arg9);
			if (arg8 == 1)
			{
				if (kuaigan3 < 50)
				{
					ArgBox.Set("xingfen1", xingfen1 + 2);
					ArgBox.Set("xingfen2", xingfen2 + 3);
					if (arg < 6 || (arg > 21 && arg < 30))
					{
						ArgBox.Set("kuaigan1", Addkuaigan1(2));
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(3));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(3));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(3));
							}
						}
					}
					else
					{
						ArgBox.Set("kuaigan2", Addkuaigan2(3));
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(2));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(2));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(2));
							}
						}
					}
					if (num2 == 0 || list.Contains(0))
					{
						ArgBox.Set("xingfen2", num + 5);
						ArgBox.Set("kuaigan2", Addkuaigan2(5));
					}
				}
				else
				{
					ArgBox.Set("xingfen1", xingfen1 + 8);
					ArgBox.Set("xingfen2", xingfen2 + 10);
					if (arg < 6 || (arg > 21 && arg < 30))
					{
						ArgBox.Set("kuaigan1", Addkuaigan1(5));
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(10));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(10));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(10));
							}
						}
					}
					else
					{
						ArgBox.Set("kuaigan2", Addkuaigan2(10));
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(5));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(5));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(5));
							}
						}
					}
					if (num2 == 0 || list.Contains(0))
					{
						ArgBox.Set("xingfen2", num + 10);
						ArgBox.Set("kuaigan2", Addkuaigan2(10));
					}
				}
				int random = EventHelper.GetRandom(1, 4);
				string text = "";
				if (random == 1)
				{
					text = "<Character key=RoleTaiwu str=Name/>九浅一深的抽送，\"嗯~~<ArgBox key=chengweiduifang type=string/>~快点~~用力~~~操我~~~\"";
				}
				if (random == 2)
				{
					text = "\"啊~嗯~~~好喜欢~~~继续~~~\"";
				}
				if (random == 3)
				{
					text = "\"嘻嘻~~~我的身体舒不舒服呀~~~\"";
				}
				if (ren.HasVirginity() && kuaigan3 < 100 && kuaigan4 < 100)
				{
					text = "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~~还好，可以适应~~~嗯啊~~~\"";
				}
				if (ren.HasVirginity() && (kuaigan3 >= 100 || kuaigan4 >= 100))
				{
					text = "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~~慢点，好舒服~~~嗯啊~~~\"";
				}
				int random2 = EventHelper.GetRandom(1, 11);
				int num5 = 1;
				if (arg6 == 0 && arg7 != 0 && arg2 == 1)
				{
					if (roleCurrentMainAttributes2 >= 60)
					{
						num5 = 2;
					}
					if (roleCurrentMainAttributes2 >= 100)
					{
						num5 = 3;
					}
				}
				if (arg6 != 0 && arg7 == 0 && arg2 == 1)
				{
					if (roleCurrentMainAttributes >= 60)
					{
						num5 = 2;
					}
					if (roleCurrentMainAttributes >= 100)
					{
						num5 = 3;
					}
				}
				if (random2 <= num5)
				{
					if (arg6 == 0 && arg7 != 0 && arg2 == 1)
					{
						text += "<Character key=ren str=Name/>顶到<Character key=RoleTaiwu str=Name/>的G点了！\"啊!!!~~~~~~\"";
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(10));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(10));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(10));
							}
						}
					}
					if (arg6 != 0 && arg7 == 0 && arg2 == 1)
					{
						text += "<Character key=RoleTaiwu str=Name/>顶到<Character key=ren str=Name/>的G点了！\"啊!!!~~~~~~\"";
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(10));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(10));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(10));
							}
						}
					}
				}
				ArgBox.Set("choucha", text);
			}
			if (arg8 == 2)
			{
				if (kuaigan3 < 50)
				{
					ArgBox.Set("xingfen1", xingfen1 + 5);
					ArgBox.Set("xingfen2", xingfen2 + 6);
					if (arg < 6 || (arg > 21 && arg < 30))
					{
						ArgBox.Set("kuaigan1", Addkuaigan1(6));
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(8));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(8));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(8));
							}
						}
					}
					else
					{
						ArgBox.Set("kuaigan2", Addkuaigan2(8));
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(6));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(6));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(6));
							}
						}
					}
					if (num2 == 1 || list.Contains(1))
					{
						ArgBox.Set("xingfen2", num + 8);
						ArgBox.Set("kuaigan2", Addkuaigan2(8));
					}
				}
				else
				{
					ArgBox.Set("xingfen1", xingfen1 + 12);
					ArgBox.Set("xingfen2", xingfen2 + 15);
					if (arg < 6 || (arg > 21 && arg < 30))
					{
						ArgBox.Set("kuaigan1", Addkuaigan1(10));
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(15));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(15));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(15));
							}
						}
					}
					else
					{
						ArgBox.Set("kuaigan2", Addkuaigan2(15));
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(10));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(10));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(10));
							}
						}
					}
					if (num2 == 1 || list.Contains(1))
					{
						ArgBox.Set("xingfen2", num + 15);
						ArgBox.Set("kuaigan2", Addkuaigan2(15));
					}
				}
				int random3 = EventHelper.GetRandom(1, 4);
				string text2 = "";
				if (random3 == 1)
				{
					text2 = "<Character key=RoleTaiwu str=Name/>加大力度，\"啊啊啊~~~<ArgBox key=chengweiduifang type=string/>~~~好~~~好舒服~~~\"";
				}
				if (random3 == 2)
				{
					text2 = "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~~用力~~~用力~~~\"";
				}
				if (random3 == 3)
				{
					text2 = "\"呜呜~~~<ArgBox key=chengweiduifang type=string/>~~~温柔一点嘛~~~\"";
				}
				if (ren.HasVirginity() && kuaigan3 < 100 && kuaigan4 < 100)
				{
					text2 = ((arg6 == 0) ? "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~好烫~~好温暖~~~\"" : "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~~撑开啦~~~啊啊~~~\"");
				}
				if (ren.HasVirginity() && (kuaigan3 >= 100 || kuaigan4 >= 100))
				{
					text2 = ((arg6 == 0) ? "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~慢点啊~~~\"" : "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~~太大啦~~~受不了啊啊~~~\"");
				}
				int random4 = EventHelper.GetRandom(1, 11);
				int num6 = 1;
				if (arg6 == 0 && arg7 != 0 && arg2 == 1)
				{
					if (roleCurrentMainAttributes2 >= 60)
					{
						num6 = 2;
					}
					if (roleCurrentMainAttributes2 >= 100)
					{
						num6 = 3;
					}
				}
				if (arg6 != 0 && arg7 == 0 && arg2 == 1)
				{
					if (roleCurrentMainAttributes >= 60)
					{
						num6 = 2;
					}
					if (roleCurrentMainAttributes >= 100)
					{
						num6 = 3;
					}
				}
				if (random4 <= num6)
				{
					if (arg6 == 0 && arg7 != 0 && arg2 == 1)
					{
						text2 += "<Character key=ren str=Name/>顶到<Character key=RoleTaiwu str=Name/>的G点了！\"啊!!!~~~~~~\"";
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(15));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(15));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(15));
							}
						}
					}
					if (arg6 != 0 && arg7 == 0 && arg2 == 1)
					{
						text2 += "<Character key=RoleTaiwu str=Name/>顶到<Character key=ren str=Name/>的G点了！\"啊!!!~~~~~~\"";
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(15));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(15));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(15));
							}
						}
					}
				}
				ArgBox.Set("choucha", text2);
			}
			if (arg8 == 3)
			{
				if (kuaigan3 < 50)
				{
					ArgBox.Set("xingfen1", xingfen1 + 5);
					ArgBox.Set("xingfen2", xingfen2 + 6);
					if (arg < 6 || (arg > 21 && arg < 30))
					{
						ArgBox.Set("kuaigan1", Addkuaigan1(12));
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(8));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(8));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(8));
							}
						}
					}
					else
					{
						ArgBox.Set("kuaigan2", Addkuaigan2(8));
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(12));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(12));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(12));
							}
						}
					}
					if (num2 == 2 || list.Contains(2))
					{
						ArgBox.Set("xingfen2", num + 12);
						ArgBox.Set("kuaigan2", Addkuaigan2(12));
					}
				}
				else
				{
					ArgBox.Set("xingfen1", xingfen1 + 18);
					ArgBox.Set("xingfen2", xingfen2 + 18);
					if (arg < 6 || (arg > 21 && arg < 30))
					{
						ArgBox.Set("kuaigan1", Addkuaigan1(15));
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(20));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(20));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(20));
							}
						}
					}
					else
					{
						ArgBox.Set("kuaigan2", Addkuaigan2(20));
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(15));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(15));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(15));
							}
						}
					}
					if (num2 == 2 || list.Contains(2))
					{
						ArgBox.Set("xingfen2", num + 20);
						ArgBox.Set("kuaigan2", Addkuaigan2(20));
					}
				}
				int random5 = EventHelper.GetRandom(1, 3);
				string text3 = "";
				if (random5 == 1)
				{
					text3 = "\"啊啊啊~~~<ArgBox key=chengweiduifang type=string/>~~~要来了~~~要来了！~~~\"";
				}
				if (random5 == 2)
				{
					text3 = "\"啊~啊~~~<ArgBox key=chengweiduifang type=string/>~~~轻点~~~轻点啊~~~\"";
				}
				if (ren.HasVirginity() && kuaigan3 < 100 && kuaigan4 < 100)
				{
					text3 = "\"啊啊~~~<ArgBox key=chengweiduifang type=string/>~~~不要不要~~~停停停~~~\"";
				}
				if (ren.HasVirginity() && (kuaigan3 >= 100 || kuaigan4 >= 100))
				{
					text3 = "\"啊~嗯~~<ArgBox key=chengweiduifang type=string/>~~~要死了~~~要死了！~~~\"";
				}
				int random6 = EventHelper.GetRandom(1, 11);
				int num7 = 1;
				if (arg6 == 0 && arg7 != 0 && arg2 == 1)
				{
					if (roleCurrentMainAttributes2 >= 60)
					{
						num7 = 2;
					}
					if (roleCurrentMainAttributes2 >= 100)
					{
						num7 = 3;
					}
				}
				if (arg6 != 0 && arg7 == 0 && arg2 == 1)
				{
					if (roleCurrentMainAttributes >= 60)
					{
						num7 = 2;
					}
					if (roleCurrentMainAttributes >= 100)
					{
						num7 = 3;
					}
				}
				if (random6 <= num7)
				{
					if (arg6 == 0 && arg7 != 0 && arg2 == 1)
					{
						text3 += "<Character key=ren str=Name/>顶到<Character key=RoleTaiwu str=Name/>的G点了！\"啊!!!~~~~~~\"";
						if (arg6 != 2)
						{
							ArgBox.Set("kuaigan1", Addkuaigan1(20));
						}
						if (arg6 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan12", Addkuaigan12(20));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan1", Addkuaigan1(20));
							}
						}
					}
					if (arg6 != 0 && arg7 == 0 && arg2 == 1)
					{
						text3 += "<Character key=RoleTaiwu str=Name/>顶到<Character key=ren str=Name/>的G点了！\"啊!!!~~~~~~\"";
						if (arg7 != 2)
						{
							ArgBox.Set("kuaigan2", Addkuaigan2(20));
						}
						if (arg7 == 2)
						{
							if (arg2 == 1)
							{
								ArgBox.Set("kuaigan22", Addkuaigan22(20));
							}
							if (arg2 == 2)
							{
								ArgBox.Set("kuaigan2", Addkuaigan2(20));
							}
						}
					}
				}
				ArgBox.Set("choucha", text3);
			}
			int item = arg8 - 1;
			if ((arg7 == 2 || kuaigan3 < 200 || arg3 < 100) && (arg7 != 2 || (kuaigan3 < 100 && kuaigan4 < 100) || arg3 < 100))
			{
				return;
			}
			string val2 = "1";
			string text4 = "1";
			if (!TaiwuEvent.GetModData("JHXP", isArchive: true, ref val2))
			{
				val2 = "1";
			}
			string[] array3 = val2.Split(',');
			bool flag = false;
			if (array3.Length > 1)
			{
				for (int k = 1; k < array3.Length; k++)
				{
					string[] array4 = array3[k].Split('|');
					int num8 = int.Parse(array4[0]);
					if (num8 != ren.GetId())
					{
						continue;
					}
					List<int> list2 = new List<int>();
					for (int l = 1; l < array4.Length; l++)
					{
						list2.Add(int.Parse(array4[l]));
					}
					if (!list2.Contains(item))
					{
						for (int m = 1; m < array3.Length; m++)
						{
							text4 = ((m == k) ? (text4 + "," + array3[k] + "|" + item) : (text4 + "," + array3[m]));
						}
						flag = true;
					}
				}
				if (flag)
				{
					TaiwuEvent.SetModString("JHXP", isArchive: true, text4);
					return;
				}
				TaiwuEvent.SetModString("JHXP", isArchive: true, val2 + "," + ren.GetId() + "|" + item);
			}
			else
			{
				TaiwuEvent.SetModString("JHXP", isArchive: true, val2 + "," + ren.GetId() + "|" + item);
			}
			int Addkuaigan1(int jichu)
			{
				double num12 = (double)kuaigan1 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin2 * 0.0025);
				if (taiwu.HasVirginity())
				{
					num12 *= 2.0;
				}
				if (ren.GetConsummateLevel() > taiwu.GetConsummateLevel())
				{
					num12 *= 1.0 + (double)(ren.GetConsummateLevel() - taiwu.GetConsummateLevel()) * 0.2;
				}
				return (int)num12;
			}
			int Addkuaigan12(int jichu)
			{
				double num9 = (double)kuaigan2 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin2 * 0.0025);
				if (taiwu.HasVirginity())
				{
					num9 *= 2.0;
				}
				if (ren.GetConsummateLevel() > taiwu.GetConsummateLevel())
				{
					num9 *= 1.0 + (double)(ren.GetConsummateLevel() - taiwu.GetConsummateLevel()) * 0.2;
				}
				return (int)num9;
			}
			int Addkuaigan2(int jichu)
			{
				if (jichu < 6 && teshutizhi == 0)
				{
					jichu = 10;
				}
				double num11 = (double)kuaigan3 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
				if (ren.HasVirginity() && ren.GetCreatingType() == 1)
				{
					num11 *= 2.0;
				}
				if (teshutizhi == 1)
				{
					num11 *= 2.0;
				}
				if (taiwu.GetConsummateLevel() > ren.GetConsummateLevel())
				{
					num11 *= 1.0 + (double)(taiwu.GetConsummateLevel() - ren.GetConsummateLevel()) * 0.2;
				}
				return (int)num11;
			}
			int Addkuaigan22(int jichu)
			{
				if (jichu < 6 && teshutizhi == 0)
				{
					jichu = 10;
				}
				double num10 = (double)kuaigan4 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
				if (ren.HasVirginity() && ren.GetCreatingType() == 1)
				{
					num10 *= 2.0;
				}
				if (teshutizhi == 1)
				{
					num10 *= 2.0;
				}
				if (taiwu.GetConsummateLevel() > ren.GetConsummateLevel())
				{
					num10 *= 1.0 + (double)(taiwu.GetConsummateLevel() - ren.GetConsummateLevel()) * 0.2;
				}
				return (int)num10;
			}
		}

		public override void OnEventExit()
		{
		}

		public override string GetReplacedContentString()
		{
			string arg = "";
			if (!ArgBox.Get("choucha", ref arg))
			{
				arg = "<Character key=RoleTaiwu str=Name/>插得<Character key=ren str=Name/>淫水直流，哭着求<Character key=RoleTaiwu str=Name/>轻一点。";
			}
			bool arg2 = false;
			if (ArgBox.Get("huandujixugankunbang", ref arg2))
			{
				arg = "\"啊~~~放开我~~你这个贱人！！！\"";
			}
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