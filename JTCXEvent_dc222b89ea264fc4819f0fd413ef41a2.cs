using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_dc222b89ea264fc4819f0fd413ef41a2 : TaiwuEventItem
    {
        public JTCXEvent_dc222b89ea264fc4819f0fd413ef41a2()
        {
            Guid = Guid.Parse("dc222b89-ea26-4fc4-819f-0fd413ef41a2");
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
                OptionKey = "Option_-1748886405"
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
            ArgBox.Get("huiheshu", ref arg);
            ArgBox.Set("huiheshu", arg + 1);
            int lichang = EventHelper.GetRoleBehavior(ren);
            int arg2 = 0;
            ArgBox.Get("mode", ref arg2);
            bool arg3 = false;
            bool arg4 = false;
            bool arg5 = false;
            if (ArgBox.Get("huandu", ref arg3) && !ArgBox.Get("huandujixugan", ref arg4))
            {
                int arg6 = 0;
                ArgBox.Get("huandulevel", ref arg6);
                int roleGrade = EventHelper.GetRoleGrade(ren);
                int random = EventHelper.GetRandom();
                if (arg6 == roleGrade + 1 && random < 7)
                {
                    EventHelper.ToEvent("a08ba0ea-806d-409c-b148-824b10a1c91c");
                }
                if (arg6 == roleGrade && random < 12)
                {
                    EventHelper.ToEvent("a08ba0ea-806d-409c-b148-824b10a1c91c");
                }
                if (arg6 == roleGrade - 1 && random < 16)
                {
                    EventHelper.ToEvent("a08ba0ea-806d-409c-b148-824b10a1c91c");
                }
            }
            int arg7 = 0;
            ArgBox.Get("kunbang", ref arg7);
            if (ArgBox.Get("huandujixugankunbang", ref arg5))
            {
                if (arg7 > 0)
                {
                    EventHelper.ToEvent("44520d31-1b9b-40cd-98b7-60385262d78e");
                }
                else
                {
                    EventHelper.ToEvent("45da0eb8-4dde-408f-9973-190d11956993");
                }
            }
            if (arg7 > 0)
            {
                ArgBox.Set("kunbang", arg7 - 1);
                EventHelper.ToEvent("cb443f3b-e0ba-43c9-83bd-2a5215656ddd");
            }
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
            int arg8 = 0;
            ArgBox.Get("xinshen1", ref arg8);
            int arg9 = 0;
            ArgBox.Get("xinshen2", ref arg9);
            int zishi2 = 0;
            ArgBox.Get("zishi", ref zishi2);
            string arg10 = "";
            ArgBox.Get("chengweitaiwu", ref arg10);
            string arg11 = "";
            ArgBox.Get("chengweiduifang", ref arg11);
            int bili1 = EventHelper.GetRoleCurrentMainAttributes(taiwu, 0);
            int bili2 = EventHelper.GetRoleCurrentMainAttributes(ren, 0);
            int lingmin = EventHelper.GetRoleCurrentMainAttributes(taiwu, 1);
            int lingmin2 = EventHelper.GetRoleCurrentMainAttributes(ren, 1);
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(ren, 2);
            int xiantianxp = -1;
            int num = -1;
            int id = taiwu.GetId();
            xiantianxp = id % 21;
            int num2 = -1;
            int id2 = ren.GetId();
            if (id2 % 5 == 4)
            {
                num2 = id2 % 17;
            }
            int teshutizhi = id % 100;
            int sex1 = 0;
            ArgBox.Get("sex1", ref sex1);
            int sex2 = 0;
            ArgBox.Get("sex2", ref sex2);
            string jieguo = "";
            if (lichang == 0 && arg2 == 0)
            {
                if (arg9 >= 80)
                {
                    if ((double)arg9 < 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        jieguo = "<Character key=ren str=Name/>被玩到失神，两眼翻白，失去了行动能力。";
                    }
                    if ((double)arg9 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        bool arg12 = false;
                        if (!ArgBox.Get("xinshenman", ref arg12))
                        {
                            EventHelper.ToEvent("24a2a2e9-9291-47e0-aba7-d626889eb1a0");
                        }
                        jieguo = "\"啊~~~\"<Character key=ren str=Name/>双颊泛红，带着晶莹唾液的舌尖从口中伸出，双眼向上翻起，彻底失去了行动能力。";
                    }
                }
                else if (xingfen1 < 50)
                {
                    int random2 = EventHelper.GetRandom(1, 7);
                    if (random2 == 1)
                    {
                        xingdong("摸");
                    }
                    if (random2 == 2)
                    {
                        xingdong("舔");
                    }
                    if (random2 == 3)
                    {
                        xingdong("亲");
                    }
                    if (random2 == 4)
                    {
                        xingdong("口交");
                    }
                    if (random2 == 5)
                    {
                        xingdong("足交");
                    }
                    if (random2 == 6)
                    {
                        xingdong("乳交");
                    }
                }
                else if ((zishi2 > 10 && zishi2 <= 40) || zishi2 == 0)
                {
                    if (kuaigan3 < kuaigan1)
                    {
                        if (tili2 < 20)
                        {
                            xingdong("休息");
                        }
                        else
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                            ArgBox.Set("zishi", 0);
                            int random3 = EventHelper.GetRandom(1, 5);
                            if (random3 == 1)
                            {
                                xingdong("摸");
                            }
                            if (random3 == 2)
                            {
                                xingdong("舔");
                            }
                            if (random3 == 3)
                            {
                                xingdong("亲");
                            }
                            if (random3 == 4)
                            {
                                xingdong("休息");
                            }
                        }
                    }
                    else if (tili2 < 10)
                    {
                        xingdong("休息");
                    }
                    else if (tili2 - tili1 >= 15 && arg9 < 60)
                    {
                        jixu(zishi2);
                    }
                    else
                    {
                        int random4 = EventHelper.GetRandom(1, 7);
                        if (random4 == 1)
                        {
                            xingdong("69");
                        }
                        if (random4 == 2)
                        {
                            xingdong("对坐");
                        }
                        if (random4 == 3)
                        {
                            xingdong("口交");
                        }
                        if (random4 == 4)
                        {
                            xingdong("足交");
                        }
                        if (random4 == 5)
                        {
                            xingdong("乳交");
                        }
                        if (random4 == 6)
                        {
                            xingdong("休息");
                        }
                    }
                }
                else if (xingfen2 < 50)
                {
                    xingdong("自摸");
                }
                else if (tili2 < 10)
                {
                    xingdong("休息");
                }
                else if (tili2 < tili1)
                {
                    if (kuaigan3 >= kuaigan1)
                    {
                        int random5 = EventHelper.GetRandom(1, 5);
                        if (random5 == 1)
                        {
                            xingdong("口交");
                        }
                        if (random5 == 2)
                        {
                            xingdong("足交");
                        }
                        if (random5 == 3)
                        {
                            xingdong("乳交");
                        }
                        if (random5 == 4)
                        {
                            xingdong("休息");
                        }
                    }
                    else
                    {
                        int random6 = EventHelper.GetRandom(1, 4);
                        if (random6 == 1)
                        {
                            xingdong("摸");
                        }
                        if (random6 == 2)
                        {
                            xingdong("舔");
                        }
                        if (random6 == 3)
                        {
                            xingdong("亲");
                        }
                    }
                }
                else if (tili2 - tili1 >= 15 && arg9 < 60)
                {
                    int random7 = EventHelper.GetRandom(1, 3);
                    if (num2 >= 6 && num2 <= 13 && random7 == 1)
                    {
                        if (random7 == 6)
                        {
                            xingdong("骑乘");
                        }
                        if (random7 == 7)
                        {
                            xingdong("打桩");
                        }
                        if (random7 == 8)
                        {
                            xingdong("火车");
                        }
                        if (random7 == 9)
                        {
                            xingdong("推车");
                        }
                        if (random7 == 10)
                        {
                            xingdong("侧交");
                        }
                        if (random7 == 11)
                        {
                            xingdong("传教");
                        }
                        if (random7 == 12)
                        {
                            xingdong("69");
                        }
                        if (random7 == 13)
                        {
                            xingdong("对坐");
                        }
                    }
                    else
                    {
                        if (sex2 == 0 && sex1 != 0)
                        {
                            int random8 = EventHelper.GetRandom(1, 3);
                            if (random8 == 1)
                            {
                                xingdong("骑乘");
                            }
                            if (random8 == 2)
                            {
                                xingdong("打桩");
                            }
                        }
                        if (sex2 == 0 && sex1 == 0)
                        {
                            int random9 = EventHelper.GetRandom(1, 6);
                            if (random9 == 1)
                            {
                                xingdong("贴贴");
                            }
                            if (random9 == 2)
                            {
                                xingdong("骑乘");
                            }
                            if (random9 == 3)
                            {
                                xingdong("打桩");
                            }
                            if (random9 == 4)
                            {
                                xingdong("火车");
                            }
                            if (random9 == 5)
                            {
                                xingdong("传教");
                            }
                        }
                        if (sex2 != 0)
                        {
                            if (sex1 != 1)
                            {
                                ArgBox.Set("qianhou", 1);
                            }
                            if (sex1 == 1)
                            {
                                ArgBox.Set("qianhou", 2);
                            }
                            int random10 = EventHelper.GetRandom(1, 5);
                            if (random10 == 1)
                            {
                                xingdong("火车");
                            }
                            if (random10 == 2)
                            {
                                xingdong("推车");
                            }
                            if (random10 == 3)
                            {
                                xingdong("侧交");
                            }
                            if (random10 == 4)
                            {
                                xingdong("传教");
                            }
                        }
                    }
                }
                else
                {
                    int random11 = EventHelper.GetRandom(1, 4);
                    if (random11 == 1)
                    {
                        xingdong("69");
                    }
                    if (random11 == 2)
                    {
                        xingdong("对坐");
                    }
                    if (random11 == 3)
                    {
                        xingdong("休息");
                    }
                }
            }
            if ((lichang == 1 || lichang == 2) && arg2 == 0)
            {
                if (arg9 >= 80)
                {
                    if ((double)arg9 < 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        jieguo = "<Character key=ren str=Name/>被玩到失神，两眼翻白，失去了行动能力。";
                    }
                    if ((double)arg9 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        bool arg13 = false;
                        if (!ArgBox.Get("xinshenman", ref arg13))
                        {
                            EventHelper.ToEvent("24a2a2e9-9291-47e0-aba7-d626889eb1a0");
                        }
                        jieguo = "\"啊~~~\"<Character key=ren str=Name/>双颊泛红，带着晶莹唾液的舌尖从口中伸出，双眼向上翻起，彻底失去了行动能力。";
                    }
                }
                else if ((zishi2 > 10 && zishi2 <= 40) || zishi2 == 0)
                {
                    if (xingfen1 < 50)
                    {
                        if (tili2 < 3)
                        {
                            EventHelper.ToEvent("d2a009a4-4b4e-4083-89eb-319f726fbdcf");
                        }
                        if (tili2 >= 3 && tili2 < 10)
                        {
                            xingdong("休息");
                        }
                        if (tili2 >= 10)
                        {
                            int random12 = EventHelper.GetRandom(1, 7);
                            if (random12 == 1)
                            {
                                xingdong("摸");
                            }
                            if (random12 == 2)
                            {
                                xingdong("舔");
                            }
                            if (random12 == 3)
                            {
                                xingdong("亲");
                            }
                            if (random12 == 4)
                            {
                                xingdong("口交");
                            }
                            if (random12 == 5)
                            {
                                xingdong("足交");
                            }
                            if (random12 == 6)
                            {
                                xingdong("乳交");
                            }
                        }
                    }
                    else
                    {
                        if (tili2 < 10)
                        {
                            int random13 = EventHelper.GetRandom(1, 5);
                            if (random13 == 1)
                            {
                                xingdong("摸");
                            }
                            if (random13 == 2)
                            {
                                xingdong("舔");
                            }
                            if (random13 == 3)
                            {
                                xingdong("亲");
                            }
                            if (random13 == 4)
                            {
                                xingdong("休息");
                            }
                        }
                        if (tili2 >= 10 && tili2 < 30)
                        {
                            if (zishi2 == 21 || zishi2 == 22)
                            {
                                jixu(zishi2);
                            }
                            else
                            {
                                int random14 = EventHelper.GetRandom(1, 3);
                                if (random14 == 1)
                                {
                                    xingdong("69");
                                }
                                if (random14 == 2)
                                {
                                    xingdong("对坐");
                                }
                            }
                        }
                        if (tili2 >= 30)
                        {
                            if (arg9 < 60)
                            {
                                int random15 = EventHelper.GetRandom(1, 3);
                                if (num2 >= 6 && num2 <= 13 && random15 == 1)
                                {
                                    if (random15 == 6)
                                    {
                                        xingdong("骑乘");
                                    }
                                    if (random15 == 7)
                                    {
                                        xingdong("打桩");
                                    }
                                    if (random15 == 8)
                                    {
                                        xingdong("火车");
                                    }
                                    if (random15 == 9)
                                    {
                                        xingdong("推车");
                                    }
                                    if (random15 == 10)
                                    {
                                        xingdong("侧交");
                                    }
                                    if (random15 == 11)
                                    {
                                        xingdong("传教");
                                    }
                                    if (random15 == 12)
                                    {
                                        xingdong("69");
                                    }
                                    if (random15 == 13)
                                    {
                                        xingdong("对坐");
                                    }
                                }
                                else
                                {
                                    if (sex2 == 0 && sex1 != 0)
                                    {
                                        int random16 = EventHelper.GetRandom(1, 3);
                                        if (random16 == 1)
                                        {
                                            xingdong("骑乘");
                                        }
                                        if (random16 == 2)
                                        {
                                            xingdong("打桩");
                                        }
                                    }
                                    if (sex2 == 0 && sex1 == 0)
                                    {
                                        int random17 = EventHelper.GetRandom(1, 6);
                                        if (random17 == 1)
                                        {
                                            xingdong("贴贴");
                                        }
                                        if (random17 == 2)
                                        {
                                            xingdong("骑乘");
                                        }
                                        if (random17 == 3)
                                        {
                                            xingdong("打桩");
                                        }
                                        if (random17 == 4)
                                        {
                                            xingdong("火车");
                                        }
                                        if (random17 == 5)
                                        {
                                            xingdong("传教");
                                        }
                                    }
                                    if (sex2 != 0)
                                    {
                                        if (sex1 != 1)
                                        {
                                            ArgBox.Set("qianhou", 1);
                                        }
                                        if (sex1 == 1)
                                        {
                                            ArgBox.Set("qianhou", 2);
                                        }
                                        int random18 = EventHelper.GetRandom(1, 5);
                                        if (random18 == 1)
                                        {
                                            xingdong("火车");
                                        }
                                        if (random18 == 2)
                                        {
                                            xingdong("推车");
                                        }
                                        if (random18 == 3)
                                        {
                                            xingdong("侧交");
                                        }
                                        if (random18 == 4)
                                        {
                                            xingdong("传教");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                int random19 = EventHelper.GetRandom(1, 4);
                                if (random19 == 1)
                                {
                                    xingdong("69");
                                }
                                if (random19 == 2)
                                {
                                    xingdong("对坐");
                                }
                                if (random19 == 3)
                                {
                                    xingdong("休息");
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (tili2 < 3)
                    {
                        EventHelper.ToEvent("d2a009a4-4b4e-4083-89eb-319f726fbdcf");
                    }
                    if (tili2 >= 3 && tili2 < 10)
                    {
                        xingdong("休息");
                    }
                    if (tili2 >= 10)
                    {
                        int random20 = EventHelper.GetRandom(1, 5);
                        if (random20 == 1)
                        {
                            xingdong("摸");
                        }
                        if (random20 == 2)
                        {
                            xingdong("舔");
                        }
                        if (random20 == 3)
                        {
                            xingdong("亲");
                        }
                        if (random20 == 4)
                        {
                            xingdong("休息");
                        }
                    }
                }
            }
            if (lichang == 4 && arg2 == 0)
            {
                if (arg9 >= 80)
                {
                    if ((double)arg9 < 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        jieguo = "<Character key=ren str=Name/>被玩到失神，两眼翻白，失去了行动能力。";
                    }
                    if ((double)arg9 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        bool arg14 = false;
                        if (!ArgBox.Get("xinshenman", ref arg14))
                        {
                            EventHelper.ToEvent("24a2a2e9-9291-47e0-aba7-d626889eb1a0");
                        }
                        jieguo = "\"啊~~~\"<Character key=ren str=Name/>双颊泛红，带着晶莹唾液的舌尖从口中伸出，双眼向上翻起，彻底失去了行动能力。";
                    }
                }
                else if ((zishi2 > 10 && zishi2 <= 40) || zishi2 == 0)
                {
                    if (xingfen2 < 50)
                    {
                        int random21 = EventHelper.GetRandom(1, 4);
                        if (random21 == 1)
                        {
                            xingdong("摸");
                        }
                        if (random21 == 2)
                        {
                            xingdong("舔");
                        }
                        if (random21 == 3)
                        {
                            xingdong("亲");
                        }
                    }
                    else if (tili2 < 10)
                    {
                        xingdong("休息");
                    }
                    else if (arg9 < 60)
                    {
                        int random22 = EventHelper.GetRandom(1, 3);
                        if (num2 >= 6 && num2 <= 13 && random22 == 1)
                        {
                            if (random22 == 6)
                            {
                                xingdong("骑乘");
                            }
                            if (random22 == 7)
                            {
                                xingdong("打桩");
                            }
                            if (random22 == 8)
                            {
                                xingdong("火车");
                            }
                            if (random22 == 9)
                            {
                                xingdong("推车");
                            }
                            if (random22 == 10)
                            {
                                xingdong("侧交");
                            }
                            if (random22 == 11)
                            {
                                xingdong("传教");
                            }
                            if (random22 == 12)
                            {
                                xingdong("69");
                            }
                            if (random22 == 13)
                            {
                                xingdong("对坐");
                            }
                        }
                        else
                        {
                            if (sex2 == 0 && sex1 != 0)
                            {
                                int random23 = EventHelper.GetRandom(1, 3);
                                if (random23 == 1)
                                {
                                    xingdong("骑乘");
                                }
                                if (random23 == 2)
                                {
                                    xingdong("打桩");
                                }
                            }
                            if (sex2 == 0 && sex1 == 0)
                            {
                                int random24 = EventHelper.GetRandom(1, 6);
                                if (random24 == 1)
                                {
                                    xingdong("贴贴");
                                }
                                if (random24 == 2)
                                {
                                    xingdong("骑乘");
                                }
                                if (random24 == 3)
                                {
                                    xingdong("打桩");
                                }
                                if (random24 == 4)
                                {
                                    xingdong("火车");
                                }
                                if (random24 == 5)
                                {
                                    xingdong("传教");
                                }
                            }
                            if (sex2 != 0)
                            {
                                if (sex1 != 1)
                                {
                                    ArgBox.Set("qianhou", 1);
                                }
                                if (sex1 == 1)
                                {
                                    ArgBox.Set("qianhou", 2);
                                }
                                int random25 = EventHelper.GetRandom(1, 5);
                                if (random25 == 1)
                                {
                                    xingdong("火车");
                                }
                                if (random25 == 2)
                                {
                                    xingdong("推车");
                                }
                                if (random25 == 3)
                                {
                                    xingdong("侧交");
                                }
                                if (random25 == 4)
                                {
                                    xingdong("传教");
                                }
                            }
                        }
                    }
                    else
                    {
                        int random26 = EventHelper.GetRandom(1, 3);
                        if (random26 == 1)
                        {
                            xingdong("69");
                        }
                        if (random26 == 2)
                        {
                            xingdong("对坐");
                        }
                    }
                }
                else if (tili2 < 10)
                {
                    xingdong("休息");
                }
                else if (tili2 < tili1)
                {
                    int random27 = EventHelper.GetRandom(1, 4);
                    if (random27 == 1)
                    {
                        xingdong("摸");
                    }
                    if (random27 == 2)
                    {
                        xingdong("舔");
                    }
                    if (random27 == 3)
                    {
                        xingdong("亲");
                    }
                }
                else if (arg9 < 60)
                {
                    int random28 = EventHelper.GetRandom(1, 3);
                    if (num2 >= 6 && num2 <= 13 && random28 == 1)
                    {
                        if (random28 == 6)
                        {
                            xingdong("骑乘");
                        }
                        if (random28 == 7)
                        {
                            xingdong("打桩");
                        }
                        if (random28 == 8)
                        {
                            xingdong("火车");
                        }
                        if (random28 == 9)
                        {
                            xingdong("推车");
                        }
                        if (random28 == 10)
                        {
                            xingdong("侧交");
                        }
                        if (random28 == 11)
                        {
                            xingdong("传教");
                        }
                        if (random28 == 12)
                        {
                            xingdong("69");
                        }
                        if (random28 == 13)
                        {
                            xingdong("对坐");
                        }
                    }
                    else
                    {
                        if (sex2 == 0 && sex1 != 0)
                        {
                            int random29 = EventHelper.GetRandom(1, 3);
                            if (random29 == 1)
                            {
                                xingdong("骑乘");
                            }
                            if (random29 == 2)
                            {
                                xingdong("打桩");
                            }
                        }
                        if (sex2 == 0 && sex1 == 0)
                        {
                            int random30 = EventHelper.GetRandom(1, 6);
                            if (random30 == 1)
                            {
                                xingdong("贴贴");
                            }
                            if (random30 == 2)
                            {
                                xingdong("骑乘");
                            }
                            if (random30 == 3)
                            {
                                xingdong("打桩");
                            }
                            if (random30 == 4)
                            {
                                xingdong("火车");
                            }
                            if (random30 == 5)
                            {
                                xingdong("传教");
                            }
                        }
                        if (sex2 != 0)
                        {
                            if (sex1 != 1)
                            {
                                ArgBox.Set("qianhou", 1);
                            }
                            if (sex1 == 1)
                            {
                                ArgBox.Set("qianhou", 2);
                            }
                            int random31 = EventHelper.GetRandom(1, 5);
                            if (random31 == 1)
                            {
                                xingdong("火车");
                            }
                            if (random31 == 2)
                            {
                                xingdong("推车");
                            }
                            if (random31 == 3)
                            {
                                xingdong("侧交");
                            }
                            if (random31 == 4)
                            {
                                xingdong("传教");
                            }
                        }
                    }
                }
                else
                {
                    int random32 = EventHelper.GetRandom(1, 4);
                    if (random32 == 1)
                    {
                        xingdong("摸");
                    }
                    if (random32 == 2)
                    {
                        xingdong("舔");
                    }
                    if (random32 == 3)
                    {
                        xingdong("亲");
                    }
                }
            }
            if (lichang == 3 || arg2 != 0)
            {
                if (arg9 >= 60)
                {
                    if (arg9 < 80)
                    {
                        if (tili2 < 10)
                        {
                            EventHelper.ToEvent("d2a009a4-4b4e-4083-89eb-319f726fbdcf");
                        }
                        int random33 = EventHelper.GetRandom(1, 10);
                        if (random33 == 1)
                        {
                            xingdong("摸");
                        }
                        if (random33 == 2)
                        {
                            xingdong("舔");
                        }
                        if (random33 == 3)
                        {
                            xingdong("亲");
                        }
                        if (random33 == 4)
                        {
                            xingdong("69");
                        }
                        if (random33 == 5)
                        {
                            xingdong("对坐");
                        }
                        if (random33 == 6)
                        {
                            xingdong("口交");
                        }
                        if (random33 == 7)
                        {
                            xingdong("足交");
                        }
                        if (random33 == 8)
                        {
                            xingdong("乳交");
                        }
                        if (random33 == 9)
                        {
                            xingdong("休息");
                        }
                    }
                    if (arg9 >= 80 && (double)arg9 < 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        jieguo = "<Character key=ren str=Name/>被玩到失神，两眼翻白，失去了行动能力。";
                    }
                    if ((double)arg9 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
                    {
                        bool arg15 = false;
                        if (!ArgBox.Get("xinshenman", ref arg15))
                        {
                            EventHelper.ToEvent("24a2a2e9-9291-47e0-aba7-d626889eb1a0");
                        }
                        jieguo = "\"啊~~~\"<Character key=ren str=Name/>双颊泛红，带着晶莹唾液的舌尖从口中伸出，双眼向上翻起，彻底失去了行动能力。";
                    }
                }
                if (arg9 < 60)
                {
                    if (zishi2 > 10 && zishi2 <= 40 && zishi2 != 0)
                    {
                        if (tili2 < 10)
                        {
                            EventHelper.ToEvent("d2a009a4-4b4e-4083-89eb-319f726fbdcf");
                        }
                        if (tili2 >= 10 && tili2 < 30)
                        {
                            if (kuaigan3 >= 160)
                            {
                                if (zishi2 == 30 || zishi2 == 31 || zishi2 == 32)
                                {
                                    jixu(zishi2);
                                }
                                else
                                {
                                    int random34 = EventHelper.GetRandom(1, 4);
                                    if (random34 == 1)
                                    {
                                        xingdong("口交");
                                    }
                                    if (random34 == 2)
                                    {
                                        xingdong("乳交");
                                    }
                                    if (random34 == 3)
                                    {
                                        xingdong("足交");
                                    }
                                }
                            }
                            if (kuaigan3 < 160 && kuaigan3 < kuaigan1)
                            {
                                int random35 = EventHelper.GetRandom(1, 4);
                                if (random35 == 1)
                                {
                                    jixu(zishi2);
                                }
                                else
                                {
                                    int random36 = EventHelper.GetRandom(1, 3);
                                    if (random36 == 1)
                                    {
                                        xingdong("69");
                                    }
                                    if (random36 == 2)
                                    {
                                        xingdong("对坐");
                                    }
                                }
                            }
                            if (kuaigan3 < 160 && kuaigan3 >= kuaigan1)
                            {
                                int random37 = EventHelper.GetRandom(1, 8);
                                if (random37 == 1)
                                {
                                    xingdong("亲");
                                }
                                if (random37 == 2)
                                {
                                    xingdong("摸");
                                }
                                if (random37 == 3)
                                {
                                    xingdong("舔");
                                }
                                if (random37 == 4)
                                {
                                    if (sex2 != 1 && sex1 != 0)
                                    {
                                        xingdong("乳交");
                                    }
                                    if (sex2 != 1 && sex1 != 1)
                                    {
                                        xingdong("贴贴");
                                    }
                                    if (sex2 == 1)
                                    {
                                        xingdong("口交");
                                    }
                                }
                                if (random37 == 5)
                                {
                                    if (zishi2 == 31)
                                    {
                                        jixu(31);
                                    }
                                    else
                                    {
                                        if (sex1 == 0)
                                        {
                                            jieguo = "<Character key=ren str=Name/>用脚掌揉搓<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"";
                                        }
                                        if (sex1 != 0)
                                        {
                                            jieguo = "<Character key=ren str=Name/>用脚掌夹住<Character key=RoleTaiwu str=Name/>的肉棒上下撸动。";
                                            EventBackground = "zujiao1";
                                            EventHelper.SetEventSeriesTexture("zujiao1");
                                        }
                                        ArgBox.Set("xingfen1", xingfen1 + 10);
                                        ArgBox.Set("xingfen2", xingfen2 + 5);
                                        ArgBox.Set("zishi", 31);
                                    }
                                }
                                if (random37 == 6)
                                {
                                    int random38 = EventHelper.GetRandom(1, 3);
                                    if (random38 == 1)
                                    {
                                        if (zishi2 == 21)
                                        {
                                            jixu(21);
                                        }
                                        else
                                        {
                                            if (sex1 == 0)
                                            {
                                                jieguo = "<Character key=ren str=Name/>转过身，吮吸<Character key=RoleTaiwu str=Name/>的阴蒂。";
                                                if (sex2 != 1)
                                                {
                                                    jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的蜜穴";
                                                }
                                                if (sex2 == 1)
                                                {
                                                    jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的肉棒";
                                                }
                                                EventBackground = "";
                                                EventHelper.SetEventSeriesTexture("");
                                                ArgBox.Set("xingfen1", xingfen1 + 5);
                                                ArgBox.Set("xingfen2", xingfen2 + 5);
                                                ArgBox.Set("zishi", 21);
                                            }
                                            if (sex1 != 0)
                                            {
                                                jieguo = "<Character key=ren str=Name/>转过身，吮吸<Character key=RoleTaiwu str=Name/>的肉棒。";
                                                if (sex2 != 1)
                                                {
                                                    jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的蜜穴";
                                                }
                                                if (sex2 == 1)
                                                {
                                                    jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的肉棒";
                                                }
                                                EventBackground = "";
                                                EventHelper.SetEventSeriesTexture("");
                                                ArgBox.Set("xingfen1", xingfen1 + 5);
                                                ArgBox.Set("xingfen2", xingfen2 + 5);
                                                ArgBox.Set("zishi", 21);
                                            }
                                        }
                                    }
                                    if (random38 == 2)
                                    {
                                        if (zishi2 == 22)
                                        {
                                            jixu(22);
                                        }
                                        else
                                        {
                                            if (sex2 != 1 && sex1 != 0)
                                            {
                                                ArgBox.Set("qianhou", 1);
                                            }
                                            if (sex2 == 1 && sex1 != 0)
                                            {
                                                ArgBox.Set("qianhou", 2);
                                            }
                                            if (sex2 == 0 && sex1 == 0)
                                            {
                                                ArgBox.Set("qianhou", 1);
                                            }
                                            if (sex2 == 1 && sex1 == 0)
                                            {
                                                ArgBox.Set("qianhou", 1);
                                            }
                                            jieguo = "<Character key=ren str=Name/>与<Character key=RoleTaiwu str=Name/>对坐着，互相抽动着下体配合对方。";
                                            ArgBox.Set("zishi", 22);
                                        }
                                    }
                                }
                                if (random37 == 7)
                                {
                                    xingdong("休息");
                                }
                            }
                        }
                        if (tili2 >= 30)
                        {
                            if (xingfen1 >= 50)
                            {
                                if (zishi2 == 30 || zishi2 == 31 || zishi2 == 32)
                                {
                                    jixu(zishi2);
                                }
                                else
                                {
                                    int random39 = EventHelper.GetRandom(1, 4);
                                    if (random39 == 1)
                                    {
                                        xingdong("口交");
                                    }
                                    if (random39 == 2)
                                    {
                                        xingdong("乳交");
                                    }
                                    if (random39 == 3)
                                    {
                                        xingdong("足交");
                                    }
                                }
                            }
                            if (xingfen1 < 50 && kuaigan3 < kuaigan1)
                            {
                                jixu(zishi2);
                            }
                            if (xingfen1 < 50 && kuaigan3 >= kuaigan1)
                            {
                                int random40 = EventHelper.GetRandom(1, 4);
                                if (random40 == 1)
                                {
                                    jixu(zishi2);
                                }
                                else
                                {
                                    int random41 = EventHelper.GetRandom(1, 3);
                                    if (random41 == 1)
                                    {
                                        xingdong("69");
                                    }
                                    if (random41 == 2)
                                    {
                                        xingdong("对坐");
                                    }
                                }
                            }
                        }
                    }
                    else if (xingfen1 < 50)
                    {
                        int num3 = 0;
                        num3 = EventHelper.GetRandom(1, 4);
                        if (num3 == 1)
                        {
                            xingdong("摸");
                        }
                        if (num3 == 2)
                        {
                            xingdong("舔");
                        }
                        if (num3 == 3)
                        {
                            xingdong("亲");
                        }
                    }
                    else if (kuaigan3 < 160)
                    {
                        if (tili2 >= 40 && kuaigan3 <= kuaigan1)
                        {
                            int random42 = EventHelper.GetRandom(1, 3);
                            if (random42 == 1)
                            {
                                xingdong("舔");
                            }
                            if (random42 == 2)
                            {
                                xingdong("亲");
                            }
                        }
                        if (tili2 >= 40 && kuaigan3 > kuaigan1)
                        {
                            if (sex2 == 0 && sex1 != 0)
                            {
                                int random43 = EventHelper.GetRandom(1, 3);
                                if (random43 == 1)
                                {
                                    xingdong("骑乘");
                                }
                                if (random43 == 2)
                                {
                                    xingdong("打桩");
                                }
                            }
                            if (sex2 == 0 && sex1 == 0)
                            {
                                int random44 = EventHelper.GetRandom(1, 6);
                                if (random44 == 1)
                                {
                                    xingdong("贴贴");
                                }
                                if (random44 == 2)
                                {
                                    xingdong("骑乘");
                                }
                                if (random44 == 3)
                                {
                                    xingdong("打桩");
                                }
                                if (random44 == 4)
                                {
                                    xingdong("火车");
                                }
                                if (random44 == 5)
                                {
                                    xingdong("传教");
                                }
                            }
                            if (sex2 != 0)
                            {
                                if (sex1 != 1)
                                {
                                    ArgBox.Set("qianhou", 1);
                                }
                                if (sex1 == 1)
                                {
                                    ArgBox.Set("qianhou", 2);
                                }
                                int random45 = EventHelper.GetRandom(1, 5);
                                if (random45 == 1)
                                {
                                    xingdong("火车");
                                }
                                if (random45 == 2)
                                {
                                    xingdong("推车");
                                }
                                if (random45 == 3)
                                {
                                    xingdong("侧交");
                                }
                                if (random45 == 4)
                                {
                                    xingdong("传教");
                                }
                            }
                        }
                        if (tili2 < 40)
                        {
                            int random46 = EventHelper.GetRandom(1, 5);
                            if (random46 == 1)
                            {
                                xingdong("舔");
                            }
                            if (random46 == 2)
                            {
                                xingdong("亲");
                            }
                            if (random46 == 3)
                            {
                                jieguo = "<Character key=ren str=Name/>不停的呻吟，\"啊~~~<ArgBox key=chengweiduifang type=string/>~~~快~快~~我不行了~~~\"";
                                ArgBox.Set("xingfen1", xingfen1 + 10);
                                ArgBox.Set("xingfen2", xingfen2 + 8);
                            }
                            if (random46 == 4)
                            {
                                xingdong("休息");
                            }
                        }
                    }
                    else
                    {
                        if (tili2 >= 20 && kuaigan3 <= kuaigan1)
                        {
                            if (sex2 == 0 && sex1 != 0)
                            {
                                int random47 = EventHelper.GetRandom(1, 3);
                                if (random47 == 1)
                                {
                                    xingdong("骑乘");
                                }
                                if (random47 == 2)
                                {
                                    xingdong("打桩");
                                }
                            }
                            if (sex2 == 0 && sex1 == 0)
                            {
                                int random48 = EventHelper.GetRandom(1, 6);
                                if (random48 == 1)
                                {
                                    xingdong("贴贴");
                                }
                                if (random48 == 2)
                                {
                                    xingdong("骑乘");
                                }
                                if (random48 == 3)
                                {
                                    xingdong("打桩");
                                }
                                if (random48 == 4)
                                {
                                    xingdong("火车");
                                }
                                if (random48 == 5)
                                {
                                    xingdong("传教");
                                }
                            }
                            if (sex2 != 0)
                            {
                                if (sex1 != 1)
                                {
                                    ArgBox.Set("qianhou", 1);
                                }
                                if (sex1 == 1)
                                {
                                    ArgBox.Set("qianhou", 2);
                                }
                                int random49 = EventHelper.GetRandom(1, 5);
                                if (random49 == 1)
                                {
                                    xingdong("火车");
                                }
                                if (random49 == 2)
                                {
                                    xingdong("推车");
                                }
                                if (random49 == 3)
                                {
                                    xingdong("侧交");
                                }
                                if (random49 == 4)
                                {
                                    xingdong("传教");
                                }
                            }
                        }
                        if (tili2 >= 20 && kuaigan3 > kuaigan1)
                        {
                            int random50 = EventHelper.GetRandom(1, 4);
                            if (random50 == 1)
                            {
                                xingdong("口交");
                            }
                            if (random50 == 2)
                            {
                                xingdong("足交");
                            }
                            if (random50 == 3)
                            {
                                xingdong("乳交");
                            }
                        }
                        if (tili2 < 20)
                        {
                            int random51 = EventHelper.GetRandom(1, 4);
                            if (random51 == 1)
                            {
                                xingdong("舔");
                            }
                            if (random51 == 2)
                            {
                                xingdong("亲");
                            }
                            if (random51 == 3)
                            {
                                xingdong("休息");
                            }
                        }
                    }
                }
            }
            if (ren.GetCreatingType() == 1)
            {
                EventHelper.ChangeRoleHappiness(ren, 1);
                if (EventHelper.GetFavorability(ren, taiwu) < 30000)
                {
                    EventHelper.ChangeFavorability(ren, taiwu, 10, -1, 0);
                }
                EventHelper.ChangeRoleExp(taiwu, 20);
            }
            ArgBox.Set("duifang", jieguo);
            int Addkuaigan1(int jichu)
            {
                double num4 = (double)kuaigan1 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin2 * 0.0025);
                if (taiwu.HasVirginity())
                {
                    num4 *= 2.0;
                }
                if (ren.GetConsummateLevel() > taiwu.GetConsummateLevel())
                {
                    num4 *= 1.0 + (double)(ren.GetConsummateLevel() - taiwu.GetConsummateLevel()) * 0.2;
                }
                return (int)num4;
            }
            int Addkuaigan2(int jichu)
            {
                if (jichu < 6 && teshutizhi == 0)
                {
                    jichu = 10;
                }
                double num6 = (double)kuaigan3 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
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
                double num5 = (double)kuaigan4 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
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
            void jixu(int zishi)
            {
                if (zishi == 11)
                {
                    jieguo = "<Character key=ren str=Name/>继续骑在<Character key=RoleTaiwu str=Name/>身上扭动着腰肢。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    EventBackground = "qicheng";
                    EventHelper.SetEventSeriesTexture("qicheng");
                }
                if (zishi == 12)
                {
                    jieguo = "<Character key=ren str=Name/>将<Character key=RoleTaiwu str=Name/>压在身下，高抬起<Character key=RoleTaiwu str=Name/>的双腿，使出打桩机体位。";
                    if (sex1 == 0 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n两人的小穴相互摩擦。";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 2);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地套弄<Character key=RoleTaiwu str=Name/>的下体。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                }
                if (zishi == 13)
                {
                    if (sex1 == 0 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>抱着，狠狠的摩擦<Character key=RoleTaiwu str=Name/>的阴蒂。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 != 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>抱着，狠狠的抽插<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>抱着，狠狠的抽插<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>抱着，狠狠的套弄<Character key=RoleTaiwu str=Name/>的肉棒。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    EventBackground = "huochebiandang1";
                    EventHelper.SetEventSeriesTexture("huochebiandang1");
                }
                if (zishi == 14)
                {
                    if (sex1 == 0 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>骑在身下，从背后抠弄着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>骑在身下，从背后抽插着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>骑在身下，从背后抽插着<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续把<Character key=RoleTaiwu str=Name/>骑在身下，从背后撸动着<Character key=RoleTaiwu str=Name/>的肉棒。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    EventBackground = "houru";
                    EventHelper.SetEventSeriesTexture("houru");
                }
                if (zishi == 15)
                {
                    if (sex1 == 0 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续躺在<Character key=RoleTaiwu str=Name/>背后，抠弄着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续躺在<Character key=RoleTaiwu str=Name/>背后，抽插着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续躺在<Character key=RoleTaiwu str=Name/>背后，抽插着<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续躺在<Character key=RoleTaiwu str=Name/>背后，撸动着<Character key=RoleTaiwu str=Name/>的肉棒。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    EventBackground = "ceru";
                    EventHelper.SetEventSeriesTexture("ceru");
                }
                if (zishi == 16)
                {
                    jieguo = "<Character key=ren str=Name/>趴在<Character key=RoleTaiwu str=Name/>身上，使出传教士体位。";
                    if (sex1 == 0 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n两人的小穴相互摩擦。";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 2);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地套弄<Character key=RoleTaiwu str=Name/>的下体。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                }
                if (zishi == 21)
                {
                    if (sex1 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续吮吸着<Character key=RoleTaiwu str=Name/>的阴蒂。";
                        if (sex2 != 1)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的蜜穴";
                        }
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的肉棒";
                        }
                    }
                    if (sex1 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>继续吮吸着<Character key=RoleTaiwu str=Name/>的肉棒。";
                        if (sex2 != 1)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的蜜穴";
                        }
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的肉棒";
                        }
                    }
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                }
                if (zishi == 22)
                {
                    jieguo = "<Character key=ren str=Name/>继续与<Character key=RoleTaiwu str=Name/>对坐着，互相抽动着下体配合对方。";
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                }
                if (zishi == 30)
                {
                    if (sex1 != 1)
                    {
                        jieguo = "<Character key=ren str=Name/>继续吮吸着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"<Character key=RoleTaiwu str=Name/>的双腿紧紧的夹住<Character key=ren str=Name/>的头。";
                        EventBackground = "";
                        EventHelper.SetEventSeriesTexture("");
                    }
                    if (sex1 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>继续舔舐着<Character key=RoleTaiwu str=Name/>的肉棒。\n<Character key=ren str=Name/>灵巧的舌头不断挑逗着<Character key=RoleTaiwu str=Name/>的肉棒，让<Character key=RoleTaiwu str=Name/>不禁发出一声舒爽的长叹。";
                        EventBackground = "koujiao";
                        EventHelper.SetEventSeriesTexture("koujiao");
                    }
                }
                if (zishi == 31)
                {
                    if (sex1 != 1)
                    {
                        jieguo = "<Character key=ren str=Name/>继续用脚掌揉搓<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"";
                        EventBackground = "";
                        EventHelper.SetEventSeriesTexture("");
                    }
                    if (sex1 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>继续用脚掌夹住<Character key=RoleTaiwu str=Name/>的肉棒上下撸动。";
                        EventBackground = "zujiao1";
                        EventHelper.SetEventSeriesTexture("zujiao1");
                    }
                }
                if (zishi == 32)
                {
                    if (sex1 != 1)
                    {
                        jieguo = "<Character key=ren str=Name/>继续用双乳与<Character key=RoleTaiwu str=Name/>的双乳相互摩擦。";
                        EventBackground = "";
                        EventHelper.SetEventSeriesTexture("");
                    }
                    if (sex1 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>继续用双乳夹着<Character key=RoleTaiwu str=Name/>的肉棒上下撸动。";
                        EventBackground = "rujiao";
                        EventHelper.SetEventSeriesTexture("rujiao");
                    }
                }
                if (zishi == 33)
                {
                    jieguo = "<Character key=ren str=Name/>继续用双乳与<Character key=RoleTaiwu str=Name/>的双乳相互摩擦。";
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                }
            }
            void xingdong(string caozuo)
            {
                if (caozuo == "自摸")
                {
                    if (sex2 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>用力撸动着自己的肉棒。\"嗯~~<ArgBox key=chengweiduifang type=string/>~~~快来干我~~~\"";
                    }
                    else
                    {
                        jieguo = "<Character key=ren str=Name/>用力揉搓着自己的小穴。\"嗯~~<ArgBox key=chengweiduifang type=string/>~~~快来干我~~~\"";
                    }
                    if (sex2 != 2)
                    {
                        ArgBox.Set("kuaigan2", Addkuaigan2(5));
                    }
                    else
                    {
                        ArgBox.Set("kuaigan22", Addkuaigan22(5));
                    }
                }
                if (caozuo == "休息")
                {
                    ArgBox.Set("tili2", tili2 + 10);
                    jieguo = "<Character key=ren str=Name/>擦了擦脸上的汗，\"我们继续！\"";
                }
                if (caozuo == "摸")
                {
                    if (sex1 == 2)
                    {
                        sex1 = EventHelper.GetRandom(0, 2);
                    }
                    if (sex1 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>轻柔的揉搓<Character key=RoleTaiwu str=Name/>的小穴。\"嗯~~<ArgBox key=chengweitaiwu type=string/>~继续~~~\"<Character key=RoleTaiwu str=Name/>流出的晶莹液体沾湿了<Character key=ren str=Name/>的手。";
                    }
                    if (sex1 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>轻柔的撸动<Character key=RoleTaiwu str=Name/>的肉棒。<Character key=RoleTaiwu str=Name/>感受着<Character key=ren str=Name/>柔软细腻的小手，粗大的肉棒变得越发的坚挺。";
                    }
                    if (lichang != 3)
                    {
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手撸动着自己的肉棒。";
                        }
                        else
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手揉搓着自己的小穴。";
                        }
                        if (sex2 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"<ArgBox key=chengweiduifang type=string/>~~这样可以吗，有感觉舒服吗~~~\"";
                    }
                    ArgBox.Set("xingfen1", xingfen1 + 10);
                    ArgBox.Set("xingfen2", xingfen2 + 5);
                    ArgBox.Set("kuaigan1", Addkuaigan1(8));
                    if (xiantianxp == 18)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (caozuo == "舔")
                {
                    int random52 = EventHelper.GetRandom(1, 3);
                    if (random52 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>轻轻的舔舐<Character key=RoleTaiwu str=Name/>的乳头。\"嗯~~<ArgBox key=chengweitaiwu type=string/>~继续舔~~~\"";
                    }
                    if (random52 == 2)
                    {
                        jieguo = "<Character key=ren str=Name/>轻轻的吮吸<Character key=RoleTaiwu str=Name/>的乳头。\"嗯~~<ArgBox key=chengweitaiwu type=string/>~继续吸~~~\"";
                    }
                    if (lichang != 3)
                    {
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手撸动着自己的肉棒。";
                        }
                        else
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手揉搓着自己的小穴。";
                        }
                        if (sex2 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"<ArgBox key=chengweiduifang type=string/>~~这样可以吗，有感觉舒服吗~~~\"";
                    }
                    ArgBox.Set("xingfen1", xingfen1 + 10);
                    ArgBox.Set("xingfen2", xingfen2 + 5);
                    if (xiantianxp == 19)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (caozuo == "亲")
                {
                    jieguo = "<Character key=ren str=Name/>抱住<Character key=RoleTaiwu str=Name/>深情的舌吻";
                    if (lichang != 3)
                    {
                        if (sex2 == 1)
                        {
                            jieguo += "同时一只手撸动着自己的肉棒。";
                        }
                        else
                        {
                            jieguo += "同时一只手揉搓着自己的小穴。";
                        }
                        if (sex2 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                    }
                    ArgBox.Set("xingfen1", xingfen1 + 10);
                    ArgBox.Set("xingfen2", xingfen2 + 10);
                    if (xiantianxp == 20)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (caozuo == "骑乘")
                {
                    if (sex2 != 1 && sex1 != 0)
                    {
                        ArgBox.Set("qianhou", 1);
                    }
                    if (sex2 == 1 && sex1 != 0)
                    {
                        ArgBox.Set("qianhou", 2);
                    }
                    if (sex2 == 0 && sex1 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                    }
                    if (sex2 == 1 && sex1 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                    }
                    jieguo = "<Character key=ren str=Name/>将<Character key=RoleTaiwu str=Name/>骑在身下，扭动着腰肢。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"<ArgBox key=chengweiduifang type=string/>~~这样可以吗，我感觉舒服吗~~~\"";
                    }
                    EventBackground = "qicheng";
                    EventHelper.SetEventSeriesTexture("qicheng");
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 11);
                }
                if (caozuo == "打桩")
                {
                    jieguo = "<Character key=ren str=Name/>将<Character key=RoleTaiwu str=Name/>压在身下，高抬起<Character key=RoleTaiwu str=Name/>的双腿，使出打桩机体位。";
                    if (sex1 == 0 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n两人的小穴相互摩擦。";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 2);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地套弄<Character key=RoleTaiwu str=Name/>的下体。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"啊~~~<ArgBox key=chengweiduifang type=string/>~~这样好舒服~~~\"";
                    }
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    if (bili2 >= bili1)
                    {
                        if (tili2 >= 10)
                        {
                            ArgBox.Set("tili2", tili2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    else if (tili2 >= 20)
                    {
                        ArgBox.Set("tili2", tili2 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili2", 0);
                    }
                    ArgBox.Set("zishi", 12);
                }
                if (caozuo == "火车")
                {
                    if (sex1 == 0 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>抱起站立，狠狠的摩擦<Character key=RoleTaiwu str=Name/>的阴蒂。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 != 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>抱起站立，狠狠的抽插<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>抱起站立，狠狠的抽插<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>抱起站立，狠狠的套弄<Character key=RoleTaiwu str=Name/>的肉棒。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"啊~~~<ArgBox key=chengweiduifang type=string/>~~这样好舒服~~~\"";
                    }
                    EventBackground = "huochebiandang1";
                    EventHelper.SetEventSeriesTexture("huochebiandang1");
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 13);
                }
                if (caozuo == "推车")
                {
                    if (sex1 == 0 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>骑在身下，从背后抠弄着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>骑在身下，从背后抽插着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>骑在身下，从背后抽插着<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>把<Character key=RoleTaiwu str=Name/>骑在身下，从背后撸动着<Character key=RoleTaiwu str=Name/>的肉棒。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"啊~~~<ArgBox key=chengweiduifang type=string/>~~这样好舒服~~~\"";
                    }
                    EventBackground = "houru";
                    EventHelper.SetEventSeriesTexture("houru");
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 14);
                }
                if (caozuo == "侧交")
                {
                    if (sex1 == 0 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>躺在<Character key=RoleTaiwu str=Name/>背后，抠弄着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>躺在<Character key=RoleTaiwu str=Name/>背后，抽插着<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        jieguo = "<Character key=ren str=Name/>躺在<Character key=RoleTaiwu str=Name/>背后，抽插着<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>躺在<Character key=RoleTaiwu str=Name/>背后，撸动着<Character key=RoleTaiwu str=Name/>的肉棒。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"啊~~~<ArgBox key=chengweiduifang type=string/>~~这样好舒服~~~\"";
                    }
                    EventBackground = "ceru";
                    EventHelper.SetEventSeriesTexture("ceru");
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 15);
                }
                if (caozuo == "传教")
                {
                    jieguo = "<Character key=ren str=Name/>趴在<Character key=RoleTaiwu str=Name/>身上，使出传教士体位。";
                    if (sex1 == 0 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n两人的小穴相互摩擦。";
                    }
                    if (sex1 == 0 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的小穴。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 != 0)
                    {
                        ArgBox.Set("qianhou", 2);
                        jieguo += "\n狠狠地抽插<Character key=RoleTaiwu str=Name/>的菊花。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (sex1 == 1 && sex2 == 0)
                    {
                        ArgBox.Set("qianhou", 1);
                        jieguo += "\n狠狠地套弄<Character key=RoleTaiwu str=Name/>的下体。\n\"啊~~<ArgBox key=chengweitaiwu type=string/>~好舒服~继续干我~~~\"";
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"啊~~~<ArgBox key=chengweiduifang type=string/>~~这样好舒服~~~\"";
                    }
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 16);
                }
                if (caozuo == "69")
                {
                    if (sex1 == 2)
                    {
                        sex1 = EventHelper.GetRandom(0, 2);
                    }
                    if (sex1 == 0)
                    {
                        jieguo = "<Character key=ren str=Name/>转过身，吮吸<Character key=RoleTaiwu str=Name/>的阴蒂。";
                        if (sex2 == 0)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的蜜穴";
                        }
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的肉棒";
                        }
                        EventBackground = "";
                        EventHelper.SetEventSeriesTexture("");
                        ArgBox.Set("xingfen1", xingfen1 + 5);
                        ArgBox.Set("xingfen2", xingfen2 + 5);
                        if (zishi2 <= 10 && zishi2 > 0)
                        {
                            if (bili2 >= bili1)
                            {
                                if (tili2 >= 10)
                                {
                                    ArgBox.Set("tili2", tili2 - 10);
                                }
                                else
                                {
                                    ArgBox.Set("tili2", 0);
                                }
                            }
                            else if (tili2 >= 20)
                            {
                                ArgBox.Set("tili2", tili2 - 20);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        ArgBox.Set("zishi", 21);
                    }
                    if (sex1 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>转过身，吮吸<Character key=RoleTaiwu str=Name/>的肉棒。";
                        if (sex2 == 0)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的蜜穴";
                        }
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=RoleTaiwu str=Name/>也同时品尝着<Character key=ren str=Name/>的肉棒";
                        }
                        EventBackground = "";
                        EventHelper.SetEventSeriesTexture("");
                        ArgBox.Set("xingfen1", xingfen1 + 5);
                        ArgBox.Set("xingfen2", xingfen2 + 5);
                        if (zishi2 <= 10 && zishi2 > 0)
                        {
                            if (bili2 >= bili1)
                            {
                                if (tili2 >= 10)
                                {
                                    ArgBox.Set("tili2", tili2 - 10);
                                }
                                else
                                {
                                    ArgBox.Set("tili2", 0);
                                }
                            }
                            else if (tili2 >= 20)
                            {
                                ArgBox.Set("tili2", tili2 - 20);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        ArgBox.Set("zishi", 21);
                    }
                }
                if (caozuo == "对坐")
                {
                    jieguo = "<Character key=ren str=Name/>与<Character key=RoleTaiwu str=Name/>对坐着，互相抽动着下体配合对方。";
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"啊~~~<ArgBox key=chengweiduifang type=string/>~~这样好舒服~~~\"";
                    }
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 22);
                }
                if (caozuo == "口交")
                {
                    if (sex1 == 2)
                    {
                        sex1 = EventHelper.GetRandom(0, 2);
                    }
                    if (sex1 == 0)
                    {
                        int random53 = EventHelper.GetRandom(1, 3);
                        if (random53 == 1)
                        {
                            jieguo = "<Character key=ren str=Name/>轻轻的舔舐<Character key=RoleTaiwu str=Name/>的小穴。\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"<Character key=RoleTaiwu str=Name/>的双腿紧紧的夹住<Character key=ren str=Name/>的头。";
                        }
                        if (random53 == 2)
                        {
                            jieguo = "<Character key=ren str=Name/>轻轻的吮吸<Character key=RoleTaiwu str=Name/>的小穴。\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"<Character key=RoleTaiwu str=Name/>的双腿紧紧的夹住<Character key=ren str=Name/>的头。";
                        }
                    }
                    if (sex1 == 1)
                    {
                        int random54 = EventHelper.GetRandom(1, 3);
                        if (random54 == 1)
                        {
                            jieguo = "<Character key=ren str=Name/>轻轻的舔舐<Character key=RoleTaiwu str=Name/>的肉棒。<Character key=ren str=Name/>灵巧的舌头不断挑逗着<Character key=RoleTaiwu str=Name/>的肉棒，让<Character key=RoleTaiwu str=Name/>不禁发出一声舒爽的长叹。";
                        }
                        if (random54 == 2)
                        {
                            jieguo = "<Character key=ren str=Name/>轻轻的吮吸<Character key=RoleTaiwu str=Name/>的肉棒。<Character key=RoleTaiwu str=Name/>感受到一阵酥麻，双手按住了<Character key=ren str=Name/>的头。";
                        }
                        EventBackground = "koujiao";
                        EventHelper.SetEventSeriesTexture("koujiao");
                    }
                    if (lichang != 3)
                    {
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手撸动着自己的肉棒。";
                        }
                        else
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手揉搓着自己的小穴。";
                        }
                        if (sex2 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"<ArgBox key=chengweiduifang type=string/>~~这样可以吗，有感觉舒服吗~~~\"";
                    }
                    ArgBox.Set("xingfen1", xingfen1 + 15);
                    ArgBox.Set("xingfen2", xingfen2 + 10);
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    if (zishi2 != 21)
                    {
                        ArgBox.Set("zishi", 30);
                    }
                }
                if (caozuo == "足交")
                {
                    if (sex1 != 1)
                    {
                        jieguo = "<Character key=ren str=Name/>用脚掌揉搓<Character key=RoleTaiwu str=Name/>的小穴。\"啊~~<ArgBox key=chengweitaiwu type=string/>~嗯~继续~~~\"";
                        EventBackground = "";
                        EventHelper.SetEventSeriesTexture("");
                    }
                    if (sex1 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>用脚掌夹住<Character key=RoleTaiwu str=Name/>的肉棒上下撸动。";
                        EventBackground = "zujiao1";
                        EventHelper.SetEventSeriesTexture("zujiao1");
                    }
                    if (lichang != 3)
                    {
                        if (sex2 == 1)
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手撸动着自己的肉棒。";
                        }
                        else
                        {
                            jieguo += "<Character key=ren str=Name/>同时一只手揉搓着自己的小穴。";
                        }
                        if (sex2 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"<ArgBox key=chengweiduifang type=string/>~~这样可以吗，有感觉舒服吗~~~\"";
                    }
                    ArgBox.Set("xingfen1", xingfen1 + 10);
                    ArgBox.Set("xingfen2", xingfen2 + 5);
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 31);
                }
                if (caozuo == "乳交")
                {
                    if (sex1 != 1)
                    {
                        jieguo = "<Character key=ren str=Name/>用双乳与<Character key=RoleTaiwu str=Name/>的双乳相互摩擦。";
                        EventBackground = "";
                        EventHelper.SetEventSeriesTexture("");
                    }
                    if (sex1 == 1)
                    {
                        jieguo = "<Character key=ren str=Name/>用双乳夹着<Character key=RoleTaiwu str=Name/>的肉棒上下撸动。";
                        EventBackground = "rujiao";
                        EventHelper.SetEventSeriesTexture("rujiao");
                    }
                    if (ren.HasVirginity())
                    {
                        jieguo += "\n\"<ArgBox key=chengweiduifang type=string/>~~这样可以吗，有感觉舒服吗~~~\"";
                    }
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 33);
                }
                if (caozuo == "贴贴")
                {
                    jieguo = "<Character key=ren str=Name/>用双乳与<Character key=RoleTaiwu str=Name/>的双乳相互摩擦。";
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    if (zishi2 <= 10 && zishi2 > 0)
                    {
                        if (bili2 >= bili1)
                        {
                            if (tili2 >= 10)
                            {
                                ArgBox.Set("tili2", tili2 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili2", 0);
                            }
                        }
                        else if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                    }
                    ArgBox.Set("zishi", 33);
                }
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            string arg = "";
            ArgBox.Get("duifang", ref arg);
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
            int num = xingfen2;
            int kuaigan3 = 0;
            ArgBox.Get("kuaigan2", ref kuaigan3);
            int kuaigan4 = 0;
            ArgBox.Get("kuaigan22", ref kuaigan4);
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            int arg2 = 0;
            ArgBox.Get("xinshen2", ref arg2);
            ArgBox.Set("xingfen1", xingfen1 + 5);
            ArgBox.Set("xingfen2", xingfen2 + 5);
            int arg3 = 0;
            ArgBox.Get("zishi", ref arg3);
            int tili1 = 0;
            ArgBox.Get("tili1", ref tili1);
            int tili2 = 0;
            ArgBox.Get("tili2", ref tili2);
            int arg4 = 0;
            ArgBox.Get("sex1", ref arg4);
            int arg5 = 0;
            ArgBox.Get("sex2", ref arg5);
            int lingmin = EventHelper.GetRoleCurrentMainAttributes(taiwu, 1);
            int lingmin2 = EventHelper.GetRoleCurrentMainAttributes(ren, 1);
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(taiwu, 2);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(taiwu, 3);
            int roleCurrentMainAttributes3 = EventHelper.GetRoleCurrentMainAttributes(ren, 3);
            int arg6 = 0;
            ArgBox.Get("qianhou", ref arg6);
            int num2 = -1;
            int num3 = -1;
            int id = ren.GetId();
            if (id % 5 == 4)
            {
                num2 = id % 17;
            }
            int arg7 = 0;
            ArgBox.Get("mode", ref arg7);
            if (arg7 != 0)
            {
                int arg8 = 0;
                ArgBox.Get("juedouxp", ref arg8);
                if (arg8 % 5 == 4)
                {
                    num2 = arg8 % 17;
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
            string val2 = "1";
            bool flag = false;
            if (TaiwuEvent.GetModData("JuhuaXP", isArchive: true, ref val2) && arg7 == 0 && arg6 == 2)
            {
                string[] array3 = val.Split(',');
                if (array3.Length > 1)
                {
                    for (int k = 1; k < array3.Length; k++)
                    {
                        int num5 = int.Parse(array3[k]);
                        if (num5 == ren.GetId())
                        {
                            flag = true;
                        }
                    }
                }
            }
            int num6 = -1;
            int num7 = -1;
            int id2 = taiwu.GetId();
            num6 = id2 % 23;
            if (arg3 != 0)
            {
                if (arg3 == 1)
                {
                    if (kuaigan3 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(1));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(1));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (tili1 >= 15)
                        {
                            ArgBox.Set("tili1", tili1 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(3));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        ArgBox.Set("xinshen2", arg2 + 1);
                        if (num2 == 0 || list.Contains(0))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 0)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (tili1 >= 10)
                        {
                            ArgBox.Set("tili1", tili1 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        ArgBox.Set("xinshen2", arg2 + 3);
                        if (num2 == 0 || list.Contains(0))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 0)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 2)
                {
                    if (kuaigan3 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(1));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(1));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (tili1 >= 15)
                        {
                            ArgBox.Set("tili1", tili1 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(3));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        ArgBox.Set("xinshen2", arg2 + 1);
                        if (num2 == 1 || list.Contains(1))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 1)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (tili1 >= 10)
                        {
                            ArgBox.Set("tili1", tili1 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        ArgBox.Set("xinshen2", arg2 + 3);
                        if (num2 == 1 || list.Contains(1))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 1)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 3)
                {
                    if (kuaigan3 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (tili1 >= 20)
                        {
                            ArgBox.Set("tili1", tili1 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen2", arg2 + 2);
                        if (num2 == 2 || list.Contains(2))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 2)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                        }
                        if (tili1 >= 15)
                        {
                            ArgBox.Set("tili1", tili1 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(15));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                        }
                        ArgBox.Set("xinshen2", arg2 + 4);
                        if (num2 == 2 || list.Contains(2))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 2)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 4)
                {
                    if (kuaigan3 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (tili1 >= 15)
                        {
                            ArgBox.Set("tili1", tili1 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen2", arg2 + 1);
                        if (num2 == 3 || list.Contains(3))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 3)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (tili1 >= 10)
                        {
                            ArgBox.Set("tili1", tili1 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        ArgBox.Set("xinshen2", arg2 + 3);
                        if (num2 == 3 || list.Contains(3))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 3)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 5)
                {
                    if (kuaigan3 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (tili1 >= 18)
                        {
                            ArgBox.Set("tili1", tili1 - 18);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen2", arg2 + 2);
                        if (num2 == 4 || list.Contains(4))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 4)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(6));
                            ArgBox.Set("kuaigan2", Addkuaigan2(13));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(6));
                            ArgBox.Set("kuaigan2", Addkuaigan2(4));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(6));
                            ArgBox.Set("kuaigan2", Addkuaigan2(13));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(6));
                            ArgBox.Set("kuaigan2", Addkuaigan2(13));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(6));
                            ArgBox.Set("kuaigan2", Addkuaigan2(13));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(4));
                            ArgBox.Set("kuaigan2", Addkuaigan2(13));
                        }
                        if (tili1 >= 13)
                        {
                            ArgBox.Set("tili1", tili1 - 13);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(6));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(13));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(13));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(6));
                            ArgBox.Set("kuaigan2", Addkuaigan2(13));
                        }
                        ArgBox.Set("xinshen2", arg2 + 4);
                        if (num2 == 4 || list.Contains(4))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 4)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 6)
                {
                    if (kuaigan3 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (tili1 >= 15)
                        {
                            ArgBox.Set("tili1", tili1 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(2));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(2));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        ArgBox.Set("xinshen2", arg2 + 1);
                        if (num2 == 5 || list.Contains(5))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 5)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (tili1 >= 10)
                        {
                            ArgBox.Set("tili1", tili1 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen2", arg2 + 3);
                        if (num2 == 5 || list.Contains(5))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 5)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 11)
                {
                    if (kuaigan1 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(1));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(1));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (tili2 >= 15)
                        {
                            ArgBox.Set("tili2", tili2 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(2));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(2));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        ArgBox.Set("xinshen1", arg + 1);
                        if (num2 == 6 || list.Contains(6))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 6)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (tili2 >= 10)
                        {
                            ArgBox.Set("tili2", tili2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen1", arg + 3);
                        if (num2 == 6 || list.Contains(6))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 6)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 12)
                {
                    if (kuaigan1 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (tili2 >= 18)
                        {
                            ArgBox.Set("tili2", tili2 - 18);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        ArgBox.Set("xinshen1", arg + 2);
                        if (num2 == 7 || list.Contains(7))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 7)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(8));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (tili2 >= 13)
                        {
                            ArgBox.Set("tili2", tili2 - 13);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(15));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        ArgBox.Set("xinshen1", arg + 4);
                        if (num2 == 7 || list.Contains(7))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 7)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 13)
                {
                    if (kuaigan1 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (tili2 >= 20)
                        {
                            ArgBox.Set("tili2", tili2 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        ArgBox.Set("xinshen1", arg + 2);
                        if (num2 == 8 || list.Contains(8))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 8)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                        }
                        if (tili2 >= 15)
                        {
                            ArgBox.Set("tili2", tili2 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(15));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(15));
                            ArgBox.Set("kuaigan2", Addkuaigan2(8));
                        }
                        ArgBox.Set("xinshen1", arg + 4);
                        if (num2 == 8 || list.Contains(8))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 8)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 14)
                {
                    if (kuaigan1 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(1));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(1));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (tili2 >= 15)
                        {
                            ArgBox.Set("tili2", tili2 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(3));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        ArgBox.Set("xinshen1", arg + 1);
                        if (num2 == 9 || list.Contains(9))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 9)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (tili2 >= 10)
                        {
                            ArgBox.Set("tili2", tili2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(10));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen1", arg + 3);
                        if (num2 == 9 || list.Contains(9))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 9)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 15)
                {
                    if (kuaigan1 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (tili2 >= 15)
                        {
                            ArgBox.Set("tili2", tili2 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        ArgBox.Set("xinshen1", arg + 1);
                        if (num2 == 10 || list.Contains(10))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 10)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (tili2 >= 10)
                        {
                            ArgBox.Set("tili2", tili2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(10));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen1", arg + 3);
                        if (num2 == 10 || list.Contains(10))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 10)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 16)
                {
                    if (kuaigan1 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(1));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(1));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        if (tili2 >= 15)
                        {
                            ArgBox.Set("tili2", tili2 - 15);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(3));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(2));
                        }
                        ArgBox.Set("xinshen1", arg + 1);
                        if (num2 == 11 || list.Contains(11))
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num6 == 11)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 5);
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                        }
                    }
                    else
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (tili2 >= 10)
                        {
                            ArgBox.Set("tili2", tili2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili2", 0);
                        }
                        if (arg4 == 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan12", Addkuaigan12(10));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            }
                        }
                        if (arg4 != 2 && arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        ArgBox.Set("xinshen1", arg + 3);
                        if (num2 == 11 || list.Contains(11))
                        {
                            ArgBox.Set("xingfen2", num + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        if (num6 == 11)
                        {
                            ArgBox.Set("xingfen1", xingfen1 + 10);
                            ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        }
                    }
                }
                if (arg3 == 21)
                {
                    ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    if (arg5 != 2)
                    {
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (arg5 == 2 && (arg6 == 1 || flag))
                    {
                        ArgBox.Set("kuaigan22", Addkuaigan22(10));
                    }
                    if (arg5 == 2 && arg6 != 1)
                    {
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    ArgBox.Set("xinshen1", arg + 2);
                    ArgBox.Set("xinshen2", arg2 + 2);
                    if (num2 == 12 || list.Contains(12))
                    {
                        ArgBox.Set("xingfen2", num + 10);
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (num6 == 12)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (arg3 == 22)
                {
                    ArgBox.Set("xinshen1", arg + 3);
                    ArgBox.Set("xinshen2", arg2 + 3);
                    if (kuaigan1 < 50 || kuaigan3 < 50)
                    {
                        if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                        }
                        if (arg4 == 1 && arg5 == 1)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 0)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(3));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (arg5 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            if (arg6 == 1 || flag)
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(5));
                            }
                            if (arg6 == 2 && !flag)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        if (arg5 != 2 && arg4 == 2)
                        {
                            ArgBox.Set("kuaigan1", Addkuaigan1(5));
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        if (num2 == 13)
                        {
                            ArgBox.Set("xingfen2", num + 5);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg4 == 1 && arg5 == 0 && (arg6 == 1 || flag))
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (arg4 == 1 && arg5 == 0 && arg6 == 2 && !flag)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        ArgBox.Set("kuaigan2", Addkuaigan2(6));
                    }
                    if (arg4 == 1 && arg5 == 1)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (arg4 == 0 && arg5 == 0)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (arg4 == 0 && arg5 == 1 && (arg6 == 1 || flag))
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (arg4 == 0 && arg5 == 1 && arg6 == 2 && !flag)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(6));
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (arg5 == 2)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        if (arg6 == 1 || flag)
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(10));
                        }
                        if (arg6 == 2 && !flag)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                    }
                    if (arg5 != 2 && arg4 == 2)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (num2 == 13 || list.Contains(13))
                    {
                        ArgBox.Set("xingfen2", num + 10);
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                    }
                    if (num6 == 13)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (arg3 == 30)
                {
                    if (xingfen1 < 50)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                    else
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(15));
                    }
                    ArgBox.Set("xinshen1", arg + 2);
                    if (num6 == 14)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (arg3 == 31)
                {
                    if (xingfen1 < 50)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(5));
                    }
                    else
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                    if (tili2 >= 5)
                    {
                        ArgBox.Set("tili2", tili2 - 5);
                    }
                    ArgBox.Set("xinshen1", arg + 2);
                    if (num6 == 15)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (arg3 == 32)
                {
                    if (xingfen1 < 50)
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(8));
                    }
                    else
                    {
                        ArgBox.Set("kuaigan1", Addkuaigan1(13));
                    }
                    if (tili2 >= 5)
                    {
                        ArgBox.Set("tili2", tili2 - 5);
                    }
                    ArgBox.Set("xinshen1", arg + 2);
                    if (num6 == 16)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                        ArgBox.Set("kuaigan1", Addkuaigan1(10));
                    }
                }
                if (arg3 == 33)
                {
                    ArgBox.Set("xingfen1", xingfen1 + 10);
                    ArgBox.Set("xingfen2", xingfen2 + 10);
                    ArgBox.Set("xinshen1", arg + 2);
                    ArgBox.Set("xinshen2", arg2 + 2);
                    if (num2 == 14 || list.Contains(14))
                    {
                        ArgBox.Set("xingfen2", xingfen2 + 10);
                    }
                    if (num6 == 17)
                    {
                        ArgBox.Set("xingfen1", xingfen1 + 10);
                    }
                }
            }
            if ((double)arg >= 100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025))
            {
                return "dc8d400b-b094-483b-b2e8-f4f1848f52df";
            }
            if (arg4 != 2 && arg5 != 2)
            {
                if ((double)kuaigan1 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) && (double)kuaigan3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)kuaigan1 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)kuaigan3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
            }
            if (arg4 == 2 && arg5 != 2)
            {
                if (((double)kuaigan1 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) || (double)kuaigan2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025)) && (double)kuaigan3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)kuaigan1 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)kuaigan2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)kuaigan3 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
            }
            if (arg4 != 2 && arg5 == 2)
            {
                if (((double)kuaigan3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025) || (double)kuaigan4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025)) && (double)kuaigan1 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)kuaigan3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)kuaigan4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)kuaigan1 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
            }
            if (arg4 == 2 && arg5 == 2)
            {
                if (((double)kuaigan1 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) || (double)kuaigan2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025)) && ((double)kuaigan3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025) || (double)kuaigan4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025)))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)kuaigan3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)kuaigan4 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)kuaigan1 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)kuaigan2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
            }
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
            int Addkuaigan1(int jichu)
            {
                double num11 = (double)kuaigan1 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin2 * 0.0025);
                if (taiwu.HasVirginity())
                {
                    num11 *= 2.0;
                }
                if (ren.GetConsummateLevel() > taiwu.GetConsummateLevel())
                {
                    num11 *= 1.0 + (double)(ren.GetConsummateLevel() - taiwu.GetConsummateLevel()) * 0.2;
                }
                return (int)num11;
            }
            int Addkuaigan12(int jichu)
            {
                double num8 = (double)kuaigan2 + (double)(jichu + xingfen1 / 10) * (1.0 + (double)(101 - tili1) * 0.0025 + (double)lingmin2 * 0.0025);
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
                double num10 = (double)kuaigan3 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
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
            int Addkuaigan22(int jichu)
            {
                if (jichu < 6 && teshutizhi == 0)
                {
                    jichu = 10;
                }
                double num9 = (double)kuaigan4 + (double)(jichu + xingfen2 / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
                if (ren.HasVirginity() && ren.GetCreatingType() == 1)
                {
                    num9 *= 2.0;
                }
                if (teshutizhi == 1)
                {
                    num9 *= 2.0;
                }
                if (taiwu.GetConsummateLevel() > ren.GetConsummateLevel())
                {
                    num9 *= 1.0 + (double)(taiwu.GetConsummateLevel() - ren.GetConsummateLevel()) * 0.2;
                }
                return (int)num9;
            }
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}