using System;

namespace RandomDistribution.Distribution.Discrete
{
    /// <summary>
    /// Distribution class for a binomial distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public class BinomialDistribution : IDistribution
    {
        /// <summary>
        /// Gets the p value of the distribution.
        /// </summary>
        /// <value>
        /// The p value of the distribution.
        /// </value>
        public double P { get; }

        /// <summary>
        /// Gets the n value of the distribution.
        /// </summary>
        /// <value>
        /// The n value of the distribution.
        /// </value>
        public int N { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinomialDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        /// <param name="n">The n value of the distribution.</param>
        public BinomialDistribution(int n, double p)
        {
            P = p;
            N = n;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinomialDistribution"/> class.
        /// </summary>
        /// <param name="p">The p value of the distribution.</param>
        /// <param name="n">The n value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public BinomialDistribution(int n, double p, int seed)
        {
            P = p;
            N = n;
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

            for (int i = 0; i < N; ++i)
            {
                if (_rnd.NextDouble() < P)
                {
                    ++value;
                }
            }

            return value;
        }
    }
}
