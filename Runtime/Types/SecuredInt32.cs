namespace Kukumberman.SecuredVariables
{
    public sealed class SecuredInt32
    {
        private readonly byte _offset;
        private int _value;

        public SecuredInt32(int value = 0)
        {
            _offset = SecuredVariablesHelper.GenerateOffset();
            Value = value;
        }

        public int Value
        {
            get => _value ^ _offset;
            set { _value = value ^ _offset; }
        }

        public int GetRealValue() => _value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator int(SecuredInt32 value)
        {
            return value.Value;
        }

        public static implicit operator SecuredInt32(int value)
        {
            return new SecuredInt32(value);
        }
    }
}
