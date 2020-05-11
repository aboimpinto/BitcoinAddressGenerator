using System;
using System.IO;
using BitcoinUtilities;
using Generator.Key;

namespace Generator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var random = PrivateKey.CreatePrivateKey(Globals.ProdDumpKeyVersion);


            
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




            // var keyByte = new byte[32];
            // StreamWriter writer = null;

            // for (keyByte[0]=0; keyByte[0] <= 255; keyByte[0]++)
            // {
            //     for (keyByte[1]=0; keyByte[1] < 255; keyByte[1]++)
            //     {
            //         for (keyByte[2]=0; keyByte[2] < 255; keyByte[2]++)
            //         {
            //             for (keyByte[3]=0; keyByte[3] < 255; keyByte[3]++)
            //             {
            //                 for (keyByte[4]=0; keyByte[4] < 255; keyByte[4]++)
            //                 {
            //                     for (keyByte[5]=0; keyByte[5] < 255; keyByte[5]++)
            //                     {
            //                         for (keyByte[6]=0; keyByte[6] < 255; keyByte[6]++)
            //                         {
            //                             for (keyByte[7]=0; keyByte[7] < 255; keyByte[7]++)
            //                             {
            //                                 for (keyByte[8]=0; keyByte[8] < 255; keyByte[8]++)
            //                                 {
            //                                     for (keyByte[9]=0; keyByte[9] < 255; keyByte[9]++)
            //                                     {
            //                                         for (keyByte[10]=0; keyByte[10] < 255; keyByte[10]++)
            //                                         {
            //                                             for (keyByte[11]=0; keyByte[11] < 255; keyByte[11]++)
            //                                             {
            //                                                 for (keyByte[12]=0; keyByte[12] < 255; keyByte[12]++)
            //                                                 {
            //                                                     for (keyByte[13]=0; keyByte[13] < 255; keyByte[13]++)
            //                                                     {
            //                                                         for (keyByte[14]=0; keyByte[14] < 255; keyByte[14]++)
            //                                                         {
            //                                                             for (keyByte[15]=0; keyByte[15] < 255; keyByte[15]++)
            //                                                             {
            //                                                                 for (keyByte[16]=0; keyByte[16] < 255; keyByte[16]++)
            //                                                                 {
            //                                                                     for (keyByte[17]=0; keyByte[17] < 255; keyByte[17]++)
            //                                                                     {
            //                                                                         for (keyByte[18]=0; keyByte[18] < 255; keyByte[18]++)
            //                                                                         {
            //                                                                             for (keyByte[19]=0; keyByte[19] < 255; keyByte[19]++)
            //                                                                             {
            //                                                                                 for (keyByte[20]=0; keyByte[20] < 255; keyByte[20]++)
            //                                                                                 {
            //                                                                                     for (keyByte[21]=0; keyByte[21] < 255; keyByte[21]++)
            //                                                                                     {
            //                                                                                         for (keyByte[22]=0; keyByte[22] < 255; keyByte[22]++)
            //                                                                                         {
            //                                                                                             for (keyByte[23]=0; keyByte[23] < 255; keyByte[23]++)
            //                                                                                             {
            //                                                                                                 for (keyByte[24]=0; keyByte[24] < 255; keyByte[24]++)
            //                                                                                                 {
            //                                                                                                     for (keyByte[25]=0; keyByte[25] < 255; keyByte[25]++)
            //                                                                                                     {
            //                                                                                                         for (keyByte[26]=0; keyByte[26] < 255; keyByte[26]++)
            //                                                                                                         {
            //                                                                                                             for (keyByte[27]=0; keyByte[27] < 255; keyByte[27]++)
            //                                                                                                             {
            //                                                                                                                 for (keyByte[28]=0; keyByte[28] < 255; keyByte[28]++)
            //                                                                                                                 {
            //                                                                                                                     for (keyByte[29]=0; keyByte[29] < 255; keyByte[29]++)
            //                                                                                                                     {
            //                                                                                                                         for (keyByte[30]=0; keyByte[30] <= 255; keyByte[30]++)
            //                                                                                                                         {
            //                                                                                                                             for (keyByte[31]=0; keyByte[31] <= 255; keyByte[31]++)
            //                                                                                                                             {
            //                                                                                                                                 if (writer == null && keyByte[31] == 0)
            //                                                                                                                                 {
            //                                                                                                                                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                                                                 }
            //                                                                                                                                 else
            //                                                                                                                                 {
            //                                                                                                                                     var bitcoinAddress = new BitcoinAddressModel(keyByte);
            //                                                                                                                                     // writer.WriteLine(bitcoinAddress.ToString());
            //                                                                                                                                     writer.WriteLine($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}");
            //                                                                                                                                 }
            //                                                                                                                             }
            //                                                                                                                         }
            //                                                                                                                         writer.Flush();
            //                                                                                                                         writer.Close();
            //                                                                                                                         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                                                     }
            //                                                                                                                     writer.Flush();
            //                                                                                                                     writer.Close();
            //                                                                                                                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                                                 }
            //                                                                                                                 writer.Flush();
            //                                                                                                                 writer.Close();
            //                                                                                                                 writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                                             }
            //                                                                                                             writer.Flush();
            //                                                                                                             writer.Close();
            //                                                                                                             writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                                         }
            //                                                                                                         writer.Flush();
            //                                                                                                         writer.Close();
            //                                                                                                         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                                     }
            //                                                                                                     writer.Flush();
            //                                                                                                     writer.Close();
            //                                                                                                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                                 }
            //                                                                                                 writer.Flush();
            //                                                                                                 writer.Close();
            //                                                                                                 writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                             }
            //                                                                                             writer.Flush();
            //                                                                                             writer.Close();
            //                                                                                             writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                         }
            //                                                                                         writer.Flush();
            //                                                                                         writer.Close();
            //                                                                                         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                     }
            //                                                                                     writer.Flush();
            //                                                                                     writer.Close();
            //                                                                                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                                 }
            //                                                                                 writer.Flush();
            //                                                                                 writer.Close();
            //                                                                                 writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                             }
            //                                                                             writer.Flush();
            //                                                                             writer.Close();
            //                                                                             writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                         }
            //                                                                         writer.Flush();
            //                                                                         writer.Close();
            //                                                                         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                     }
            //                                                                     writer.Flush();
            //                                                                     writer.Close();
            //                                                                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                                 }
            //                                                                 writer.Flush();
            //                                                                 writer.Close();
            //                                                                 writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                             }
            //                                                             writer.Flush();
            //                                                             writer.Close();
            //                                                             writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                         }
            //                                                         writer.Flush();
            //                                                         writer.Close();
            //                                                         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                     }
            //                                                     writer.Flush();
            //                                                     writer.Close();
            //                                                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                                 }
            //                                                 writer.Flush();
            //                                                 writer.Close();
            //                                                 writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                             }
            //                                             writer.Flush();
            //                                             writer.Close();
            //                                             writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                         }
            //                                         writer.Flush();
            //                                         writer.Close();
            //                                         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                     }
            //                                     writer.Flush();
            //                                     writer.Close();
            //                                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                                 }
            //                                 writer.Flush();
            //                                 writer.Close();
            //                                 writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");                                            
            //                             }
            //                             writer.Flush();
            //                             writer.Close();
            //                             writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                         }
            //                         writer.Flush();
            //                         writer.Close();
            //                         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                     }
            //                     writer.Flush();
            //                     writer.Close();
            //                     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //                 }
            //                 writer.Flush();
            //                 writer.Close();
            //                 writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //             }
            //             writer.Flush();
            //             writer.Close();
            //             writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //         }    
            //         writer.Flush();
            //         writer.Close();
            //         writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            //     }
            //     writer.Flush();
            //     writer.Close();
            //     writer = new StreamWriter($"{keyByte[0]}.{keyByte[1]}.{keyByte[2]}.{keyByte[3]}.{keyByte[4]}.{keyByte[5]}.{keyByte[6]}.{keyByte[7]}.{keyByte[8]}.{keyByte[9]}.{keyByte[10]}.{keyByte[11]}.{keyByte[12]}.{keyByte[13]}.{keyByte[14]}.{keyByte[15]}.{keyByte[16]}.{keyByte[17]}.{keyByte[18]}.{keyByte[19]}.{keyByte[20]}.{keyByte[21]}.{keyByte[22]}.{keyByte[23]}.{keyByte[24]}.{keyByte[25]}.{keyByte[26]}.{keyByte[27]}.{keyByte[28]}.{keyByte[29]}.{keyByte[30]}.{keyByte[31]}.txt");
            // }
            
            // writer.Flush();
            // writer.Close();

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("THE END...");
            // Console.ReadLine();