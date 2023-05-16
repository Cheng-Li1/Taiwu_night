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
    public class JTCXEvent_44520d311b9b40cd98b760385262d78e : TaiwuEventItem
    {
        public JTCXEvent_44520d311b9b40cd98b760385262d78e()
        {
            Guid = Guid.Parse("44520d31-1b9b-40cd-98b7-60385262d78e");
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
                OptionKey = "Option_1606777187"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_2036475454"
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
            int arg = 0;
            ArgBox.Get("kunbang", ref arg);
            if (arg > 0)
            {
                ArgBox.Set("kunbang", arg - 1);
            }
            ArgBox.Set("huandujixugankunbang", arg: true);
            ArgBox.Set("huandujixugan", arg: true);
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