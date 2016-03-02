using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.ActivationFunctions
{
    /// <summary>
    /// The sigmoid activation function
    /// </summary>
    /// <remarks>
    /// Here is the definition of the sigmoid activation function
    /// <code>
    ///                1
    /// f(x) = -----------------   beta > 0
    ///         1 + e^(-beta*x)
    /// 
    /// f'(x) = beta * f(x) * ( 1 - f(x) )   
    /// </code>     
    /// </remarks>
    class SigmoidActivationFunction : IActivationFunction
    {
        #region Fields

        private double _beta;

        #endregion

        #region Properties

        public double Beta
        {
            get { return this._beta; }
            set { _beta = Math.Max(value, 1.0); }
        }

        #endregion

        #region IActivationFunction Implementation

        public string Name
        {
            get
            {
                return "Sigmoid";
            }
        }

        public double Output(double sum)
        {
            return (1.0 / (1.0 + Math.Exp(-_beta * sum)));
        }

        public double OutputPrime(double output)
        {
            double y = Output(output);
            return (_beta * y * (1 - y));
        }

        #endregion
    }
}
