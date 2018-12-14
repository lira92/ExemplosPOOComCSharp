public static class ValidadorDeCpf
{
    public static bool Validar(string numero)
    {
        return numero.Length == 11;
    }
}