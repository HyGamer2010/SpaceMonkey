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

namespace SpaceMonkey.Upgrades.Middle
{
    public class PlanetGunDisplay : ModTowerDisplay<SpaceMonkey>
    {
        public override string BaseDisplay => Game.instance.model.GetTower(TowerType.BombShooter, 4).display.guidRef;
        public override bool UseForTower(int[] tiers)
        {
            if(!IsParagon(tiers))
                if (tiers[2] == 5)
                    return true;
            return false;
        }
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "PlanetGunTexture");
            SetMeshOutlineColor(node, Color.black);
        }
    }
}
