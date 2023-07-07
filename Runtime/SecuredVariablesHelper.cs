using System;

namespace Kukumberman.SecuredVariables
{
    public static class SecuredVariablesHelper
    {
        private static readonly Random Random = new Random(DateTime.Now.Millisecond);

        public static byte GenerateOffset()
        {
            return (byte)Random.Next(146, 256);
        }
    }
}
