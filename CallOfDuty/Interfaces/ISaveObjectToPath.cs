using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Interfaces
{
    public interface ISaveObjectToPath<T>
    {
        void SaveObject(T configuration, string path);
    }
}
