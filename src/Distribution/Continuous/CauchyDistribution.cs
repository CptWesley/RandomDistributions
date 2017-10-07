using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a Cauchy distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class CauchyDistribution : IDistribution
    {
        /// <summary>
        /// Gets the alpha value of the distribution.
        /// </summary>
        /// <value>
        /// The alpha value of the distribution.
        /// </value>
        public double Alpha { get; }

        /// <summary>
        /// Gets the beta value of the distribution.
        /// </summary>
        /// <value>
        /// The beta value of the distribution.
        /// </value>
        public double Beta { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="CauchyDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        public CauchyDistribution(double alpha, double beta)
        {
            Alpha = alpha;
            Beta = beta;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CauchyDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public CauchyDistribution(double alpha, double beta, int seed)
        {
            Alpha = alpha;
            Beta = beta;
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

            value -= 0.5;
            value *= Math.PI;
            value = Beta * Math.Tan(value) + Alpha;

            return value;
        }
    }
}
