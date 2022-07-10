using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace MessageEncoder
{
    public static class Encoder
    {
        public static string EncodeMessage(string message)
        {
            byte[] encodedBytes = Encoding.UTF8.GetBytes(message);
            string encodedMessage = WebEncoders.Base64UrlEncode(encodedBytes);
            return encodedMessage;
        }

        public static string DecodeMessage(string encodedMessage)
        {
            byte[] decodedBytes = WebEncoders.Base64UrlDecode(encodedMessage);
            string decodedMessage = Encoding.UTF8.GetString(decodedBytes);
            return decodedMessage;
        }
    }
}