using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public interface IParty
    {
        int Gold { get; set; }

        void Stats();
    }
}
