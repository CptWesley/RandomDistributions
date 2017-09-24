using System;

namespace RandomDistribution.Distribution
{
    /// <summary>
    /// Distribution class for a uniform distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    public class UniformDistribution : IDistribution
    {
        /// <summary>
        /// Gets the alpha value of the distribution.
        /// </summary>
        /// <value>
        /// The alpha value of the distribution.
        /// </value>
        public double Alpha { get; }
        /// <summary>
        /// Gets the beta value of the distribution.
        /// </summary>
        /// <value>
        /// The beta value of the distribution.
        /// </value>
        public double Beta { get; }

        private Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniformDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        public UniformDistribution(double alpha, double beta)
        {
            Alpha = alpha;
            Beta = beta;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniformDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        /// <param name="seed">The seed.</param>
        public UniformDistribution(double alpha, double beta, int seed)
        {
            Alpha = alpha;
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
            throw new NotImplementedException();
        }
    }
}
