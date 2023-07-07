namespace Kukumberman.SecuredVariables
{
    public sealed class SecuredInt64
    {
        private readonly byte _offset;
        private long _value;

        public SecuredInt64(long value = 0)
        {
            _offset = SecuredVariablesHelper.GenerateOffset();
            Value = value;
        }

        public long Value
        {
            get => _value ^ _offset;
            set { _value = value ^ _offset; }
        }

        public long GetRealValue() => _value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator long(SecuredInt64 value)
        {
            return value.Value;
        }

        public static implicit operator SecuredInt64(long value)
        {
            return new SecuredInt64(value);
        }
    }
}
