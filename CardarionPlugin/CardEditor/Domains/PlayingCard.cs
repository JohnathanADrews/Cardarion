using CardarionPlugin.CardEditor.Domains;
using HularionMesh;
using HularionMesh.Repository;
using HularionMesh.SystemDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.CardEditor.Models
{
    [CardarionMeshIncludeAttribute]
    public class PlayingCard
    {

        [DomainProperty(DomainObjectPropertySelector.Key)]
        public IMeshKey Key { get; set; }

        public string Name { get; set; }

        public ActivationCost ActivationCost { get; set; }

        public UniqueSet<Ability> Abilities { get; set; } = new UniqueSet<Ability>();

    }
}
