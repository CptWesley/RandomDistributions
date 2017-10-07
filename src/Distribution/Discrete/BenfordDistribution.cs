using System;

namespace RandomDistribution.Distribution.Discrete
{
    /// <summary>
    /// Distribution class for a Benford distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class BenfordDistribution : IDistribution
    {
        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="BenfordDistribution"/> class.
        /// </summary>
        public BenfordDistribution()
        {
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenfordDistribution"/> class.
        /// </summary>
        /// <param name="seed">The seed of the distribution.</param>
        public BenfordDistribution(int seed)
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
            double value = _rnd.NextDouble();

            if (value <= 0.301)
                return 1;
            if (value <= 0.477)
                return 2;
            if (value <= 0.602)
                return 3;
            if (value <= 0.699)
                return 4;
            if (value <= 0.778)
                return 5;
            if (value <= 0.845)
                return 6;
            if (value <= 0.903)
                return 7;
            if (value <= 0.954)
                return 8;
            return 9;
        }
    }
}
