using System.Text;
using System.Text.RegularExpressions;

public enum NivelSenha
{
    Vazio = 0,
    MuitoFraco = 1,
    Fraco = 2,
    Medio = 3,
    Forte = 4,
    MuitoForte = 5
}

public class ForcaSenha
{
    public static int pontos;

    public static NivelSenha checarForca(string password)
    {
        pontos = 1;

        if (password.Length < 1)
            return NivelSenha.Vazio;
        if (password.Length < 4)
            return NivelSenha.MuitoFraco;

        if (password.Length >= 8)
            pontos++;
        if (password.Length >= 12)
            pontos++;
        if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
            pontos++;
        if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //both, lower and upper case
            pontos++;
        if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
            pontos++;
        return (NivelSenha)pontos;
    }
}