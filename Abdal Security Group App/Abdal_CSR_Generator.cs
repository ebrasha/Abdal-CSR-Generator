using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Abdal_Security_Group_App
{
    public partial class Abdal_AES_Encryption : Telerik.WinControls.UI.RadForm
    {
        public Abdal_AES_Encryption()
        {
            InitializeComponent();
            PrivateKeyPasswordTextBox.Text = RandomString(25);
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = "Abdal CSR Generator" + " " + version.Major + "." + version.Minor; //change form title
             
        }

        private void EncryptToggleSwitch_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DecryptToggleSwitch_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EncDecButton_Click(object sender, EventArgs e)
        {
                if(backgroundWorkerCsr.IsBusy != true)
            {
                radWaitingBar1.Visible = true;
                radWaitingBar1.StartWaiting();
                backgroundWorkerCsr.RunWorkerAsync();
            }

        }

        private void Abdal_2Key_Triple_DES_Builder_Load(object sender, EventArgs e)
        {
            // Call Global Chilkat Unlock
            Abdal_Security_Group_App.GlobalUnlockChilkat GlobalUnlock = new Abdal_Security_Group_App.GlobalUnlockChilkat();
            GlobalUnlock.unlock();

            radWaitingBar1.Visible = false;

        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void randButton_Click(object sender, EventArgs e)
        {

           

        }

        private void backgroundWorkerCsr_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CountryTextBox.Text == "" || StateTextBox.Text == "" || LocalityTextBox.Text == "" || OrganizationTextBox.Text == "" || OrganizationalUnitTextBox.Text == "" || CommonNameTextBox.Text == "" || EmailAddressTextBox.Text == "")
            {
                radWaitingBar1.StopWaiting();
                MessageBox.Show("Please fill in all Information...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {

                   
                    Int32 key_size = 0;



                    if (keySizeToggleSwitch.Value == true)
                    {

                        key_size = 2048;
                    }
                    else
                    {
                        key_size = 4096;

                    }


                    //  First generate an RSA private key.
                    Chilkat.Rsa rsa = new Chilkat.Rsa();

                    //  Generate a random 2048-bit RSA key.
                    rsa.GenerateKey(key_size);


                    //  Get the private key
                    Chilkat.PrivateKey privKey = rsa.ExportPrivateKeyObj();
                    //  Create the CSR object and set properties.
                    Chilkat.Csr csr = new Chilkat.Csr();

                    //  Specify the Common Name.  This is the only required property.
                    //  For SSL/TLS certificates, this would be the domain name.
                    //  For email certificates this would be the email address.
                    csr.CommonName = CommonNameTextBox.Text;

                    //  Country Name (2 letter code)
                    csr.Country = CountryTextBox.Text;

                    //  State or Province Name (full name)
                    csr.State = StateTextBox.Text;

                    //  Locality Name (eg, city)
                    csr.Locality = LocalityTextBox.Text;

                    //  Organization Name (eg, company)
                    csr.Company = OrganizationTextBox.Text;

                    //  Organizational Unit Name (eg, secion/division)
                    csr.CompanyDivision = OrganizationalUnitTextBox.Text;

                    //  Email address
                    csr.EmailAddress = EmailAddressTextBox.Text;

                    //  Create the CSR using the private key.
                    string pemStr = csr.GenCsrPem(privKey);


                    string userDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    privKey.SavePkcs8EncryptedPemFile(PrivateKeyPasswordTextBox.Text, userDesktopPath + "\\" + CommonNameTextBox.Text + ".key");
                    Chilkat.FileAccess fac = new Chilkat.FileAccess();
                    fac.WriteEntireTextFile(userDesktopPath + "\\" + CommonNameTextBox.Text + ".csr", pemStr, "utf-8", false);
                    fac.WriteEntireTextFile(userDesktopPath + "\\" + CommonNameTextBox.Text + "-privateKey-password" + ".txt", PrivateKeyPasswordTextBox.Text, "utf-8", false);

                    radWaitingBar1.StopWaiting();

                    radWaitingBar1.Visible = false;
                    MessageBox.Show("Your CSR has been successfully created !", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                //End Try/Catch
            }

        }

        private void backgroundWorkerCsr_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorkerCsr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void EmailAddressTextBox_Click(object sender, EventArgs e)
        {
            if (CommonNameTextBox.Text != "")
            {
                EmailAddressTextBox.Text = "admin@" + CommonNameTextBox.Text;
            }
            
        }
    }
}
