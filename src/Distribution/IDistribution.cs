namespace RandomDistribution.Distribution
{
    /// <summary>
    /// Interface for distribution classes.
    /// </summary>
    /// <author>Wesley Baartman</author>
    public interface IDistribution
    {
        /// <summary>
        /// Gets next value.
        /// </summary>
        /// <returns>Random value of said distribution.</returns>
        double Next();
    }
}
