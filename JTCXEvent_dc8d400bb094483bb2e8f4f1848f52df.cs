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
    public class JTCXEvent_dc8d400bb094483bb2e8f4f1848f52df : TaiwuEventItem
    {
        public JTCXEvent_dc8d400bb094483bb2e8f4f1848f52df()
        {
            Guid = Guid.Parse("dc8d400b-b094-483b-b2e8-f4f1848f52df");
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
                OptionKey = "Option_418488195"
            },
            new TaiwuEventOption
            {
                OptionKey = "Option_1243859606"
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
            int arg = 0;
            ArgBox.Get("mode", ref arg);
            if (arg != 2)
            {
                return true;
            }
            return false;
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

        public List<string> Option1GetExtraFormatLanguageKeys()
        {
            return null;
        }

        private void OnOption2Create()
        {
        }

        private bool OnOption2VisibleCheck()
        {
            int arg = 0;
            ArgBox.Get("mode", ref arg);
            if (arg == 2)
            {
                return true;
            }
            return false;
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
            int roleBehavior = EventHelper.GetRoleBehavior(characterById);
            if (roleBehavior == 1 || roleBehavior == 2)
            {
                HashSet<int> relatedCharacters = EventHelper.GetRelatedCharacters(character.GetId(), 16384, aliveOnly: false);
                if (relatedCharacters != null)
                {
                    foreach (int item in relatedCharacters)
                    {
                        EventHelper.EndRelation(character.GetId(), item, 16384);
                    }
                }
                EventHelper.AddRelation(character.GetId(), arg, 16384);
                return "0e9865e5-8397-4db2-8dd4-cc70e07dea2e";
            }
            if (EventHelper.CheckHasRelationship(characterById, character, 16384))
            {
                HashSet<int> relatedCharacters2 = EventHelper.GetRelatedCharacters(character.GetId(), 16384, aliveOnly: false);
                if (relatedCharacters2 != null)
                {
                    foreach (int item2 in relatedCharacters2)
                    {
                        EventHelper.EndRelation(character.GetId(), item2, 16384);
                    }
                }
                HashSet<int> relatedCharacters3 = EventHelper.GetRelatedCharacters(character.GetId(), 1024, aliveOnly: false);
                if (relatedCharacters3 != null)
                {
                    foreach (int item3 in relatedCharacters3)
                    {
                        DomainManager.Character.ChangeRelationType(DomainManager.TaiwuEvent.MainThreadDataContext, character.GetId(), item3, 1024, 0);
                        DomainManager.Character.ChangeRelationType(DomainManager.TaiwuEvent.MainThreadDataContext, item3, character.GetId(), 1024, 0);
                    }
                }
                EventHelper.AddRelation(character.GetId(), arg, 16384);
                return "0e9865e5-8397-4db2-8dd4-cc70e07dea2e";
            }
            return "259d8297-d1b8-4afa-bcdc-14fd1b9f3ddd";
        }

        public List<string> Option2GetExtraFormatLanguageKeys()
        {
            return null;
        }
    }
}