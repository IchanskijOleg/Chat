using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ClassLibraryContract
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        void Print(string name, string str);
    }
}
