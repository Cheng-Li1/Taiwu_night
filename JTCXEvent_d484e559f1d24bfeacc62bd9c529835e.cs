using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_d484e559f1d24bfeacc62bd9c529835e : TaiwuEventItem
    {
        public JTCXEvent_d484e559f1d24bfeacc62bd9c529835e()
        {
            Guid = Guid.Parse("d484e559-f1d2-4bfe-acc6-2bd9c529835e");
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
                OptionKey = "Option_-829012068"
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
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            Character taiwu = ArgBox.GetCharacter("RoleTaiwu");
            Character ren = ArgBox.GetCharacter("ren");
            string text = "";
            int arg = 0;
            ArgBox.Get("koubuwei", ref arg);
            int arg2 = 0;
            ArgBox.Get("koucaozuo", ref arg2);
            int arg3 = 0;
            ArgBox.Get("koulidu", ref arg3);
            int xingfen = 0;
            ArgBox.Get("xingfen2", ref xingfen);
            int kuaigan = 0;
            ArgBox.Get("kuaigan2", ref kuaigan);
            int kuaigan2 = 0;
            ArgBox.Get("kuaigan22", ref kuaigan2);
            int tili2 = 0;
            ArgBox.Get("tili2", ref tili2);
            int arg4 = 0;
            ArgBox.Get("tili1", ref arg4);
            int arg5 = 0;
            ArgBox.Get("sex1", ref arg5);
            int arg6 = 0;
            ArgBox.Get("sex2", ref arg6);
            int arg7 = 0;
            ArgBox.Get("xinshen2", ref arg7);
            int arg8 = 0;
            ArgBox.Get("huiheshu", ref arg8);
            ArgBox.Set("kouhuiheshu", arg8);
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(taiwu, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(ren, 0);
            int lingmin = EventHelper.GetRoleCurrentMainAttributes(taiwu, 1);
            int num = -1;
            int num2 = -1;
            int id = ren.GetId();
            if (id % 5 == 1)
            {
                num = id % 22;
            }
            int arg9 = 0;
            ArgBox.Get("mode", ref arg9);
            if (arg9 == 1)
            {
                int arg10 = 0;
                ArgBox.Get("juedouxp", ref arg10);
                if (arg10 % 5 == 1)
                {
                    num = arg10 % 22;
                }
            }
            int teshutizhi = id % 100;
            string val = "1";
            List<int> list = new List<int>();
            if (TaiwuEvent.GetModData("KouXP", isArchive: true, ref val) && arg9 == 0)
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
            bool flag = false;
            if (ren.GetGender() != 1)
            {
                HashSet<int> relatedCharacters = EventHelper.GetRelatedCharacters(ren.GetId(), 2, aliveOnly: true);
                if (relatedCharacters != null && relatedCharacters.Count > 0)
                {
                    foreach (int item in relatedCharacters)
                    {
                        Character characterById = EventHelper.GetCharacterById(item);
                        if (characterById.GetAgeGroup() == 0 && EventHelper.GetBloodParentId(item, 0) == ren.GetId())
                        {
                            flag = true;
                        }
                    }
                }
            }
            if (arg == 0)
            {
                if (arg3 == 1)
                {
                    ArgBox.Set("xingfen2", xingfen + 5);
                    text = "<Character key=RoleTaiwu str=Name/>轻轻的亲吻<Character key=ren str=Name/>";
                    if (num == 0 || list.Contains(0))
                    {
                        ArgBox.Set("xingfen2", xingfen + 10);
                    }
                }
                if (arg3 == 2)
                {
                    ArgBox.Set("xingfen2", xingfen + 10);
                    text = "<Character key=RoleTaiwu str=Name/>与<Character key=ren str=Name/>深情舌吻";
                    if (num == 1 || list.Contains(1))
                    {
                        ArgBox.Set("xingfen2", xingfen + 10);
                    }
                }
            }
            if (arg == 1)
            {
                if (arg2 == 1)
                {
                    if (arg3 == 1)
                    {
                        ArgBox.Set("xingfen2", xingfen + 5);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的舔舐<Character key=ren str=Name/>的身体。";
                        if (num == 2 || list.Contains(2))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("xingfen2", xingfen + 3);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", xingfen + 8);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的舔舐<Character key=ren str=Name/>的身体。";
                        if (num == 3 || list.Contains(3))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                }
                if (arg2 == 2)
                {
                    if (arg3 == 1)
                    {
                        ArgBox.Set("xingfen2", xingfen + 5);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的吮吸<Character key=ren str=Name/>的身体。";
                        if (num == 4 || list.Contains(4))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("xingfen2", xingfen + 3);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", xingfen + 8);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的吮吸<Character key=ren str=Name/>的身体。";
                        if (num == 5 || list.Contains(5))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                }
                if (ren.HasVirginity())
                {
                    text += "\n\"嗯~~~<ArgBox key=chengweiduifang type=string/>~~好痒~~~\"";
                }
            }
            if (arg == 2)
            {
                if (arg2 == 1)
                {
                    if (arg3 == 1)
                    {
                        ArgBox.Set("xingfen2", xingfen + 5);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的舔舐<Character key=ren str=Name/>的乳头。";
                        if (num == 6 || list.Contains(6))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("xingfen2", xingfen + 3);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", xingfen + 8);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的舔舐<Character key=ren str=Name/>的乳头。";
                        if (num == 7 || list.Contains(7))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                }
                if (arg2 == 2)
                {
                    if (arg3 == 1)
                    {
                        ArgBox.Set("xingfen2", xingfen + 5);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的吮吸<Character key=ren str=Name/>的乳头。";
                        if (num == 8 || list.Contains(8))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("xingfen2", xingfen + 3);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", xingfen + 8);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的吮吸<Character key=ren str=Name/>的乳头。";
                        if (num == 9 || list.Contains(9))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                    if (flag)
                    {
                        text += "\n<Character key=RoleTaiwu str=Name/>感觉到嘴里一股甘甜，从<Character key=ren str=Name/>的乳头中吸出了奶水。";
                        if (arg4 <= 95)
                        {
                            ArgBox.Set("tili1", arg4 + 5);
                        }
                        ArgBox.Set("xingfen2", xingfen + 20);
                    }
                }
                if (kuaigan < 80)
                {
                    ArgBox.Set("kuaigan2", Addkuaigan2(5));
                }
                if (ren.HasVirginity())
                {
                    text += "\n\"嗯~~~<ArgBox key=chengweiduifang type=string/>~~好痒~~好舒服~~~\"";
                }
            }
            if (arg == 3)
            {
                int arg11 = 0;
                ArgBox.Get("zishi", ref arg11);
                if (arg11 > 10 && arg11 <= 40 && arg11 != 21)
                {
                    int arg12 = 0;
                    ArgBox.Get("tili1", ref arg12);
                    if (arg12 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                    {
                        EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                    }
                    if (arg12 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                    }
                    if ((arg12 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg12 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                    {
                        if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                        {
                            if (arg12 >= 10)
                            {
                                ArgBox.Set("tili1", arg4 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili1", 0);
                            }
                        }
                        else if (arg12 >= 20)
                        {
                            ArgBox.Set("tili1", arg4 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                }
                if (arg11 != 21)
                {
                    ArgBox.Set("zishi", 0);
                    ArgBox.Set("ppzishi", "无");
                }
                if (arg2 == 1)
                {
                    if (arg3 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的舔舐<Character key=ren str=Name/>的小穴。";
                        ArgBox.Set("xingfen2", xingfen + 5);
                        if (arg6 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(10));
                        }
                        if (num == 10 || list.Contains(10))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            if (arg6 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            ArgBox.Set("xingfen2", xingfen + 3);
                            if (num == 11 || list.Contains(11))
                            {
                                ArgBox.Set("xingfen2", xingfen + 10);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        else
                        {
                            if (arg6 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(15));
                            }
                            ArgBox.Set("xingfen2", xingfen + 8);
                            if (num == 11 || list.Contains(11))
                            {
                                ArgBox.Set("xingfen2", xingfen + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的舔舐<Character key=ren str=Name/>的小穴。";
                    }
                }
                if (arg2 == 2)
                {
                    if (arg3 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的吮吸<Character key=ren str=Name/>的小穴。";
                        ArgBox.Set("xingfen2", xingfen + 5);
                        if (arg6 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(10));
                        }
                        if (num == 12 || list.Contains(12))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            if (arg6 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            ArgBox.Set("xingfen2", xingfen + 3);
                            if (num == 13 || list.Contains(13))
                            {
                                ArgBox.Set("xingfen2", xingfen + 10);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        else
                        {
                            if (arg6 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(15));
                            }
                            ArgBox.Set("xingfen2", xingfen + 8);
                            if (num == 13 || list.Contains(13))
                            {
                                ArgBox.Set("xingfen2", xingfen + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的吮吸<Character key=ren str=Name/>的小穴。";
                    }
                }
                if (ren.HasVirginity())
                {
                    text += "\n\"嗯~~~<ArgBox key=chengweiduifang type=string/>~~好舒服~~~那里不会觉得脏吗~~~\"";
                }
            }
            if (arg == 4)
            {
                int arg13 = 0;
                ArgBox.Get("zishi", ref arg13);
                if (arg13 > 10 && arg13 <= 40 && arg13 != 21)
                {
                    int arg14 = 0;
                    ArgBox.Get("tili1", ref arg14);
                    if (arg14 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                    {
                        EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                    }
                    if (arg14 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                    }
                    if ((arg14 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg14 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                    {
                        if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                        {
                            if (arg14 >= 10)
                            {
                                ArgBox.Set("tili1", arg4 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili1", 0);
                            }
                        }
                        else if (arg14 >= 20)
                        {
                            ArgBox.Set("tili1", arg4 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                }
                if (arg13 != 21)
                {
                    ArgBox.Set("zishi", 0);
                    ArgBox.Set("ppzishi", "无");
                }
                if (arg2 == 1)
                {
                    if (arg3 == 1)
                    {
                        ArgBox.Set("xingfen2", xingfen + 5);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的舔舐<Character key=ren str=Name/>的菊花。";
                        if (num == 14 || list.Contains(14))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("xingfen2", xingfen + 3);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", xingfen + 5);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的舔舐<Character key=ren str=Name/>的菊花。";
                        if (num == 15 || list.Contains(15))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                }
                if (arg2 == 2)
                {
                    if (arg3 == 1)
                    {
                        ArgBox.Set("xingfen2", xingfen + 5);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的吮吸<Character key=ren str=Name/>的菊花。";
                        if (num == 16 || list.Contains(16))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("xingfen2", xingfen + 3);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", xingfen + 5);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的吮吸<Character key=ren str=Name/>的菊花。";
                        if (num == 17 || list.Contains(17))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                        }
                    }
                }
                if (ren.HasVirginity())
                {
                    text += "\n\"嗯~~~<ArgBox key=chengweiduifang type=string/>~~好痒~~~那里不会觉得脏吗~~~\"";
                }
            }
            if (arg == 5)
            {
                int arg15 = 0;
                ArgBox.Get("zishi", ref arg15);
                if (arg15 > 10 && arg15 <= 40 && arg15 != 21)
                {
                    int arg16 = 0;
                    ArgBox.Get("tili1", ref arg16);
                    if (arg16 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                    {
                        EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                    }
                    if (arg16 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                    }
                    if ((arg16 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg16 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                    {
                        if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                        {
                            if (arg16 >= 10)
                            {
                                ArgBox.Set("tili1", arg4 - 10);
                            }
                            else
                            {
                                ArgBox.Set("tili1", 0);
                            }
                        }
                        else if (arg16 >= 20)
                        {
                            ArgBox.Set("tili1", arg4 - 20);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                }
                if (arg15 != 21)
                {
                    ArgBox.Set("zishi", 0);
                    ArgBox.Set("ppzishi", "无");
                }
                if (arg2 == 1)
                {
                    if (arg3 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的舔舐<Character key=ren str=Name/>的肉棒。";
                        ArgBox.Set("xingfen2", xingfen + 5);
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        if (num == 18 || list.Contains(18))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            ArgBox.Set("xingfen2", xingfen + 3);
                            if (num == 19 || list.Contains(19))
                            {
                                ArgBox.Set("xingfen2", xingfen + 10);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        else
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            ArgBox.Set("xingfen2", xingfen + 8);
                            if (num == 19 || list.Contains(19))
                            {
                                ArgBox.Set("xingfen2", xingfen + 10);
                                ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的舔舐<Character key=ren str=Name/>的肉棒。";
                    }
                }
                if (arg2 == 2)
                {
                    if (arg3 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的吮吸<Character key=ren str=Name/>的肉棒。";
                        ArgBox.Set("xingfen2", xingfen + 5);
                        ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        if (num == 20 || list.Contains(20))
                        {
                            ArgBox.Set("xingfen2", xingfen + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                        }
                    }
                    if (arg3 == 3)
                    {
                        if (xingfen <= 50)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            ArgBox.Set("xingfen2", xingfen + 3);
                            if (num == 21 || list.Contains(21))
                            {
                                ArgBox.Set("xingfen2", xingfen + 10);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        else
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            ArgBox.Set("xingfen2", xingfen + 8);
                            if (num == 21 || list.Contains(21))
                            {
                                ArgBox.Set("xingfen2", xingfen + 10);
                                ArgBox.Set("kuaigan2", Addkuaigan2(15));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的吮吸<Character key=ren str=Name/>的肉棒。";
                    }
                }
                if (ren.HasVirginity())
                {
                    text += "\n\"嗯~~~<ArgBox key=chengweiduifang type=string/>~~好舒服~~~那里不会觉得脏吗~~~\"";
                }
            }
            bool arg17 = false;
            if (ArgBox.Get("huandujixugankunbang", ref arg17))
            {
                text = "\"啊~~~放开我~~你这个贱人！！！\"";
            }
            bool arg18 = false;
            if (ArgBox.Get("zhandoucx", ref arg18))
            {
                text = "\"哼，你平时练功都练到舌头上了吧，嗯~~~\"";
            }
            string targetString = string.Format(base.EventContent, text);
            return EventHelper.HandleStringTag(targetString, ArgBox, TaiwuEvent);
            int Addkuaigan2(int jichu)
            {
                if (jichu < 6 && teshutizhi == 0)
                {
                    jichu = 10;
                }
                double num5 = (double)kuaigan + (double)(jichu + xingfen / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
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
            int Addkuaigan22(int jichu)
            {
                if (jichu < 6 && teshutizhi == 0)
                {
                    jichu = 10;
                }
                double num4 = (double)kuaigan2 + (double)(jichu + xingfen / 10) * (1.0 + (double)(101 - tili2) * 0.0025 + (double)lingmin * 0.0025);
                if (ren.HasVirginity() && ren.GetCreatingType() == 1)
                {
                    num4 *= 2.0;
                }
                if (teshutizhi == 1)
                {
                    num4 *= 2.0;
                }
                if (taiwu.GetConsummateLevel() > ren.GetConsummateLevel())
                {
                    num4 *= 1.0 + (double)(taiwu.GetConsummateLevel() - ren.GetConsummateLevel()) * 0.2;
                }
                return (int)num4;
            }
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