using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_3e316d4c62104d9ba253ef3645eef9b9 : TaiwuEventItem
    {
        public JTCXEvent_3e316d4c62104d9ba253ef3645eef9b9()
        {
            Guid = Guid.Parse("3e316d4c-6210-4d9b-a253-ef3645eef9b9");
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
            EventOptions = new TaiwuEventOption[7]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_1854167791"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-683336982"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_998964824"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-565440702"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_935061773"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1836316673"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1833581794"
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
            ArgBox.Set("koubuwei", 0);
            return "be635c03-e465-4035-8979-7a415e882498";
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
            ArgBox.Set("koubuwei", 1);
            return "503c16a1-1f2d-4997-90bd-bb722af1984a";
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
            ArgBox.Set("koubuwei", 2);
            return "503c16a1-1f2d-4997-90bd-bb722af1984a";
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
            ArgBox.Set("koubuwei", 5);
            return "503c16a1-1f2d-4997-90bd-bb722af1984a";
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
            ArgBox.Set("koubuwei", 3);
            return "503c16a1-1f2d-4997-90bd-bb722af1984a";
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
            ArgBox.Set("koubuwei", 4);
            return "503c16a1-1f2d-4997-90bd-bb722af1984a";
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