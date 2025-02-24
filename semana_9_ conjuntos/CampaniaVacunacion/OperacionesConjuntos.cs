// OperacionesConjuntos.cs
using System;
using System.Collections.Generic;
using System.Linq;

public static class OperacionesConjuntos
{
    public static int ContarConjunto(HashSet<Ciudadano> conjunto)
    {
        return conjunto.Count;
    }

    public static HashSet<Ciudadano> Interseccion(HashSet<Ciudadano> conjunto1, HashSet<Ciudadano> conjunto2)
    {
        return new HashSet<Ciudadano>(conjunto1.Intersect(conjunto2));
    }

    public static HashSet<Ciudadano> Diferencia(HashSet<Ciudadano> conjunto1, HashSet<Ciudadano> conjunto2)
    {
        return new HashSet<Ciudadano>(conjunto1.Except(conjunto2));
    }

    public static HashSet<Ciudadano> UnirConjuntos(HashSet<Ciudadano> conjunto1, HashSet<Ciudadano> conjunto2)
    {
        return new HashSet<Ciudadano>(conjunto1.Union(conjunto2));
    }
}
