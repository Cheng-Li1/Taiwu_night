using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_f412bfcf87f0419b94dc0977a0760e19 : TaiwuEventItem
    {
        public JTCXEvent_f412bfcf87f0419b94dc0977a0760e19()
        {
            Guid = Guid.Parse("f412bfcf-87f0-419b-94dc-0977a0760e19");
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
                OptionKey = "Option_-1522643143"
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
            short arg = 0;
            ArgBox.Get("SelectedCombatSkillId", ref arg);
            int arg2 = 0;
            ArgBox.Get("gongfacishu", ref arg2);
            if (arg2 <= 0)
            {
                ArgBox.Set("gongfashiyong", "功法次数已用完。");
                return;
            }
            switch (arg)
            {
                case 289:
                    {
                        ArgBox.Set("gongfashiyong", "<Character key=RoleTaiwu str=Name/>使出了乱情障，<Character key=ren str=Name/>感觉有点心神紊乱。");
                        ArgBox.Set("gongfacishu", arg2 - 1);
                        int arg4 = 0;
                        ArgBox.Get("xinshen2", ref arg4);
                        ArgBox.Set("xinshen2", arg4 + 10);
                        break;
                    }
                case 724:
                    {
                        ArgBox.Set("gongfashiyong", "<Character key=RoleTaiwu str=Name/>使用了沛然决，恢复了一些体力。");
                        ArgBox.Set("gongfacishu", arg2 - 1);
                        int arg3 = 0;
                        ArgBox.Get("tili1", ref arg3);
                        ArgBox.Set("tili1", arg3 + 15);
                        break;
                    }
                default:
                    ArgBox.Set("gongfashiyong", "无效果");
                    break;
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            string arg = "";
            ArgBox.Get("gongfashiyong", ref arg);
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
            ArgBox.Remove<int>("SelectedCombatSkillId");
            return "dc222b89-ea26-4fc4-819f-0fd413ef41a2";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}