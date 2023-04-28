using System;

using R5T.T0131;


namespace R5T.Z0014
{
	[ValuesMarker]
	public partial interface IRepositoryDescriptions : IValuesMarker
	{
        /// <summary>
        /// A test repository.
        /// </summary>
        public string ForTestRepository => "A test repository.";
	}
}