using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibonacci
{
    struct BigIntMat
    {
        public BigInteger M11, M12;
        public BigInteger M21, M22;
        public BigIntMat(BigInteger M11, BigInteger M12,BigInteger M21,BigInteger M22)
        {
            this.M11 = M11; this.M12 = M12;
            this.M21 = M21; this.M22 = M22;
        }

        public static BigIntMat operator * (BigIntMat left, BigIntMat right)
        {
            return new BigIntMat(left.M11 * right.M11 + left.M12 * right.M21, left.M11 * right.M12 + left.M12 * right.M22,
                left.M21 * right.M11 + left.M22 * right.M21, left.M21 * right.M12 + left.M22 * right.M22);
        }
        public static BigIntMat operator + (BigIntMat left, BigIntMat right)
        {
            return new BigIntMat(left.M11 + right.M11, left.M12 + right.M12, left.M21 + right.M21, left.M22 + right.M22);
        }
    }
}
