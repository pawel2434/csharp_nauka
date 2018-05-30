using System;

namespace ConsoleApp10
{
    internal class Calkulate:ICalkulate
    {
        private int _value;
        public Calkulate()
        {
        }

        public ICalkulate Add(int v)
        {
            _value += v;
            return this;
        }

        public ICalkulate Sub(int v)
        {
            _value -= v;
            return this;
        }

        internal ICalkulate Set(int v)
        {
            _value = v;
            return this;
        }
        public override string ToString()
        {
            return _value.ToString();
        }

        public ICalkulate Pow(int v)
        {
            var tem = _value;
            for (var i = 1; i < v; i++)
            {
                _value *= tem;

            }
            return this;
        }

       
    }
}