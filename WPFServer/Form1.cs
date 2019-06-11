using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace WPFServer
{
    public partial class Form1 : Form
    {
        ServiceHost serviceHost;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_StartServer_Click(object sender, EventArgs e)
        {
            // Создаём хост с указанием сервиса
            serviceHost = new ServiceHost(typeof(Service));
            // Запускаем наш хост
            serviceHost.Open();
            tBox_StatusServer.Text = "Сервер запущен.";
        }

        private void bt_StopServer_Click(object sender, EventArgs e)
        {
            // Закрываем наш хост после того, как будет нажата любая клавиша
            serviceHost.Close();
            tBox_StatusServer.Text = "Сервер остановлен.";
        }
    }
}
