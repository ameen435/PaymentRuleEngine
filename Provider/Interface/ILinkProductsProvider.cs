using System;
using System.Collections.Generic;
using System.Text;

namespace Provider.Interface
{
    public interface ILinkProductsProvider
    {
        Func<T, bool> CompileRule<T>(Rule r);
    }
}
