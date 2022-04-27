using System;

using R5T.Tamsog.Types;using R5T.T0064;


namespace R5T.Tamsog
{[ServiceDefinitionMarker]
    public interface ISourceControlRootDirectoryPathProvider:IServiceDefinition
    {
        SourceControlRootDirectoryPath GetSourceControlRootDirectoryPath();
    }
}
