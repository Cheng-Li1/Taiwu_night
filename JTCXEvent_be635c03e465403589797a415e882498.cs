using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_be635c03e465403589797a415e882498 : TaiwuEventItem
    {
        public JTCXEvent_be635c03e465403589797a415e882498()
        {
            Guid = Guid.Parse("be635c03-e465-4035-8979-7a415e882498");
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
            EventOptions = new TaiwuEventOption[3]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_1135028101"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1552534621"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-237464138"
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
            EventOptions[1].OnOptionVisibleCheck = OnOption2VisibleCheck;
            EventOptions[1].OnOptionAvailableCheck = OnOption2AvailableCheck;
            EventOptions[1].GetReplacedContent = OnOption2GetReplacedContent;
            EventOptions[1].OnOptionSelect = OnOption2Select;
            EventOptions[1].GetExtraFormatLanguageKeys = Option2GetExtraFormatLanguageKeys;
            OnOption2Create();
            EventOptions[2].OnOptionVisibleCheck = OnOption3VisibleCheck;
            EventOptions[2].OnOptionAvailableCheck = OnOption3AvailableCheck;
            EventOptions[2].GetReplacedContent = OnOption3GetReplacedContent;
            EventOptions[2].OnOptionSelect = OnOption3Select;
            EventOptions[2].GetExtraFormatLanguageKeys = Option3GetExtraFormatLanguageKeys;
            OnOption3Create();
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
            ArgBox.Set("koulidu", 1);
            return "d484e559-f1d2-4bfe-acc6-2bd9c529835e";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption2Create()
        {
        }

        private bool OnOption2VisibleCheck()
        {
            return true;
        }

        private bool OnOption2AvailableCheck()
        {
            return true;
        }

        private string OnOption2GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption2Select()
        {
            ArgBox.Set("koulidu", 2);
            return "d484e559-f1d2-4bfe-acc6-2bd9c529835e";
        }

        public List<string> Option2GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption3Create()
        {
        }

        private bool OnOption3VisibleCheck()
        {
            return true;
        }

        private bool OnOption3AvailableCheck()
        {
            return true;
        }

        private string OnOption3GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption3Select()
        {
            return string.Empty;
        }

        public List<string> Option3GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}