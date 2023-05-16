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
    public class JTCXEvent_e4f78439e92341a1800df7a0c4017cbe : TaiwuEventItem
    {
        public JTCXEvent_e4f78439e92341a1800df7a0c4017cbe()
        {
            Guid = Guid.Parse("e4f78439-e923-41a1-800d-f7a0c4017cbe");
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
            EventOptions = new TaiwuEventOption[1]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_-226861758"
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
        }

        public override bool OnCheckEventCondition()
        {
            return true;
        }

        public override void OnEventEnter()
        {
            EventBackground = "";
            EventHelper.SetEventSeriesTexture("");
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
            int arg = 0;
            ArgBox.Get("ren", ref arg);
            Character characterById = EventHelper.GetCharacterById(arg);
            if (ArgBox.Get("nvyifu", out ItemKey arg2))
            {
                characterById.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg2);
            }
            if (ArgBox.Get("nanyifu", out ItemKey arg3))
            {
                character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg3);
            }
            if (!character.GetFeatureIds().Contains(168) && character.GetGender() == 1)
            {
                character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 168, removeMutexFeature: true);
            }
            if (!character.GetFeatureIds().Contains(169) && character.GetGender() == 0)
            {
                character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 169, removeMutexFeature: true);
            }
            return string.Empty;
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}