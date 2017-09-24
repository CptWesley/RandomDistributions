using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a gaussian (normal) distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class GaussianDistribution : IDistribution
    {
        /// <summary>
        /// Gets the mu (mean) value of the distribution.
        /// </summary>
        /// <value>
        /// The mu (mean) value of the distribution.
        /// </value>
        public double Mu { get; }
        /// <summary>
        /// Gets the sigma (deviation) value of the distribution.
        /// </summary>
        /// <value>
        /// The sigma (deviation) value of the distribution.
        /// </value>
        public double Sigma { get; }

        private readonly Random _rnd;

        private double _next;
        private bool _hasNext;

        /// <summary>
        /// Initializes a new instance of the <see cref="GaussianDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu (mean) value of the distribution.</param>
        /// <param name="sigma">The sigma (deviation) value of the distribution.</param>
        public GaussianDistribution(double mu, double sigma)
        {
            Mu = mu;
            Sigma = sigma;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GaussianDistribution"/> class.
        /// </summary>
        /// <param name="mu">The mu (mean) value of the distribution.</param>
        /// <param name="sigma">The sigma (deviation) value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public GaussianDistribution(double mu, double sigma, int seed)
        {
            Mu = mu;
            Sigma = sigma;
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
            return MarsagliaPolar() * Sigma + Mu;
        }

        /// <summary>
        /// Calculates Marsaglias polar algorithm.
        /// </summary>
        /// <returns>A random N(0,1) distributed value.</returns>
        private double MarsagliaPolar()
        {
            // Return the second result for better performance for every second execution.
            if (_hasNext)
            {
                _hasNext = false;
                return _next;
            }

            double u ,v, s;
            do
            {
                u = _rnd.NextDouble() * 2 - 1; // U(-1, 1)
                v = _rnd.NextDouble() * 2 - 1; // U(-1, 1)

                s = u * u + v * v; // S = U^2+V^2
            } while (s >= 1);

            double root = Math.Sqrt(-2 * Math.Log(s) / s) * Sigma + Mu; //
            double value = u * root;

            // Store the second result for better performance for every second execution.
            _next = v * root;
            _hasNext = true;

            return value;
        }
    }
}
