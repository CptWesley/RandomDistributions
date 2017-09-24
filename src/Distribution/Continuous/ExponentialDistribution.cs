using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a exponential distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    public class ExponentialDistribution : IDistribution
    {
        /// <summary>
        /// Gets the lambda value of the distribution.
        /// </summary>
        /// <value>
        /// The lambda value of the distribution.
        /// </value>
        public double Lambda { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExponentialDistribution"/> class.
        /// </summary>
        /// <param name="lambda">The lambda value of the distribution.</param>
        public ExponentialDistribution(double lambda)
        {
            Lambda = lambda;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExponentialDistribution"/> class.
        /// </summary>
        /// <param name="lambda">The lambda value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public ExponentialDistribution(double lambda, int seed)
        {
            Lambda = lambda;
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
            value *= -1 / Lambda;

            return value;
        }
    }
}
