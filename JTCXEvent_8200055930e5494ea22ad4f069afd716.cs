using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_8200055930e5494ea22ad4f069afd716 : TaiwuEventItem
    {
        public JTCXEvent_8200055930e5494ea22ad4f069afd716()
        {
            Guid = Guid.Parse("82000559-30e5-494e-a22a-d4f069afd716");
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
                OptionKey = "Option_855968433"
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
            int tili1 = 0;
            ArgBox.Get("tili1", ref tili1);
            int xingfen1 = 0;
            ArgBox.Get("xingfen1", ref xingfen1);
            int kuaigan1 = 0;
            ArgBox.Get("kuaigan1", ref kuaigan1);
            int kuaigan2 = 0;
            ArgBox.Get("kuaigan12", ref kuaigan2);
            int tili2 = 0;
            ArgBox.Get("tili2", ref tili2);
            int xingfen2 = 0;
            ArgBox.Get("xingfen2", ref xingfen2);
            int kuaigan3 = 0;
            ArgBox.Get("kuaigan2", ref kuaigan3);
            int kuaigan4 = 0;
            ArgBox.Get("kuaigan22", ref kuaigan4);
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            int arg2 = 0;
            ArgBox.Get("xinshen2", ref arg2);
            int arg3 = 0;
            ArgBox.Get("sex1", ref arg3);
            int arg4 = 0;
            ArgBox.Get("sex2", ref arg4);
            int arg5 = 0;
            ArgBox.Get("zishi", ref arg5);
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(taiwu, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(ren, 0);
            int lingmin = EventHelper.GetRoleCurrentMainAttributes(taiwu, 1);
            int lingmin2 = EventHelper.GetRoleCurrentMainAttributes(ren, 1);
            int num = -1;
            int num2 = -1;
            int id = ren.GetId();
            if (id % 5 == 3)
            {
                num = id % 2;
            }
            int arg6 = 0;
            ArgBox.Get("mode", ref arg6);
            if (arg6 != 0)
            {
                int arg7 = 0;
                ArgBox.Get("juedouxp", ref arg7);
                if (arg7 % 5 == 3)
                {
                    num = arg7 % 2;
                }
            }
            int teshutizhi = id % 100;
            string val = "1";
            List<int> list = new List<int>();
            if (TaiwuEvent.GetModData("QitaXP", isArchive: true, ref val) && arg6 == 0)
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
            int num4 = -1;
            int num5 = -1;
            int id2 = taiwu.GetId();
            num4 = id2 % 23;
            EventBackground = "";
            EventHelper.SetEventSeriesTexture("");
            ArgBox.Set("xingfen1", xingfen1 + 10);
            ArgBox.Set("xingfen2", xingfen2 + 10);
            ArgBox.Set("xinshen1", arg + 2);
            ArgBox.Set("xinshen2", arg2 + 2);
            ArgBox.Set("kuaigan1", Addkuaigan1(10));
            ArgBox.Set("kuaigan2", Addkuaigan2(10));
            if (num == 0 || list.Contains(0))
            {
                ArgBox.Set("xingfen2", xingfen2 + 10);
                ArgBox.Set("kuaigan2", Addkuaigan2(10));
            }
            if (num4 == 22)
            {
                ArgBox.Set("xingfen1", xingfen1 + 10);
                ArgBox.Set("kuaigan1", Addkuaigan1(10));
            }
            if (arg5 <= 20 && arg5 > 10 && arg5 != 30 && arg5 != 32)
            {
                if (tili1 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (tili1 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((tili1 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (tili1 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (tili1 >= 10)
                        {
                            ArgBox.Set("tili1", tili1 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (tili1 >= 20)
                    {
                        ArgBox.Set("tili1", tili1 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            int item = 0;
            if ((arg4 != 2 && kuaigan3 >= 200 && arg2 >= 100) || (arg4 == 2 && (kuaigan3 >= 100 || kuaigan4 >= 100) && arg2 >= 100))
            {
                string val2 = "1";
                string text = "1";
                if (!TaiwuEvent.GetModData("QitaXP", isArchive: true, ref val2))
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
                        int num6 = int.Parse(array4[0]);
                        if (num6 != ren.GetId())
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
                        TaiwuEvent.SetModString("QitaXP", isArchive: true, text);
                    }
                    else
                    {
                        TaiwuEvent.SetModString("QitaXP", isArchive: true, val2 + "," + ren.GetId() + "|" + item);
                    }
                }
                else
                {
                    TaiwuEvent.SetModString("QitaXP", isArchive: true, val2 + "," + ren.GetId() + "|" + item);
                }
            }
            ArgBox.Set("zishi", 0);
            int Addkuaigan1(int jichu)
            {
                double num8 = (double)kuaigan1 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin2 * 0.0025);
                if (taiwu.HasVirginity())
                {
                    num8 *= 2.0;
                }
                if (ren.GetConsummateLevel() > taiwu.GetConsummateLevel())
                {
                    num8 *= 1.0 + (double)(ren.GetConsummateLevel() - taiwu.GetConsummateLevel()) * 0.2;
                }
                return (int)num8;
            }
            int Addkuaigan2(int jichu)
            {
                if (jichu < 6 && teshutizhi == 0)
                {
                    jichu = 10;
                }
                double num7 = (double)kuaigan3 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
                if (ren.HasVirginity() && ren.GetCreatingType() == 1)
                {
                    num7 *= 2.0;
                }
                if (teshutizhi == 1)
                {
                    num7 *= 2.0;
                }
                if (taiwu.GetConsummateLevel() > ren.GetConsummateLevel())
                {
                    num7 *= 1.0 + (double)(taiwu.GetConsummateLevel() - ren.GetConsummateLevel()) * 0.2;
                }
                return (int)num7;
            }
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