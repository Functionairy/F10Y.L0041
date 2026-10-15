using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0041
{
    /// <summary>
    /// Finder in MacOSX application functions.
    /// </summary>
    [FunctionsMarker]
    public partial interface IFinderOperator
    {
        /// <summary>
        /// Quality-of-life overload for <see cref="Open_Directory_InFinder(string)"/>.
        /// </summary>
        void Open(string directoryPath)
        {
            this.Open_Directory_InFinder(directoryPath);
        }

        void Open_Directory_InFinder(string directoryPath)
        {
            var arguments = $"\"{directoryPath}\"";

            Instances.CommandLineOperator.Run_Synchronous(
                Instances.CommandNames.open,
                arguments);
        }

        void Open_Directories_InFinder(IEnumerable<string> directoryPaths)
        {
            foreach (var directoryPath in directoryPaths)
            {
                this.Open_Directory_InFinder(directoryPath);
            }
        }

        void Open_Directories_InFinder(params string[] directoryPaths)
        {
            this.Open_Directories_InFinder(directoryPaths.AsEnumerable());
        }
    }
}
