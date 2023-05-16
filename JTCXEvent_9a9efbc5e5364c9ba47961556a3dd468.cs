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
    public class JTCXEvent_9a9efbc5e5364c9ba47961556a3dd468 : TaiwuEventItem
    {
        public JTCXEvent_9a9efbc5e5364c9ba47961556a3dd468()
        {
            Guid = Guid.Parse("9a9efbc5-e536-4c9b-a479-61556a3dd468");
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
                OptionKey = "Option_937480121"
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
            Character character2 = ArgBox.GetCharacter("ren");
            int arg = 0;
            ArgBox.Get("kuaigan1", ref arg);
            int arg2 = 0;
            ArgBox.Get("kuaigan12", ref arg2);
            if (arg > 0)
            {
                ArgBox.Set("kuaigan1", 0);
            }
            if (arg2 > 0)
            {
                ArgBox.Set("kuaigan12", 0);
            }
            ArgBox.Set("xingfen1", 30);
            ArgBox.Set("zishi", 0);
            ArgBox.Set("ppzishi", "无");
            ArgBox.Set("gaochao", 1);
            if (!character.GetFeatureIds().Contains(196))
            {
                character.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
            }
            if (!character2.GetFeatureIds().Contains(196))
            {
                character2.AddFeature(DomainManager.TaiwuEvent.MainThreadDataContext, 196, removeMutexFeature: true);
            }
            int arg3 = 0;
            ArgBox.Get("gaochao1count", ref arg3);
            int arg4 = 0;
            if (ArgBox.Get("gaochaotuichu1", ref arg4) && arg3 >= arg4)
            {
                string arg5 = "";
                if (ArgBox.Get("fanhui", ref arg5))
                {
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    Character character3 = character2;
                    if (ArgBox.Get("nvyifu", out ItemKey arg6))
                    {
                        character3.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg6);
                    }
                    if (ArgBox.Get("nanyifu", out ItemKey arg7))
                    {
                        character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, -1, 4, arg7);
                    }
                    return arg5;
                }
            }
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}