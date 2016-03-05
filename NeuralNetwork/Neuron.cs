using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetwork.ActivationFunctions;
using NeuralNetwork.Layers;
using NeuralNetwork.Structures;

namespace NeuralNetwork
{
    public class Neuron:ITwoDimensionSupport,IInputSupplier
    {
        #region Fields

        IActivationFunction _actFunc;
        private Position2D _position;
        private double _lastOutput;
        private List<InputPair> _inputList = new List<InputPair>();

        #endregion

        #region Properties

        internal IActivationFunction ActivationFunction
        {
            get { return _actFunc; }
            set { _actFunc = value; }
        }

        public double LastOutput
        {
            get { return _lastOutput; }
        }

        #endregion

        #region Constructors

        internal Neuron(IActivationFunction actFunction)
        {
            this._actFunc = actFunction;
        }

        #endregion
        
        #region ITwoDimensionSupport Implementation
        Position2D ITwoDimensionSupport.Position
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }

        #endregion

        #region IInputSupplier Implementation

        double IInputSupplier.Data
        {
            get { return this._lastOutput; }
        }

        #endregion

        #region Public Methods

        public double CalculateOutput()
        {
            return _lastOutput = this._actFunc.Output(CalculateInputSum());
        }

        #endregion

        #region Private Methods

        private double CalculateInputSum()
        {
            double sum = 0.0;
            foreach (var inputPair in this._inputList)
            {
                sum += inputPair.InputNeuron.LastOutput * inputPair.Weight;
            }

            return sum;
        }

        #endregion
    }
}
