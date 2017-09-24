using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a weibull distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    public class WeibullDistribution : IDistribution
    {
        /// <summary>
        /// Gets the lambda value of the distribution.
        /// </summary>
        /// <value>
        /// The lambda value of the distribution.
        /// </value>
        public double Lambda { get; }
        /// <summary>
        /// Gets the k value of the distribution.
        /// </summary>
        /// <value>
        /// The k value of the distribution.
        /// </value>
        public double K { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeibullDistribution"/> class.
        /// </summary>
        /// <param name="lambda">The lambda value of the distribution.</param>
        /// <param name="k">The k value of the distribution.</param>
        public WeibullDistribution(double lambda, double k)
        {
            Lambda = lambda;
            K = k;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeibullDistribution"/> class.
        /// </summary>
        /// <param name="lambda">The lambda value of the distribution.</param>
        /// <param name="k">The k value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public WeibullDistribution(double lambda, double k, int seed)
        {
            Lambda = lambda;
            K = k;
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
            value *= -Math.Pow(Lambda, K);
            value = Math.Pow(value, 1 / K);
            return value;
        }
    }
}
