using System;

namespace RandomDistribution.Distribution.Discrete
{
    /// <summary>
    /// Distribution class for a negative binomial distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class NegativeBinomialDistribution : IDistribution
    {
        /// <summary>
        /// Gets the p value of the distribution.
        /// </summary>
        /// <value>
        /// The p value of the distribution.
        /// </value>
        public double P { get; }

        /// <summary>
        /// Gets the r value (numbers of failures) of the distribution.
        /// </summary>
        /// <value>
        /// The r value (numbers of failures) of the distribution.
        /// </value>
        public int R { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeBinomialDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        /// <param name="r">The r (numbers of failures) value of the distribution.</param>
        public NegativeBinomialDistribution(int r, double p)
        {
            P = p;
            R = r;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeBinomialDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        /// <param name="r">The r (numbers of failures) value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public NegativeBinomialDistribution(int r, double p, int seed)
        {
            P = p;
            R = r;
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
            int value = 0;
            int errors = 0;

            while (errors < R)
            {
                if (_rnd.NextDouble() > P)
                {
                    ++errors;
                }
                else
                {
                    ++value;
                }
            }

            return value;
        }
    }
}
