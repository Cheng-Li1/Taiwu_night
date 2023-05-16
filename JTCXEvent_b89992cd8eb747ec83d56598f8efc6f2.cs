using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains;
using GameData.Domains.Character;
using GameData.Domains.Combat;
using GameData.Domains.Item;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_b89992cd8eb747ec83d56598f8efc6f2 : TaiwuEventItem
    {
        public JTCXEvent_b89992cd8eb747ec83d56598f8efc6f2()
        {
            Guid = Guid.Parse("b89992cd-8eb7-47ec-83d5-6598f8efc6f2");
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
                OptionKey = "Option_1446612432"
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
            ArgBox.Get("gaochao2count", ref arg);
            ArgBox.Set("gaochao2count", arg + 1);
            int arg2 = 0;
            ArgBox.Get("xinshen2", ref arg2);
            ArgBox.Set("xinshen2", arg2 + 20);
            int arg3 = 0;
            ArgBox.Get("huiheshu", ref arg3);
            int arg4 = 0;
            ArgBox.Get("shouhuiheshu", ref arg4);
            int arg5 = 0;
            ArgBox.Get("kouhuiheshu", ref arg5);
            Character character = ArgBox.GetCharacter("ren");
            int arg6 = 0;
            ArgBox.Get("sex2", ref arg6);
            int arg7 = 0;
            ArgBox.Get("zishi", ref arg7);
            if (arg7 != 21 && arg7 != 0 && arg7 < 30)
            {
                if (arg6 != 0)
                {
                    EventBackground = "neishe";
                    EventHelper.SetEventSeriesTexture("neishe");
                }
                else
                {
                    EventBackground = "yiqi";
                    EventHelper.SetEventSeriesTexture("yiqi");
                }
            }
            if (arg2 >= 100 && arg7 != 0)
            {
                string val = "1";
                string text = "1";
                if (!TaiwuEvent.GetModData("ZishiXP", isArchive: true, ref val))
                {
                    val = "1";
                }
                string[] array = val.Split(',');
                bool flag = false;
                if (array.Length > 1)
                {
                    for (int i = 1; i < array.Length; i++)
                    {
                        string[] array2 = array[i].Split('|');
                        int num = int.Parse(array2[0]);
                        if (num != character.GetId())
                        {
                            continue;
                        }
                        List<int> list = new List<int>();
                        for (int j = 1; j < array2.Length; j++)
                        {
                            list.Add(int.Parse(array2[j]));
                        }
                        if (!list.Contains(arg7))
                        {
                            for (int k = 1; k < array.Length; k++)
                            {
                                text = ((k == i) ? (text + "," + array[i] + "|" + arg7) : (text + "," + array[k]));
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
                        TaiwuEvent.SetModString("ZishiXP", isArchive: true, val + "," + character.GetId() + "|" + arg7);
                    }
                }
                else
                {
                    TaiwuEvent.SetModString("ZishiXP", isArchive: true, val + "," + character.GetId() + "|" + arg7);
                }
            }
            int arg8 = 0;
            ArgBox.Get("shoubuwei", ref arg8);
            int arg9 = 0;
            ArgBox.Get("shoucaozuo", ref arg9);
            int arg10 = 0;
            ArgBox.Get("shoulidu", ref arg10);
            if (arg4 == arg3 && arg2 >= 100)
            {
                int item = 0;
                if (arg8 == 1)
                {
                    if (arg9 == 1)
                    {
                        if (arg10 == 1)
                        {
                            item = 0;
                        }
                        if (arg10 == 3)
                        {
                            item = 1;
                        }
                    }
                    if (arg9 == 2)
                    {
                        if (arg10 == 1)
                        {
                            item = 2;
                        }
                        if (arg10 == 3)
                        {
                            item = 3;
                        }
                    }
                    if (arg9 == 3)
                    {
                        if (arg10 == 1)
                        {
                            item = 4;
                        }
                        if (arg10 == 3)
                        {
                            item = 5;
                        }
                    }
                    if (arg9 == 4)
                    {
                        if (arg10 == 1)
                        {
                            item = 6;
                        }
                        if (arg10 == 3)
                        {
                            item = 7;
                        }
                    }
                }
                if (arg8 == 2)
                {
                    if (arg9 == 1)
                    {
                        if (arg10 == 1)
                        {
                            item = 8;
                        }
                        if (arg10 == 3)
                        {
                            item = 9;
                        }
                    }
                    if (arg9 == 2)
                    {
                        if (arg10 == 1)
                        {
                            item = 10;
                        }
                        if (arg10 == 3)
                        {
                            item = 11;
                        }
                    }
                    if (arg9 == 3)
                    {
                        if (arg10 == 1)
                        {
                            item = 12;
                        }
                        if (arg10 == 3)
                        {
                            item = 13;
                        }
                    }
                    if (arg9 == 4)
                    {
                        if (arg10 == 1)
                        {
                            item = 14;
                        }
                        if (arg10 == 3)
                        {
                            item = 15;
                        }
                    }
                }
                if (arg8 == 3)
                {
                    if (arg9 == 1)
                    {
                        if (arg10 == 1)
                        {
                            item = 16;
                        }
                        if (arg10 == 3)
                        {
                            item = 17;
                        }
                    }
                    if (arg9 == 2)
                    {
                        if (arg10 == 1)
                        {
                            item = 18;
                        }
                        if (arg10 == 3)
                        {
                            item = 19;
                        }
                    }
                    if (arg9 == 3)
                    {
                        if (arg10 == 1)
                        {
                            item = 20;
                        }
                        if (arg10 == 3)
                        {
                            item = 21;
                        }
                    }
                    if (arg9 == 4)
                    {
                        if (arg10 == 1)
                        {
                            item = 22;
                        }
                        if (arg10 == 3)
                        {
                            item = 23;
                        }
                    }
                }
                if (arg8 == 4)
                {
                    if (arg9 == 1)
                    {
                        if (arg10 == 1)
                        {
                            item = 24;
                        }
                        if (arg10 == 3)
                        {
                            item = 25;
                        }
                    }
                    if (arg9 == 2)
                    {
                        if (arg10 == 1)
                        {
                            item = 26;
                        }
                        if (arg10 == 3)
                        {
                            item = 27;
                        }
                    }
                    if (arg9 == 3)
                    {
                        if (arg10 == 1)
                        {
                            item = 28;
                        }
                        if (arg10 == 3)
                        {
                            item = 29;
                        }
                    }
                    if (arg9 == 4)
                    {
                        if (arg10 == 1)
                        {
                            item = 30;
                        }
                        if (arg10 == 3)
                        {
                            item = 31;
                        }
                    }
                }
                if (arg8 == 5)
                {
                    if (arg9 == 1)
                    {
                        if (arg10 == 1)
                        {
                            item = 32;
                        }
                        if (arg10 == 3)
                        {
                            item = 33;
                        }
                    }
                    if (arg9 == 2)
                    {
                        if (arg10 == 1)
                        {
                            item = 34;
                        }
                        if (arg10 == 3)
                        {
                            item = 35;
                        }
                    }
                    if (arg9 == 3)
                    {
                        if (arg10 == 1)
                        {
                            item = 36;
                        }
                        if (arg10 == 3)
                        {
                            item = 37;
                        }
                    }
                    if (arg9 == 4)
                    {
                        if (arg10 == 1)
                        {
                            item = 38;
                        }
                        if (arg10 == 3)
                        {
                            item = 39;
                        }
                    }
                }
                if (arg8 == 6)
                {
                    if (arg9 == 1)
                    {
                        if (arg10 == 1)
                        {
                            item = 40;
                        }
                        if (arg10 == 3)
                        {
                            item = 41;
                        }
                    }
                    if (arg9 == 2)
                    {
                        if (arg10 == 1)
                        {
                            item = 42;
                        }
                        if (arg10 == 3)
                        {
                            item = 43;
                        }
                    }
                    if (arg9 == 3)
                    {
                        if (arg10 == 1)
                        {
                            item = 44;
                        }
                        if (arg10 == 3)
                        {
                            item = 45;
                        }
                    }
                    if (arg9 == 4)
                    {
                        if (arg10 == 1)
                        {
                            item = 46;
                        }
                        if (arg10 == 3)
                        {
                            item = 47;
                        }
                    }
                }
                string val2 = "1";
                string text2 = "1";
                if (!TaiwuEvent.GetModData("ShouXP", isArchive: true, ref val2))
                {
                    val2 = "1";
                }
                string[] array3 = val2.Split(',');
                bool flag2 = false;
                if (array3.Length > 1)
                {
                    List<int> list2 = new List<int>();
                    for (int l = 1; l < array3.Length; l++)
                    {
                        string[] array4 = array3[l].Split('|');
                        int num2 = int.Parse(array4[0]);
                        if (num2 != character.GetId())
                        {
                            continue;
                        }
                        for (int m = 1; m < array4.Length; m++)
                        {
                            list2.Add(int.Parse(array4[m]));
                        }
                        if (!list2.Contains(item))
                        {
                            for (int n = 1; n < array3.Length; n++)
                            {
                                text2 = ((n == l) ? (text2 + "," + array3[l] + "|" + item) : (text2 + "," + array3[n]));
                            }
                            flag2 = true;
                        }
                    }
                    if (flag2)
                    {
                        ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                        TaiwuEvent.SetModString("ShouXP", isArchive: true, text2);
                    }
                    if (!flag2 && !list2.Contains(item))
                    {
                        ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                        TaiwuEvent.SetModString("ShouXP", isArchive: true, val2 + "," + character.GetId() + "|" + item);
                    }
                }
                else
                {
                    ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                    TaiwuEvent.SetModString("ShouXP", isArchive: true, val2 + "," + character.GetId() + "|" + item);
                }
            }
            int arg11 = 0;
            ArgBox.Get("koubuwei", ref arg11);
            int arg12 = 0;
            ArgBox.Get("koucaozuo", ref arg12);
            int arg13 = 0;
            ArgBox.Get("koulidu", ref arg13);
            if (arg5 == arg3 && arg2 >= 100)
            {
                int item2 = 0;
                if (arg11 == 0)
                {
                    if (arg13 == 1)
                    {
                        item2 = 0;
                    }
                    if (arg13 == 2)
                    {
                        item2 = 1;
                    }
                }
                if (arg11 == 1)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 2;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 3;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 4;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 5;
                        }
                    }
                }
                if (arg11 == 2)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 6;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 7;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 8;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 9;
                        }
                    }
                }
                if (arg11 == 3)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 10;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 11;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 12;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 13;
                        }
                    }
                }
                if (arg11 == 4)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 14;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 15;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 16;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 17;
                        }
                    }
                }
                if (arg11 == 5)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 18;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 19;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item2 = 20;
                        }
                        if (arg13 == 3)
                        {
                            item2 = 21;
                        }
                    }
                }
                string val3 = "1";
                string text3 = "1";
                if (!TaiwuEvent.GetModData("KouXP", isArchive: true, ref val3))
                {
                    val3 = "1";
                }
                string[] array5 = val3.Split(',');
                bool flag3 = false;
                if (array5.Length > 1)
                {
                    List<int> list3 = new List<int>();
                    for (int num3 = 1; num3 < array5.Length; num3++)
                    {
                        string[] array6 = array5[num3].Split('|');
                        int num4 = int.Parse(array6[0]);
                        if (num4 != character.GetId())
                        {
                            continue;
                        }
                        for (int num5 = 1; num5 < array6.Length; num5++)
                        {
                            list3.Add(int.Parse(array6[num5]));
                        }
                        if (!list3.Contains(item2))
                        {
                            for (int num6 = 1; num6 < array5.Length; num6++)
                            {
                                text3 = ((num6 == num3) ? (text3 + "," + array5[num3] + "|" + item2) : (text3 + "," + array5[num6]));
                            }
                            flag3 = true;
                        }
                    }
                    if (flag3)
                    {
                        ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                        TaiwuEvent.SetModString("KouXP", isArchive: true, text3);
                    }
                    if (!flag3 && !list3.Contains(item2))
                    {
                        ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                        TaiwuEvent.SetModString("KouXP", isArchive: true, val3 + "," + character.GetId() + "|" + item2);
                    }
                }
                else
                {
                    ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                    TaiwuEvent.SetModString("KouXP", isArchive: true, val3 + "," + character.GetId() + "|" + item2);
                }
            }
            int arg14 = 0;
            ArgBox.Get("qianhou", ref arg14);
            if (arg14 != 2 || arg2 < 100)
            {
                return;
            }
            string val4 = "1";
            if (!TaiwuEvent.GetModData("JuhuaXP", isArchive: true, ref val4))
            {
                val4 = "1";
            }
            string[] array7 = val4.Split(',');
            bool flag4 = false;
            if (array7.Length > 1)
            {
                for (int num7 = 1; num7 < array7.Length; num7++)
                {
                    int num8 = int.Parse(array7[num7]);
                    if (num8 == character.GetId())
                    {
                        flag4 = true;
                    }
                }
                if (!flag4)
                {
                    ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                    TaiwuEvent.SetModString("JuhuaXP", isArchive: true, val4 + "," + character.GetId());
                }
            }
            else
            {
                ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                TaiwuEvent.SetModString("JuhuaXP", isArchive: true, val4 + "," + character.GetId());
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            int arg = 0;
            ArgBox.Get("sex2", ref arg);
            int arg2 = 0;
            ArgBox.Get("kuaigan2", ref arg2);
            int arg3 = 0;
            ArgBox.Get("kuaigan22", ref arg3);
            string arg4 = "";
            ArgBox.Get("chengweiduifang", ref arg4);
            Character character = ArgBox.GetCharacter("ren");
            string text = "";
            if (arg == 0)
            {
                text = "\"啊~~~<ArgBox key=chengweiduifang type=string/>~~~我要去啦~~~!!!\"<Character key=ren str=Name/>身体突然紧绷，达到高潮，喷出了大量的淫水。";
            }
            if (arg == 1)
            {
                text = "\"啊~~~<ArgBox key=chengweiduifang type=string/>~~~我要射啦~~~!!!\"<Character key=ren str=Name/>精关一松，射出了大量的白浆。";
            }
            if (arg == 2 && arg3 >= 100)
            {
                text = "\"啊~~~<ArgBox key=chengweiduifang type=string/>~~~我要去啦~~~!!!\"<Character key=ren str=Name/>身体突然紧绷，达到高潮，喷出了大量的淫水。";
            }
            if (arg == 2 && arg2 >= 100)
            {
                text = "\"啊~~~<ArgBox key=chengweiduifang type=string/>~~~我要射啦~~~!!!\"<Character key=ren str=Name/>精关一松，射出了大量的白浆。";
            }
            int arg5 = 0;
            ArgBox.Get("mode", ref arg5);
            if (arg5 == 1)
            {
                text += "\n<Character key=ren str=Name/>被<Character key=RoleTaiwu str=Name/>吸去了内力。";
            }
            string arg6 = "";
            if (ArgBox.Get("xinxp", ref arg6))
            {
                text += arg6;
            }
            string targetString = string.Format(base.EventContent, text);
            targetString = EventHelper.HandleStringTag(targetString, ArgBox, TaiwuEvent);
            ArgBox.Remove<string>("xinxp");
            return targetString;
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
            string arg = "";
            int arg2 = 0;
            ArgBox.Get("kuaigan2", ref arg2);
            int arg3 = 0;
            ArgBox.Get("kuaigan22", ref arg3);
            if (arg2 > 0)
            {
                ArgBox.Set("kuaigan2", 0);
            }
            if (arg3 > 0)
            {
                ArgBox.Set("kuaigan22", 0);
            }
            ArgBox.Set("xingfen2", 30);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int arg4 = 0;
            ArgBox.Get("zishi", ref arg4);
            int arg5 = 0;
            ArgBox.Get("qianhou", ref arg5);
            int arg6 = 0;
            ArgBox.Get("sex1", ref arg6);
            int arg7 = 0;
            ArgBox.Get("sex2", ref arg7);
            if (!character.GetFeatureIds().Contains(196))
            {
                character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
            }
            if (!character2.GetFeatureIds().Contains(196))
            {
                character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
            }
            if (arg4 != 21 && arg4 != 0 && arg4 < 30 && arg5 == 1 && character2.GetCreatingType() == 1)
            {
                if (arg6 != 1 && arg7 != 0)
                {
                    int val = 0;
                    DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val);
                    int random = EventHelper.GetRandom(1, 101);
                    if (!character.GetFeatureIds().Contains(197) && random <= val)
                    {
                        DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
                        character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
                    }
                }
                bool val2 = false;
                DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "tongxing", ref val2);
                if (val2)
                {
                    if (arg6 == 0 && arg7 == 0)
                    {
                        int val3 = 0;
                        DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val3);
                        int random2 = EventHelper.GetRandom(1, 101);
                        if (!character2.GetFeatureIds().Contains(197) && random2 <= val3)
                        {
                            DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character2, character, isRaped: false);
                            character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
                        }
                    }
                    if (arg6 == 1 && arg7 == 1)
                    {
                        int val4 = 0;
                        DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val4);
                        int random3 = EventHelper.GetRandom(1, 101);
                        if (!character.GetFeatureIds().Contains(197) && random3 <= val4)
                        {
                            DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
                            character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
                        }
                    }
                }
            }
            ArgBox.Set("zishi", 0);
            ArgBox.Set("ppzishi", "无");
            ArgBox.Set("gaochao", 2);
            int arg8 = 0;
            ArgBox.Get("mode", ref arg8);
            if (arg8 == 1)
            {
                if (character2.GetCreatingType() == 1)
                {
                    int val5 = 0;
                    DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "neili", ref val5);
                    int neiliType = character.GetNeiliType();
                    int neiliType2 = character2.GetNeiliType();
                    int num = 0;
                    int num2 = 0;
                    if (neiliType == 0 || (neiliType > 5 && neiliType < 12))
                    {
                        num = 1;
                    }
                    if (neiliType == 2 || (neiliType > 17 && neiliType < 24))
                    {
                        num = 2;
                    }
                    if (neiliType == 1 || (neiliType > 11 && neiliType < 18))
                    {
                        num = 3;
                    }
                    if (neiliType == 3 || (neiliType > 23 && neiliType < 30))
                    {
                        num = 4;
                    }
                    if (neiliType == 4 || neiliType > 29)
                    {
                        num = 5;
                    }
                    if (neiliType == 5)
                    {
                        num = 6;
                    }
                    if (neiliType2 == 0 || (neiliType2 > 5 && neiliType2 < 12))
                    {
                        num2 = 1;
                    }
                    if (neiliType2 == 2 || (neiliType2 > 17 && neiliType2 < 24))
                    {
                        num2 = 2;
                    }
                    if (neiliType2 == 1 || (neiliType2 > 11 && neiliType2 < 18))
                    {
                        num2 = 3;
                    }
                    if (neiliType2 == 3 || (neiliType2 > 23 && neiliType2 < 30))
                    {
                        num2 = 4;
                    }
                    if (neiliType2 == 4 || neiliType2 > 29)
                    {
                        num2 = 5;
                    }
                    if (neiliType2 == 5)
                    {
                        num2 = 6;
                    }
                    if (num == 6 || num2 == 6)
                    {
                        val5 = (int)((double)val5 * 0.7);
                    }
                    else
                    {
                        if (num2 == num + 1 || (num == 5 && num2 == 1))
                        {
                            val5 = (int)((double)val5 * 0.75);
                        }
                        if (num == num2 + 1 || (num == 1 && num2 == 5))
                        {
                            val5 = (int)((double)val5 * 1.25);
                        }
                        if (num2 == num + 2 || (num == 4 && num2 == 1) || (num == 5 && num2 == 2))
                        {
                            val5 = (int)((double)val5 * 1.5);
                        }
                        if (num == num2 + 2 || (num2 == 4 && num == 1) || (num2 == 5 && num == 2))
                        {
                            val5 = (int)((double)val5 * 0.5);
                        }
                    }
                    character.SetExtraNeili(character.GetExtraNeili() + val5, DomainManager.TaiwuEvent.MainThreadDataContext);
                    character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character.GetCurrNeili() + val5);
                    if (character2.GetPureCurrNeili() < val5)
                    {
                        character2.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 0);
                    }
                    else
                    {
                        character2.SpecifyBaseNeiliAllocation(DomainManager.TaiwuEvent.MainThreadDataContext, default(NeiliAllocation));
                        character2.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character2.GetCurrNeili() - val5);
                    }
                }
                Character character3 = character2;
                if (ArgBox.Get("nvyifu", out ItemKey arg9))
                {
                    character3.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg9);
                }
                if (ArgBox.Get("nanyifu", out ItemKey arg10))
                {
                    character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg10);
                }
                if (EventHelper.GetFavorabilityType(character2, character) >= 5)
                {
                    EventHelper.EndRelation(character2.GetId(), character.GetId(), 32768);
                    EventHelper.EndRelation(character.GetId(), character2.GetId(), 32768);
                }
                EventBackground = "";
                EventHelper.SetEventSeriesTexture("");
                ArgBox.Set("juedouresult", 1);
                bool arg11 = false;
                if (ArgBox.Get("zhandoucx", ref arg11))
                {
                    CombatCharacter combatCharacter = DomainManager.Combat.GetCombatCharacter(isAlly: false);
                    combatCharacter.SetNeiliAllocation(default(NeiliAllocation), DomainManager.TaiwuEvent.MainThreadDataContext);
                    return "4884185b-1ba0-4367-a214-883f6210ebea";
                }
                bool arg12 = false;
                if (ArgBox.Get("jiaoyicx", ref arg12))
                {
                    return "feb39e93-c762-491d-b852-7d1349de6bd5";
                }
                if (ArgBox.Get("fanhui", ref arg))
                {
                    return arg;
                }
                return string.Empty;
            }
            int arg13 = 0;
            ArgBox.Get("gaochao2count", ref arg13);
            int arg14 = 0;
            if (ArgBox.Get("gaochaotuichu2", ref arg14) && arg13 >= arg14 && ArgBox.Get("fanhui", ref arg))
            {
                EventBackground = "";
                EventHelper.SetEventSeriesTexture("");
                Character character4 = character2;
                if (ArgBox.Get("nvyifu", out ItemKey arg15))
                {
                    character4.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg15);
                }
                if (ArgBox.Get("nanyifu", out ItemKey arg16))
                {
                    character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg16);
                }
                return arg;
            }
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}