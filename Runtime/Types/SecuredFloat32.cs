namespace Kukumberman.SecuredVariables
{
    public sealed class SecuredFloat32
    {
        private readonly byte _offset;
        private float _value;

        public SecuredFloat32(float value = 0)
        {
            _offset = SecuredVariablesHelper.GenerateOffset();
            Value = value;
        }

        public float Value
        {
            get => _value * _offset;
            set { _value = value / _offset; }
        }

        public float GetRealValue() => _value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator float(SecuredFloat32 value)
        {
            return value.Value;
        }

        public static implicit operator SecuredFloat32(float value)
        {
            return new SecuredFloat32(value);
        }
    }
}
