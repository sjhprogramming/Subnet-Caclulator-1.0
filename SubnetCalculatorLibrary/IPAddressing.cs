namespace SubnetCalculatorLibrary
{
    public class IPAddressing
    {
        /// <summary>
        /// ipAddress for the purpose off:
        /// </summary>
        private string ipAddress;
        private string firstAddress;
        /// <summary>
        /// Ip Address to work with in this class
        /// </summary>
        public string IpAddress { get; set; }
        public string FirstIpAddress { get; set; }
        public int OctetValue { get; set; }


        /// <summary>
        /// Gets the last octet of a supplied ipAddress for use in the program
        /// </summary>
        /// <param name="IpAddress">IP Address to obtain the last octet from the array....</param>
        /// <returns>The last Octet</returns>
        public string GetLastOctet(string IpAddress, int OctetValue)
        {
            //Create an escape character to grab the last octet:
            Char[] DelimChar = { '.' };

            //Create an aray so we can split the ip into octets.
            string[] netOctet = IpAddress.Split(DelimChar);

            //Get the last octet from the array
            string LastOctet = netOctet[OctetValue];

            return LastOctet;


        }

        public string GetFirstIpAddress(string IpAddress)
        {
            //Step 1: Find the last octet of the network ip address:
            string IPlastOctet = GetLastOctet(IpAddress, 3);

            //Break down the IpAddress so we can change the last octet.
            Char[] DelimChar = { '.' };

            string[] netOctet = IpAddress.Split(DelimChar);
            int newLastOctet = Convert.ToInt32(netOctet[3]) + 1;
            //Re construct the ipAddress but changing the final octet by + 1 since this is the first address.
            firstAddress = netOctet[0] + "." + netOctet[1] + "." + netOctet[2] + "." + newLastOctet.ToString();
            
            return firstAddress;

        }

        public int GetAvailiableAddress(string NetSubNetMask)
        {
            string LastSubOctet = GetLastOctet(NetSubNetMask, 3);
            int AvailAddress = 256 - Convert.ToInt32(LastSubOctet);

            return AvailAddress;
        }
    }
}