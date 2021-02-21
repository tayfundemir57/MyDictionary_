using System;

namespace MyDictionary_
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string> Dersler = new MyDictionary<string>();

            Dersler.Add("Türçe");
            Dersler.Add("Matematik");
            Dersler.Add("Kimya");
            Dersler.Add("Teknik Resim");
            Console.WriteLine(Dersler.Count);
        }
    }


    class MyDictionary<T>
    {
        T[] _mydictionary;
        T[] _tempMyDictionary;

        public MyDictionary()
        {
            _mydictionary = new T[0];

        }

        public void Add(T item)
        {
            _tempMyDictionary = _mydictionary;

            _mydictionary = new T[_mydictionary.Length + 1];

            for (int i = 0; i < _tempMyDictionary.Length; i++)
            {

                _mydictionary[i] = _tempMyDictionary[i];

            }

            _mydictionary[_mydictionary.Length - 1] = item;

        }

        public int Count
        {

            get { return _mydictionary.Length; }

        }


    }

}
