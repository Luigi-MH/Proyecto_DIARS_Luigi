using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoDoc
    {
        private readonly static logTipoDoc _instancia = new logTipoDoc();

        private logTipoDoc()
        { }

        public static logTipoDoc Instancia
        {
            get { return _instancia; }
        }

        public List<entTipoDoc> ListarTipoDoc()
        {
            return datTipoDoc.Instancia.ListarTipoDoc();
        }

        public List<entTipoDoc> ListarTiposDocumento_Todo()
        {
            return datTipoDoc.Instancia.ListarTiposDocumento_Todo();
        }

        public Boolean AgregarTipoDoc(entTipoDoc tipoDoc)
        {
            return datTipoDoc.Instancia.AgregarTipoDoc(tipoDoc);
        }

        public Boolean ModificaTipoDoc(entTipoDoc tipoDoc)
        {
            return datTipoDoc.Instancia.ModificaTipoDoc(tipoDoc);
        }
    }
}
