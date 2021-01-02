using System;
using System.Collections.Generic;
using System.Text;

namespace SecureNumber
{
    internal interface ISecureNumber<BaseType, SecureType> : IComparable, IComparable<SecureType>, IEquatable<SecureType>, IFormattable
    {
        BaseType ToPrimitive();
    }
}
