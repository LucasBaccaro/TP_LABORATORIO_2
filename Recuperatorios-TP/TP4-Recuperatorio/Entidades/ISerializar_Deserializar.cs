using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializar_Deserializar
    {
        string Path { get; }

        bool SerializarXml();

        string DeserializarXml();
    }
}
