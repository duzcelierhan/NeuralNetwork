using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.ActivationFunctions
{
    /// <summary>
    /// The linear activation function
    /// </summary>
    /// <remarks>
    /// <code>
    ///        |1            if x > 0.5/A
    /// f(x) = |A * x + 0.5  if 0.5/A > x > -0.5/A
    ///        |0            if -0.5/A > x
    /// 
    ///             A > 0      
    /// </code>
    /// </remarks>
    class LinearActivationFunction : IActivationFunction
    {
        #region Fields

        private double _a = 1.0;
        private double _threshold = 0.5;

        #endregion

        #region Properties

        public double A
        {
            get { return _a; }
            set
            {
                _a = value > 0 ? value : 1.0;
                _threshold = .5 / _a;
            }
        }

        #endregion

        #region IActivationFunction Implementation

        public string Name
        {
            get
            {
                return "Linear";
            }
        }

        public double Output(double sum)
        {
            if (sum > _threshold) return 1;
            if (sum < -_threshold) return 0;
            return _a * sum + 0.5f;
        }

        public double OutputPrime(double output)
        {
            if (output > _threshold) return 0;
            if (output < -_threshold) return 0;
            return _a;
        }

        #endregion
    }
}
