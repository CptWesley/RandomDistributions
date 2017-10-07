using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a logistic distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class LogisticDistribution : IDistribution
    {
        /// <summary>
        /// Gets the mu value of the distribution.
        /// </summary>
        /// <value>
        /// The mu value of the distribution.
        /// </value>
        public double Mu { get; }
        /// <summary>
        /// Gets the s value of the distribution.
        /// </summary>
        /// <value>
        /// The s value of the distribution.
        /// </value>
        public double S { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogisticDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu value of the distribution.</param>
        /// <param name="s">The s value of the distribution.</param>
        public LogisticDistribution(double mu, double s)
        {
            Mu = mu;
            S = s;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogisticDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu value of the distribution.</param>
        /// <param name="s">The s value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public LogisticDistribution(double mu, double s, int seed)
        {
            Mu = mu;
            S = s;
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

            value = Math.Log(1 / value - 1);
            value *= -S;
            value += Mu;

            return value;
        }
    }
}
