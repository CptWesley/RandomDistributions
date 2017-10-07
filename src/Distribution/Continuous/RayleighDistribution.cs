using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a Rayleigh distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class RayleighDistribution : IDistribution
    {
        /// <summary>
        /// Gets the sigma value of the distribution.
        /// </summary>
        /// <value>
        /// The sigma value of the distribution.
        /// </value>
        public double Sigma { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="RayleighDistribution"/> class.
        /// </summary>
        /// <param name="sigma">The sigma value of the distribution.</param>
        public RayleighDistribution(double sigma)
        {
            Sigma = sigma;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RayleighDistribution"/> class.
        /// </summary>
        /// <param name="sigma">The sigma value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public RayleighDistribution(double sigma, int seed)
        {
            Sigma = sigma;
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

            value = Math.Log(value);
            value *= -2 * Sigma * Sigma;
            value = Math.Sqrt(value);

            return value;
        }
    }
}
