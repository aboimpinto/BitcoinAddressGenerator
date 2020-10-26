using System;

namespace AddressGenerator
{
    public class Bitcoin : IBitcoinAddressGenerator
    {
        public byte[] GenerateBitcoinKeyByte()
        {
            return new PrivateKeyBytesGenerator().GetRandomBytes(32);
        }

        public void GenerateAddress()
        {
            throw new NotImplementedException();
        }

        public void GenerateAddress(byte[] keyByte)
        {
            throw new NotImplementedException();
        }
    }
}
