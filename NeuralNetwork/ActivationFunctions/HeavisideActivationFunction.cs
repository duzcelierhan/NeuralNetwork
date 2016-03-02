using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.ActivationFunctions
{
    /// <summary>
    /// The heaviside activation function
    /// </summary>
    /// <remarks>
    /// <code>
    /// f(x) = 0 if 0>x
    /// f(x) = 1 if x>0
    /// </code>   
    /// </remarks>
    class HeavisideActivationFunction : IActivationFunction
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region IActivationFunction Implementation

        public string Name
        {
            get
            {
                return "Heaviside";
            }
        }

        public double Output(double sum)
        {
            return sum > 0 ? 1 : 0;
        }

        public double OutputPrime(double output)
        {
            return (Math.Abs(output) < 0.0001) ? double.MaxValue : 0;
        }

        #endregion
    }
}
