using System;

namespace edx_Microsoft_DEV204.2x.Mod3
{
    public class ManagedWord : IDisposable
    {
        bool _isDisposed;
        public void Dispose()
        {
           throw new NotImplementedException();
        }
        public void OpenWordDocument(string filePath)
    {
       if (this._isDisposed)
          throw new ObjectDisposedException("ManagedWord");
           ...
    }
    protected virtual void Dispose(bool isDisposing)
        {
            if (this._isDisposed)
                return;
            if (isDisposing)
            {
               // Release only managed resources.
               ...
            }
            // Always release unmanaged resources.
            ...
            // Indicate that the object has been disposed.
            this._isDisposed = true;
        }
        public void Dispose()
    {
       Dispose(true);
       GC.SuppressFinalize(this);
    }
    // Defining a Destructor
class ManagedWord
{
    ...
    // Destructor
    ~ManagedWord()
    {
        // Destructor logic.
        Dispose(false);
    }
}
// Invoking the Dispose Method
var word = new ManagedWord();
 // Code to use the ManagedWord object.
word.Dispose();

// Invoking the Dispose Method in a finally Block
var word = default(ManagedWord);
try
{
   word = new ManagedWord();
   // Code to use the ManagedWord object.
}
catch
{
    // Code to handle any errors.
}
finally
{
   if(word!=null)
      word.Dispose();
}
// Disposing Of an Object by Using a using Statement
using (var word = default(ManagedWord))
{
   // Code to use the ManagedWord object.
}
     
    }
}