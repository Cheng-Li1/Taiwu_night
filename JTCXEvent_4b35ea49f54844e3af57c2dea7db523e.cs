using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_4b35ea49f54844e3af57c2dea7db523e : TaiwuEventItem
    {
        public JTCXEvent_4b35ea49f54844e3af57c2dea7db523e()
        {
            Guid = Guid.Parse("4b35ea49-f548-44e3-af57-c2dea7db523e");
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
                OptionKey = "Option_-1293064699"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-681566967"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-203689006"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-1877054165"
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
            string arg = "";
            if (!ArgBox.Get("choucha", ref arg))
            {
                arg = "<Character key=RoleTaiwu str=Name/>与<Character key=ren str=Name/>的下体交合着，发出啪啪啪的撞击声。";
            }
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
            ArgBox.Get("kuaigan2", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            if (arg < 50)
            {
                if (arg2 < 15)
                {
                    return "01596837-7b11-4b8a-9bb7-144504443bf1";
                }
                ArgBox.Set("tili1", arg2 - 15);
            }
            else
            {
                if (arg2 < 10)
                {
                    return "01596837-7b11-4b8a-9bb7-144504443bf1";
                }
                ArgBox.Set("tili1", arg2 - 10);
            }
            ArgBox.Set("cha", 1);
            return "0e94043b-ebc2-457d-b4da-8b7ef152cdea";
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
            int arg = 0;
            ArgBox.Get("kuaigan2", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            if (arg < 50)
            {
                if (arg2 < 20)
                {
                    return "01596837-7b11-4b8a-9bb7-144504443bf1";
                }
                ArgBox.Set("tili1", arg2 - 20);
            }
            else
            {
                if (arg2 < 15)
                {
                    return "01596837-7b11-4b8a-9bb7-144504443bf1";
                }
                ArgBox.Set("tili1", arg2 - 15);
            }
            ArgBox.Set("cha", 2);
            return "0e94043b-ebc2-457d-b4da-8b7ef152cdea";
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
            int arg = 0;
            ArgBox.Get("kuaigan2", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            if (arg < 50)
            {
                if (arg2 < 25)
                {
                    return "01596837-7b11-4b8a-9bb7-144504443bf1";
                }
                ArgBox.Set("tili1", arg2 - 25);
            }
            else
            {
                if (arg2 < 20)
                {
                    return "01596837-7b11-4b8a-9bb7-144504443bf1";
                }
                ArgBox.Set("tili1", arg2 - 20);
            }
            ArgBox.Set("cha", 3);
            return "0e94043b-ebc2-457d-b4da-8b7ef152cdea";
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
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option4GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}