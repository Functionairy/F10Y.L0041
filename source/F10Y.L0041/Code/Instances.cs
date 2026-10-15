using System;


namespace F10Y.L0041
{
#pragma warning disable IDE1006 // Naming Styles
    public interface Instances :
#pragma warning restore IDE1006 // Naming Styles
        Instances_Internal,
        L0000.Instances_Internal
    {
		
    }


#pragma warning disable IDE1006 // Naming Styles
    public interface Instances_Internal
#pragma warning restore IDE1006 // Naming Styles
    {
        public static ICommandNames CommandNames => L0041.CommandNames.Instance;
        public static IFinderOperator FinderOperator => L0041.FinderOperator.Instance;
    }
}