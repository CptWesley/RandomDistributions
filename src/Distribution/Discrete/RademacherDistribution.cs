using System;

namespace RandomDistribution.Distribution.Discrete
{
    /// <summary>
    /// Distribution class for a Rademacher distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class RademacherDistribution : IDistribution
    {
        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="RademacherDistribution"/> class.
        /// </summary>
        public RademacherDistribution()
        {
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RademacherDistribution"/> class.
        /// </summary>
        /// <param name="seed">The seed of the distribution.</param>
        public RademacherDistribution(int seed)
        {
            _rnd = new Random(seed);
        }

        /// <summary>
        /// Gets next value.
        /// </summary>
        /// <returns>
        /// Random value of said distribution.
        /// </returns>
        public double Next()
        {
            if (_rnd.NextDouble() > 0.5)
            {
                return 1;
            }
            return -1;
        }
    }
}
