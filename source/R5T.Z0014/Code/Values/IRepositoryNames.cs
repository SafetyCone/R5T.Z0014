using System;

using R5T.T0131;


namespace R5T.Z0014
{
	[ValuesMarker]
	public partial interface IRepositoryNames : IValuesMarker
	{
		/// <summary>
		/// Test123
		/// </summary>
		public string TestRepository => "Test123";
	}
}