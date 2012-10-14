using System;
using System.Collections.Generic;
using System.Web;

public static class Informacion
{
    public const String[] nombres = {"makabeo","zhionit","zheref","batman","suphavanegas","frenterodilla","toño","mulk","lachole","elbarto"};
    public const String[] claves = {"0924","sergio","alatairis","darks","motorhead","calvo","chucho","verde","naranja","jijijiji"};

    public Boolean IsUsuario(var nombre, var clave)
    {
        Boolean isEncontrado = false;
        for(int i = 0; i < nombres.Length; i++)
        {
            if(nombres[i] == nombre && claves[i] == clave)
            {
                isEncontrado = true;
            }
            else
            {
                isEncontrado = false;
            }
        }
        return isEncontrado;
    }
}

