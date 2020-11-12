
using System;
using System.Threading.Tasks;
using AddressGenerator;
using StackExchange.Redis;

namespace Generator
{
    partial class Program
    {
        static async Task Main(string[] args)
        {
            var connectionMultiplexer = await ConnectionMultiplexer.ConnectAsync("127.0.0.1");
            var redisDb = connectionMultiplexer.GetDatabase(1);

            if (redisDb == null)
            {
                throw new ApplicationException("Could not establish connection with the Redis database");
            }

            while (true)
            {
                var newPrivateKeyBytes = new Bitcoin().GenerateBitcoinKeyByte();

                var value = Convert.ToBase64String(newPrivateKeyBytes);
                var key = $"Phase0:Worker1:{value}";
                
                var streamValue = new NameValueEntry[1];
                streamValue[0] = new NameValueEntry(key, value);
            
                await redisDb
                    .StreamAddAsync("Phase0", streamValue)
                    .ConfigureAwait(false);

                // var verifiedKey = Convert.FromBase64String(key);
            }

            // var random = PrivateKey.CreatePrivateKey(Globals.ProdDumpKeyVersion);
            // var seedBytes = random.PrivateKeyBytes;

            // //create a private key using seedBytes and not supplying compressedPublicKey which by default forces the public key to be compressed
            // var pkCompressed = new PrivateKey(Globals.ProdDumpKeyVersion, seedBytes);
            // //get the wif encoded string that represents the pkCompressed private key
            // var wifCompressed = pkCompressed.WIFEncodedPrivateKeyString;
            // //here we can create a bitcoin address string using the public key ascociated with our private key
            // var bitcoinAddressCompressed = BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(pkCompressed.PublicKey);

            // //create a private key using seedBytes which forces the public key to be compressed and supplying compressedPublicKey as false so the public key will not be compressed
            // var pkNotCompressed = new PrivateKey(Globals.ProdDumpKeyVersion, seedBytes, false);
            // var wif = pkNotCompressed.WIFEncodedPrivateKeyString;
            // var bitcoinAddress = BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(pkNotCompressed.PublicKey);

            // Console.WriteLine($"{bitcoinAddressCompressed} | {random.ToString()}");
            // Console.WriteLine($"{bitcoinAddress} | {wif}");
        }

        public static byte[] StringToByteArrayFastest(string hex) 
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        public static int GetHexVal(char hex) 
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
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




            