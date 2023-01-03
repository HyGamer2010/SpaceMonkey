using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;
using Il2CppInterop.Runtime;
using Il2CppAssets.Scripts.Unity;
using SpaceMonkey.Projectiles;

namespace SpaceMonkey
{
    public class SpaceMonkey : ModTower
    {
        public override int MiddlePathUpgrades => 5;
        public override int TopPathUpgrades => 5;
        public override int BottomPathUpgrades => 5;
        public override ParagonMode ParagonMode => ParagonMode.Base555;
        public override string Portrait => "SpaceMonkey";
        public override int Cost => 600;
        public override string BaseTower => TowerType.NinjaMonkey;
        public override TowerSet TowerSet => TowerSet.Primary;
        public override string Icon => "SpaceMonkey";
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.GetAttackModel().range = 50;
            towerModel.GetAttackModel().name = "Base";
            towerModel.GetWeapon().name = "Base";
            towerModel.range = 50;
            towerModel.GetWeapon().rate = .5f;
            towerModel.GetWeapon().projectile.ApplyDisplay<ProjectileDisplay>();
            towerModel.GetWeapon().projectile.scale = 2;
        }
    }
}
