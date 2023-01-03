using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Towers;
using Il2CppAssets.Scripts.Unity.Towers.Behaviors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaceAlongTrack = Il2CppAssets.Scripts.Unity.Towers.Behaviors.PlaceAlongTrack;

namespace SpaceMonkey.Upgrades.Bottom
{
    public class StrongMeteors : ModUpgrade<SpaceMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 1;
        public override int Cost => 200;
        public override string Icon => nameof(StrongMeteors);
        public override string Description => "Increases damage by 1";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 1;
        }
    }
    public class HotCoals : ModUpgrade<SpaceMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 2;
        public override int Cost => 400;
        public override string Description => "Now shoots hot coals";
        public override string Icon => nameof(HotCoals);
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var behav = Game.instance.model.GetTower(TowerType.NinjaMonkey, 0, 0, 2).GetAttackModel("AttackModel_Caltrops_").Duplicate();
            behav.weapons[0].projectile.ApplyDisplay<HotCoalsDisplay>();
            behav.weapons[0].projectile.GetDamageModel().immuneBloonProperties = 0;
            behav.weapons[0].projectile.GetDamageModel().damage = 3;
            behav.name = "HotCoals";
            behav.weapons[0].rate = towerModel.GetWeapon().rate;
            towerModel.AddBehavior(behav);
        }
    }
    public class StrongerMeteors : ModUpgrade<SpaceMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 3;
        public override int Cost => 600;
        public override string Icon => nameof(StrongerMeteors);
        public override string Description => "Increases damage by 2";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 2;
        }
    }
    public class EvenStrongerMeteors : ModUpgrade<SpaceMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 4;
        public override int Cost => 2000;
        public override string Icon => nameof(EvenStrongerMeteors);
        public override string Description => "Increases damage by 3";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 3;
        }
    }
    public class PlanetGun : ModUpgrade<SpaceMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 5;
        public override int Cost => 12500;
        public override string Icon => nameof(PlanetGun);
        public override string Description => "Increases damage by 7";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 7;
        }
    }
}
