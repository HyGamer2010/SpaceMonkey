using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppSteamNative;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMonkey
{
    public class HotCoalsDisplay : ModDisplay
    {
        public override string BaseDisplay => Game.instance.model.GetTower(TowerType.NinjaMonkey, 0, 0, 2).GetAttackModel("AttackModel_Caltrops_").Duplicate().weapons[0].projectile.display.guidRef;
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "HotCoal");
        }
    }
}
