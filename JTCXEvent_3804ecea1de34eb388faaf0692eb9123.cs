using System;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains;
using GameData.Domains.Character;
using GameData.Domains.Combat;
using GameData.Domains.Item;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;

namespace Modder_76561198211789445.EventConfig.Taiwu.EventGroup1400fef7bec0446382eabb61aa9fc7c8
{
    public class JTCXEvent_3804ecea1de34eb388faaf0692eb9123 : TaiwuEventItem
    {
        public JTCXEvent_3804ecea1de34eb388faaf0692eb9123()
        {
            Guid = Guid.Parse("3804ecea-1de3-4eb3-88fa-af0692eb9123");
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
            EscOptionKey = "Option_1339879668";
            EventOptions = new TaiwuEventOption[10]
            {
            new TaiwuEventOption
            {
                OptionKey = "Option_-950515739"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-545741104"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_503068726"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-733528454"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1223969164"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_571364726"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_386695015"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_-175301048"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_14874813"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1339879668"
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
            EventOptions[3].OnOptionVisibleCheck = OnOption4VisibleCheck;
            EventOptions[3].OnOptionAvailableCheck = OnOption4AvailableCheck;
            EventOptions[3].GetReplacedContent = OnOption4GetReplacedContent;
            EventOptions[3].OnOptionSelect = OnOption4Select;
            EventOptions[3].GetExtraFormatLanguageKeys = Option4GetExtraFormatLanguageKeys;
            OnOption4Create();
            EventOptions[4].OnOptionVisibleCheck = OnOption5VisibleCheck;
            EventOptions[4].OnOptionAvailableCheck = OnOption5AvailableCheck;
            EventOptions[4].GetReplacedContent = OnOption5GetReplacedContent;
            EventOptions[4].OnOptionSelect = OnOption5Select;
            EventOptions[4].GetExtraFormatLanguageKeys = Option5GetExtraFormatLanguageKeys;
            OnOption5Create();
            EventOptions[5].OnOptionVisibleCheck = OnOption6VisibleCheck;
            EventOptions[5].OnOptionAvailableCheck = OnOption6AvailableCheck;
            EventOptions[5].GetReplacedContent = OnOption6GetReplacedContent;
            EventOptions[5].OnOptionSelect = OnOption6Select;
            EventOptions[5].GetExtraFormatLanguageKeys = Option6GetExtraFormatLanguageKeys;
            OnOption6Create();
            EventOptions[6].OnOptionVisibleCheck = OnOption7VisibleCheck;
            EventOptions[6].OnOptionAvailableCheck = OnOption7AvailableCheck;
            EventOptions[6].GetReplacedContent = OnOption7GetReplacedContent;
            EventOptions[6].OnOptionSelect = OnOption7Select;
            EventOptions[6].GetExtraFormatLanguageKeys = Option7GetExtraFormatLanguageKeys;
            OnOption7Create();
            EventOptions[7].OnOptionVisibleCheck = OnOption8VisibleCheck;
            EventOptions[7].OnOptionAvailableCheck = OnOption8AvailableCheck;
            EventOptions[7].GetReplacedContent = OnOption8GetReplacedContent;
            EventOptions[7].OnOptionSelect = OnOption8Select;
            EventOptions[7].GetExtraFormatLanguageKeys = Option8GetExtraFormatLanguageKeys;
            OnOption8Create();
            EventOptions[8].OnOptionVisibleCheck = OnOption9VisibleCheck;
            EventOptions[8].OnOptionAvailableCheck = OnOption9AvailableCheck;
            EventOptions[8].GetReplacedContent = OnOption9GetReplacedContent;
            EventOptions[8].OnOptionSelect = OnOption9Select;
            EventOptions[8].GetExtraFormatLanguageKeys = Option9GetExtraFormatLanguageKeys;
            OnOption9Create();
            EventOptions[9].OnOptionVisibleCheck = OnOption10VisibleCheck;
            EventOptions[9].OnOptionAvailableCheck = OnOption10AvailableCheck;
            EventOptions[9].GetReplacedContent = OnOption10GetReplacedContent;
            EventOptions[9].OnOptionSelect = OnOption10Select;
            EventOptions[9].GetExtraFormatLanguageKeys = Option10GetExtraFormatLanguageKeys;
            OnOption10Create();
        }

        public override bool OnCheckEventCondition()
        {
            return true;
        }

        public override void OnEventEnter()
        {
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            Character character2 = new Character();
            int arg = -1;
            character2 = ((!ArgBox.Get("SelectedCharacterId", ref arg)) ? ArgBox.GetCharacter("CharacterId") : ArgBox.GetCharacter("SelectedCharacterId"));
            int arg2 = 0;
            if (!ArgBox.Get("kaishi", ref arg2))
            {
                int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 4);
                int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character2, 4);
                ArgBox.Set("tili1", (int)(100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025)));
                ArgBox.Set("xinshen1", 0);
                ArgBox.Set("xingfen1", 0);
                ArgBox.Set("kuaigan1", 0);
                ArgBox.Set("kuaigan12", 0);
                ArgBox.Set("tili2", (int)(100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025)));
                ArgBox.Set("xinshen2", 0);
                ArgBox.Set("xingfen2", 0);
                ArgBox.Set("kuaigan2", 0);
                ArgBox.Set("kuaigan22", 0);
                ArgBox.Set("zishi", 0);
                ArgBox.Set("ppzishi", "无");
                ArgBox.Set("zhankuang", "双方蓄势待发");
                ArgBox.Set("kaishi", 1);
                ArgBox.Set("ren", character2.GetId());
                ArgBox.Set("kunbang", 0);
                ArgBox.Set("gongfacishu", 3);
                ArgBox.Set("gaochao1count", 0);
                ArgBox.Set("gaochao2count", 0);
                ArgBox.Set("neishecount", 0);
                ArgBox.Set("huiheshu", 0);
                int arg3 = 0;
                ArgBox.Get("mode", ref arg3);
                if (arg3 != 0)
                {
                    ArgBox.Set("juedouxp", EventHelper.GetRandom(1000, 10000));
                }
                ArgBox.Set("sex1", character.GetGender());
                ArgBox.Set("sex2", character2.GetGender());
                if (character2.GetGender() != 0 && character2.GetGender() != 1)
                {
                    ArgBox.Set("sex2", character2.GetAvatar().GetGender());
                }
                if (character.GetFeatureIds().Contains(168))
                {
                    ArgBox.Set("sex1", 0);
                }
                if (character2.GetFeatureIds().Contains(170))
                {
                    ArgBox.Set("sex2", 0);
                }
                if (character.GetFeatureIds().Contains(170))
                {
                    ArgBox.Set("sex1", 2);
                }
                if (character2.GetFeatureIds().Contains(170))
                {
                    ArgBox.Set("sex2", 2);
                }
                bool arg4 = false;
                if (ArgBox.Get("jianbing", ref arg4) && arg4 && character.GetGender() == 0)
                {
                    ArgBox.Set("sex1", 2);
                }
                DomainManager.LifeRecord.GetLifeRecordCollection().AddMakeLoveIllegal(character.GetId(), DomainManager.World.GetCurrDate(), character2.GetId(), character.GetLocation());
                EventHelper.CommitLifeRecords();
                bool val = false;
                DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "miwen", ref val);
                if (val)
                {
                    int dataOffset = DomainManager.Information.GetSecretInformationCollection().AddMakeLoveIllegal(character.GetId(), character2.GetId());
                    int metaDataId = DomainManager.Information.AddSecretInformationMetaData(DomainManager.TaiwuEvent.MainThreadDataContext, dataOffset);
                    EventHelper.DistributeSecretInformationToCharacter(metaDataId, DomainManager.Taiwu.GetTaiwuCharId());
                }
                bool arg5 = false;
                if (EventHelper.CheckHasRelationship(character, character2, 1) || EventHelper.CheckHasRelationship(character, character2, 8) || EventHelper.CheckHasRelationship(character, character2, 64))
                {
                    if (character2.GetGender() == 1 && character.GetGender() == 1)
                    {
                        ArgBox.Set("chengweitaiwu", "爸爸");
                        ArgBox.Set("chengweiduifang", "儿子");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 0)
                    {
                        ArgBox.Set("chengweitaiwu", "爸爸");
                        ArgBox.Set("chengweiduifang", "女儿");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 1)
                    {
                        ArgBox.Set("chengweitaiwu", "妈妈");
                        ArgBox.Set("chengweiduifang", "儿子");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 0)
                    {
                        ArgBox.Set("chengweitaiwu", "妈妈");
                        ArgBox.Set("chengweiduifang", "女儿");
                    }
                }
                else if (EventHelper.CheckHasRelationship(character, character2, 2) || EventHelper.CheckHasRelationship(character, character2, 16) || EventHelper.CheckHasRelationship(character, character2, 128))
                {
                    if (character2.GetGender() == 1 && character.GetGender() == 1)
                    {
                        ArgBox.Set("chengweitaiwu", "儿子");
                        ArgBox.Set("chengweiduifang", "爸爸");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 0)
                    {
                        ArgBox.Set("chengweitaiwu", "儿子");
                        ArgBox.Set("chengweiduifang", "妈妈");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 1)
                    {
                        ArgBox.Set("chengweitaiwu", "女儿");
                        ArgBox.Set("chengweiduifang", "爸爸");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 0)
                    {
                        ArgBox.Set("chengweitaiwu", "女儿");
                        ArgBox.Set("chengweiduifang", "妈妈");
                    }
                }
                else if (EventHelper.CheckHasRelationship(character, character2, 4) || EventHelper.CheckHasRelationship(character, character2, 32) || EventHelper.CheckHasRelationship(character, character2, 256))
                {
                    if (character2.GetGender() == 1 && character.GetGender() == 1 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "弟弟");
                        ArgBox.Set("chengweiduifang", "哥哥");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 1 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "哥哥");
                        ArgBox.Set("chengweiduifang", "弟弟");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 0 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "弟弟");
                        ArgBox.Set("chengweiduifang", "姐姐");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 0 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "哥哥");
                        ArgBox.Set("chengweiduifang", "妹妹");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 1 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "妹妹");
                        ArgBox.Set("chengweiduifang", "哥哥");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 1 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "姐姐");
                        ArgBox.Set("chengweiduifang", "弟弟");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 0 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "妹妹");
                        ArgBox.Set("chengweiduifang", "姐姐");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 0 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "姐姐");
                        ArgBox.Set("chengweiduifang", "妹妹");
                    }
                }
                else if (EventHelper.CheckHasRelationship(character, character2, 2048))
                {
                    ArgBox.Set("chengweitaiwu", "师傅");
                    ArgBox.Set("chengweiduifang", "徒儿");
                }
                else if (EventHelper.CheckHasRelationship(character, character2, 4096))
                {
                    ArgBox.Set("chengweitaiwu", "徒儿");
                    ArgBox.Set("chengweiduifang", "师傅");
                }
                else if (EventHelper.CheckHasRelationship(character, character2, 512))
                {
                    if (character2.GetGender() == 1 && character.GetGender() == 1 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "弟弟");
                        ArgBox.Set("chengweiduifang", "哥哥");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 1 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "哥哥");
                        ArgBox.Set("chengweiduifang", "弟弟");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 0 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "弟弟");
                        ArgBox.Set("chengweiduifang", "姐姐");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 0 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "哥哥");
                        ArgBox.Set("chengweiduifang", "妹妹");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 1 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "妹妹");
                        ArgBox.Set("chengweiduifang", "哥哥");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 1 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "姐姐");
                        ArgBox.Set("chengweiduifang", "弟弟");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 0 && EventHelper.GetRoleAge(character) >= EventHelper.GetRoleAge(character2))
                    {
                        ArgBox.Set("chengweitaiwu", "妹妹");
                        ArgBox.Set("chengweiduifang", "姐姐");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 0 && EventHelper.GetRoleAge(character2) > EventHelper.GetRoleAge(character))
                    {
                        ArgBox.Set("chengweitaiwu", "姐姐");
                        ArgBox.Set("chengweiduifang", "妹妹");
                    }
                }
                else if (ArgBox.Get("enren", ref arg5))
                {
                    string item = DomainManager.Character.GetRealName(character2.GetId()).givenName;
                    ArgBox.Set("chengweitaiwu", item);
                    ArgBox.Set("chengweiduifang", "恩公");
                }
                else if (EventHelper.CheckHasRelationship(character, character2, 32768))
                {
                    ArgBox.Set("chengweitaiwu", "贱人");
                    ArgBox.Set("chengweiduifang", "贱人");
                }
                else if (EventHelper.CheckHasRelationship(character, character2, 1024) || EventHelper.CheckHasRelationship(character, character2, 16384))
                {
                    if (character2.GetGender() == 1 && character.GetGender() == 1)
                    {
                        ArgBox.Set("chengweitaiwu", "夫君");
                        ArgBox.Set("chengweiduifang", "夫君");
                    }
                    if (character2.GetGender() == 1 && character.GetGender() == 0)
                    {
                        ArgBox.Set("chengweitaiwu", "夫君");
                        ArgBox.Set("chengweiduifang", "夫人");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 1)
                    {
                        ArgBox.Set("chengweitaiwu", "夫人");
                        ArgBox.Set("chengweiduifang", "夫君");
                    }
                    if (character2.GetGender() == 0 && character.GetGender() == 0)
                    {
                        ArgBox.Set("chengweitaiwu", "夫人");
                        ArgBox.Set("chengweiduifang", "夫人");
                    }
                }
                else
                {
                    string item2 = DomainManager.Character.GetRealName(character2.GetId()).givenName;
                    string item3 = DomainManager.Character.GetRealName(character.GetId()).givenName;
                    ArgBox.Set("chengweitaiwu", item2);
                    ArgBox.Set("chengweiduifang", item3);
                }
                string val2 = "1";
                if (TaiwuEvent.GetModData("ChengWei", isArchive: true, ref val2))
                {
                    string[] array = val2.Split(',');
                    if (array.Length > 1)
                    {
                        for (int i = 1; i < array.Length; i++)
                        {
                            string[] array2 = array[i].Split('|');
                            int num = int.Parse(array2[0]);
                            if (num == character2.GetId())
                            {
                                ArgBox.Set("chengweitaiwu", array2[1]);
                                ArgBox.Set("chengweiduifang", array2[2]);
                            }
                        }
                    }
                }
                if (character2.HasVirginity() && character2.GetCreatingType() == 1)
                {
                    EventHelper.ToEvent("5877fe93-9663-482e-85c0-ec3b5e3cfcb4");
                }
                int roleBehavior = EventHelper.GetRoleBehavior(character2);
                if (roleBehavior < 3)
                {
                    int random = EventHelper.GetRandom(1, 3);
                    if (random == 1)
                    {
                        EventHelper.ToEvent("dc222b89-ea26-4fc4-819f-0fd413ef41a2");
                    }
                }
                else
                {
                    int currMainAttribute = character.GetCurrMainAttribute(0);
                    int currMainAttribute2 = character2.GetCurrMainAttribute(0);
                    if (currMainAttribute2 > currMainAttribute)
                    {
                        EventHelper.ToEvent("dc222b89-ea26-4fc4-819f-0fd413ef41a2");
                    }
                    else
                    {
                        int random2 = EventHelper.GetRandom(1, 3);
                        if (random2 == 1)
                        {
                            EventHelper.ToEvent("dc222b89-ea26-4fc4-819f-0fd413ef41a2");
                        }
                    }
                }
            }
            int arg6 = 0;
            ArgBox.Get("xingfen1", ref arg6);
            int arg7 = 0;
            ArgBox.Get("kuaigan1", ref arg7);
            int arg8 = 0;
            ArgBox.Get("xingfen2", ref arg8);
            int arg9 = 0;
            ArgBox.Get("kuaigan2", ref arg9);
            if (arg6 > 50 && arg8 > 50)
            {
                ArgBox.Set("zhankuang", "双方情到深处，缠绵温存。");
            }
            if (arg7 > 150 && arg9 > 150)
            {
                ArgBox.Set("zhankuang", "双方难舍难分，直奔高潮。");
            }
            int arg10 = 0;
            if (ArgBox.Get("gaochao", ref arg10) && arg10 != 0)
            {
                ArgBox.Set("zhankuang", "云雨之巅，如登仙境。");
                ArgBox.Set("gaochao", 0);
                if (character.GetGender() == 0 || character2.GetGender() == 0)
                {
                    EventBackground = "waishe";
                    EventHelper.SetEventSeriesTexture("waishe");
                }
            }
            int arg11 = 0;
            ArgBox.Get("zishi", ref arg11);
            switch (arg11)
            {
                case 1:
                    ArgBox.Set("ppzishi", "传教士");
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 2:
                    ArgBox.Set("ppzishi", "老汉推车");
                    EventBackground = "houru";
                    EventHelper.SetEventSeriesTexture("houru");
                    break;
                case 3:
                    ArgBox.Set("ppzishi", "火车便当");
                    EventBackground = "huochebiandang2";
                    EventHelper.SetEventSeriesTexture("huochebiandang2");
                    break;
                case 4:
                    ArgBox.Set("ppzishi", "侧交位");
                    EventBackground = "ceru2";
                    EventHelper.SetEventSeriesTexture("ceru2");
                    break;
                case 5:
                    ArgBox.Set("ppzishi", "打桩机");
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 6:
                    ArgBox.Set("ppzishi", "骑乘位");
                    EventBackground = "qicheng";
                    EventHelper.SetEventSeriesTexture("qicheng");
                    break;
                case 11:
                    ArgBox.Set("ppzishi", "被骑乘");
                    EventBackground = "qicheng";
                    EventHelper.SetEventSeriesTexture("qicheng");
                    break;
                case 12:
                    ArgBox.Set("ppzishi", "逆打桩机");
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 13:
                    ArgBox.Set("ppzishi", "逆火车便当");
                    EventBackground = "huochebiandang2";
                    EventHelper.SetEventSeriesTexture("huochebiandang2");
                    break;
                case 14:
                    ArgBox.Set("ppzishi", "逆老汉推车");
                    EventBackground = "houru";
                    EventHelper.SetEventSeriesTexture("houru");
                    break;
                case 15:
                    ArgBox.Set("ppzishi", "逆侧交位");
                    EventBackground = "ceru2";
                    EventHelper.SetEventSeriesTexture("ceru2");
                    break;
                case 16:
                    ArgBox.Set("ppzishi", "逆传教士");
                    EventBackground = "chuanjiaoshi";
                    EventHelper.SetEventSeriesTexture("chuanjiaoshi");
                    break;
                case 21:
                    ArgBox.Set("ppzishi", "69");
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    break;
                case 22:
                    ArgBox.Set("ppzishi", "对坐位");
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    break;
                case 30:
                    ArgBox.Set("ppzishi", "口交");
                    EventBackground = "koujiao2";
                    EventHelper.SetEventSeriesTexture("koujiao2");
                    break;
                case 31:
                    ArgBox.Set("ppzishi", "足交");
                    EventBackground = "zujiao1";
                    EventHelper.SetEventSeriesTexture("zujiao1");
                    break;
                case 32:
                    ArgBox.Set("ppzishi", "乳交");
                    EventBackground = "rujiao";
                    EventHelper.SetEventSeriesTexture("rujiao");
                    break;
                case 33:
                    ArgBox.Set("ppzishi", "贴贴");
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    break;
                default:
                    EventBackground = "";
                    EventHelper.SetEventSeriesTexture("");
                    break;
            }
            List<short> charCombatSkillList = EventHelper.GetCharCombatSkillList(character.GetId(), -1, -1, 0, 8);
            List<short> list = new List<short> { 724 };
            if (!charCombatSkillList.Contains(724))
            {
                EventHelper.LearnCombatSkill(character.GetId(), 724);
            }
            if (charCombatSkillList.Contains(289))
            {
                list.Add(289);
            }
            EventHelper.CreateCombatSkillSelectRequestOfCharacter(this, 6, character.GetId(), "SelectedCombatSkillId", list);
            Character character3 = character2;
            if (!EventHelper.IsCharacterNaked(character2.GetId()) && EventHelper.GetRoleAge(character2) > 15)
            {
                ItemKey[] equipment = character3.GetEquipment();
                ArgBox.Set("nvyifu", equipment[4]);
                character2.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, 4, -1, equipment[4]);
            }
            if (!EventHelper.IsCharacterNaked(character.GetId()) && EventHelper.GetRoleAge(character) > 15)
            {
                ItemKey[] equipment2 = character.GetEquipment();
                ArgBox.Set("nanyifu", equipment2[4]);
                character.ChangeEquipment(DomainManager.TaiwuEvent.MainThreadDataContext, 4, -1, equipment2[4]);
            }
        }

        public override void OnEventExit()
        {
        }

        public override string GetReplacedContentString()
        {
            int arg = 0;
            ArgBox.Get("sex1", ref arg);
            int arg2 = 0;
            ArgBox.Get("sex2", ref arg2);
            string text = "";
            if (arg != 2)
            {
                text = "<Character key=RoleTaiwu str=Name/>：体力值：<color=#darkred><ArgBox key=tili1 type=int/></color>   心神值：<color=#darkred><ArgBox key=xinshen1 type=int/></color>   兴奋值：<color=#darkred><ArgBox key=xingfen1 type=int/></color>   快感值：<color=#darkred><ArgBox key=kuaigan1 type=int/></color>";
            }
            if (arg == 2)
            {
                text = "<Character key=RoleTaiwu str=Name/>：体力值：<color=#darkred><ArgBox key=tili1 type=int/></color>   心神值：<color=#darkred><ArgBox key=xinshen1 type=int/></color>   兴奋值：<color=#darkred><ArgBox key=xingfen1 type=int/></color>   快感值1：<color=#darkred><ArgBox key=kuaigan1 type=int/></color>   快感值2：<color=#darkred><ArgBox key=kuaigan12 type=int/></color>";
            }
            if (arg2 != 2)
            {
                text += "\n<Character key=ren str=Name/>：体力值：<color=#darkred><ArgBox key=tili2 type=int/></color>   心神值：<color=#darkred><ArgBox key=xinshen2 type=int/></color>   兴奋值：<color=#darkred><ArgBox key=xingfen2 type=int/></color>   快感值：<color=#darkred><ArgBox key=kuaigan2 type=int/></color>";
            }
            if (arg2 == 2)
            {
                text += "\n<Character key=ren str=Name/>：体力值：<color=#darkred><ArgBox key=tili2 type=int/></color>   心神值：<color=#darkred><ArgBox key=xinshen2 type=int/></color>   兴奋值：<color=#darkred><ArgBox key=xingfen2 type=int/></color>   快感值1：<color=#darkred><ArgBox key=kuaigan2 type=int/></color>   快感值2：<color=#darkred><ArgBox key=kuaigan22 type=int/></color>";
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
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            if (arg >= 80)
            {
                return "d79b987c-b5ba-4f7c-9942-71c0e4f3dd6d";
            }
            return "75b92dda-9abb-4b58-a65d-1bfacf728bd0";
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
            ArgBox.Get("xinshen1", ref arg);
            if (arg >= 80)
            {
                return "d79b987c-b5ba-4f7c-9942-71c0e4f3dd6d";
            }
            return "3e316d4c-6210-4d9b-a253-ef3645eef9b9";
        }

        public List<string> Option2GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption3Create()
        {
        }

        private bool OnOption3VisibleCheck()
        {
            return true;
        }

        private bool OnOption3AvailableCheck()
        {
            int arg = 0;
            ArgBox.Get("zishi", ref arg);
            int arg2 = 0;
            ArgBox.Get("tili1", ref arg2);
            if (arg != 0 && arg != 21 && arg < 30 && arg2 > 0)
            {
                return true;
            }
            return false;
        }

        private string OnOption3GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption3Select()
        {
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            if (arg >= 80)
            {
                return "d79b987c-b5ba-4f7c-9942-71c0e4f3dd6d";
            }
            return "4b35ea49-f548-44e3-af57-c2dea7db523e";
        }

        public List<string> Option3GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption4Create()
        {
        }

        private bool OnOption4VisibleCheck()
        {
            return true;
        }

        private bool OnOption4AvailableCheck()
        {
            return true;
        }

        private string OnOption4GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption4Select()
        {
            Character character = ArgBox.GetCharacter("RoleTaiwu");
            int roleCurrentMainAttributes = EventHelper.GetRoleCurrentMainAttributes(character, 4);
            int arg = 0;
            ArgBox.Get("tili1", ref arg);
            if (arg <= (int)(100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025) - 10.0))
            {
                ArgBox.Set("tili1", arg + 10);
            }
            else
            {
                ArgBox.Set("tili1", (int)(100.0 * (1.0 + (double)roleCurrentMainAttributes * 0.0025)));
            }
            int arg2 = 0;
            ArgBox.Get("kuaigan1", ref arg2);
            int arg3 = 0;
            ArgBox.Get("kuaigan12", ref arg3);
            int arg4 = 0;
            ArgBox.Get("xinshen1", ref arg4);
            int arg5 = 0;
            ArgBox.Get("kuaigan2", ref arg5);
            int arg6 = 0;
            ArgBox.Get("kuaigan22", ref arg6);
            Character character2 = ArgBox.GetCharacter("ren");
            int roleCurrentMainAttributes2 = EventHelper.GetRoleCurrentMainAttributes(character, 3);
            int roleCurrentMainAttributes3 = EventHelper.GetRoleCurrentMainAttributes(character2, 3);
            int arg7 = 0;
            ArgBox.Get("sex1", ref arg7);
            int arg8 = 0;
            ArgBox.Get("sex2", ref arg8);
            if (arg4 >= 3)
            {
                ArgBox.Set("xinshen1", arg4 - 3);
            }
            if (arg7 != 2 && arg8 != 2)
            {
                if ((double)arg2 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) && (double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)arg2 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
            }
            if (arg7 == 2 && arg8 != 2)
            {
                if (((double)arg2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) || (double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025)) && (double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)arg2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)arg5 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
            }
            if (arg7 != 2 && arg8 == 2)
            {
                if (((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025) || (double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025)) && (double)arg2 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)arg2 >= 200.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
            }
            if (arg7 == 2 && arg8 == 2)
            {
                if (((double)arg2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025) || (double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025)) && ((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025) || (double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025)))
                {
                    return "ea0136f9-33e9-4843-8bd4-b17170a531fc";
                }
                if ((double)arg5 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)arg6 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes3 * 0.0025))
                {
                    return "b89992cd-8eb7-47ec-83d5-6598f8efc6f2";
                }
                if ((double)arg2 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
                if ((double)arg3 >= 100.0 * (1.0 + (double)roleCurrentMainAttributes2 * 0.0025))
                {
                    return "adb6cf89-3b4b-46a7-8662-4897a276e5c9";
                }
            }
            return "dc222b89-ea26-4fc4-819f-0fd413ef41a2";
        }

        public List<string> Option4GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption5Create()
        {
        }

        private bool OnOption5VisibleCheck()
        {
            return true;
        }

        private bool OnOption5AvailableCheck()
        {
            return true;
        }

        private string OnOption5GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption5Select()
        {
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            if (arg >= 80)
            {
                return "d79b987c-b5ba-4f7c-9942-71c0e4f3dd6d";
            }
            return "9492f03e-d6f1-4cee-af4f-a593e15fbdb7";
        }

        public List<string> Option5GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption6Create()
        {
        }

        private bool OnOption6VisibleCheck()
        {
            return true;
        }

        private bool OnOption6AvailableCheck()
        {
            return true;
        }

        private string OnOption6GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption6Select()
        {
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            if (arg >= 80)
            {
                return "d79b987c-b5ba-4f7c-9942-71c0e4f3dd6d";
            }
            return "65979702-3cdd-49d4-bc5d-c8f095f3f81f";
        }

        public List<string> Option6GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption7Create()
        {
        }

        private bool OnOption7VisibleCheck()
        {
            CombatCharacter combatCharacter = DomainManager.Combat.GetCombatCharacter(isAlly: false);
            if (combatCharacter != null)
            {
                return false;
            }
            return true;
        }

        private bool OnOption7AvailableCheck()
        {
            return true;
        }

        private string OnOption7GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption7Select()
        {
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            if (arg >= 80)
            {
                return "d79b987c-b5ba-4f7c-9942-71c0e4f3dd6d";
            }
            return "f412bfcf-87f0-419b-94dc-0977a0760e19";
        }

        public List<string> Option7GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption8Create()
        {
        }

        private bool OnOption8VisibleCheck()
        {
            return true;
        }

        private bool OnOption8AvailableCheck()
        {
            return true;
        }

        private string OnOption8GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption8Select()
        {
            int arg = 0;
            ArgBox.Get("xinshen1", ref arg);
            if (arg >= 80)
            {
                return "d79b987c-b5ba-4f7c-9942-71c0e4f3dd6d";
            }
            return "d77d6db0-c1d8-4e90-a314-3197f6c55051";
        }

        public List<string> Option8GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption9Create()
        {
        }

        private bool OnOption9VisibleCheck()
        {
            return true;
        }

        private bool OnOption9AvailableCheck()
        {
            return true;
        }

        private string OnOption9GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption9Select()
        {
            return "02df9888-760d-4ae8-b6d4-a903c9c738f9";
        }

        public List<string> Option9GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption10Create()
        {
        }

        private bool OnOption10VisibleCheck()
        {
            return true;
        }

        private bool OnOption10AvailableCheck()
        {
            return true;
        }

        private string OnOption10GetReplacedContent()
        {
            return string.Empty;
        }

        private string OnOption10Select()
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
            if (EventHelper.GetFavorabilityType(characterById, character) >= 5)
            {
                EventHelper.EndRelation(arg, character.GetId(), 32768);
                EventHelper.EndRelation(character.GetId(), arg, 32768);
            }
            string arg4 = "";
            int arg5 = 0;
            ArgBox.Get("mode", ref arg5);
            if (arg5 == 1)
            {
                if (characterById.GetCreatingType() == 1)
                {
                    int val = 0;
                    DomainManager.Mod.GetSetting(TaiwuEvent.EventConfig.Package.ModIdString, "neili", ref val);
                    int neiliType = character.GetNeiliType();
                    int neiliType2 = characterById.GetNeiliType();
                    int num = 0;
                    int num2 = 0;
                    if (neiliType == 0 || (neiliType > 5 && neiliType < 12))
                    {
                        num = 1;
                    }
                    if (neiliType == 2 || (neiliType > 17 && neiliType < 24))
                    {
                        num = 2;
                    }
                    if (neiliType == 1 || (neiliType > 11 && neiliType < 18))
                    {
                        num = 3;
                    }
                    if (neiliType == 3 || (neiliType > 23 && neiliType < 30))
                    {
                        num = 4;
                    }
                    if (neiliType == 4 || neiliType > 29)
                    {
                        num = 5;
                    }
                    if (neiliType == 5)
                    {
                        num = 6;
                    }
                    if (neiliType2 == 0 || (neiliType2 > 5 && neiliType2 < 12))
                    {
                        num2 = 1;
                    }
                    if (neiliType2 == 2 || (neiliType2 > 17 && neiliType2 < 24))
                    {
                        num2 = 2;
                    }
                    if (neiliType2 == 1 || (neiliType2 > 11 && neiliType2 < 18))
                    {
                        num2 = 3;
                    }
                    if (neiliType2 == 3 || (neiliType2 > 23 && neiliType2 < 30))
                    {
                        num2 = 4;
                    }
                    if (neiliType2 == 4 || neiliType2 > 29)
                    {
                        num2 = 5;
                    }
                    if (neiliType2 == 5)
                    {
                        num2 = 6;
                    }
                    if (num == 6 || num2 == 6)
                    {
                        val = (int)((double)val * 0.7);
                    }
                    else
                    {
                        if (num2 == num + 1 || (num == 5 && num2 == 1))
                        {
                            val = (int)((double)val * 1.25);
                        }
                        if (num == num2 + 1 || (num == 1 && num2 == 5))
                        {
                            val = (int)((double)val * 0.75);
                        }
                        if (num2 == num + 2 || (num == 4 && num2 == 1) || (num == 5 && num2 == 2))
                        {
                            val = (int)((double)val * 0.5);
                        }
                        if (num == num2 + 2 || (num2 == 4 && num == 1) || (num2 == 5 && num == 2))
                        {
                            val = (int)((double)val * 1.5);
                        }
                    }
                    if (character.GetPureCurrNeili() < val)
                    {
                        character.SpecifyBaseNeiliAllocation(DomainManager.TaiwuEvent.MainThreadDataContext, default(NeiliAllocation));
                        character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 0);
                    }
                    else if (character.GetCurrNeili() >= val)
                    {
                        character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character.GetCurrNeili() - val);
                    }
                    else
                    {
                        int currNeili = character.GetCurrNeili();
                        while (currNeili < val)
                        {
                            int num3 = 0;
                            while (num3 == 0)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 0))
                                {
                                    if (character.GetCurrNeili() >= val)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 1;
                                }
                            }
                            while (num3 == 1)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 1))
                                {
                                    if (character.GetCurrNeili() >= val)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 2;
                                }
                            }
                            while (num3 == 2)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 2))
                                {
                                    if (character.GetCurrNeili() >= val)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 3;
                                }
                            }
                            while (num3 == 3)
                            {
                                if (character.DeallocateNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 3))
                                {
                                    if (character.GetCurrNeili() >= val)
                                    {
                                        num3 = 5;
                                        currNeili = character.GetCurrNeili();
                                    }
                                }
                                else
                                {
                                    num3 = 4;
                                }
                            }
                        }
                        if (character.GetCurrNeili() >= val)
                        {
                            character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, character.GetCurrNeili() - val);
                        }
                        else
                        {
                            character.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, 0);
                        }
                    }
                    characterById.SetExtraNeili(characterById.GetExtraNeili() + val, DomainManager.TaiwuEvent.MainThreadDataContext);
                    characterById.SpecifyCurrNeili(DomainManager.TaiwuEvent.MainThreadDataContext, characterById.GetCurrNeili() + val);
                }
                ArgBox.Set("juedouresult", 2);
                bool arg6 = false;
                if (ArgBox.Get("zhandoucx", ref arg6))
                {
                    CombatCharacter combatCharacter = DomainManager.Combat.GetCombatCharacter(isAlly: true);
                    combatCharacter.SetNeiliAllocation(default(NeiliAllocation), DomainManager.TaiwuEvent.MainThreadDataContext);
                    return "fcde02f3-fb01-4d6d-9dad-aad96d979f63";
                }
                bool arg7 = false;
                if (ArgBox.Get("jiaoyicx", ref arg7))
                {
                    return "7da6d1a8-959f-44e5-a2bc-2e3cb41a1f5a";
                }
                if (ArgBox.Get("fanhui", ref arg4))
                {
                    return arg4;
                }
            }
            if (ArgBox.Get("fanhui", ref arg4))
            {
                return arg4;
            }
            return string.Empty;
        }

        public List<string> Option10GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}