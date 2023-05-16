using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.Item;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_eb118866e4aa48bdb8e65dff2f2cf50f : TaiwuEventItem
    {
        public JTCXEvent_eb118866e4aa48bdb8e65dff2f2cf50f()
        {
            Guid = Guid.Parse("eb118866-e4aa-48bd-b8e6-5dff2f2cf50f");
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
                OptionKey = "Option_313242251"
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
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            ArgBox.Get("GiftKey", out ItemKey arg);
            if (arg.ItemType == 12 && arg.TemplateId == 210 && character.GetGender() == 0)
            {
                ArgBox.Set("sex1", 2);
                ArgBox.Set("daojushiyong", "<Character key=RoleTaiwu str=Name/>使用了伏虞剑柄，变成了一根硕大的肉棒长在自己的下体。");
            }
            else if (arg.ItemType == 12 && arg.TemplateId >= 73 && arg.TemplateId <= 81)
            {
                EventHelper.ToEvent("48d1d258-61f9-402d-bcc9-cbe63ce6ee7e");
            }
            else
            {
                ArgBox.Set("daojushiyong", "无效果");
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            string arg = "";
            ArgBox.Get("daojushiyong", ref arg);
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
            return "dc222b89-ea26-4fc4-819f-0fd413ef41a2";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}