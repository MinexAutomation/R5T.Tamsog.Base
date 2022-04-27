using System;
using System.Collections.Generic;

using R5T.Tamsog.Types;using R5T.T0064;


namespace R5T.Tamsog
{[ServiceDefinitionMarker]
    public interface ISourceControlUserDirectoryPathsProvider:IServiceDefinition
    {
        IEnumerable<SourceControlUserDirectoryPath> GetSourceControlUserDirectoryPaths();
    }
}
