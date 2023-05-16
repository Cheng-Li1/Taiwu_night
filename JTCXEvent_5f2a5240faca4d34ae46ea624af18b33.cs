using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_5f2a5240faca4d34ae46ea624af18b33 : TaiwuEventItem
    {
        public JTCXEvent_5f2a5240faca4d34ae46ea624af18b33()
        {
            Guid = Guid.Parse("5f2a5240-faca-4d34-ae46-ea624af18b33");
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
            EventOptions = new TaiwuEventOption[4]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_-288381202"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-1179895481"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_840782313"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-527994653"
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
            EventOptions[3].OnOptionVisibleCheck = OnOption4VisibleCheck;
            EventOptions[3].OnOptionAvailableCheck = OnOption4AvailableCheck;
            EventOptions[3].GetReplacedContent = OnOption4GetReplacedContent;
            EventOptions[3].OnOptionSelect = OnOption4Select;
            EventOptions[3].GetExtraFormatLanguageKeys = Option4GetExtraFormatLanguageKeys;
            OnOption4Create();
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
            int arg = 0;
            ArgBox.Get("sex2", ref arg);
            int arg2 = 0;
            ArgBox.Get("zishi", ref arg2);
            if (arg2 == 21 && arg != 0)
            {
                return true;
            }
            return false;
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
            ArgBox.Set("qianhou", 2);
            return "99144b8b-750f-4e47-9e1b-86f0fde782aa";
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
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("sex2", ref arg2);
            int arg3 = 0;
            ArgBox.Get("zishi", ref arg3);
            switch (arg3)
            {
                case 5:
                    if (arg == 1 && arg2 == 1)
                    {
                        return false;
                    }
                    return true;
                case 6:
                    if (arg == 1)
                    {
                        return false;
                    }
                    return true;
                default:
                    if (arg2 == 1)
                    {
                        return false;
                    }
                    return true;
            }
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
            ArgBox.Set("qianhou", 1);
            return "99144b8b-750f-4e47-9e1b-86f0fde782aa";
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
            ArgBox.Set("qianhou", 2);
            return "99144b8b-750f-4e47-9e1b-86f0fde782aa";
        }

        public List<string> Option3GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption4Create()
        {
        }

        private bool OnOption4VisibleCheck()
        {
            return true;
        }

        private bool OnOption4AvailableCheck()
        {
            return true;
        }

        private string OnOption4GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption4Select()
        {
            return "65979702-3cdd-49d4-bc5d-c8f095f3f81f";
        }

        public List<string> Option4GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}