using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceTest
{
    class Wrapper<T> : IWrapper<T>
    {
        private T storedData;

        T IWrapper<T>.GetData()
        {
            return this.storedData;
        }

        void IWrapper<T>.SetData(T data)
        {
            this.storedData = data;
        }
    }
}
