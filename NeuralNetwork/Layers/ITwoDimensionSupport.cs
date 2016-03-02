using NeuralNetwork.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Layers
{
    interface ITwoDimensionSupport
    {
        Position2D Position { get; set; }
    }
}
