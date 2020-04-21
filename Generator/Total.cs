namespace Generator
{
    partial class Program
    {
        public class Total
        {
            public string received { get; set; }
            public int received_int { get; set; }
            public string spent { get; set; }
            public int spent_int { get; set; }
            public string balance { get; set; }
            public int balance_int { get; set; }
            public int input_count { get; set; }
            public int output_count { get; set; }
            public int transaction_count { get; set; }
        }
    }
}


            // var bFounded = false;
            // var count = 0;

            // while (!bFounded)
            // {
            //     var random = PrivateKey.CreatePrivateKey(Globals.ProdDumpKeyVersion);
            //     var seedBytes = random.PrivateKeyBytes;

            //     //create a private key using seedBytes and not supplying compressedPublicKey which by default forces the public key to be compressed
            //     var pkCompressed = new PrivateKey(Globals.ProdDumpKeyVersion, seedBytes);
            //     //get the wif encoded string that represents the pkCompressed private key
            //     var wifCompressed = pkCompressed.WIFEncodedPrivateKeyString;
            //     //here we can create a bitcoin address string using the public key ascociated with our private key
            //     var bitcoinAddressCompressed = BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(pkCompressed.PublicKey);

            //     //create a private key using seedBytes which forces the public key to be compressed and supplying compressedPublicKey as false so the public key will not be compressed
            //     var pkNotCompressed = new PrivateKey(Globals.ProdDumpKeyVersion, seedBytes, false);
            //     var wif = pkNotCompressed.WIFEncodedPrivateKeyString;
            //     var bitcoinAddress = BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(pkNotCompressed.PublicKey);

            //     WebClient client = new WebClient();
            //     var response = client.DownloadString($"https://api.smartbit.com.au/v1/blockchain/address/{bitcoinAddress}");

            //     var rootObject = JsonConvert.DeserializeObject<RootObject>(response);
            //     if (rootObject.address.total.balance_int > 0)
            //     {
            //         Console.WriteLine($"WIF: {wif}");
            //         Console.WriteLine($"Bitcoin Address: {bitcoinAddress}");
            //         Console.WriteLine($"WIF Compressed: {wifCompressed}");
            //         Console.WriteLine($"Bitcoin Address Compressed: {bitcoinAddressCompressed}");

            //         bFounded = true;
            //     }

            //     count ++;
            //     Console.WriteLine($"{count}: {bitcoinAddress} | {wif} | {rootObject.address.total.balance_int} | {bFounded}");

            // }