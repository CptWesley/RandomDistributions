using System;

namespace RandomDistribution.Distribution.Discrete
{
    /// <summary>
    /// Distribution class for a geometric distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class GeometricDistribution : IDistribution
    {
        /// <summary>
        /// Gets the p value of the distribution.
        /// </summary>
        /// <value>
        /// The p value of the distribution.
        /// </value>
        public double P { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        public GeometricDistribution(double p)
        {
            P = p;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public GeometricDistribution(double p, int seed)
        {
            P = p;
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

            value = Math.Log(value) / Math.Log(1 - P);

            return value;
        }
    }
}
