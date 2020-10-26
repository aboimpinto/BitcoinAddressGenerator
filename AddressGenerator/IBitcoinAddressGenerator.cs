namespace AddressGenerator
{
    public interface IBitcoinAddressGenerator
    {
        byte[] GenerateBitcoinKeyByte();

        void GenerateAddress();

        void GenerateAddress(byte[] keyByte);
    }
}