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
using ClassLibraryContract;

namespace WPFClient
{
    public partial class Form1 : Form
    {
        IContract channel;
        private Color _color = Color.Blue;

        public Form1()
        {
            InitializeComponent();
            //підключаємося до сервера
            ConnectToServer();
        }
        private void ConnectToServer()
        {
            Uri address = new Uri("http://localhost:323/IContract"); // Адрес
            BasicHttpBinding binding = new BasicHttpBinding(); // Привязка
                                                               // Создаём конечную точку.
            EndpointAddress endpoint = new EndpointAddress(address);
            // Создаём фабрику каналов.
            ChannelFactory<IContract> channelFactory = new ChannelFactory<IContract>(binding, endpoint);
            // Создаём канал
            channel = channelFactory.CreateChannel();
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text.Length > 0 && tb_mess.Text.Length > 0)
            {
                // Отправляем сообщение
                channel.Print(textBox_FirstName.Text, tb_mess.Text);
                //додаемо в своэ вікно
                PrintOnTextListClient(tb_mess.Text, _color);
            }
        }

        private void PrintOnTextListClient(string text, Color color)
        {
            rtfMessageAll.SelectionColor = color;
            rtfMessageAll.SelectedText = "I: " + text + Environment.NewLine;
            tb_mess.Clear();
            tb_mess.Focus();
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog1.Color;
                pColor.BackColor = _color;
            }
        }

        private void pColor_Paint(object sender, PaintEventArgs e)
        {
            pColor.BackColor = _color;
        }
    }
}
