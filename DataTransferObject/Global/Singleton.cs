using System.Collections;
using System;
using System.Threading;

public class Singleton<T> where T : class, new()
{
    private static T instance = null;

    public static T Instance
    {
        get
        {
            if (instance == null)
                Interlocked.CompareExchange(ref instance, new T(), null);

            return instance;
        }
    }
}