using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Layers
{
    public abstract class LayerBase
    {
        #region Fields

        #endregion


        public enum State { NotStarted, Calculating, Finished }

        public event EventHandler<State> StateChanged;

        public abstract void CalculateOutput();
    }
}
