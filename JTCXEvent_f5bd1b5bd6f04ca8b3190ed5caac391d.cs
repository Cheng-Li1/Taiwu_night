using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_f5bd1b5bd6f04ca8b3190ed5caac391d : TaiwuEventItem
    {
        public JTCXEvent_f5bd1b5bd6f04ca8b3190ed5caac391d()
        {
            Guid = Guid.Parse("f5bd1b5b-d6f0-4ca8-b319-0ed5caac391d");
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
                OptionKey = "Option_-32827507"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_261106829"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-862225940"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_589309488"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-366149595"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_370047333"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_799023908"
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
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            if (arg != 0)
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
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 0);
            if (arg <= 40 && arg > 10 && arg != 21 && arg != 22 && arg != 33)
            {
                if (arg2 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (arg2 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((arg2 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg2 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (arg2 >= 10)
                        {
                            ArgBox.Set("tili1", arg2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (arg2 >= 20)
                    {
                        ArgBox.Set("tili1", arg2 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            ArgBox.Set("zishi", 1);
            return "5f2a5240-faca-4d34-ae46-ea624af18b33";
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
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 0);
            if (arg <= 40 && arg > 10 && arg != 21 && arg != 22 && arg != 33)
            {
                if (arg2 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (arg2 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((arg2 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg2 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (arg2 >= 10)
                        {
                            ArgBox.Set("tili1", arg2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (arg2 >= 20)
                    {
                        ArgBox.Set("tili1", arg2 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            ArgBox.Set("zishi", 5);
            return "5f2a5240-faca-4d34-ae46-ea624af18b33";
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
            if (arg != 1 && arg2 != 0)
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
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 0);
            if (arg <= 40 && arg > 10 && arg != 21 && arg != 22 && arg != 33)
            {
                if (arg2 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (arg2 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((arg2 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg2 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (arg2 >= 10)
                        {
                            ArgBox.Set("tili1", arg2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (arg2 >= 20)
                    {
                        ArgBox.Set("tili1", arg2 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            ArgBox.Set("zishi", 6);
            return "5f2a5240-faca-4d34-ae46-ea624af18b33";
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
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
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 0);
            if (arg <= 40 && arg > 10 && arg != 21 && arg != 22 && arg != 33)
            {
                if (arg2 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (arg2 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((arg2 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg2 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (arg2 >= 10)
                        {
                            ArgBox.Set("tili1", arg2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (arg2 >= 20)
                    {
                        ArgBox.Set("tili1", arg2 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            ArgBox.Set("zishi", 2);
            return "5f2a5240-faca-4d34-ae46-ea624af18b33";
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("sex2", ref arg2);
            if (arg == 0 && arg2 == 1)
            {
                return false;
            }
            return true;
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
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 0);
            if (arg <= 40 && arg > 10 && arg != 21 && arg != 22 && arg != 33)
            {
                if (arg2 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (arg2 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((arg2 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg2 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (arg2 >= 10)
                        {
                            ArgBox.Set("tili1", arg2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (arg2 >= 20)
                    {
                        ArgBox.Set("tili1", arg2 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            ArgBox.Set("zishi", 3);
            return "5f2a5240-faca-4d34-ae46-ea624af18b33";
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            if (arg != 0)
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
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 0);
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 0);
            if (arg <= 40 && arg > 10 && arg != 21 && arg != 22 && arg != 33)
            {
                if (arg2 < 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if (arg2 < 10 && roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                {
                    EventHelper.ToEvent("01596837-7b11-4b8a-9bb7-144504443bf1");
                }
                if ((arg2 >= 20 && roleCurrentMainAttributes < roleCurrentMainAttributes2) || (arg2 >= 10 && roleCurrentMainAttributes > roleCurrentMainAttributes2))
                {
                    if (roleCurrentMainAttributes >= roleCurrentMainAttributes2)
                    {
                        if (arg2 >= 10)
                        {
                            ArgBox.Set("tili1", arg2 - 10);
                        }
                        else
                        {
                            ArgBox.Set("tili1", 0);
                        }
                    }
                    else if (arg2 >= 20)
                    {
                        ArgBox.Set("tili1", arg2 - 20);
                    }
                    else
                    {
                        ArgBox.Set("tili1", 0);
                    }
                }
            }
            ArgBox.Set("zishi", 4);
            return "5f2a5240-faca-4d34-ae46-ea624af18b33";
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
            return "65979702-3cdd-49d4-bc5d-c8f095f3f81f";
        }

        public List<string> Option7GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}