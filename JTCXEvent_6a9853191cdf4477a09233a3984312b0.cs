using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains;
using GameData.Domains.Character;
using GameData.Domains.Combat;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_6a9853191cdf4477a09233a3984312b0 : TaiwuEventItem
    {
        public JTCXEvent_6a9853191cdf4477a09233a3984312b0()
        {
            Guid = Guid.Parse("6a985319-1cdf-4477-a092-33a3984312b0");
            IsHeadEvent = true;
            EventGroup = "jutichunxiao";
            ForceSingle = false;
            EventType = EEventType.ModEvent;
            TriggerType = EventTrigger.CombatOpening;
            EventSortingOrder = short.MaxValue;
            MainRoleKey = "RoleTaiwu";
            TargetRoleKey = "CharacterId";
            EventBackground = "";
            MaskControl = 0;
            MaskTweenTime = 0f;
            EscOptionKey = "";
            EventOptions = new TaiwuEventOption[2]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_-794514078"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1139314525"
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
            int val = 0;
            DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "zhandoucx", ref val);
            Character character = ArgBox.GetCharacter("CharacterId");
            Character character2 = ArgBox.GetCharacter("RoleTaiwu");
            CombatCharacter combatCharacter = DomainManager.Combat.GetCombatCharacter(isAlly: false);
            if (val == 0 && character != null && combatCharacter != null && EventHelper.GetRoleAge(character) > 15)
            {
                return true;
            }
            if (val == 1 && character != null && combatCharacter != null && EventHelper.GetRoleAge(character) > 15 && character2.GetGender() != character.GetGender())
            {
                return true;
            }
            if (val == 2 && character != null && combatCharacter != null && EventHelper.GetRoleAge(character) > 15 && character2.GetGender() == character.GetGender())
            {
                return true;
            }
            return false;
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
            ArgBox.Set("zhandoucx", arg: true);
            ArgBox.Set("mode", 1);
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
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