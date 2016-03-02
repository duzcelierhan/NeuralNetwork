using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.ActivationFunctions
{
    interface IActivationFunction
    {
        double Output(double sum);
        double OutputPrime(double output);
        string Name { get; }
    }
}
