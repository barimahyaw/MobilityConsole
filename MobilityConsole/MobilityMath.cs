using System.Runtime.InteropServices;

namespace MobilityConsole;

public static class MobilityMath
{
    public static int Multiply(int num1, int num2)
    {
        [DllImport("MobilityMultiplier.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Multiply(int a, int b);
        int result = Multiply(num1, num2);
        return result;
    }
}