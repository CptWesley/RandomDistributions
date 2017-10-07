using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a Gumbel distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class GumbelDistribution : IDistribution
    {
        /// <summary>
        /// Gets the mu value of the distribution.
        /// </summary>
        /// <value>
        /// The mu value of the distribution.
        /// </value>
        public double Mu { get; }

        /// <summary>
        /// Gets the beta value of the distribution.
        /// </summary>
        /// <value>
        /// The beta value of the distribution.
        /// </value>
        public double Beta { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="GumbelDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        public GumbelDistribution(double mu, double beta)
        {
            Mu = mu;
            Beta = beta;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GumbelDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public GumbelDistribution(double mu, double beta, int seed)
        {
            Mu = mu;
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

            value = Math.Log(-Math.Log(value));
            value *= -Beta;
            value += Mu;

            return value;
        }
    }
}
