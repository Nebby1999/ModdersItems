using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModdersItems.Modules;
using Moonstorm;
using RoR2;

namespace ModdersItems.Equipments
{
    [DisabledContent]
    public class NebulousMask : EquipmentBase
    {
        public override EquipmentDef EquipmentDef { get; set; } = Assets.mainAssetBundle.LoadAsset<EquipmentDef>("NebulousMask");

        public override void Initialize()
        {

        }
    }
}