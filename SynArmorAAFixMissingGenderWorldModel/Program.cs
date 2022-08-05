using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;

namespace SynArmorAAFixMissingGenderWorldModel
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .SetTypicalOpen(GameRelease.SkyrimSE, "YourPatcher.esp")
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            // set templates data
            // iterate armors
            // skip invalid
            // get armor type to detect template
            // get armor addon
            // check world model path for female and male
            // fix by substitute missing world model file subpath by subpath from template and write aa in patch
        }
    }
}
