using System.Security.Cryptography;

namespace PasswordStrengthAnalyzer.Logic;

public class CreateStrongPassword
{
    public const string Upper = "ABCDEFGHIGKLMNOPQRSTUVWXYZ";
    public const string Lower = "abcdefghijklmnopqrstuvwxyz";
    public const string Number  = "0123456789";
    public const string Symbol = "!@#$%^&*+-=:;()";
   
    public readonly int size;
    public readonly char[] newStrongPassword;
    
    public CreateStrongPassword()
    { 
        size = RandomNumberGenerator.GetInt32(14, 21);

    newStrongPassword = new char[size];   
}

    public string StrongPasswordGenerator()
    {
        int indexUpper = RandomNumberGenerator.GetInt32(0, Upper.Length);
        int indexLower = RandomNumberGenerator.GetInt32(0, Lower.Length);
        int indexNumber = RandomNumberGenerator.GetInt32(0, Number.Length);
        int indexSymbol = RandomNumberGenerator.GetInt32(0, Symbol.Length);

        newStrongPassword[0] = Upper[indexUpper];
        newStrongPassword[1] = Lower[indexLower];
        newStrongPassword[2] = Number[indexNumber];
        newStrongPassword[3] = Symbol[indexSymbol];
        
        string All = Upper+Lower+Number+Symbol;
        int index;

        for (int i = 4; i < size; i++)
        {
            index = RandomNumberGenerator.GetInt32(All.Length);
            newStrongPassword[i] = All[index];
        }
        
        for (int i = newStrongPassword.Length - 1; i >= 0; i--)
        {
            int j = RandomNumberGenerator.GetInt32(0, i+1);
            char temp = newStrongPassword[i];
            newStrongPassword[i] = newStrongPassword[j];
            newStrongPassword[j] = temp;
        }

        string password = new string(newStrongPassword);
        return password;
    }
    public void ClearPassword()
    {
        Array.Clear(newStrongPassword, 0, newStrongPassword.Length);
    }
}