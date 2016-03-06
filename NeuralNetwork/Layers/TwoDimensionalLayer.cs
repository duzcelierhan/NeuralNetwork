using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Layers
{
    class TwoDimensionalLayer : HiddenLayerBase
    {
        #region Fields

        Neuron[,] _neurons;
        int _width, _height;

        #endregion

        #region Constructor(s)

        public TwoDimensionalLayer(int width, int height):base()
        {
            this._width = width;
            this._height = height;
            _neurons = new Neuron[height, width];
        }

        #endregion

        public override void CalculateOutput()
        {
            Parallel.For(0, _height, y => 
            {
                for (int x = 0; x < _width; x++)
                {
                    _neurons[y, x].CalculateOutput();
                }
            });
        }
    }
}
