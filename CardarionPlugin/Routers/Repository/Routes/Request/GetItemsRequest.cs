﻿using HularionMesh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.Routers.Repository.Routes.Request
{
    public class GetItemsRequest
    {

        public List<IMeshKey> ItemKeys { get; set; }

    }
}