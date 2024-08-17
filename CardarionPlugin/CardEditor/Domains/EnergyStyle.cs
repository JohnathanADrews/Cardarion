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
    public class EnergyStyle
    {

        [DomainProperty(DomainObjectPropertySelector.Key)]
        public IMeshKey Key { get; set; }

        public string Name { get; set; }
    }
}
