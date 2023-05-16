using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_9492f03ed6f14ceeaf4fa593e15fbdb7 : TaiwuEventItem
    {
        public JTCXEvent_9492f03ed6f14ceeaf4fa593e15fbdb7()
        {
            Guid = Guid.Parse("9492f03e-d6f1-4cee-af4f-a593e15fbdb7");
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
            EventOptions = new TaiwuEventOption[8]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_-777309888"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1923346792"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1201079983"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1990837539"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_864154733"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_602387043"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-779278337"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-1343942745"
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
            EventOptions[7].OnOptionVisibleCheck = OnOption8VisibleCheck;
            EventOptions[7].OnOptionAvailableCheck = OnOption8AvailableCheck;
            EventOptions[7].GetReplacedContent = OnOption8GetReplacedContent;
            EventOptions[7].OnOptionSelect = OnOption8Select;
            EventOptions[7].GetExtraFormatLanguageKeys = Option8GetExtraFormatLanguageKeys;
            OnOption8Create();
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
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("sex2", ref arg2);
            if (arg != 1 && arg2 != 0)
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
            return "24c6f6c4-b651-4dce-adc4-1e6d2e7df7f2";
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
            return "d8ceef23-0dc7-4575-a082-6134016c685a";
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
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("sex2", ref arg2);
            if (arg != 0 && arg2 != 1)
            {
                return true;
            }
            return false;
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
            return "170e12a4-2f89-43ee-8f3d-f48b80b0a014";
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
            return "0fcb351f-d5bc-46ea-ae01-497b2a0fb4a4";
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
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("sex2", ref arg2);
            if (arg != 1 || arg2 != 1)
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
            return "82000559-30e5-494e-a22a-d4f069afd716";
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
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("sex2", ref arg2);
            if (arg != 0 && arg2 != 0)
            {
                return true;
            }
            return false;
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
            return "2b16bb86-72ef-438d-962d-89c313c1cf45";
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
            return "c4ecd83b-1313-4784-ad17-da386b547a58";
        }

        public List<string> Option7GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption8Create()
        {
        }

        private bool OnOption8VisibleCheck()
        {
            return true;
        }

        private bool OnOption8AvailableCheck()
        {
            return true;
        }

        private string OnOption8GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption8Select()
        {
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option8GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}