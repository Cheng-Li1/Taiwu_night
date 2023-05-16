using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_75b92dda9abb4b58a65d1bfacf728bd0 : TaiwuEventItem
    {
        public JTCXEvent_75b92dda9abb4b58a65d1bfacf728bd0()
        {
            Guid = Guid.Parse("75b92dda-9abb-4b58-a65d-1bfacf728bd0");
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
            EscOptionKey = "Option_319555763";
            EventOptions = new TaiwuEventOption[7]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_1502160188"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-1169242667"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-1455164852"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-1051128389"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-497572695"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-1606566327"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_319555763"
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
            EventOptions[4].OnOptionVisibleCheck = OnOption5VisibleCheck;
            EventOptions[4].OnOptionAvailableCheck = OnOption5AvailableCheck;
            EventOptions[4].GetReplacedContent = OnOption5GetReplacedContent;
            EventOptions[4].OnOptionSelect = OnOption5Select;
            EventOptions[4].GetExtraFormatLanguageKeys = Option5GetExtraFormatLanguageKeys;
            OnOption5Create();
            EventOptions[5].OnOptionVisibleCheck = OnOption6VisibleCheck;
            EventOptions[5].OnOptionAvailableCheck = OnOption6AvailableCheck;
            EventOptions[5].GetReplacedContent = OnOption6GetReplacedContent;
            EventOptions[5].OnOptionSelect = OnOption6Select;
            EventOptions[5].GetExtraFormatLanguageKeys = Option6GetExtraFormatLanguageKeys;
            OnOption6Create();
            EventOptions[6].OnOptionVisibleCheck = OnOption7VisibleCheck;
            EventOptions[6].OnOptionAvailableCheck = OnOption7AvailableCheck;
            EventOptions[6].GetReplacedContent = OnOption7GetReplacedContent;
            EventOptions[6].OnOptionSelect = OnOption7Select;
            EventOptions[6].GetExtraFormatLanguageKeys = Option7GetExtraFormatLanguageKeys;
            OnOption7Create();
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
            ArgBox.Set("shoubuwei", 1);
            return "06c5facf-4502-4d80-b3e9-36558706cf3e";
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
            ArgBox.Set("shoubuwei", 2);
            return "06c5facf-4502-4d80-b3e9-36558706cf3e";
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
            ArgBox.Set("shoubuwei", 5);
            return "06c5facf-4502-4d80-b3e9-36558706cf3e";
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
            int arg = 0;
            ArgBox.Get("sex2", ref arg);
            if (arg != 0)
            {
                return true;
            }
            return false;
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
            ArgBox.Set("shoubuwei", 6);
            return "06c5facf-4502-4d80-b3e9-36558706cf3e";
        }

        public List<string> Option4GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption5Create()
        {
        }

        private bool OnOption5VisibleCheck()
        {
            int arg = 0;
            ArgBox.Get("sex2", ref arg);
            if (arg != 1)
            {
                return true;
            }
            return false;
        }

        private bool OnOption5AvailableCheck()
        {
            return true;
        }

        private string OnOption5GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption5Select()
        {
            ArgBox.Set("shoubuwei", 3);
            return "06c5facf-4502-4d80-b3e9-36558706cf3e";
        }

        public List<string> Option5GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption6Create()
        {
        }

        private bool OnOption6VisibleCheck()
        {
            return true;
        }

        private bool OnOption6AvailableCheck()
        {
            return true;
        }

        private string OnOption6GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption6Select()
        {
            ArgBox.Set("shoubuwei", 4);
            return "06c5facf-4502-4d80-b3e9-36558706cf3e";
        }

        public List<string> Option6GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption7Create()
        {
        }

        private bool OnOption7VisibleCheck()
        {
            return true;
        }

        private bool OnOption7AvailableCheck()
        {
            return true;
        }

        private string OnOption7GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption7Select()
        {
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option7GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}