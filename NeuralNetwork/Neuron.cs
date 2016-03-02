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
    public class Neuron:ITwoDimensionSupport
    {
        #region Fields

        IActivationFunction _actFunc;
        private Position2D _position;

        #endregion

        #region Properties

        #endregion

        #region Constructors

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

    }
}
