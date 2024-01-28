using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss
{
    internal interface ICrud
    {
        void Create();
        void Visualization();
        void Update();
        void Delete();
        void Search();
        void More();
    }
}
