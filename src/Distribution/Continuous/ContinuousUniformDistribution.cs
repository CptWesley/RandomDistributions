﻿using System;

namespace RandomDistribution.Distribution.Continuous
{
    /// <summary>
    /// Distribution class for a continuous uniform distribution.
    /// </summary>
    /// <seealso cref="RandomDistribution.Distribution.IDistribution" />
    /// <author>Wesley Baartman</author>
    public sealed class ContinuousUniformDistribution : IDistribution
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

        private readonly Random _rnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousUniformDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        public ContinuousUniformDistribution(double alpha, double beta)
        {
            Alpha = alpha;
            Beta = beta;
            _rnd = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousUniformDistribution"/> class.
        /// </summary>
        /// <param name="alpha">The alpha value of the distribution.</param>
        /// <param name="beta">The beta value of the distribution.</param>
        /// <param name="seed">The seed of the distribution.</param>
        public ContinuousUniformDistribution(double alpha, double beta, int seed)
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
            return _rnd.NextDouble() * (Beta - Alpha) + Alpha;
        }
    }
}
