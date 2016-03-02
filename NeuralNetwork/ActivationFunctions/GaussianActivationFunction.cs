using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.ActivationFunctions
{
    /// <summary>
    /// The gaussian activation function
    /// </summary>
    /// <remarks>
    /// <code>
    /// 
    ///                  1                -(x-mu)^2 / (2 * sigma^2)
    /// f(x)  =  -------------------- *  e
    ///          sqrt(2 * pi * sigma)
    /// 
    /// f'(x)  =  y(x) * -2*K*(x - mu) 
    /// </code>
    /// To implement a more efficient computation :
    /// <code>
    /// C = 1/sqrt(2 * pi * sigma)
    /// K = 1/(2 * sigma^2)
    /// </code>
    /// </remarks>
    class GaussianActivationFunction
    {
        #region Fields

        private double _sigma = 0.159155;
        private double _mu = 0.0;
        private double _C;
        private double _K;

        #endregion

        #region Properties

        public double Sigma
        {
            get { return this._sigma; }
            set
            {
                _sigma = value > 0 ? value : _sigma;
                ComputeCandK();
            }
        }

        #endregion

        #region Constructor

        public GaussianActivationFunction()
        {
            ComputeCandK();
        }

        #endregion

        #region IActivationFunction Implementation

        public string Name
        {
            get
            {
                return "Gaussian";
            }
        }

        public double Output(double sum)
        {
            return _C * Math.Exp(-(sum - _mu) * (sum - _mu) * _K);
        }

        public double OutputPrime(double output)
        {
            double y = Output(output);
            return -2 * y * _K * (output - _mu);
        }

        #endregion

        #region Private Methods

        private void ComputeCandK()
        {
            _C = 1.0 / (float)Math.Sqrt(2 * Math.PI * _sigma);
            _K = 1.0 / (2 * _sigma * _sigma);
        }

        #endregion
    }
}
