using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;

namespace SynArmorAAFixMissingGenderWorldModel
{
    [SynthesisObjectNameMember("Armor template")]
    public class ArmorTemplate
    {
        [SynthesisDiskName("Keyword")]
        public FormLink<IKeywordGetter>? Keyword;
        [SynthesisDiskName("SlotArmorAddonPairs")]
        public Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>? SlotArmorAddonPairs;
    }

    public class PatcherSettings
    {
        [SynthesisOrder]
        [SynthesisDiskName("IgnoreMods")]
        [SynthesisSettingName("Ignore mods")]
        [SynthesisTooltip("Excluded mods")]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public HashSet<ModKey> IgnoreMods = new() 
        { 
            Mutagen.Bethesda.FormKeys.SkyrimLE.Skyrim.ModKey,
            Mutagen.Bethesda.FormKeys.SkyrimLE.Update.ModKey,
            Mutagen.Bethesda.FormKeys.SkyrimLE.Dawnguard.ModKey,
            Mutagen.Bethesda.FormKeys.SkyrimLE.HearthFires.ModKey,
            Mutagen.Bethesda.FormKeys.SkyrimLE.Dragonborn.ModKey,
        };

        [SynthesisOrder]
        [SynthesisDiskName("ArmorTemplates")]
        [SynthesisTooltip("Data about keyword to detect and armor addons for slots")]
        public List<ArmorTemplate> ArmorTemplates = new()
        {
            // daedric
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBD4:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("098BB2:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("098BB3:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("098BB5:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("098BB4:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("098BB2:Skyrim.esm")} },
                }
            },
            // dragonplate
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBD5:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("06F948:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("06F94C:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("06F949:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("06F94B:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("06F948:Skyrim.esm")} },
                }
            },
            // dragonscaled
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBD6:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("059E75:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("059E74:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("059E72:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("059E73:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("059E75:Skyrim.esm")} },
                }
            },
            // ebony
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBD8:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("05B69A:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("05B69C:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("05B69B:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("05B69D:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("05B69A:Skyrim.esm")} },
                }
            },
            // glass
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBDC:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("041381:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("04137F:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("041380:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("04137E:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("041381:Skyrim.esm")} },
                }
            },
            // scaled
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBDE:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B39E:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B399:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B39C:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B396:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B39E:Skyrim.esm")} },
                }
            },
            // elven guilded
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBDA:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("08969C:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("08969A:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("08969B:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("089699:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("08969C:Skyrim.esm")} },
                }
            },
            // elven
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBD9:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("08969C:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0896A2:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("08969B:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("089699:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("08969C:Skyrim.esm")} },
                }
            },
            // dwarwen
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBD7:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03F7FF:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03F7FE:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03F7FD:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03F7FC:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03F7FF:Skyrim.esm")} },
                }
            },
            // orcish
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBE5:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("036198:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("036195:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("036197:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("036196:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("036198:Skyrim.esm")} },
                }
            },
            // steelplate
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBE7:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0E4ADD:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0E4AD7:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0E4ADB:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0E4AD9:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0E4ADD:Skyrim.esm")} },
                }
            },
            // steel
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBE6:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0179B0:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0179AE:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0179AF:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0179AD:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("0179B0:Skyrim.esm")} },
                }
            },
            // iron
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBE3:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("012E4C:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("012E48:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("012E47:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("012E4A:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("012E4C:Skyrim.esm")} },
                }
            },
            // hide
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBDD:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B39D:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B397:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B39B:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B395:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("01B39D:Skyrim.esm")} },
                }
            },
            // leather
            new ArmorTemplate()
            {
                Keyword=new FormLink<IKeywordGetter>(){ FormKey=FormKey.Factory("06BBDB:Skyrim.esm")},
                SlotArmorAddonPairs=new Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>>()
                {
                    { BipedObjectFlag.Hair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03619C:Skyrim.esm")} },
                    { BipedObjectFlag.Body, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("036199:Skyrim.esm")} },
                    { BipedObjectFlag.Hands, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03619A:Skyrim.esm")} },
                    { BipedObjectFlag.Feet, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03619B:Skyrim.esm")} },
                    { BipedObjectFlag.LongHair, new FormLink<IArmorAddonGetter>(){ FormKey=FormKey.Factory("03619C:Skyrim.esm")} },
                }
            },
        };
    }
}
