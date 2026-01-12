namespace PasswordStrengthAnalyzer.Logic;

public class PasswordChecker
{
    public string InputPassword { get; set; }
    public bool HasUpper { get; set; } 
    public bool HasLower { get; set; }
    public bool HasNumber { get; set; }
    public bool HasSpecial { get; set; }

    private const string specialSymbols = "!@#$%^&*()_-+=<>?:;,.";

    public PasswordLevels CheckPasswordStrength()
    {
    HasUpper = InputPassword.Any(char.IsUpper);
    HasLower = InputPassword.Any(char.IsLower);
    HasNumber = InputPassword.Any(char.IsDigit); 
    HasSpecial = InputPassword.Any(c =>  specialSymbols.Contains(c) );

    if (HasUpper && HasLower && HasNumber && HasSpecial && InputPassword.Length >= 14 && InputPassword.Length <= 48)
    {
        return PasswordLevels.VeryStrong;
    }
    else if (HasUpper && HasLower && HasNumber && HasSpecial && InputPassword.Length > 8 && InputPassword.Length < 14)
    {
        return PasswordLevels.Strong;
    }
    else if (HasUpper && HasLower && HasNumber && HasSpecial && InputPassword.Length == 8)
    {
        return PasswordLevels.Medium;
    }
    else if (HasUpper && HasLower && HasNumber && !HasSpecial && InputPassword.Length >= 6 && InputPassword.Length <= 8)
    {
        return PasswordLevels.Low;
    }
    else
    {
        return PasswordLevels.Invalid;
    }
    }
}