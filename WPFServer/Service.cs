using ClassLibraryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFServer
{
    class Service : IContract
    {
        public void Print(string name, string str)
        {
            string s = string.Format("Сервер получил сообщение: {0} ; {1}", name, str);
            MessageBox.Show(s);
        }
    }
}
