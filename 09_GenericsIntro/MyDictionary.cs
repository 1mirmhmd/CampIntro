namespace _09_GenericsIntro
{
    class MyDictionary<Key, Value>
    {
        Key[] _keys;
        Value[] _values;
        public MyDictionary()
        {
            _keys = new Key[0];
            _values = new Value[0];
        }
        public void Add(Key key, Value value)
        {
            Key[] tempKeys = _keys;
            Value[] tempValues = _values;

            _keys = new Key[_keys.Length + 1];
            _values = new Value[_keys.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                _values[i] = tempValues[i];
            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        public Key[] Keys
        {
            get { return _keys; }

        }
        public Value[] Values
        {
            get { return _values; }

        }

    }
}