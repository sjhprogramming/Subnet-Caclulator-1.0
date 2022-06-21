using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnet_Caclulator_1._0
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Populate the Combobox with the subnets in class C network:
            comSubnetMask.Items.Add("255.255.255.0");
            comSubnetMask.Items.Add("255.255.255.252");
            comSubnetMask.Items.Add("255.255.255.248");
            comSubnetMask.Items.Add("255.255.255.240");
            comSubnetMask.Items.Add("255.255.255.224");
            comSubnetMask.Items.Add("255.255.255.192");
            comSubnetMask.Items.Add("255.255.255.128");

            //comSubnetMask.Text("Select a Subnet Mask");







        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string NetworkAddress = null;           // Network Address Variable
            string BroadcastAddress = null;         // Broadcast Address Variable
            string FirstHostAddress = null;
            string LastHostAddress = null;
            string subnet = null;                   // Subnet Variable

            subnet = comSubnetMask.SelectedItem.ToString(); //Assign the selected subnet to the string


            //Create an escape character to grab the last octet:
            Char[] DelimChar = { '.' };

            //Subnet Octets into an array for Binary Conversion.
            string[] netOctet = subnet.Split(DelimChar);
            string binOctet1 = Convert.ToString(Int32.Parse(netOctet[0]), 2);
            string binOctet2 = Convert.ToString(Int32.Parse(netOctet[1]), 2);
            string binOctet3 = Convert.ToString(Int32.Parse(netOctet[2]), 2);
            string binOctet4 = Convert.ToString(Int32.Parse(netOctet[3]), 2);

            lblBinaryMask.Text = binOctet1 + binOctet2 + binOctet3 + binOctet4;


            // Calculat Network Host info:
            int AvailAddresses = 256 - Int32.Parse(netOctet[3]);
            int TotalHostAddresses = AvailAddresses - 2;
            int TotalSubnets = 256 / AvailAddresses;

            //Fill in the gaps for Network Addresses
            lblNetworkAddresses.Text = AvailAddresses.ToString();
            lblUsableAddress.Text = TotalHostAddresses.ToString();
            lblTotSubnets.Text = TotalSubnets.ToString();


            //Ip addressing:
            string[] HostAddress = txtIPAdd.Text.Split(DelimChar);
            string Octet1 = HostAddress[0];
            string Octet2 = HostAddress[1];
            string Octet3 = HostAddress[2];
            string Octet4 = HostAddress[3];

            NetworkAddress = Octet1 + "." + Octet2 + "." + Octet3 + "." + Octet4;

            lblNetworkAddress.Text = NetworkAddress.ToString();

            int FirstHost = Convert.ToInt32(HostAddress[3]) + 1;                    // Calculate First Host Address
            int BCastAddress = AvailAddresses + Convert.ToInt32(Octet4) - 1;            // Calculate the Broadcast Address
            int LastHost = Convert.ToInt32(Octet4) + TotalHostAddresses;

            lblFirstHostAddress.Text = Octet1 + "." + Octet2 + "." + Octet3 + "." + FirstHost;
            lblLastHostAddress.Text = Octet1 + "." + Octet2 + "." + Octet3 + "." + LastHost;
            lblBroadcastAddress.Text = Octet1 + "." + Octet2 + "." + Octet3 + "." + BCastAddress;




        }
    }
}
