using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SpaceMonkey.Upgrades.Top
{
    public class SolarShooterDisplay : ModTowerDisplay<SpaceMonkey>
    {
        public override string BaseDisplay => Game.instance.model.GetTower(TowerType.NinjaMonkey, 3).display.guidRef;
        public override bool UseForTower(int[] tiers)
        {
            if(!IsParagon(tiers))
                if (tiers[0] == 5)
                    return true;
            return false;
        }
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "SpaceMonkeyTower");
            SetMeshOutlineColor(node, Color.black);
        }
    }
}
