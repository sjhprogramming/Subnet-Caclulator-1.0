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

        public int FirstHost; // First Availibale Host

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

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // Fire the code to Calculate the IpAddresses
            try
            {
                CalculateIpAddresses(txtIPAdd.Text, comSubnetMask.SelectedItem.ToString());
            }

            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Null Reference Error");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CalculateIpAddresses(string IpAddress, string NetSubNetMask)
        {
            var lastOctet = new SubnetCalculatorLibrary.IPAddressing();

            try
            {
                //Populate the First Host Address
                lblFirstHostAddress.Text = lastOctet.GetFirstIpAddress(IpAddress);
                
                //Total Network Addresses - Includes Network and Broadcast
                lblNetworkAddresses.Text = lastOctet.GetAvailiableAddress(NetSubNetMask).ToString();
                
                //Work out how many addresses can be used for endpoints / dhcp
                lblUsableAddress.Text = Convert.ToString(lastOctet.GetAvailiableAddress(NetSubNetMask) - 2);

                //Populate Network Address
                lblNetworkAddress.Text = IpAddress;

                //Populate the Last Host Address
                lblLastHostAddress.Text = lastOctet.GetLastHostAddress(IpAddress, NetSubNetMask);

                //Populate the Last Host Address
                lblBroadcastAddress .Text = lastOctet.GetBroadCastAddress(IpAddress, NetSubNetMask);

                //Populate Total Subnets
                lblTotSubnets.Text = Convert.ToString(256 / lastOctet.GetAvailiableAddress(NetSubNetMask));

                //Populate Binary Subnet Mask
                lblBinaryMask.Text = Convert.ToString(lastOctet.GetBinarySubnetMask(NetSubNetMask));

            }
                
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void txtIPAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
