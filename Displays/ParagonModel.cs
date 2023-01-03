using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SpaceMonkey.Upgrades.Paragon
{
    public class ParagonModel : ModTowerDisplay<SpaceMonkey>
    {
        public override float Scale => 1;
        public override int ParagonDisplayIndex => 0;
        public override string BaseDisplay => Game.instance.model.GetTower(TowerType.SuperMonkey, 1, 3, 0).display.guidRef;
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "ParagonTexture");
            SetMeshOutlineColor(node, Color.black);
        }

        public override bool UseForTower(int[] tiers) => IsParagon(tiers);
    }
}
