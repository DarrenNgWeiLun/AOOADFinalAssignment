using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADFinalAssignment
{
    // the builder abstraction
    interface IPolicyBuilder
    {
        // we are using the builder pattern here
        // since we can make the pattern determine thye policy to build
        // based on the payOut type :D
        PayOutType payOutType { get; set; }
        Policy GetResult();
    }
}
