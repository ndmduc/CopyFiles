using System;

namespace CopyFiles.CopyCore
{
    public interface ICopy
    {
        void Copy(string source, string destination, Action<double, bool> progressChange, Action completed);
    }
}
