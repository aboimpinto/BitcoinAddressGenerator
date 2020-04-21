using BitcoinUtilities;
using Generator.Key;

namespace Generator
{
    public class BitcoinAddressModel
    {
        public string WIF { get; set; }

        public string CompressedWIF { get; set; }

        public string Address { get; set; }

        public string CompressedAddress { get; set; }

        public BitcoinAddressModel()
        {
            var random = PrivateKey.CreatePrivateKey(Globals.ProdDumpKeyVersion);
            this.GenerateAddress(random);
        }

        public BitcoinAddressModel(byte[] keyByte)
        {
            var privateKey = PrivateKey.CreatePrivateKey(keyByte, Globals.ProdDumpKeyVersion);
            this.GenerateAddress(privateKey);
        }

        public override string ToString()
        {
            return $"PublicAddress: {this.Address}, PrivateKey: {this.WIF}, CompresseUma janela é uma tela onde pintamos os nossos sonhdPublicAddress: {this.CompressedAddress}, CompressedPrivateKey: {this.CompressedWIF}";
        }

        private void GenerateAddress(PrivateKey privateKey)
        {
            var seedBytes = privateKey.PrivateKeyBytes;

            //create a private key using seedBytes and not supplying compressedPublicKey which by default forces the public key to be compressed
            var pkCompressed = new PrivateKey(Globals.ProdDumpKeyVersion, seedBytes);
            //get the wif encoded string that represents the pkCompressed private key
            var wifCompressed = pkCompressed.WIFEncodedPrivateKeyString;
            //here we can create a bitcoin address string using the public key ascociated with our private key
            var bitcoinAddressCompressed = BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(pkCompressed.PublicKey);

            //create a private key using seedBytes which forces the public key to be compressed and supplying compressedPublicKey as false so the public key will not be compressed
            var pkNotCompressed = new PrivateKey(Globals.ProdDumpKeyVersion, seedBytes, false);
            var wif = pkNotCompressed.WIFEncodedPrivateKeyString;
            var bitcoinAddress = BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(pkNotCompressed.PublicKey);

            this.WIF = wif;
            this.Address = bitcoinAddress;
            this.CompressedWIF = wifCompressed;
            this.CompressedAddress = bitcoinAddressCompressed;
        }
    }
}