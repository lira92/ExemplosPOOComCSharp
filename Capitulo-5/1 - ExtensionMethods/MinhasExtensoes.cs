using System;

public static class MinhasExtensoes
{
    public static bool EhUmCpf(this string texto)
    {
        return texto.Length == 11;
    }

    public static bool EhMeuAniversario(this DateTime data)
    {
        return data.Date == new DateTime(1992, 7, 6).Date;
    }
}