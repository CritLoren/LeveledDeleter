using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;

namespace LeveledDeleter
{
    public class Settings
    {
        // [SynthesisSettingName("Item types to look for")]
        // public List<IFormLinkGetter<ISkyrimMajorRecordGetter>> ItemTypeToRemove { get; set; } =
        //     new() { };

        [SynthesisSettingName("Keywords to look for")]
        public List<IFormLinkGetter<IKeywordGetter>> KeywordsToRemove { get; set; } = new() { };

        [SynthesisSettingName("Items to look for")]
        public List<IFormLinkGetter<IItemGetter>> ItemsToRemove { get; set; } = new() { };

        [SynthesisSettingName("Item to always keep")]
        public List<IFormLinkGetter<IItemGetter>> ItemsToKeep { get; set; } = new() { };

        [SynthesisSettingName("Leveled Lists to never patch")]
        public List<IFormLinkGetter<ILeveledItemGetter>> ListBlacklist { get; set; } = new() { };
    }
}
