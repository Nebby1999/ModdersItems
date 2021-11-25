using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moonstorm;
using UnityEngine;

namespace ModdersItems.Bodies
{
    [DisabledContent]
    public class NebulousWisp : CharacterBase
    {
        public override GameObject BodyPrefab { get; set; }
        public override GameObject MasterPrefab { get; set; }
    }
}
