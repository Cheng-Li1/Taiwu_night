using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_d2a009a44b4e408389eb319f726fbdcf : TaiwuEventItem
    {
        public JTCXEvent_d2a009a44b4e408389eb319f726fbdcf()
        {
            Guid = Guid.Parse("d2a009a4-4b4e-4083-89eb-319f726fbdcf");
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
                OptionKey = "Option_-982830861"
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
            int arg = 0;
            ArgBox.Get("kuaigan1", ref arg);
            int arg2 = 0;
            ArgBox.Get("kuaigan2", ref arg2);
            if (arg >= 200 && arg2 >= 200)
            {
                return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
            }
            if (arg >= 200)
            {
                return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
            }
            if (arg2 >= 200)
            {
                return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
            }
            int arg3 = 0;
            ArgBox.Get("zishi", ref arg3);
            if (arg3 > 10 && arg3 <= 40)
            {
                ArgBox.Set("zishi", 0);
            }
            int arg4 = 0;
            ArgBox.Get("tili2", ref arg4);
            ArgBox.Set("tili2", arg4 + 10);
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}