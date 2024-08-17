using CardarionPlugin.Data.RepositoryTypes;
using HularionCore.Pattern.Identifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.Data
{
    public class DatabaseManager
    {

        private Dictionary<string, object> repositories = new Dictionary<string, object>();

        public string RegisterSqliteRepository(SqliteRepositoryConnection connectionDetail)
        {
            if(connectionDetail == null || String.IsNullOrWhiteSpace(connectionDetail.Location))
            {
                return null;
            }

            var filenameIndex = connectionDetail.Location.LastIndexOf(@"\");
            var directory = connectionDetail.Location.Substring(0, filenameIndex);
            var filename = connectionDetail.Location.Substring(filenameIndex + 1);
            var suffixIndex = filename.LastIndexOf(".");
            var suffix = filename.Substring(suffixIndex + 1);
            filename = filename.Substring(0, suffixIndex);
            
            var builder = new HularionMesh.Connector.Sqlite.SqliteMeshRepositoryBuilder()
                .SetDatabaseName(filename)
                .SetDatabaseSuffix(suffix)
                .SetDirectory(directory)
                .SetUseExisting(true);

            var repository = builder.Build();
            var repositoryKey = ObjectKey.CreateUniqueTag();
            repositories.Add(repositoryKey, repository);
            return repositoryKey;
        }




    }
}
