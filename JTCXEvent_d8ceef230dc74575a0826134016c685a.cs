using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_d8ceef230dc74575a0826134016c685a : TaiwuEventItem
    {
        public JTCXEvent_d8ceef230dc74575a0826134016c685a()
        {
            Guid = Guid.Parse("d8ceef23-0dc7-4575-a082-6134016c685a");
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
                OptionKey = "Option_-1638955481"
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
            int arg = 0;
            ArgBox.Get("tili1", ref arg);
            int arg2 = 0;
            ArgBox.Get("xingfen1", ref arg2);
            int arg3 = 0;
            ArgBox.Get("kuaigan1", ref arg3);
            int arg4 = 0;
            ArgBox.Get("kuaigan12", ref arg4);
            int tili2 = 0;
            ArgBox.Get("tili2", ref tili2);
            int xingfen2 = 0;
            ArgBox.Get("xingfen2", ref xingfen2);
            int kuaigan2 = 0;
            ArgBox.Get("kuaigan2", ref kuaigan2);
            int kuaigan3 = 0;
            ArgBox.Get("kuaigan22", ref kuaigan3);
            int arg5 = 0;
            ArgBox.Get("zishi", ref arg5);
            int arg6 = 0;
            ArgBox.Get("xinshen2", ref arg6);
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(taiwu, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(ren, 0);
            int lingmin = EventHelper.GetRoleCurrentMainAttributes(taiwu, 1);
            int num = -1;
            int num2 = -1;
            int id = ren.GetId();
            if (id % 5 == 4)
            {
                num = id % 17;
            }
            int arg7 = 0;
            ArgBox.Get("mode", ref arg7);
            if (arg7 != 0)
            {
                int arg8 = 0;
                ArgBox.Get("juedouxp", ref arg8);
                if (arg8 % 5 == 4)
                {
                    num = arg8 % 17;
                }
            }
            int teshutizhi = id % 100;
            string val = "1";
            List<int> list = new List<int>();
            if (TaiwuEvent.GetModData("ZishiXP", isArchive: true, ref val) && arg7 == 0)
            {
                string[] array = val.Split(',');
                if (array.Length > 1)
                {
                    for (int i = 1; i < array.Length; i++)
                    {
                        string[] array2 = array[i].Split('|');
                        int num3 = int.Parse(array2[0]);
                        if (num3 == ren.GetId())
                        {
                            for (int j = 1; j < array2.Length; j++)
                            {
                                list.Add(int.Parse(array2[j]));
                            }
                        }
                    }
                }
            }
            string arg9 = "";
            int arg10 = 0;
            ArgBox.Get("sex1", ref arg10);
            int arg11 = 0;
            ArgBox.Get("sex2", ref arg11);
            if (arg11 != 1)
            {
                arg9 = "<Character key=RoleTaiwu str=Name/>用脚掌揉搓<Character key=ren str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweiduifang type=string/>~嗯~继续~~~\"";
                EventBackground = "";
                EventHelper.SetEventSeriesTexture("");
                if (xingfen2 < 50)
                {
                    if (arg11 == 0)
                    {
                        ArgBox.Set("kuaigan2", Addkuaigan2(5));
                    }
                    else
                    {
                        ArgBox.Set("kuaigan2", Addkuaigan22(5));
                    }
                }
                else if (arg11 == 0)
                {
                    ArgBox.Set("kuaigan2", Addkuaigan2(10));
                }
                else
                {
                    ArgBox.Set("kuaigan2", Addkuaigan22(10));
                }
            }
            if (arg11 == 1)
            {
                arg9 = "<Character key=RoleTaiwu str=Name/>用脚掌夹住<Character key=ren str=Name/>的肉棒上下撸动。\n\"啊~~<ArgBox key=chengweiduifang type=string/>~嗯~继续~~~\"";
                EventBackground = "zujiao1";
                EventHelper.SetEventSeriesTexture("zujiao1");
                if (xingfen2 < 50)
                {
                    ArgBox.Set("kuaigan2", Addkuaigan2(5));
                }
                else
                {
                    ArgBox.Set("kuaigan2", Addkuaigan2(10));
                }
            }
            if (num == 15 || list.Contains(15))
            {
                ArgBox.Set("xingfen2", xingfen2 + 10);
                ArgBox.Set("kuaigan2", Addkuaigan2(10));
            }
            ArgBox.Set("xingfen1", arg2 + 5);
            ArgBox.Set("xingfen2", xingfen2 + 10);
            if (arg5 <= 20 && arg5 > 10 && arg5 != 30 && arg5 != 32)
            {
                if (arg < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (arg < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((arg >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (arg >= 10)
                        {
                            ArgBox.Set("tili1", arg - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (arg >= 20)
                    {
                        ArgBox.Set("tili1", arg - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            else
            {
                ArgBox.Set("tili1", arg - 5);
            }
            int item = 15;
            if ((arg11 != 2 && kuaigan2 >= 200 && arg6 >= 100) || (arg11 == 2 && (kuaigan2 >= 100 || kuaigan3 >= 100) && arg6 >= 100))
            {
                string val2 = "1";
                string text = "1";
                if (!TaiwuEvent.GetModData("ZishiXP", isArchive: true, ref val2))
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
                        int num4 = int.Parse(array4[0]);
                        if (num4 != ren.GetId())
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
                                text = ((m == k) ? (text + "," + array3[k] + "|" + item) : (text + "," + array3[m]));
                            }
                            flag = true;
                        }
                    }
                    if (flag)
                    {
                        TaiwuEvent.SetModString("ZishiXP", isArchive: true, text);
                    }
                    else
                    {
                        TaiwuEvent.SetModString("ZishiXP", isArchive: true, val2 + "," + ren.GetId() + "|" + item);
                    }
                }
                else
                {
                    TaiwuEvent.SetModString("ZishiXP", isArchive: true, val2 + "," + ren.GetId() + "|" + item);
                }
            }
            ArgBox.Set("weizujiao", arg9);
            int Addkuaigan2(int jichu)
            {
                if (jichu < 6 && teshutizhi == 0)
                {
                    jichu = 10;
                }
                double num6 = (double)kuaigan2 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
                if (ren.HasVirginity() && ren.GetCreatingType() == 1)
                {
                    num6 *= 2.0;
                }
                if (teshutizhi == 1)
                {
                    num6 *= 2.0;
                }
                if (taiwu.GetConsummateLevel() > ren.GetConsummateLevel())
                {
                    num6 *= 1.0 + (double)(taiwu.GetConsummateLevel() - ren.GetConsummateLevel()) * 0.2;
                }
                return (int)num6;
            }
            int Addkuaigan22(int jichu)
            {
                if (jichu < 6 && teshutizhi == 0)
                {
                    jichu = 10;
                }
                double num5 = (double)kuaigan3 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
                if (ren.HasVirginity() && ren.GetCreatingType() == 1)
                {
                    num5 *= 2.0;
                }
                if (teshutizhi == 1)
                {
                    num5 *= 2.0;
                }
                if (taiwu.GetConsummateLevel() > ren.GetConsummateLevel())
                {
                    num5 *= 1.0 + (double)(taiwu.GetConsummateLevel() - ren.GetConsummateLevel()) * 0.2;
                }
                return (int)num5;
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            string arg = "";
            ArgBox.Get("weizujiao", ref arg);
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