using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// A troca de chaves permite que um remetente crie informações secretas 
// (como dados aleatórios que podem ser usados como chave em um algoritmo de criptografia simétrica)
// e use criptografia para enviá-la ao destinatário pretendido.

// Recomendamos que você não tente criar seu próprio método de troca de chaves a partir da funcionalidade básica fornecida, 
// pois muitos detalhes da operação devem ser realizados cuidadosamente para que a troca de chaves seja bem sucedida.


namespace _32_Criptografia_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (Bob bob = new Bob())
            {
                using (RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider())
                {
                    // Get Bob's public key
                    rsaKey.ImportCspBlob(bob.key);
                    byte[] encryptedSessionKey = null;
                    byte[] encryptedMessage = null;
                    byte[] iv = null;
                    Send(rsaKey, "Secret message", out iv, out encryptedSessionKey, out encryptedMessage);
                    bob.Receive(iv, encryptedSessionKey, encryptedMessage);
                }
            }
        }

        private static void Send(RSA key, string secretMessage, out byte[] iv, out byte[] encryptedSessionKey, out byte[] encryptedMessage)
        {
            using (Aes aes = new AesCryptoServiceProvider())
            {
                iv = aes.IV;

                // Encrypt the session key
                RSAPKCS1KeyExchangeFormatter keyFormatter = new RSAPKCS1KeyExchangeFormatter(key);
                encryptedSessionKey = keyFormatter.CreateKeyExchange(aes.Key, typeof(Aes));

                // Encrypt the message
                using (MemoryStream ciphertext = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ciphertext, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] plaintextMessage = Encoding.UTF8.GetBytes(secretMessage);
                    cs.Write(plaintextMessage, 0, plaintextMessage.Length);
                    cs.Close();

                    encryptedMessage = ciphertext.ToArray();
                }
            }
        }
    }
    public class Bob : IDisposable
    {
        public byte[] key;
        private RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();
        public Bob()
        {
            key = rsaKey.ExportCspBlob(false);
        }
        public void Receive(byte[] iv, byte[] encryptedSessionKey, byte[] encryptedMessage)
        {

            using (Aes aes = new AesCryptoServiceProvider())
            {
                aes.IV = iv;

                // Decrypt the session key
                RSAPKCS1KeyExchangeDeformatter keyDeformatter = new RSAPKCS1KeyExchangeDeformatter(rsaKey);
                aes.Key = keyDeformatter.DecryptKeyExchange(encryptedSessionKey);

                // Decrypt the message
                using (MemoryStream plaintext = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(plaintext, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(encryptedMessage, 0, encryptedMessage.Length);
                    cs.Close();

                    string message = Encoding.UTF8.GetString(plaintext.ToArray());
                    Console.WriteLine(message);
                }
            }
        }
        public void Dispose()
        {
            rsaKey.Dispose();
        }
    }
}
