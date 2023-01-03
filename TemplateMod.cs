using MelonLoader;
using BTD_Mod_Helper;
using SpaceMonkey;

[assembly: MelonInfo(typeof(SpaceMonkey.SpaceMonkeyMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace SpaceMonkey;

public class SpaceMonkeyMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<SpaceMonkeyMod>("SpaceMonkeyMod loaded!");
    }
}