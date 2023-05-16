using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.Item;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.DisplayEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_b6ac6816c2f54b74a6446ed1dd500a54 : TaiwuEventItem
    {
        public JTCXEvent_b6ac6816c2f54b74a6446ed1dd500a54()
        {
            Guid = Guid.Parse("b6ac6816-c2f5-4b74-a644-6ed1dd500a54");
            IsHeadEvent = false;
            EventGroup = "jutichunxiao";
            ForceSingle = false;
            EventType = EEventType.ModEvent;
            TriggerType = EventTrigger.None;
            EventSortingOrder = 500;
            MainRoleKey = "";
            TargetRoleKey = "";
            EventBackground = "";
            MaskControl = 0;
            MaskTweenTime = 0f;
            EscOptionKey = "";
            EventOptions = new TaiwuEventOption[2]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_96509141"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_210407465"
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
        }

        public override bool OnCheckEventCondition()
        {
            return true;
        }

        public override void OnEventEnter()
        {
            SelectItemFilter filter = default(SelectItemFilter);
            filter.FilterTemplateId = 60;
            filter.Key = "MetalKey";
            EventHelper.TaiwuSelectItemRequest(ArgBox, filter);
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            if (ArgBox.Get("MetalKey", out ItemKey arg))
            {
                if (arg.TemplateId >= 45 && arg.TemplateId <= 53)
                {
                    EventHelper.RemoveInventoryItem(character, arg);
                    ArgBox.Set("huandulevel", arg.TemplateId - 45);
                    Character character2 = ArgBox.GetCharacter("CharacterId");
                    int random = EventHelper.GetRandom(1, 7);
                    if (arg.TemplateId - 45 >= EventHelper.GetRoleGrade(character2) + 2)
                    {
                        return "cdc46e1d-8963-42dc-bc74-56dc37f5006c";
                    }
                    if (arg.TemplateId - 45 == EventHelper.GetRoleGrade(character2) + 1 && random <= 4)
                    {
                        return "cdc46e1d-8963-42dc-bc74-56dc37f5006c";
                    }
                    if (arg.TemplateId - 45 == EventHelper.GetRoleGrade(character2) && random <= 3)
                    {
                        return "cdc46e1d-8963-42dc-bc74-56dc37f5006c";
                    }
                    if (arg.TemplateId - 45 == EventHelper.GetRoleGrade(character2) - 1 && random <= 2)
                    {
                        return "cdc46e1d-8963-42dc-bc74-56dc37f5006c";
                    }
                    return "4a5967ed-316b-4b3a-b7d9-04457cd0553f";
                }
                return "4a5967ed-316b-4b3a-b7d9-04457cd0553f";
            }
            return "7c70ce0c-577a-4049-bcad-e593c63d62d4";
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
            return string.Empty;
        }

        public List<string> Option2GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}