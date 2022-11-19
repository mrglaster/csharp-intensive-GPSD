using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intensive_csharp_app
{
    public class GpsdEventArg:EventArgs
    {
        private IGpsdModel? _model;
        public GpsdEventArg(IGpsdModel model) {
            _model = model;
        }

        public IGpsdModel Model => _model;
    }
}
