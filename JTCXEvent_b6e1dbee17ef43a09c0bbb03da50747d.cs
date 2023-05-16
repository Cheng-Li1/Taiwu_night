using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_b6e1dbee17ef43a09c0bbb03da50747d : TaiwuEventItem
    {
        public JTCXEvent_b6e1dbee17ef43a09c0bbb03da50747d()
        {
            Guid = Guid.Parse("b6e1dbee-17ef-43a0-9c0b-bb03da50747d");
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
                OptionKey = "Option_-83335460"
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
            int xingfen2 = 0;
            ArgBox.Get("xingfen2", ref xingfen2);
            int kuaigan2 = 0;
            ArgBox.Get("kuaigan2", ref kuaigan2);
            int kuaigan3 = 0;
            ArgBox.Get("kuaigan22", ref kuaigan3);
            int tili2 = 0;
            ArgBox.Get("tili2", ref tili2);
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("xinshen2", ref arg2);
            int arg3 = 0;
            ArgBox.Get("huiheshu", ref arg3);
            ArgBox.Set("shouhuiheshu", arg3);
            int lingmin = EventHelper.GetRoleCurrentMainAttributes(taiwu, 1);
            int arg4 = 0;
            ArgBox.Get("sex1", ref arg4);
            int arg5 = 0;
            ArgBox.Get("sex2", ref arg5);
            int num = -1;
            int num2 = -1;
            int id = ren.GetId();
            if (id % 5 == 0)
            {
                num = id % 48;
            }
            int arg6 = 0;
            ArgBox.Get("mode", ref arg6);
            if (arg6 == 1)
            {
                int arg7 = 0;
                ArgBox.Get("juedouxp", ref arg7);
                if (arg7 % 5 == 0)
                {
                    num = arg7 % 48;
                }
            }
            int teshutizhi = id % 100;
            string val = "1";
            List<int> list = new List<int>();
            if (TaiwuEvent.GetModData("ShouXP", isArchive: true, ref val) && arg6 == 0)
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
            string text = "";
            int arg8 = 0;
            ArgBox.Get("shoubuwei", ref arg8);
            int arg9 = 0;
            ArgBox.Get("shoucaozuo", ref arg9);
            int arg10 = 0;
            ArgBox.Get("shoulidu", ref arg10);
            int num4 = xingfen2;
            if (arg8 == 1)
            {
                if (arg9 == 1)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的抚摸<Character key=ren str=Name/>的身体。";
                        if (num == 0 || list.Contains(0))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的抚摸<Character key=ren str=Name/>的身体。";
                        if (num == 1 || list.Contains(1))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 2)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的按揉<Character key=ren str=Name/>的身体。";
                        if (num == 2 || list.Contains(2))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的按揉<Character key=ren str=Name/>的身体。";
                        if (num == 3 || list.Contains(3))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 3)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的拍打<Character key=ren str=Name/>的身体。";
                        if (num == 4 || list.Contains(4))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的拍打<Character key=ren str=Name/>的身体。";
                        if (num == 5 || list.Contains(5))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 4)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的搓弄<Character key=ren str=Name/>的身体。";
                        if (num == 6 || list.Contains(6))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的搓弄<Character key=ren str=Name/>的身体。";
                        if (num == 7 || list.Contains(7))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
            }
            if (arg8 == 2)
            {
                if (arg9 == 1)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的抚摸<Character key=ren str=Name/>的胸部。";
                        if (num == 8 || list.Contains(8))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的抚摸<Character key=ren str=Name/>的胸部。";
                        if (num == 9 || list.Contains(9))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 2)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的按揉<Character key=ren str=Name/>的胸部。";
                        if (num == 10 || list.Contains(10))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的按揉<Character key=ren str=Name/>的胸部。";
                        if (num == 11 || list.Contains(11))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 3)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的拍打<Character key=ren str=Name/>的胸部。";
                        if (num == 12 || list.Contains(12))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的拍打<Character key=ren str=Name/>的胸部。";
                        if (num == 13 || list.Contains(13))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 4)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的搓弄<Character key=ren str=Name/>的胸部。";
                        if (num == 14 || list.Contains(14))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的搓弄<Character key=ren str=Name/>的胸部。";
                        if (num == 15 || list.Contains(15))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
            }
            if (arg8 == 3)
            {
                if (arg9 == 1)
                {
                    if (arg10 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的抚摸<Character key=ren str=Name/>的小穴。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        if (arg5 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                        if (num == 16 || list.Contains(16))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(3));
                            }
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 17 || list.Contains(17))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 17 || list.Contains(17))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的抚摸<Character key=ren str=Name/>的小穴。";
                    }
                }
                if (arg9 == 2)
                {
                    if (arg10 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的按揉<Character key=ren str=Name/>的小穴。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        if (arg5 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                        if (num == 18 || list.Contains(18))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(3));
                            }
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 19 || list.Contains(19))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 19 || list.Contains(19))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的按揉<Character key=ren str=Name/>的小穴。";
                    }
                }
                if (arg9 == 3)
                {
                    if (arg10 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的拍打<Character key=ren str=Name/>的小穴。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        if (arg5 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                        if (num == 20 || list.Contains(20))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(3));
                            }
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 21 || list.Contains(21))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 21 || list.Contains(21))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的拍打<Character key=ren str=Name/>的小穴。";
                    }
                }
                if (arg9 == 4)
                {
                    if (arg10 == 1)
                    {
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的搓弄<Character key=ren str=Name/>的小穴。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        if (arg5 != 2)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                        else
                        {
                            ArgBox.Set("kuaigan22", Addkuaigan22(5));
                        }
                        if (num == 22 || list.Contains(22))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(3));
                            }
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 23 || list.Contains(23))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            if (arg5 != 2)
                            {
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                            else
                            {
                                ArgBox.Set("kuaigan22", Addkuaigan22(10));
                            }
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 23 || list.Contains(23))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的搓弄<Character key=ren str=Name/>的小穴。";
                    }
                }
            }
            if (arg8 == 4)
            {
                if (arg9 == 1)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的抚摸<Character key=ren str=Name/>的菊花。";
                        if (num == 24 || list.Contains(24))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的抚摸<Character key=ren str=Name/>的菊花。";
                        if (num == 25 || list.Contains(25))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 2)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的按揉<Character key=ren str=Name/>的菊花。";
                        if (num == 26 || list.Contains(26))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的按揉<Character key=ren str=Name/>的菊花。";
                        if (num == 27 || list.Contains(27))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 3)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的拍打<Character key=ren str=Name/>的菊花。";
                        if (num == 28 || list.Contains(28))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的拍打<Character key=ren str=Name/>的菊花。";
                        if (num == 29 || list.Contains(29))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 4)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的搓弄<Character key=ren str=Name/>的菊花。";
                        if (num == 30 || list.Contains(30))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的搓弄<Character key=ren str=Name/>的菊花。";
                        if (num == 31 || list.Contains(31))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
            }
            if (arg8 == 5)
            {
                if (arg9 == 1)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的抚摸<Character key=ren str=Name/>的臀部。";
                        if (num == 32 || list.Contains(32))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的抚摸<Character key=ren str=Name/>的臀部。";
                        if (num == 33 || list.Contains(33))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 2)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的按揉<Character key=ren str=Name/>的臀部。";
                        if (num == 34 || list.Contains(34))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的按揉<Character key=ren str=Name/>的臀部。";
                        if (num == 35 || list.Contains(35))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 3)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的拍打<Character key=ren str=Name/>的臀部。";
                        if (num == 36 || list.Contains(36))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的拍打<Character key=ren str=Name/>的臀部。";
                        if (num == 37 || list.Contains(37))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
                if (arg9 == 4)
                {
                    if (arg10 == 1)
                    {
                        ArgBox.Set("xingfen2", num4 + 10);
                        text = "<Character key=RoleTaiwu str=Name/>轻轻的搓弄<Character key=ren str=Name/>的臀部。";
                        if (num == 38 || list.Contains(38))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("xingfen2", num4 + 5);
                        }
                        else
                        {
                            ArgBox.Set("xingfen2", num4 + 15);
                        }
                        text = "<Character key=RoleTaiwu str=Name/>用力的搓弄<Character key=ren str=Name/>的臀部。";
                        if (num == 39 || list.Contains(39))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                        }
                    }
                }
            }
            if (arg8 == 6)
            {
                text = ((arg4 == 0 || arg5 == 0 || ((arg < 1 || arg > 5) && arg != 22)) ? "" : "<Character key=RoleTaiwu str=Name/>一边操着<Character key=ren str=Name/>，一边");
                if (arg9 == 1)
                {
                    if (arg10 == 1)
                    {
                        text += "<Character key=RoleTaiwu str=Name/>轻轻的抚摸<Character key=ren str=Name/>的肉棒。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        if (num == 40 || list.Contains(40))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 41 || list.Contains(41))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 41 || list.Contains(41))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text += "<Character key=RoleTaiwu str=Name/>用力的抚摸<Character key=ren str=Name/>的肉棒。";
                    }
                }
                if (arg9 == 2)
                {
                    if (arg10 == 1)
                    {
                        text += "<Character key=RoleTaiwu str=Name/>轻轻的按揉<Character key=ren str=Name/>的肉棒。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        if (num == 42 || list.Contains(42))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 43 || list.Contains(43))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 43 || list.Contains(43))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text += "<Character key=RoleTaiwu str=Name/>用力的按揉<Character key=ren str=Name/>的肉棒。";
                    }
                }
                if (arg9 == 3)
                {
                    if (arg10 == 1)
                    {
                        text += "<Character key=RoleTaiwu str=Name/>轻轻的拍打<Character key=ren str=Name/>的肉棒。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        if (num == 44 || list.Contains(44))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 45 || list.Contains(45))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 45 || list.Contains(45))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text += "<Character key=RoleTaiwu str=Name/>用力的拍打<Character key=ren str=Name/>的肉棒。";
                    }
                }
                if (arg9 == 4)
                {
                    if (arg10 == 1)
                    {
                        text += "<Character key=RoleTaiwu str=Name/>轻轻的搓弄<Character key=ren str=Name/>的肉棒。";
                        ArgBox.Set("xingfen2", num4 + 10);
                        ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        if (num == 46 || list.Contains(46))
                        {
                            ArgBox.Set("xingfen2", num4 + 10);
                            ArgBox.Set("kuaigan2", Addkuaigan2(5));
                        }
                    }
                    if (arg10 == 3)
                    {
                        if (num4 <= 50)
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(3));
                            ArgBox.Set("xingfen2", num4 + 5);
                            if (num == 47 || list.Contains(47))
                            {
                                ArgBox.Set("xingfen2", num4 + 5);
                                ArgBox.Set("kuaigan2", Addkuaigan2(5));
                            }
                        }
                        else
                        {
                            ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            ArgBox.Set("xingfen2", num4 + 15);
                            if (num == 47 || list.Contains(47))
                            {
                                ArgBox.Set("xingfen2", num4 + 15);
                                ArgBox.Set("kuaigan2", Addkuaigan2(10));
                            }
                        }
                        text += "<Character key=RoleTaiwu str=Name/>用力的搓弄<Character key=ren str=Name/>的肉棒。";
                    }
                }
            }
            if (ren.HasVirginity())
            {
                text += "\n\"嗯~~~<ArgBox key=chengweiduifang type=string/>~~好舒服~~~第一次被别人这样做~~~\"";
            }
            bool arg11 = false;
            if (ArgBox.Get("huandujixugankunbang", ref arg11))
            {
                text = "\"啊~~~放开我~~你这个贱人！！！\"";
            }
            bool arg12 = false;
            if (ArgBox.Get("zhandoucx", ref arg12))
            {
                text = "\"哼，指法练得不错嘛，嗯~~~那里~~不要~~~\"";
            }
            string targetString = string.Format(base.EventContent, text);
            return EventHelper.HandleStringTag(targetString, ArgBox, TaiwuEvent);
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