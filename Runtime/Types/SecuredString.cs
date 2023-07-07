using System;
using System.Text;

namespace Kukumberman.SecuredVariables
{
    public sealed class SecuredString
    {
        public static bool UseBase64Format = true;

        private readonly byte _offset;
        private string _value;

        public SecuredString(string value = "")
        {
            _offset = SecuredVariablesHelper.GenerateOffset();
            Value = value;
        }

        public string Value
        {
            get =>
                UseBase64Format
                    ? Encoding.UTF8.GetString(Convert.FromBase64String(_value))
                    : Xor(_value);
            set
            {
                _value = UseBase64Format
                    ? Convert.ToBase64String(Encoding.UTF8.GetBytes(value))
                    : Xor(value);
            }
        }

        public string GetRealValue() => _value;

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(SecuredString value)
        {
            return value.Value;
        }

        public static implicit operator SecuredString(string value)
        {
            return new SecuredString(value);
        }

        private string Xor(string value)
        {
            var charArray = new char[value.Length];

            for (var i = 0; i < charArray.Length; i++)
            {
                charArray[i] = (char)(value[i] ^ _offset);
            }

            return new string(charArray);
        }
    }
}
