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
    public class JTCXEvent_ea0136f933e948438bd4b17170a531fc : TaiwuEventItem
    {
        public JTCXEvent_ea0136f933e948438bd4b17170a531fc()
        {
            Guid = Guid.Parse("ea0136f9-33e9-4843-8bd4-b17170a531fc");
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
                OptionKey = "Option_1088345018"
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
            ArgBox.Get("gaochao1count", ref arg);
            int arg2 = 0;
            ArgBox.Get("gaochao2count", ref arg2);
            ArgBox.Set("gaochao1count", arg + 1);
            ArgBox.Set("gaochao2count", arg2 + 1);
            int arg3 = 0;
            ArgBox.Get("sex1", ref arg3);
            int arg4 = 0;
            ArgBox.Get("xinshen1", ref arg4);
            int arg5 = 0;
            ArgBox.Get("xinshen2", ref arg5);
            ArgBox.Set("xinshen1", arg4 + 20);
            ArgBox.Set("xinshen2", arg5 + 20);
            int arg6 = 0;
            ArgBox.Get("huiheshu", ref arg6);
            int arg7 = 0;
            ArgBox.Get("shouhuiheshu", ref arg7);
            int arg8 = 0;
            ArgBox.Get("kouhuiheshu", ref arg8);
            int arg9 = 0;
            ArgBox.Get("mode", ref arg9);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            if (arg3 != 0 && arg9 == 0)
            {
                EventHelper.ToEvent("1c43923d-c590-45bb-816f-93fb48c32f6c");
            }
            int arg10 = 0;
            ArgBox.Get("zishi", ref arg10);
            if (arg10 != 21 && arg10 != 0 && arg10 < 30)
            {
                EventBackground = "yiqi";
                EventHelper.SetEventSeriesTexture("yiqi");
            }
            if (arg5 >= 100 && arg10 != 0)
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
                        if (num != character2.GetId())
                        {
                            continue;
                        }
                        List<int> list = new List<int>();
                        for (int j = 1; j < array2.Length; j++)
                        {
                            list.Add(int.Parse(array2[j]));
                        }
                        if (!list.Contains(arg10))
                        {
                            for (int k = 1; k < array.Length; k++)
                            {
                                text = ((k == i) ? (text + "," + array[i] + "|" + arg10) : (text + "," + array[k]));
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
                        TaiwuEvent.SetModString("ZishiXP", isArchive: true, val + "," + character2.GetId() + "|" + arg10);
                    }
                }
                else
                {
                    TaiwuEvent.SetModString("ZishiXP", isArchive: true, val + "," + character2.GetId() + "|" + arg10);
                }
            }
            int arg11 = 0;
            ArgBox.Get("shoubuwei", ref arg11);
            int arg12 = 0;
            ArgBox.Get("shoucaozuo", ref arg12);
            int arg13 = 0;
            ArgBox.Get("shoulidu", ref arg13);
            if (arg7 == arg6 && arg5 >= 100)
            {
                int item = 0;
                if (arg11 == 1)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item = 0;
                        }
                        if (arg13 == 3)
                        {
                            item = 1;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item = 2;
                        }
                        if (arg13 == 3)
                        {
                            item = 3;
                        }
                    }
                    if (arg12 == 3)
                    {
                        if (arg13 == 1)
                        {
                            item = 4;
                        }
                        if (arg13 == 3)
                        {
                            item = 5;
                        }
                    }
                    if (arg12 == 4)
                    {
                        if (arg13 == 1)
                        {
                            item = 6;
                        }
                        if (arg13 == 3)
                        {
                            item = 7;
                        }
                    }
                }
                if (arg11 == 2)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item = 8;
                        }
                        if (arg13 == 3)
                        {
                            item = 9;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item = 10;
                        }
                        if (arg13 == 3)
                        {
                            item = 11;
                        }
                    }
                    if (arg12 == 3)
                    {
                        if (arg13 == 1)
                        {
                            item = 12;
                        }
                        if (arg13 == 3)
                        {
                            item = 13;
                        }
                    }
                    if (arg12 == 4)
                    {
                        if (arg13 == 1)
                        {
                            item = 14;
                        }
                        if (arg13 == 3)
                        {
                            item = 15;
                        }
                    }
                }
                if (arg11 == 3)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item = 16;
                        }
                        if (arg13 == 3)
                        {
                            item = 17;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item = 18;
                        }
                        if (arg13 == 3)
                        {
                            item = 19;
                        }
                    }
                    if (arg12 == 3)
                    {
                        if (arg13 == 1)
                        {
                            item = 20;
                        }
                        if (arg13 == 3)
                        {
                            item = 21;
                        }
                    }
                    if (arg12 == 4)
                    {
                        if (arg13 == 1)
                        {
                            item = 22;
                        }
                        if (arg13 == 3)
                        {
                            item = 23;
                        }
                    }
                }
                if (arg11 == 4)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item = 24;
                        }
                        if (arg13 == 3)
                        {
                            item = 25;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item = 26;
                        }
                        if (arg13 == 3)
                        {
                            item = 27;
                        }
                    }
                    if (arg12 == 3)
                    {
                        if (arg13 == 1)
                        {
                            item = 28;
                        }
                        if (arg13 == 3)
                        {
                            item = 29;
                        }
                    }
                    if (arg12 == 4)
                    {
                        if (arg13 == 1)
                        {
                            item = 30;
                        }
                        if (arg13 == 3)
                        {
                            item = 31;
                        }
                    }
                }
                if (arg11 == 5)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item = 32;
                        }
                        if (arg13 == 3)
                        {
                            item = 33;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item = 34;
                        }
                        if (arg13 == 3)
                        {
                            item = 35;
                        }
                    }
                    if (arg12 == 3)
                    {
                        if (arg13 == 1)
                        {
                            item = 36;
                        }
                        if (arg13 == 3)
                        {
                            item = 37;
                        }
                    }
                    if (arg12 == 4)
                    {
                        if (arg13 == 1)
                        {
                            item = 38;
                        }
                        if (arg13 == 3)
                        {
                            item = 39;
                        }
                    }
                }
                if (arg11 == 6)
                {
                    if (arg12 == 1)
                    {
                        if (arg13 == 1)
                        {
                            item = 40;
                        }
                        if (arg13 == 3)
                        {
                            item = 41;
                        }
                    }
                    if (arg12 == 2)
                    {
                        if (arg13 == 1)
                        {
                            item = 42;
                        }
                        if (arg13 == 3)
                        {
                            item = 43;
                        }
                    }
                    if (arg12 == 3)
                    {
                        if (arg13 == 1)
                        {
                            item = 44;
                        }
                        if (arg13 == 3)
                        {
                            item = 45;
                        }
                    }
                    if (arg12 == 4)
                    {
                        if (arg13 == 1)
                        {
                            item = 46;
                        }
                        if (arg13 == 3)
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
                        if (num2 != character2.GetId())
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
                        TaiwuEvent.SetModString("ShouXP", isArchive: true, val2 + "," + character2.GetId() + "|" + item);
                    }
                }
                else
                {
                    ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                    TaiwuEvent.SetModString("ShouXP", isArchive: true, val2 + "," + character2.GetId() + "|" + item);
                }
            }
            int arg14 = 0;
            ArgBox.Get("koubuwei", ref arg14);
            int arg15 = 0;
            ArgBox.Get("koucaozuo", ref arg15);
            int arg16 = 0;
            ArgBox.Get("koulidu", ref arg16);
            if (arg8 == arg6 && arg5 >= 100)
            {
                int item2 = 0;
                if (arg14 == 0)
                {
                    if (arg16 == 1)
                    {
                        item2 = 0;
                    }
                    if (arg16 == 2)
                    {
                        item2 = 1;
                    }
                }
                if (arg14 == 1)
                {
                    if (arg15 == 1)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 2;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 3;
                        }
                    }
                    if (arg15 == 2)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 4;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 5;
                        }
                    }
                }
                if (arg14 == 2)
                {
                    if (arg15 == 1)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 6;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 7;
                        }
                    }
                    if (arg15 == 2)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 8;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 9;
                        }
                    }
                }
                if (arg14 == 3)
                {
                    if (arg15 == 1)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 10;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 11;
                        }
                    }
                    if (arg15 == 2)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 12;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 13;
                        }
                    }
                }
                if (arg14 == 4)
                {
                    if (arg15 == 1)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 14;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 15;
                        }
                    }
                    if (arg15 == 2)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 16;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 17;
                        }
                    }
                }
                if (arg14 == 5)
                {
                    if (arg15 == 1)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 18;
                        }
                        if (arg16 == 3)
                        {
                            item2 = 19;
                        }
                    }
                    if (arg15 == 2)
                    {
                        if (arg16 == 1)
                        {
                            item2 = 20;
                        }
                        if (arg16 == 3)
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
                        if (num4 != character2.GetId())
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
                        TaiwuEvent.SetModString("KouXP", isArchive: true, val3 + "," + character2.GetId() + "|" + item2);
                    }
                }
                else
                {
                    ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                    TaiwuEvent.SetModString("KouXP", isArchive: true, val3 + "," + character2.GetId() + "|" + item2);
                }
            }
            int arg17 = 0;
            ArgBox.Get("qianhou", ref arg17);
            if (arg17 != 2 || arg5 < 100)
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
                    if (num8 == character2.GetId())
                    {
                        flag4 = true;
                    }
                }
                if (!flag4)
                {
                    ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                    TaiwuEvent.SetModString("JuhuaXP", isArchive: true, val4 + "," + character2.GetId());
                }
            }
            else
            {
                ArgBox.Set("xinxp", "\n<Character key=ren str=Name/>增加了新的XP！");
                TaiwuEvent.SetModString("JuhuaXP", isArchive: true, val4 + "," + character2.GetId());
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            int arg = 0;
            ArgBox.Get("mode", ref arg);
            string text = "\"啊~~~\"\"啊~~~\"<Character key=RoleTaiwu str=Name/>和<Character key=ren str=Name/>一起达到了高潮。";
            if (arg == 1)
            {
                text = "<Character key=RoleTaiwu str=Name/>和<Character key=ren str=Name/>一起达到了高潮。\n双方的内力获得了增长。";
            }
            string arg2 = "";
            if (ArgBox.Get("xinxp", ref arg2))
            {
                text += arg2;
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
                bool val9 = false;
                DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "tongxing", ref val9);
                if (val9)
                {
                    if (arg7 == 0 && arg8 == 0)
                    {
                        int val10 = 0;
                        DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val10);
                        int random9 = EventHelper.GetRandom(1, 101);
                        if (!character2.GetFeatureIds().Contains(197) && random9 <= val10)
                        {
                            DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character2, character, isRaped: false);
                            character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
                        }
                        int random10 = EventHelper.GetRandom(1, 101);
                        if (!character.GetFeatureIds().Contains(197) && random10 <= val10)
                        {
                            DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
                            character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
                        }
                    }
                    if (arg7 == 1 && arg8 == 1)
                    {
                        int val11 = 0;
                        DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "huaiyun", ref val11);
                        int random11 = EventHelper.GetRandom(1, 101);
                        if (!character.GetFeatureIds().Contains(197) && random11 <= val11)
                        {
                            DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character, character2, isRaped: false);
                            character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
                        }
                        int random12 = EventHelper.GetRandom(1, 101);
                        if (!character2.GetFeatureIds().Contains(197) && random12 <= val11)
                        {
                            DomainManager.Character.CreatePregnantState(DomainManager.TaiwuEvent.MainThreadDataContext, character2, character, isRaped: false);
                            character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 197, removeMutexFeature: true);
                        }
                    }
                }
            }
            ArgBox.Set("zishi", 0);
            ArgBox.Set("ppzishi", "无");
            ArgBox.Set("gaochao", 3);
            int arg9 = 0;
            ArgBox.Get("mode", ref arg9);
            if (arg9 == 1)
            {
                if (character2.GetCreatingType() == 1)
                {
                    int num = 0;
                    int num2 = 0;
                    num = ((character.GetLoopingNeigong() != -1) ? ((EventHelper.GetCombatSkillGrade(character.GetLoopingNeigong()) + 1) * 10) : 5);
                    num2 = ((character2.GetLoopingNeigong() != -1) ? ((EventHelper.GetCombatSkillGrade(character2.GetLoopingNeigong()) + 1) * 10) : 5);
                    character.SetExtraNeili(character.GetExtraNeili() + num, DomainManager.TaiwuEvent.MainThreadDataContext);
                    character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character.GetCurrNeili() + num);
                    character2.SetExtraNeili(character2.GetExtraNeili() + num2, DomainManager.TaiwuEvent.MainThreadDataContext);
                    character2.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character2.GetCurrNeili() + num2);
                }
                Character character3 = character2;
                if (ArgBox.Get("nvyifu", out ItemKey arg10))
                {
                    character3.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg10);
                }
                if (ArgBox.Get("nanyifu", out ItemKey arg11))
                {
                    character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg11);
                }
                EventBackground = "";
                EventHelper.SetEventSeriesTexture("");
                if (EventHelper.GetFavorabilityType(character2, character) >= 5)
                {
                    EventHelper.EndRelation(character2.GetId(), character.GetId(), 32768);
                    EventHelper.EndRelation(character.GetId(), character2.GetId(), 32768);
                }
                ArgBox.Set("juedouresult", 0);
                bool arg12 = false;
                if (ArgBox.Get("zhandoucx", ref arg12))
                {
                    CombatCharacter combatCharacter = DomainManager.Combat.GetCombatCharacter(isAlly: true);
                    combatCharacter.SetNeiliAllocation(default(NeiliAllocation), DomainManager.TaiwuEvent.MainThreadDataContext);
                    CombatCharacter combatCharacter2 = DomainManager.Combat.GetCombatCharacter(isAlly: false);
                    combatCharacter2.SetNeiliAllocation(default(NeiliAllocation), DomainManager.TaiwuEvent.MainThreadDataContext);
                    return "4b0065f4-ca93-435d-8b95-67741e78be62";
                }
                bool arg13 = false;
                if (ArgBox.Get("jiaoyicx", ref arg13))
                {
                    return "9a48630b-a847-4571-b98c-261cb7926fba";
                }
                string arg14 = "";
                if (ArgBox.Get("fanhui", ref arg14))
                {
                    return arg14;
                }
                return string.Empty;
            }
            int arg15 = 0;
            ArgBox.Get("gaochao1count", ref arg15);
            int arg16 = 0;
            ArgBox.Get("gaochao2count", ref arg16);
            int arg17 = 0;
            if (ArgBox.Get("gaochaotuichu1", ref arg17) && arg15 >= arg17)
            {
                string arg18 = "";
                if (ArgBox.Get("fanhui", ref arg18))
                {
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    Character character4 = character2;
                    if (ArgBox.Get("nvyifu", out ItemKey arg19))
                    {
                        character4.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg19);
                    }
                    if (ArgBox.Get("nanyifu", out ItemKey arg20))
                    {
                        character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg20);
                    }
                    return arg18;
                }
            }
            int arg21 = 0;
            if (ArgBox.Get("gaochaotuichu2", ref arg21) && arg16 >= arg21)
            {
                string arg22 = "";
                if (ArgBox.Get("fanhui", ref arg22))
                {
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    Character character5 = character2;
                    if (ArgBox.Get("nvyifu", out ItemKey arg23))
                    {
                        character5.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg23);
                    }
                    if (ArgBox.Get("nanyifu", out ItemKey arg24))
                    {
                        character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg24);
                    }
                    return arg22;
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