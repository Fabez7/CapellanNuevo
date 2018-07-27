
namespace SIC.Intranet.Dominio
{
    using System;
    public abstract class EntidadBase : IDisposable
    {
        #region Miembros de IDisposable

        public void Dispose()
        {
            GC.Collect();

       
        }

        #endregion
    }
}