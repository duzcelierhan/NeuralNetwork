using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    class InputPair
    {
        #region Fields

        public Neuron InputNeuron;
        public double Weight;
        private Random rnd;

        #endregion

        #region Constructor

        public InputPair(Neuron neuron)
        {
            this.InputNeuron = neuron;
            RandomizeWeight();
        }

        public InputPair(Neuron neuron, double weight)
        {
            this.InputNeuron = neuron;
            this.Weight = weight;
        }

        private Random RND
        {
            get
            {
                return rnd ?? (rnd = new Random());
            }
        }

        #endregion

        #region Public Methods

        public void RandomizeWeight()
        {
            this.Weight = RND.NextDouble();
        }

        #endregion
    }
}
