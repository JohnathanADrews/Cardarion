using HularionMesh.Repository;
using HularionMesh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HularionMesh.SystemDomain;

namespace CardarionPlugin.CardEditor.Domains
{
    [CardarionMeshInclude]
    public class ActivationCost
    {

        [DomainProperty(DomainObjectPropertySelector.Key)]
        public IMeshKey Key { get; set; }


        public UniqueSet<EnergyCost> EnergyCosts { get; set; } = new UniqueSet<EnergyCost>();

    }
}
