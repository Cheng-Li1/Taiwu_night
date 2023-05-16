using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains;
using GameData.Domains.Character;
using GameData.Domains.Item;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_a08ba0ea806d409cb148824b10a1c91c : TaiwuEventItem
    {
        public JTCXEvent_a08ba0ea806d409cb148824b10a1c91c()
        {
            Guid = Guid.Parse("a08ba0ea-806d-409c-b148-824b10a1c91c");
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
            EventOptions = new TaiwuEventOption[2]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_826133536"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_36674520"
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            int arg = 0;
            ArgBox.Get("ren", ref arg);
            Character characterById = EventHelper.GetCharacterById(arg);
            if (EventHelper.CheckHasRelationship(character, characterById, 1) || EventHelper.CheckHasRelationship(character, characterById, 8) || EventHelper.CheckHasRelationship(character, characterById, 64) || EventHelper.CheckHasRelationship(character, characterById, 2) || EventHelper.CheckHasRelationship(character, characterById, 16) || EventHelper.CheckHasRelationship(character, characterById, 128) || EventHelper.CheckHasRelationship(character, characterById, 4) || EventHelper.CheckHasRelationship(character, characterById, 32) || EventHelper.CheckHasRelationship(character, characterById, 256) || EventHelper.CheckHasRelationship(character, characterById, 2048) || EventHelper.CheckHasRelationship(character, characterById, 4096) || EventHelper.CheckHasRelationship(character, characterById, 512) || EventHelper.CheckHasRelationship(character, characterById, 1024) || EventHelper.CheckHasRelationship(character, characterById, 16384))
            {
                int random = EventHelper.GetRandom(1, 6);
                if (random == 1)
                {
                    EventHelper.AddRelation(arg, character.GetId(), 32768);
                }
            }
            else
            {
                EventHelper.AddRelation(arg, character.GetId(), 32768);
            }
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
            return "e85b83d4-3d3f-411d-8825-0a7a2f60ade1";
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
            ArgBox.Get("kunbang", ref arg);
            int random = EventHelper.GetRandom(1, 5);
            if (random > 1 && arg <= 0)
            {
                return "7fa5f3ca-568a-4bbb-8cd9-3b620e90c884";
            }
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            int arg2 = 0;
            ArgBox.Get("ren", ref arg2);
            Character characterById = EventHelper.GetCharacterById(arg2);
            if (ArgBox.Get("nvyifu", out ItemKey arg3))
            {
                characterById.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg3);
            }
            if (ArgBox.Get("nanyifu", out ItemKey arg4))
            {
                character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg4);
            }
            EventBackground = "";
            EventHelper.SetEventSeriesTexture("");
            return string.Empty;
        }

        public List<string> Option2GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}