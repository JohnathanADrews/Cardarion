using CardarionPlugin.CardEditor.Domains;
using HularionMesh;
using HularionMesh.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.CardEditor.Models
{
    [CardarionMeshInclude]
    public class Ability
    {

        [DomainProperty(DomainObjectPropertySelector.Key)]
        public IMeshKey Key { get; set; }
    }
}
