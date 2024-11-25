using System.Collections.Generic;

namespace campus_molndal_oop_adv._01_oop_sqlite.Classes
{
    internal class Pair<T, U>
    {
        private T _first;
        private U _second;

        public Pair(T first, U second)
        {
            _first = first;
            _second = second;
        }

        public T First
        {
            get { return _first; }
            set { _first = value; }
        }
        public U Second
        {
            get { return _second; }
            set { _second = value; }
        }
        // Metod för att representera paret som en sträng
        public override string ToString()
        {
            return $"({_first}, {_second})";
        }
    }
}
