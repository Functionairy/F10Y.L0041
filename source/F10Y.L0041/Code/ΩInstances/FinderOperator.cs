using System;


namespace F10Y.L0041
{
    public class FinderOperator : IFinderOperator
    {
        #region Infrastructure

        public static IFinderOperator Instance { get; } = new FinderOperator();


        private FinderOperator()
        {
        }

        #endregion
    }
}
