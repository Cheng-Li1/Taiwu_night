using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;
using GameData.Domains.TaiwuEvent.EventOption;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_59171e2859574f1f8ccb68c1c88234b8 : TaiwuEventItem
    {
        public JTCXEvent_59171e2859574f1f8ccb68c1c88234b8()
        {
            Guid = Guid.Parse("59171e28-5957-4f1f-8ccb-68c1c88234b8");
            IsHeadEvent = true;
            EventGroup = "jutichunxiao";
            ForceSingle = false;
            EventType = EEventType.ModEvent;
            TriggerType = EventTrigger.CharacterClicked;
            EventSortingOrder = 500;
            MainRoleKey = "";
            TargetRoleKey = "";
            EventBackground = "";
            MaskControl = 0;
            MaskTweenTime = 0f;
            EscOptionKey = "";
            EventOptions = new TaiwuEventOption[3]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_805876730"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1972492470"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1000261500"
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
            EventHelper.AddOptionToEvent("bad63f08-115a-45aa-970c-fa203dd85e2b", Guid.ToString(), EventOptions[0].OptionKey);
            EventHelper.AddOptionToEvent("7c70ce0c-577a-4049-bcad-e593c63d62d4", Guid.ToString(), EventOptions[1].OptionKey);
            EventHelper.AddOptionToEvent("3fd8291d-6f22-4b24-88ff-e11e9c5dbc6b", Guid.ToString(), EventOptions[1].OptionKey);
            EventHelper.AddOptionToEvent("9dce4f27-347c-4588-9be4-08c1c7f1f4a3", Guid.ToString(), EventOptions[2].OptionKey);
            EventHelper.AddOptionToEvent("2e651ccb-3a77-447a-a74f-c9a24a1a32d1", Guid.ToString(), EventOptions[2].OptionKey);
            EventHelper.ToEvent(string.Empty);
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
            EventOptions[0].OptionAvailableConditions = new List<TaiwuEventOptionConditionBase>();
            TaiwuEventOptionConditionBase item = new OptionConditionSbyte(2, 3, OptionConditionMatcher.MovePointMore);
            EventOptions[0].OptionAvailableConditions.Add(item);
            EventOptions[0].OptionConsumeInfos = new List<OptionConsumeInfo>();
            EventOptions[0].OptionConsumeInfos.Add(new OptionConsumeInfo(8, 3, auto: true));
        }

        private bool OnOption1VisibleCheck()
        {
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("CharacterId");
            if ((EventHelper.HasRelationBetweenCharacters(character2.GetId(), character.GetId(), 16384) || EventHelper.HasRelationBetweenCharacters(character2.GetId(), character.GetId(), 1024)) && EventHelper.GetRoleAge(character2) > 15)
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
            return "193c5bf6-d439-4bd3-96e2-ee0d8004cae7";
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("CharacterId");
            if (EventHelper.GetRoleAge(character2) > 15)
            {
                return true;
            }
            return false;
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
            return "b6ac6816-c2f5-4b74-a644-6ed1dd500a54";
        }

        public List<string> Option2GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption3Create()
        {
            EventOptions[2].OptionAvailableConditions = new List<TaiwuEventOptionConditionBase>();
            TaiwuEventOptionConditionBase item = new OptionConditionSbyte(2, 3, OptionConditionMatcher.MovePointMore);
            EventOptions[2].OptionAvailableConditions.Add(item);
            EventOptions[2].OptionConsumeInfos = new List<OptionConsumeInfo>();
            EventOptions[2].OptionConsumeInfos.Add(new OptionConsumeInfo(8, 3, auto: true));
        }

        private bool OnOption3VisibleCheck()
        {
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("CharacterId");
            if (EventHelper.GetRoleAge(character2) > 15)
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
            return "49ac3b13-bd1c-491d-9d34-3a6fd6ec0a22";
        }

        public List<string> Option3GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}