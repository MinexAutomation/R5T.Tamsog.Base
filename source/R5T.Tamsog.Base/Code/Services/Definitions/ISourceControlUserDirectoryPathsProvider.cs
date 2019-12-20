using System;
using System.Collections.Generic;

using R5T.Tamsog.Types;


namespace R5T.Tamsog
{
    public interface ISourceControlUserDirectoryPathsProvider
    {
        IEnumerable<SourceControlUserDirectoryPath> GetSourceControlUserDirectoryPaths();
    }
}
