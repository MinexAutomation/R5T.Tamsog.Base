using System;
using System.Collections.Generic;

using R5T.Tamsog.Types;


namespace R5T.Tamsog
{
    public interface ISourceControlUserDirectoryPathsConvention
    {
        IEnumerable<SourceControlUserDirectoryPath> GetSourceControlUserDirectoryPaths(SourceControlRootDirectoryPath sourceControlRootDirectoryPath);
    }
}
