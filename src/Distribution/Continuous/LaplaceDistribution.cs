using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a Laplace distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class LaplaceDistribution : IDistribution
    {
        /// <summary>
        /// Gets the mu value of the distribution.
        /// </summary>
        /// <value>
        /// The mu value of the distribution.
        /// </value>
        public double Mu { get; }

        /// <summary>
        /// Gets the b value of the distribution.
        /// </summary>
        /// <value>
        /// The b value of the distribution.
        /// </value>
        public double B { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="LaplaceDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu value of the distribution.</param>
        /// <param name="b">The b value of the distribution.</param>
        public LaplaceDistribution(double mu, double b)
        {
            Mu = mu;
            B = b;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LaplaceDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu value of the distribution.</param>
        /// <param name="b">The b value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public LaplaceDistribution(double mu, double b, int seed)
        {
            Mu = mu;
            B = b;
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

            return Mu - B * Math.Sign(value) * Math.Log(1 - 2 * Math.Abs(value));
        }
    }
}
