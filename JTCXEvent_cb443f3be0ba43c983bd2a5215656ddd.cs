using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_cb443f3be0ba43c983bd2a5215656ddd : TaiwuEventItem
    {
        public JTCXEvent_cb443f3be0ba43c983bd2a5215656ddd()
        {
            Guid = Guid.Parse("cb443f3b-e0ba-43c9-83bd-2a5215656ddd");
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
                OptionKey = "Option_-1731298306"
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
            ArgBox.Get("huiheshu", ref arg);
            ArgBox.Set("huiheshu", arg + 1);
            Character character = ArgBox.GetCharacter("ren");
            bool arg2 = false;
            bool arg3 = false;
            bool arg4 = false;
            if (ArgBox.Get("huandu", ref arg2) && !ArgBox.Get("huandujixugan", ref arg3))
            {
                int arg5 = 0;
                ArgBox.Get("huandulevel", ref arg5);
                int roleGrade = EventHelper.GetRoleGrade(character);
                int random = EventHelper.GetRandom();
                if (arg5 == roleGrade + 1 && random < 7)
                {
                    EventHelper.ToEvent("a08ba0ea-806d-409c-b148-824b10a1c91c");
                }
                if (arg5 == roleGrade && random < 12)
                {
                    EventHelper.ToEvent("a08ba0ea-806d-409c-b148-824b10a1c91c");
                }
                if (arg5 == roleGrade - 1 && random < 16)
                {
                    EventHelper.ToEvent("a08ba0ea-806d-409c-b148-824b10a1c91c");
                }
            }
            int arg6 = 0;
            ArgBox.Get("kunbang", ref arg6);
            if (ArgBox.Get("huandujixugankunbang", ref arg4))
            {
                if (arg6 > 0)
                {
                    EventHelper.ToEvent("44520d31-1b9b-40cd-98b7-60385262d78e");
                }
                else
                {
                    EventHelper.ToEvent("45da0eb8-4dde-408f-9973-190d11956993");
                }
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
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}