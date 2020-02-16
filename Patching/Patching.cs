using patch_applier;
using patch_applier.PatchFileDescription;
using patch_manager.Patchers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace SuperMetroidRandomizer.Patching
{
    public static class Patching
    {
        public static void Patch(Stream baseRom, Stream outputFile)
        {
            // These paths must exist in the output directory.
            // To achieve this, the `Patches` directory is copied during a post-build step.
            List<string> patchPaths = new List<string>
            {
                "Patches/Project Base 073.ips",
                "Patches/Disable Suit Animation.IPS",
                "Patches/Fix attic.IPS",
                "Patches/introskip_doorflags.ips",
                "Patches/JAMMorphingBallFix.IPS",
                "Patches/spospo doorfix.IPS",
                "Patches/Super Metroid Item Sounds.IPS",
                "Patches/ZebesAwakens for SMPB073.IPS",
            };

            var patchers = patchPaths.Select(path => PatcherFactory.CreatePatcher(path)).ToList();
            PatchApplier.Patch(patchers, baseRom, outputFile);
        }
    }
}
