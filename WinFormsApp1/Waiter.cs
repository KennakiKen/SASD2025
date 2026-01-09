using System.Net.Sockets;
using System.Text;

namespace WinFormsApp1
{
    public partial class WaiterFrom : Form
    {
        public WaiterFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 11000);
            client.Client.Send(Encoding.UTF8.GetBytes(textBox1.Text));
            client.Close();
        }
    }
}
