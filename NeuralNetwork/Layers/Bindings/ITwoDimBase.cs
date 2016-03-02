using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Layers.Bindings
{
    internal interface ITwoDimBase
    {
        void Bind(TwoDimensionalLayer previousLayer, TwoDimensionalLayer currentLayer);
    }
}
