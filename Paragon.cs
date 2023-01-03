using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMonkey.Upgrades.Paragon
{
    public class SolarDestructor : ModParagonUpgrade<SpaceMonkey>
    {
        public override int Cost => 650000;
        public override string Description => "There are no lifeforms here, at least, not any more";
        public override string DisplayName => "Solar Destructor";
        public override string Icon => "ParagonIcon";
        public override string Portrait => "ParagonIcon";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range = 100;
            towerModel.GetAttackModel().range = 100;
            var behav = Game.instance.model.GetTower(TowerType.MonkeyAce, 0, 5, 0).Duplicate<TowerModel>().GetAbility();
            behav.GetBehavior<ActivateAttackModel>().attacks[0].weapons[0].projectile.GetDamageModel().damage = 8000000;
            behav.cooldown = 60;
            towerModel.AddBehavior<AbilityModel>(behav);
        }
        public override void ModifyPowerDegreeMutator(ParagonTowerModel.PowerDegreeMutator powerDegreeMutator, float investment, int degree)
        {
            powerDegreeMutator.additionalDamageUp += 5;
            powerDegreeMutator.additionalPierceUp += 2;
        }
    }
}
