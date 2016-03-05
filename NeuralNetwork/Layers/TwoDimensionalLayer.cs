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

        Neuron[,] neurons;

        #endregion

        #region Constructor(s)

        public TwoDimensionalLayer(int width, int height):base()
        {
            neurons = new Neuron[height, width];
        }

        #endregion

        public override void CalculateOutput()
        {
            Parallel.ForEach<Neuron>((IEnumerable<Neuron>)neurons, x => x.CalculateOutput());



            foreach (var item in neurons)
            {
                item.CalculateOutput();


            }
        }
    }
}
