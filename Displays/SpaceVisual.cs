using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Color = UnityEngine.Color;
namespace SpaceMonkey
{
    public class SpaceVisual : ModTowerDisplay<SpaceMonkey>
    {
        public override string BaseDisplay => Game.instance.model.GetTower(TowerType.NinjaMonkey).display.guidRef;
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "SpaceMonkeyTower");
            SetMeshOutlineColor(node, Color.black);
        }

        public override bool UseForTower(int[] tiers) => tiers[0] < 5 && tiers[1] < 5 && tiers[2] < 5;
    }
}
