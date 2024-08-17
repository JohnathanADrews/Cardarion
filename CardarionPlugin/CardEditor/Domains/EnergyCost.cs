using HularionMesh.Repository;
using HularionMesh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.CardEditor.Domains
{
    [CardarionMeshInclude]
    public class EnergyCost
    {

        [DomainProperty(DomainObjectPropertySelector.Key)]
        public IMeshKey Key { get; set; }


        public EnergyStyle Style { get; set; }

        public int Amount { get; set; }

    }
}
