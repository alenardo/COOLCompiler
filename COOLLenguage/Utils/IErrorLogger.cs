﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COOLLenguage.Utils
{
    public interface IErrorLogger
    {
        void LogError(string ErrorMessage);
    }
}
