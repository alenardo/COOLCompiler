﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COOLLenguage.SemanticCheck.AST1
{
    public interface IType
    {
        string Type { get; }
        List<Feature> Fetures { get; }
    }
}
