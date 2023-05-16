using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.DisplayEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_daad9f9868f24096a0faac8c693e8147 : TaiwuEventItem
    {
        public JTCXEvent_daad9f9868f24096a0faac8c693e8147()
        {
            Guid = Guid.Parse("daad9f98-68f2-4096-a0fa-ac8c693e8147");
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
                OptionKey = "Option_-1063780612"
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
            EventInputRequestData eventInputRequestData = new EventInputRequestData();
            eventInputRequestData.DataKey = "InputResult2";
            eventInputRequestData.InputDataType = 3;
            eventInputRequestData.NumberRange = new int[2] { 1, 10 };
            ArgBox.Set("InputRequestData", eventInputRequestData);
            EventHelper.AddEventInListenWithActionName(Guid.ToString(), ArgBox, "InputActionComplete");
        }

        public override void OnEventExit()
        {
            EventHelper.AddEventInListen(string.Empty, null);
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
            string arg = string.Empty;
            if (ArgBox.Get("InputResult2", ref arg))
            {
                ArgBox.Set("chengweiduifang", arg);
            }
            string arg2 = "";
            ArgBox.Get("chengweitaiwu", ref arg2);
            Character character = ArgBox.GetCharacter("ren");
            Character character2 = ArgBox.GetCharacter("RoleTaiwu");
            string val = "1";
            string text = character2.GetId().ToString();
            if (!TaiwuEvent.GetModData("ChengWei", isArchive: true, ref val))
            {
                val = character2.GetId().ToString();
            }
            string[] array = val.Split(',');
            bool flag = false;
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    string[] array2 = array[i].Split('|');
                    int num = int.Parse(array2[0]);
                    if (num == character.GetId())
                    {
                        for (int j = 1; j < array.Length; j++)
                        {
                            text = ((j == i) ? (text + "," + character.GetId() + "|" + arg2 + "|" + arg) : (text + "," + array[j]));
                        }
                        flag = true;
                    }
                }
                if (flag)
                {
                    TaiwuEvent.SetModString("ChengWei", isArchive: true, text);
                }
                else
                {
                    TaiwuEvent.SetModString("ChengWei", isArchive: true, val + "," + character.GetId() + "|" + arg2 + "|" + arg);
                }
            }
            else
            {
                TaiwuEvent.SetModString("ChengWei", isArchive: true, val + "," + character.GetId() + "|" + arg2 + "|" + arg);
            }
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}