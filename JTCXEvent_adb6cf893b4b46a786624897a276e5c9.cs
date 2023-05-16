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
    public class JTCXEvent_adb6cf893b4b46a786624897a276e5c9 : TaiwuEventItem
    {
        public JTCXEvent_adb6cf893b4b46a786624897a276e5c9()
        {
            Guid = Guid.Parse("adb6cf89-3b4b-46a7-8662-4897a276e5c9");
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
                OptionKey = "Option_-878622150"
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
            ArgBox.Set("gaochao1count", arg + 1);
            int arg2 = 0;
            ArgBox.Get("xinshen1", ref arg2);
            ArgBox.Set("xinshen1", arg2 + 20);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            int arg3 = 0;
            ArgBox.Get("sex1", ref arg3);
            int arg4 = 0;
            ArgBox.Get("mode", ref arg4);
            int arg5 = 0;
            ArgBox.Get("zishi", ref arg5);
            if (arg5 != 21 && arg5 != 0 && arg5 < 30)
            {
                if (arg3 != 0 && arg4 == 0)
                {
                    EventHelper.ToEvent("85a5bfa0-d4a6-489b-82f6-54c4e57b2cfa");
                }
                if (arg3 != 0 && arg4 == 1)
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
            if (arg5 == 31)
            {
                EventBackground = "zujiao2";
                EventHelper.SetEventSeriesTexture("zujiao2");
            }
            if (arg5 == 32)
            {
                EventBackground = "rujiao2";
                EventHelper.SetEventSeriesTexture("rujiao2");
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("kuaigan1", ref arg2);
            int arg3 = 0;
            ArgBox.Get("kuaigan12", ref arg3);
            string arg4 = "";
            ArgBox.Get("chengweitaiwu", ref arg4);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            string text = "";
            if (arg == 0)
            {
                text = "\"啊~~~<ArgBox key=chengweitaiwu type=string/>~~~我要去啦~~~!!!\"<Character key=RoleTaiwu str=Name/>身体突然紧绷，达到高潮，喷出了大量的淫水。";
            }
            if (arg == 1)
            {
                text = "\"啊~~~<ArgBox key=chengweitaiwu type=string/>~~~我要射啦~~~!!!\"<Character key=RoleTaiwu str=Name/>精关一松，射出了大量的白浆。";
            }
            if (arg == 2 && arg3 >= 100)
            {
                text = "\"啊~~~<ArgBox key=chengweitaiwu type=string/>~~~我要去啦~~~!!!\"<Character key=RoleTaiwu str=Name/>身体突然紧绷，达到高潮，喷出了大量的淫水。";
            }
            if (arg == 2 && arg2 >= 100)
            {
                text = "\"啊~~~<ArgBox key=chengweitaiwu type=string/>~~~我要射啦~~~!!!\"<Character key=RoleTaiwu str=Name/>精关一松，射出了大量的白浆。";
            }
            int arg5 = 0;
            ArgBox.Get("mode", ref arg5);
            if (arg5 == 1)
            {
                text += "\n<Character key=RoleTaiwu str=Name/>被<Character key=ren str=Name/>吸去了内力。";
            }
            string targetString = string.Format(base.EventContent, text);
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
            int arg = 0;
            ArgBox.Get("kuaigan1", ref arg);
            int arg2 = 0;
            ArgBox.Get("kuaigan12", ref arg2);
            if (arg > 0)
            {
                ArgBox.Set("kuaigan1", 0);
            }
            if (arg2 > 0)
            {
                ArgBox.Set("kuaigan12", 0);
            }
            ArgBox.Set("xingfen1", 30);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int arg3 = 0;
            ArgBox.Get("zishi", ref arg3);
            int arg4 = 0;
            ArgBox.Get("qianhou", ref arg4);
            int arg5 = 0;
            ArgBox.Get("sex1", ref arg5);
            int arg6 = 0;
            ArgBox.Get("sex2", ref arg6);
            if (!character.GetFeatureIds().Contains(196))
            {
                character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
            }
            if (!character2.GetFeatureIds().Contains(196))
            {
                character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
            }
            if (arg3 != 21 && arg3 != 0 && arg3 < 30 && arg4 == 1 && character2.GetCreatingType() == 1)
            {
                if (arg5 != 0 && arg6 != 1)
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
                bool val2 = false;
                DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "tongxing", ref val2);
                if (val2)
                {
                    if (arg5 == 1 && arg6 == 1)
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
                    if (arg5 == 0 && arg6 == 0)
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
            ArgBox.Set("gaochao", 1);
            int arg7 = 0;
            ArgBox.Get("mode", ref arg7);
            if (arg7 == 1)
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
                            val5 = (int)((double)val5 * 1.25);
                        }
                        if (num == num2 + 1 || (num == 1 && num2 == 5))
                        {
                            val5 = (int)((double)val5 * 0.75);
                        }
                        if (num2 == num + 2 || (num == 4 && num2 == 1) || (num == 5 && num2 == 2))
                        {
                            val5 = (int)((double)val5 * 0.5);
                        }
                        if (num == num2 + 2 || (num2 == 4 && num == 1) || (num2 == 5 && num == 2))
                        {
                            val5 = (int)((double)val5 * 1.5);
                        }
                    }
                    if (character.GetPureCurrNeili() < val5)
                    {
                        character.SpecifyBaseNeiliAllocation(DomainManager.TaiwuEvent.MainThreadDataContext, default(NeiliAllocation));
                        character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 0);
                    }
                    else if (character.GetCurrNeili() >= val5)
                    {
                        character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character.GetCurrNeili() - val5);
                    }
                    else
                    {
                        int currNeili = character.GetCurrNeili();
                        while (currNeili < val5)
                        {
                            int num3 = 0;
                            while (num3 == 0)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 0))
                                {
                                    if (character.GetCurrNeili() >= val5)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 1;
                                }
                            }
                            while (num3 == 1)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 1))
                                {
                                    if (character.GetCurrNeili() >= val5)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 2;
                                }
                            }
                            while (num3 == 2)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 2))
                                {
                                    if (character.GetCurrNeili() >= val5)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 3;
                                }
                            }
                            while (num3 == 3)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 3))
                                {
                                    if (character.GetCurrNeili() >= val5)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 4;
                                }
                            }
                        }
                        if (character.GetCurrNeili() >= val5)
                        {
                            character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character.GetCurrNeili() - val5);
                        }
                        else
                        {
                            character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 0);
                        }
                    }
                    character2.SetExtraNeili(character2.GetExtraNeili() + val5, DomainManager.TaiwuEvent.MainThreadDataContext);
                    character2.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character2.GetCurrNeili() + val5);
                }
                Character character3 = character2;
                if (ArgBox.Get("nvyifu", out ItemKey arg8))
                {
                    character3.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg8);
                }
                if (ArgBox.Get("nanyifu", out ItemKey arg9))
                {
                    character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg9);
                }
                if (EventHelper.GetFavorabilityType(character2, character) >= 5)
                {
                    EventHelper.EndRelation(character2.GetId(), character.GetId(), 32768);
                    EventHelper.EndRelation(character.GetId(), character2.GetId(), 32768);
                }
                EventBackground = "";
                EventHelper.SetEventSeriesTexture("");
                ArgBox.Set("juedouresult", 2);
                bool arg10 = false;
                if (ArgBox.Get("zhandoucx", ref arg10))
                {
                    CombatCharacter combatCharacter = DomainManager.Combat.GetCombatCharacter(isAlly: true);
                    combatCharacter.SetNeiliAllocation(default(NeiliAllocation), DomainManager.TaiwuEvent.MainThreadDataContext);
                    return "fcde02f3-fb01-4d6d-9dad-aad96d979f63";
                }
                bool arg11 = false;
                if (ArgBox.Get("jiaoyicx", ref arg11))
                {
                    return "7da6d1a8-959f-44e5-a2bc-2e3cb41a1f5a";
                }
                string arg12 = "";
                if (ArgBox.Get("fanhui", ref arg12))
                {
                    return arg12;
                }
                return string.Empty;
            }
            int arg13 = 0;
            ArgBox.Get("gaochao1count", ref arg13);
            int arg14 = 0;
            if (ArgBox.Get("gaochaotuichu1", ref arg14) && arg13 >= arg14)
            {
                string arg15 = "";
                if (ArgBox.Get("fanhui", ref arg15))
                {
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    Character character4 = character2;
                    if (ArgBox.Get("nvyifu", out ItemKey arg16))
                    {
                        character4.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg16);
                    }
                    if (ArgBox.Get("nanyifu", out ItemKey arg17))
                    {
                        character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg17);
                    }
                    return arg15;
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