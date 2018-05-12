using System;

namespace Course {
    class PrintService<T> {

        private T[] _values = new T[10];
        private int _cont = 0;

        public void AddValue(T value) {
            if (_cont == 10) {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_cont] = value;
            _cont++;
        }

        public T First {
            get { return _values[0]; }
        }

        public void Print() {
            Console.Write("[");
            for (int i = 0; i < _cont - 1; i++) {
                Console.Write(_values[i] + ", ");
            }
            if (_cont > 0) {
                Console.Write(_values[_cont - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
