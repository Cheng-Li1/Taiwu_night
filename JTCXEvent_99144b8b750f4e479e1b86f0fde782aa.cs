using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_99144b8b750f4e479e1b86f0fde782aa : TaiwuEventItem
    {
        public JTCXEvent_99144b8b750f4e479e1b86f0fde782aa()
        {
            Guid = Guid.Parse("99144b8b-750f-4e47-9e1b-86f0fde782aa");
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
                OptionKey = "Option_413377217"
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
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            if (arg == 1)
            {
                ArgBox.Set("ppzishi", "传教士");
            }
            if (arg == 2)
            {
                ArgBox.Set("ppzishi", "老汉推车");
            }
            if (arg == 3)
            {
                ArgBox.Set("ppzishi", "火车便当");
            }
            if (arg == 4)
            {
                ArgBox.Set("ppzishi", "侧交位");
            }
            if (arg == 5)
            {
                ArgBox.Set("ppzishi", "打桩机");
            }
            if (arg == 6)
            {
                ArgBox.Set("ppzishi", "骑乘位");
            }
            if (arg == 11)
            {
                ArgBox.Set("ppzishi", "被骑乘");
            }
            if (arg == 12)
            {
                ArgBox.Set("ppzishi", "逆打桩机");
            }
            if (arg == 13)
            {
                ArgBox.Set("ppzishi", "逆火车便当");
            }
            if (arg == 14)
            {
                ArgBox.Set("ppzishi", "逆老汉推车");
            }
            if (arg == 15)
            {
                ArgBox.Set("ppzishi", "逆侧交位");
            }
            if (arg == 16)
            {
                ArgBox.Set("ppzishi", "逆传教士");
            }
            if (arg == 21)
            {
                ArgBox.Set("ppzishi", "69");
            }
            if (arg == 22)
            {
                ArgBox.Set("ppzishi", "对坐位");
            }
            switch (arg)
            {
                case 1:
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 2:
                    EventBackground = "houru";
                    EventHelper.SetEventSeriesTexture("houru");
                    break;
                case 3:
                    EventBackground = "huochebiandang1";
                    EventHelper.SetEventSeriesTexture("huochebiandang1");
                    break;
                case 4:
                    EventBackground = "ceru1";
                    EventHelper.SetEventSeriesTexture("ceru1");
                    break;
                case 5:
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 6:
                    EventBackground = "qicheng";
                    EventHelper.SetEventSeriesTexture("qicheng");
                    break;
                case 11:
                    EventBackground = "qicheng";
                    EventHelper.SetEventSeriesTexture("qicheng");
                    break;
                case 12:
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 13:
                    EventBackground = "huochebiandang2";
                    EventHelper.SetEventSeriesTexture("huochebiandang2");
                    break;
                case 14:
                    EventBackground = "houru";
                    EventHelper.SetEventSeriesTexture("houru");
                    break;
                case 15:
                    EventBackground = "ceru2";
                    EventHelper.SetEventSeriesTexture("ceru2");
                    break;
                case 16:
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 21:
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    break;
                case 22:
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    break;
                default:
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    break;
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = ArgBox.GetCharacter("ren");
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            string text = "";
            text = ((arg != 11) ? "<Character key=RoleTaiwu str=Name/>使用了<color=#darkred><ArgBox key=ppzishi type=string/></color>体位与<Character key=ren str=Name/>进行交合。" : "<Character key=RoleTaiwu str=Name/>让<Character key=ren str=Name/>使用了<color=#darkred><ArgBox key=ppzishi type=string/></color>体位");
            if (character2.HasVirginity() && character.GetGender() == 1)
            {
                text += "\n\"这样...能进去吗......\"";
            }
            if (character2.HasVirginity() && character.GetGender() == 0 && character2.GetGender() == 1)
            {
                text += "\n\"啊~~~原来~会这么舒服~~~\"";
            }
            if (character2.HasVirginity() && character.GetGender() == 0 && character2.GetGender() == 0)
            {
                text += "\n\"这样子~~~好奇怪啊~~~嗯~~~\"";
            }
            string targetString = string.Format(base.EventContent, text);
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
            return "3804ecea-1de3-4eb3-88fa-af0692eb9123";
        }

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}