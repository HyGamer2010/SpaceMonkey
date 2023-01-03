using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMonkey.Upgrades.Top
{
    public class SpeedyNebula : ModUpgrade<SpaceMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 1;
        public override int Cost => 200;
        public override string Icon => nameof(SpeedyNebula);
        public override string Description => "Increases ATK Speed";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            foreach (var item in towerModel.GetAttackModels())
            {
                item.weapons[0].rate -= .15f;
            }
        }
    }
    public class PointierMeteors : ModUpgrade<SpaceMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 2;
        public override int Cost => 300;
        public override string Icon => nameof(PointierMeteors);
        public override string Description => "Increases pierce and range";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce += 1;
            towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 1, 0, 10, null, false);
            foreach (var item in towerModel.GetAttackModels())
            {
                item.weapons[0].rate -= .0125f;
            }
            towerModel.GetAttackModel().range += 10;
            towerModel.range += 10;
        }
    }
    public class DoubleMeteors : ModUpgrade<SpaceMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 3;
        public override int Cost => 1500;
        public override string Icon => nameof(DoubleMeteors);
        public override string Description => "Shoots 2 projectiles";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 2, 0, 10, null, false);
            foreach (var item in towerModel.GetAttackModels())
            {
                item.weapons[0].rate -= .0125f;
            }
            towerModel.GetWeapon().projectile.pierce += 1;
        }
    }
    public class EvenMoreMeteors : ModUpgrade<SpaceMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 4;
        public override int Cost => 3000;
        public override string Icon => nameof(EvenMoreMeteors);
        public override string Description => "Shoots 5 projectiles";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 5, 0, 10, null, false);
            foreach (var item in towerModel.GetAttackModels())
            {
                item.weapons[0].rate -= .0125f;
            }
            towerModel.GetAttackModel().range += 10;
            towerModel.range += 10;
        }
    }
    public class TheSolarShooter : ModUpgrade<SpaceMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 5;
        public override int Cost => 20000;
        public override string Icon => nameof(TheSolarShooter);
        public override string Description => "Too, many...";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 12, 0, 10, null, false);
            foreach (var item in towerModel.GetAttackModels())
            {
                item.weapons[0].rate /= 1.5f;
            }
            towerModel.GetWeapon().projectile.pierce += 1;
            towerModel.GetAttackModel().range += 10;
            towerModel.range += 10;
        }
    }
}
