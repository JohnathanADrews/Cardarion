using CardarionPlugin.Data.RepositoryTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.Routers.Repository.Routes.Request
{
    public class OpenRepositoryRequest
    {

        public string RepositoryType { get; set; }

        public SqliteRepositoryConnection SqliteRepository { get; set; }
    }

}
