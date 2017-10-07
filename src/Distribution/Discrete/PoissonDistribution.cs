using System;

namespace RandomDistribution.Distribution.Discrete
{
    /// <summary>
    /// Distribution class for a poisson distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class PoissonDistribution : IDistribution
    {
        /// <summary>
        /// Gets the mean value of the distribution.
        /// </summary>
        /// <value>
        /// The mean value of the distribution.
        /// </value>
        public double Mu { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="PoissonDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mean value of the distribution.</param>
        public PoissonDistribution(double mu)
        {
            Mu = mu;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoissonDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mean value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public PoissonDistribution(double mu, int seed)
        {
            Mu = mu;
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
            // Algorithm attributed to `Donald Ervin Knuth`.
            double l = Math.Exp(-Mu);
            int k = 0;
            double p = 1;

            do
            {
                ++k;
                p *= _rnd.NextDouble();
            } while (p > l);

            return k - 1;
        }
    }
}
