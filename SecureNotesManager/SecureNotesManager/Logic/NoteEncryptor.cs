using System;
using System.Linq;
using System.Text;

namespace SecureNotesManager.Logic
{
    public class NoteEncryptor
    {
        private const string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Lower = "abcdefghijklmnopqrstuvwxyz";
        private const string Number = "0123456789";

        private readonly char[] UpperArray = Upper.ToCharArray();
        private readonly char[] LowerArray = Lower.ToCharArray();
        private readonly char[] NumberArray = Number.ToCharArray();
        
        public string Encrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return ProcessText(input, forward: true);
        }
        
        public string Decrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return ProcessText(input, forward: false);
        }

        private string ProcessText(string text, bool forward)
        {
            char[] buffer = text.ToCharArray();
            int shift = forward ? 1 : -1;

            for (int i = 0; i < buffer.Length; i++)
            {
                char c = buffer[i];

                if (char.IsUpper(c))
                {
                    buffer[i] = ShiftChar(c, UpperArray, shift);
                }
                else if (char.IsLower(c))
                {
                    buffer[i] = ShiftChar(c, LowerArray, shift);
                }
                else if (char.IsDigit(c))
                {
                    buffer[i] = ShiftChar(c, NumberArray, shift);
                }
            }

            return new string(buffer);
        }

        private char ShiftChar(char c, char[] array, int shift)
        {
            int index = Array.IndexOf(array, c);
            int length = array.Length;
            
            int newIndex = (index + shift + length) % length;

            return array[newIndex];
        }
    }
}