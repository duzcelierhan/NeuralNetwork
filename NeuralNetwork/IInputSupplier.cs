using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    interface IInputSupplier
    {
        ///<summary>The data</summary>
        double Data { get; }
    }
}
