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
        /// <summary>
        /// Patch a base rom with a given set of patches (passed as file paths).
        /// </summary>
        /// <param name="baseRom"></param>
        /// <param name="outputFile"></param>
        /// <param name="patchPaths">
        ///     A list of filepaths to patchfiles.
        ///     These paths must exist in the output directory.
        ///     To achieve this, the `Patches` directory is currently copied during a post-build step.
        /// </param>
        public static void Patch(Stream baseRom, Stream outputFile, List<string> patchPaths)
        {
            var patchers = patchPaths.Select(path => PatcherFactory.CreatePatcher(path)).ToList();
            PatchApplier.Patch(patchers, baseRom, outputFile);
        }
    }
}
