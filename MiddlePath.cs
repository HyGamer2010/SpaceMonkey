using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Il2CppMS.Internal.Xml.XPath.Operator;

namespace SpaceMonkey.Upgrades.Middle
{
    public class BiggerEyes : ModUpgrade<SpaceMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 1;
        public override int Cost => 100;
        public override string Icon => nameof(BiggerEyes);
        public override string Description => "Increases range";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetAttackModel().range += 5;
            towerModel.range += 5;
        }
    }
    public class DarkMatter : ModUpgrade<SpaceMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 2;
        public override int Cost => 500;
        public override string Icon => nameof(DarkMatter);
        public override string Description => "Make invisible explosions";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var behav = Game.instance.model.GetTower(TowerType.BombShooter).Duplicate<TowerModel>().GetAttackModel().weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>();
            behav.projectile.GetDamageModel().createPopEffect = true;
            behav.projectile.GetBehavior<AgeModel>().lifespan = .1f;
            behav.projectile.GetBehavior<DamageModel>().immuneBloonProperties = 0;
            towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = 0;
            behav.projectile.SetHitCamo(true);
            behav.name = "Splodey";
            towerModel.GetWeapon().projectile.AddBehavior(behav);
        }
    }
    public class Supernova : ModUpgrade<SpaceMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 3;
        public override int Cost => 2500;
        public override string Icon => nameof(Supernova);
        public override string Description => "The explosions are bigger";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 10;
        }
    }
    public class MeteorShower : ModUpgrade<SpaceMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 4;
        public override int Cost => 22500;
        public override string Icon => nameof(MeteorShower);
        public override string Description => "Add a meteor shower ability";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var behav = Game.instance.model.GetTower(TowerType.MortarMonkey, 0, 5, 0).Duplicate<TowerModel>().GetAbility();
            behav.GetBehavior<ActivateAttackModel>().attacks[0].weapons[0].projectile.GetDamageModel().damage = 30;
            towerModel.AddBehavior<AbilityModel>(behav);
            towerModel.GetAbility().icon = GetSpriteReference(Icon);
        }
    }
    public class PlanetaryDestruction : ModUpgrade<SpaceMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 5;
        public override int Cost => 40000;
        public override string Icon => nameof(PlanetaryDestruction);
        public override string Description => "It came too close";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.RemoveBehavior<AbilityModel>();
            var behav = Game.instance.model.GetTower(TowerType.MonkeyAce, 0, 5, 0).Duplicate<TowerModel>().GetAbility();
            behav.GetBehavior<ActivateAttackModel>().attacks[0].weapons[0].projectile.GetDamageModel().damage = 4500;
            towerModel.AddBehavior<AbilityModel>(behav);
            foreach (var item in towerModel.GetAbilities())
            {
                item.cooldown -= 5;
            }
            towerModel.GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetDamageModel().damage += 1;
            towerModel.GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.scale += 15;
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 1;
            towerModel.GetAbility().icon = GetSpriteReference(Icon);
        }
    }
}
