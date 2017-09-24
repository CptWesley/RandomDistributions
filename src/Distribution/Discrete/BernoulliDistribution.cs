using System;

namespace RandomDistribution.Distribution.Discrete
{
    /// <summary>
    /// Distribution class for a bernoulli distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    public class BernoulliDistribution : IDistribution
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
        /// Initializes a new instance of the <see cref="BernoulliDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        public BernoulliDistribution(double p)
        {
            P = p;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BernoulliDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public BernoulliDistribution(double p, int seed)
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
            if (_rnd.NextDouble() < P)
            {
                return 1;
            }
            return 0;
        }
    }
}
