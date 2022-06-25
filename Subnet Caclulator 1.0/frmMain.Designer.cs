namespace Subnet_Caclulator_1._0
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNetwork = new System.Windows.Forms.Label();
            this.comSubnetMask = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotSubnets = new System.Windows.Forms.Label();
            this.lblUsableAddress = new System.Windows.Forms.Label();
            this.lblNetworkAddresses = new System.Windows.Forms.Label();
            this.lblLastHostAddress = new System.Windows.Forms.Label();
            this.lblFirstHostAddress = new System.Windows.Forms.Label();
            this.lblBroadcastAddress = new System.Windows.Forms.Label();
            this.lblNetworkAddress = new System.Windows.Forms.Label();
            this.lblBinaryMask = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalSubnets = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtIPAdd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNetwork
            // 
            this.lblNetwork.AutoSize = true;
            this.lblNetwork.Location = new System.Drawing.Point(25, 34);
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(100, 15);
            this.lblNetwork.TabIndex = 0;
            this.lblNetwork.Text = "Network Address:";
            // 
            // comSubnetMask
            // 
            this.comSubnetMask.FormattingEnabled = true;
            this.comSubnetMask.Location = new System.Drawing.Point(25, 133);
            this.comSubnetMask.Name = "comSubnetMask";
            this.comSubnetMask.Size = new System.Drawing.Size(178, 23);
            this.comSubnetMask.TabIndex = 2;
            this.comSubnetMask.Text = "Please Choose a Subnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet Mask:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotSubnets);
            this.groupBox1.Controls.Add(this.lblUsableAddress);
            this.groupBox1.Controls.Add(this.lblNetworkAddresses);
            this.groupBox1.Controls.Add(this.lblLastHostAddress);
            this.groupBox1.Controls.Add(this.lblFirstHostAddress);
            this.groupBox1.Controls.Add(this.lblBroadcastAddress);
            this.groupBox1.Controls.Add(this.lblNetworkAddress);
            this.groupBox1.Controls.Add(this.lblBinaryMask);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblTotalSubnets);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(273, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 404);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Addressing Breakdown";
            // 
            // lblTotSubnets
            // 
            this.lblTotSubnets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotSubnets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotSubnets.Location = new System.Drawing.Point(264, 293);
            this.lblTotSubnets.Name = "lblTotSubnets";
            this.lblTotSubnets.Size = new System.Drawing.Size(126, 21);
            this.lblTotSubnets.TabIndex = 15;
            this.lblTotSubnets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsableAddress
            // 
            this.lblUsableAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsableAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsableAddress.Location = new System.Drawing.Point(264, 234);
            this.lblUsableAddress.Name = "lblUsableAddress";
            this.lblUsableAddress.Size = new System.Drawing.Size(126, 21);
            this.lblUsableAddress.TabIndex = 14;
            this.lblUsableAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetworkAddresses
            // 
            this.lblNetworkAddresses.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.lblNetworkAddresses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkAddresses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNetworkAddresses.Location = new System.Drawing.Point(264, 175);
            this.lblNetworkAddresses.Name = "lblNetworkAddresses";
            this.lblNetworkAddresses.Size = new System.Drawing.Size(126, 21);
            this.lblNetworkAddresses.TabIndex = 13;
            this.lblNetworkAddresses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastHostAddress
            // 
            this.lblLastHostAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastHostAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastHostAddress.Location = new System.Drawing.Point(539, 101);
            this.lblLastHostAddress.Name = "lblLastHostAddress";
            this.lblLastHostAddress.Size = new System.Drawing.Size(196, 21);
            this.lblLastHostAddress.TabIndex = 12;
            this.lblLastHostAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstHostAddress
            // 
            this.lblFirstHostAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstHostAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstHostAddress.Location = new System.Drawing.Point(178, 101);
            this.lblFirstHostAddress.Name = "lblFirstHostAddress";
            this.lblFirstHostAddress.Size = new System.Drawing.Size(196, 21);
            this.lblFirstHostAddress.TabIndex = 11;
            this.lblFirstHostAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBroadcastAddress
            // 
            this.lblBroadcastAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBroadcastAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBroadcastAddress.Location = new System.Drawing.Point(539, 39);
            this.lblBroadcastAddress.Name = "lblBroadcastAddress";
            this.lblBroadcastAddress.Size = new System.Drawing.Size(196, 21);
            this.lblBroadcastAddress.TabIndex = 10;
            this.lblBroadcastAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetworkAddress
            // 
            this.lblNetworkAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNetworkAddress.Location = new System.Drawing.Point(178, 39);
            this.lblNetworkAddress.Name = "lblNetworkAddress";
            this.lblNetworkAddress.Size = new System.Drawing.Size(196, 21);
            this.lblNetworkAddress.TabIndex = 9;
            this.lblNetworkAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBinaryMask
            // 
            this.lblBinaryMask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBinaryMask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBinaryMask.Location = new System.Drawing.Point(284, 356);
            this.lblBinaryMask.Name = "lblBinaryMask";
            this.lblBinaryMask.Size = new System.Drawing.Size(413, 30);
            this.lblBinaryMask.TabIndex = 8;
            this.lblBinaryMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(28, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Subnet Mask - Binary Value:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalSubnets
            // 
            this.lblTotalSubnets.AutoSize = true;
            this.lblTotalSubnets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSubnets.Location = new System.Drawing.Point(28, 293);
            this.lblTotalSubnets.Name = "lblTotalSubnets";
            this.lblTotalSubnets.Size = new System.Drawing.Size(156, 21);
            this.lblTotalSubnets.TabIndex = 6;
            this.lblTotalSubnets.Text = "Availiable Subnets:";
            this.lblTotalSubnets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Usable Addresses:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Network Addresses:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(380, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Last Host Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Host Address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(380, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Broadcast Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Address:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 201);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(178, 41);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtIPAdd
            // 
            this.txtIPAdd.Location = new System.Drawing.Point(27, 58);
            this.txtIPAdd.Name = "txtIPAdd";
            this.txtIPAdd.Size = new System.Drawing.Size(176, 23);
            this.txtIPAdd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIPAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comSubnetMask);
            this.Controls.Add(this.lblNetwork);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNetwork;
        private ComboBox comSubnetMask;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblTotSubnets;
        private Label lblUsableAddress;
        private Label lblNetworkAddresses;
        private Label lblLastHostAddress;
        private Label lblFirstHostAddress;
        private Label lblBroadcastAddress;
        private Label lblNetworkAddress;
        private Label lblBinaryMask;
        private Label label9;
        private Label lblTotalSubnets;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnCalculate;
        private TextBox txtIPAdd;
        private Button button1;
    }
}