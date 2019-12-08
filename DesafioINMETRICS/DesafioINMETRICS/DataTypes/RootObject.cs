using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.DataTypes
{
    public class RootObject
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }
}
