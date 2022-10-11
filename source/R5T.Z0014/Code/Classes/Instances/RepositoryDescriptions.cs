using System;


namespace R5T.Z0014
{
	public class RepositoryDescriptions : IRepositoryDescriptions
	{
		#region Infrastructure

	    public static IRepositoryDescriptions Instance { get; } = new RepositoryDescriptions();

	    private RepositoryDescriptions()
	    {
        }

	    #endregion
	}
}