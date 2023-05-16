using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_e85b83d43d3f411d88250a7a2f60ade1 : TaiwuEventItem
    {
        public JTCXEvent_e85b83d43d3f411d88250a7a2f60ade1()
        {
            Guid = Guid.Parse("e85b83d4-3d3f-411d-8825-0a7a2f60ade1");
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
                OptionKey = "Option_-122218330"
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            string arg = "";
            if (character.GetGender() == 1 && character2.GetGender() == 0)
            {
                arg = "<Character key=RoleTaiwu str=Name/>趁<Character key=ren str=Name/>正处在混乱状态，继续将肉棒塞进<Character key=ren str=Name/>的小穴大力抽插起来。";
                EventBackground = "chuanjiaoshi";
                EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                ArgBox.Set("zishi", 1);
                ArgBox.Set("ppzishi", "传教士");
            }
            if (character.GetGender() == 1 && character2.GetGender() == 1)
            {
                arg = "<Character key=RoleTaiwu str=Name/>趁<Character key=ren str=Name/>正处在混乱状态，继续将肉棒塞进<Character key=ren str=Name/>的菊花大力抽插起来。";
                EventBackground = "chuanjiaoshi";
                EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                ArgBox.Set("zishi", 1);
                ArgBox.Set("ppzishi", "传教士");
            }
            if (character.GetGender() == 0 && character2.GetGender() == 1)
            {
                arg = "<Character key=RoleTaiwu str=Name/>趁<Character key=ren str=Name/>正处在混乱状态，继续将<Character key=ren str=Name/>的肉棒塞进自己的小穴用力扭动起来。";
                EventBackground = "qicheng";
                EventHelper.SetEventSeriesTexture("qicheng");
                ArgBox.Set("zishi", 11);
                ArgBox.Set("ppzishi", "骑乘位");
            }
            if (character.GetGender() == 0 && character2.GetGender() == 0)
            {
                arg = "<Character key=RoleTaiwu str=Name/>趁<Character key=ren str=Name/>正处在混乱状态，继续将自己的湿润的蜜穴与<Character key=ren str=Name/>相贴，用力摩擦起来。";
                EventBackground = "yiqi";
                EventHelper.SetEventSeriesTexture("yiqi");
                ArgBox.Set("zishi", 1);
                ArgBox.Set("ppzishi", "传教士");
            }
            ArgBox.Set("huandujixu", arg);
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            string arg = "";
            ArgBox.Get("huandujixu", ref arg);
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
            int arg = 0;
            ArgBox.Get("kunbang", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili2", ref arg2);
            int arg3 = 0;
            ArgBox.Get("xingfen2", ref arg3);
            int arg4 = 0;
            ArgBox.Get("kuaigan2", ref arg4);
            int arg5 = 0;
            ArgBox.Get("xinshen2", ref arg5);
            int random = EventHelper.GetRandom(1, 3);
            if (arg2 < 5)
            {
                return "4441df24-77c7-40aa-b614-16769d90d2a0";
            }
            if (arg5 >= 60)
            {
                return "4441df24-77c7-40aa-b614-16769d90d2a0";
            }
            if (arg4 > 160)
            {
                return "4441df24-77c7-40aa-b614-16769d90d2a0";
            }
            if (arg4 > 140 && random == 1)
            {
                return "4441df24-77c7-40aa-b614-16769d90d2a0";
            }
            if (arg4 > 140 && random != 1)
            {
                if (arg <= 0)
                {
                    return "45da0eb8-4dde-408f-9973-190d11956993";
                }
                return "44520d31-1b9b-40cd-98b7-60385262d78e";
            }
            if (arg <= 0)
            {
                return "45da0eb8-4dde-408f-9973-190d11956993";
            }
            return "44520d31-1b9b-40cd-98b7-60385262d78e";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}