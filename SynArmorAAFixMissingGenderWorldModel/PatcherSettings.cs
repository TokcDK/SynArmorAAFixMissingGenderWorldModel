using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynArmorAAFixMissingGenderWorldModel
{
    public class ArmorTemplate2
    {
        public FormLink<IKeywordGetter>? Keyword;
        public Dictionary<BipedObjectFlag, FormLink<IArmorAddonGetter>?>? SlotArmorAddons;
    }

    public class PatcherSettings
    {
        [SynthesisSettingName("Ignore mods")]
        [SynthesisTooltip("Excluded mods")]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public HashSet<ModKey> IgnoreMods = new();

        [SynthesisTooltip("Data about keyword to detect and armor addons for slots")]
        public HashSet<ArmorTemplate2> ArmorTemplateData = new HashSet<ArmorTemplate2>();
    }
}
