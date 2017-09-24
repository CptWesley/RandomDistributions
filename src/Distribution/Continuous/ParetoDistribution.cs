using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a pareto distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class ParetoDistribution : IDistribution
    {
        /// <summary>
        /// Gets the alpha value of the distribution.
        /// </summary>
        /// <value>
        /// The alpha value of the distribution.
        /// </value>
        public double Alpha { get; }
        /// <summary>
        /// Gets the lamda value of the distribution.
        /// </summary>
        /// <value>
        /// The lambda value of the distribution.
        /// </value>
        public double Lambda { get; }

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParetoDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="lambda">The lambda value of the distribution.</param>
        public ParetoDistribution(double alpha, double lambda)
        {
            Alpha = alpha;
            Lambda = lambda;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParetoDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="lambda">The lambda value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public ParetoDistribution(double alpha, double lambda, int seed)
        {
            Alpha = alpha;
            Lambda = lambda;
            _rnd = new Random(seed);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParetoDistribution"/> class.
        /// </summary>
        /// <param name="lambda">The lambda value of the distribution.</param>
        public ParetoDistribution(double lambda)
        {
            Alpha = 1;
            Lambda = lambda;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParetoDistribution"/> class.
        /// </summary>
        /// <param name="lambda">The lambda value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public ParetoDistribution(double lambda, int seed)
        {
            Alpha = 1;
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

            value = 1 / value;
            value = Math.Pow(value, 1 / Lambda);
            value *= Alpha;

            return value;
        }
    }
}
