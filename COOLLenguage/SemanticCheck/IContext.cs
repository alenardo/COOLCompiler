﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COOLLenguage.SemanticCheck
{
    public interface IContext
    {
        IType GetType(string typeName);
        IType GetTypeFor(string symbol);
        IContext CreateChildContext();
        bool DefineVariable(string symbol, IType type);
        IType CreateType(string name);
    }
}
