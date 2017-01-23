using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using CTR;

namespace Advanced_badge_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            appName.Text = "Advanced badge editor";
            appIcon.Image = Properties.Resources.Advanced_badge_editor_icon;
            titleIDdropdown.Text = "None / Unknown";
            regionDropdown.Text = "???";
        }
        #region GUI Interaction

        #region Import necessary DLL's
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Minimize Button
        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            appMinimize.Image = Properties.Resources.app_minimize_hover;
        }
        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            appMinimize.Image = Properties.Resources.app_minimize;
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Close Button
        private void close_MouseEnter(object sender, EventArgs e)
        {
            appClose.Image = Properties.Resources.app_close_hover;
        }
        private void close_MouseLeave(object sender, EventArgs e)
        {
            appClose.Image = Properties.Resources.app_close;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Grabbable window
        private void windowTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #endregion

        //
        // Folder browser
        //
        FolderBrowserDialog openData = new FolderBrowserDialog();
        FileInfo badgeData = null;
        FileInfo badgeMng = null;
        //
        // Save info
        //
        uint uniqueBadges = 0;
        uint totalBadges = 0;
        uint sets = 0;
        uint NNID = 0;
        string region = "???";
        //
        //
        //
        uint[] badgeIds = new uint[1000];
        uint[] badgeSetIds = new uint[1000];
        ushort[] badgeSids = new ushort[1000];
        ushort[] badgeQuants = new ushort[1000];
        string[] badgeNames = new string[1000];
        uint[] badgeTitleIds = new uint[1000];
        ushort[] badgeIndexs = new ushort[1000];
        byte[][] badgeImgs32 = new byte[1000][];
        byte[][] badgeShps32 = new byte[1000][];
        byte[][] badgeImgs64 = new byte[1000][];
        byte[][] badgeShps64 = new byte[1000][];
        //
        //
        //
        uint[] setIds = new uint[100];
        uint[] setUniqueBadges = new uint[100];
        uint[] setTotalBadges = new uint[100];
        uint[] setBadgeIndexs = new uint[100];
        uint[] setIndexs = new uint[100];
        string[] setNames = new string[100];
        byte[][] setImgs = new byte[100][];
        //
        //
        //
        static byte[] bclim32rgb565 = { 0x43, 0x4C, 0x49, 0x4D, 0xFF, 0xFE, 0x14, 0x00, 0x00, 0x00, 0x02, 0x02, 0x28, 0x08, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x69, 0x6D, 0x61, 0x67, 0x10, 0x00, 0x00, 0x00, 0x20, 0x00, 0x20, 0x00, 0x05, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00 };
        static byte[] bclim64rgb565 = { 0x43, 0x4C, 0x49, 0x4D, 0xFF, 0xFE, 0x14, 0x00, 0x00, 0x00, 0x02, 0x02, 0x28, 0x20, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x69, 0x6D, 0x61, 0x67, 0x10, 0x00, 0x00, 0x00, 0x40, 0x00, 0x40, 0x00, 0x05, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00 };
        static byte[] bclim32a4 = { 0x43, 0x4C, 0x49, 0x4D, 0xFF, 0xFE, 0x14, 0x00, 0x00, 0x00, 0x02, 0x02, 0x28, 0x02, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x69, 0x6D, 0x61, 0x67, 0x10, 0x00, 0x00, 0x00, 0x20, 0x00, 0x20, 0x00, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00 };
        static byte[] bclim64a4 = { 0x43, 0x4C, 0x49, 0x4D, 0xFF, 0xFE, 0x14, 0x00, 0x00, 0x00, 0x02, 0x02, 0x28, 0x08, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x69, 0x6D, 0x61, 0x67, 0x10, 0x00, 0x00, 0x00, 0x40, 0x00, 0x40, 0x00, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00 };
        //
        //
        //
        public void resetInfo()
        {
            uniqueBadges = 0;
            totalBadges = 0;
            sets = 0;
            NNID = 0;
            region = "???";

            badgeIds = new uint[1000];
            badgeSetIds = new uint[1000];
            badgeSids = new ushort[1000];
            badgeQuants = new ushort[1000];
            badgeNames = new string[1000];
            badgeTitleIds = new uint[1000];
            badgeIndexs = new ushort[1000];
            badgeImgs32 = new byte[1000][];
            badgeShps32 = new byte[1000][];
            badgeImgs64 = new byte[1000][];
            badgeShps64 = new byte[1000][];

            setIds = new uint[100];
            setUniqueBadges = new uint[100];
            setTotalBadges = new uint[100];
            setBadgeIndexs = new uint[100];
            setIndexs = new uint[100];
            setNames = new string[100];
            setImgs = new byte[100][];

            selectedBadgeNumer.Minimum = 1;
            selectSetNumer.Minimum = 1;
            selectedBadgeNumer.Maximum = 1000;
            selectSetNumer.Maximum = 100;
            selectedBadgeNumer.Value = 1;
            selectSetNumer.Value = 1;

            setStartingNumer.Minimum = 1;
            setStartingNumer.Maximum = 4294967296;

            badgeNameInput.Text = "None";
            setNameInput.Text = "None";
            badgeIdNumer.Value = 0;
            setIdNumer.Value = 0;
            badgeSidNumer.Value = 0;
            setStartingNumer.Value = 1;
            badgeSetIdNumer.Value = 0;
            setUniqueBadgesLabel.Text = "0";
            badgeQuantityNumer.Value = 0;
            setTotalBadgesLabel.Text = "0";
            prevBadgeImg64.Image = null;
            prevBadgeImg32.Image = null;
            prevSetImg.Image = null;
            titleIDdropdown.Text = "None / Unknown";
            titleIDnumer.Value = 0;
            if (!regionDropdown.Items.Contains("???"))
                regionDropdown.Items.Add("???");
            regionDropdown.Text = "???";
            regionDropdown.Items.Remove("???");
        }
        private void regionDropdown_DropDown(object sender, EventArgs e)
        {
            if (regionDropdown.Items.Contains("???"))
                regionDropdown.Items.Remove("???");
        }
        //
        // Open data prompt:
        //
        private void openDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openData.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openData.SelectedPath + "/BadgeMngFile.dat") && File.Exists(openData.SelectedPath + "/BadgeData.dat"))
                {
                    resetInfo();

                    badgeData = new FileInfo(openData.SelectedPath + "/BadgeData.dat");
                    badgeMng = new FileInfo(openData.SelectedPath + "/BadgeMngFile.dat");

                    // Using BinaryReader to read the Hex data of each file
                    BinaryReader data = new BinaryReader(badgeMng.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None));

                    data.BaseStream.Position = 0x4;
                    sets = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                    data.BaseStream.Position = 0x8;
                    uniqueBadges = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                    data.BaseStream.Position = 0x18;
                    totalBadges = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                    data.BaseStream.Position = 0x1C;
                    NNID = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);

                    for (int i = 0; i < uniqueBadges; i++)
                    {
                        data.BaseStream.Position = 0x3E8 + i * 0x28 + 0x4;
                        badgeIds[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        badgeSetIds[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        badgeIndexs[i] = BitConverter.ToUInt16(data.ReadBytes(0x2), 0);
                        badgeSids[i] = BitConverter.ToUInt16(data.ReadBytes(0x2), 0);
                        data.BaseStream.Position += 0x2;
                        badgeQuants[i] = BitConverter.ToUInt16(data.ReadBytes(0x2), 0);
                        data.BaseStream.Position += 0x4;
                        badgeTitleIds[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        data.BaseStream.Position -= 0x3;
                        string _region = BitConverter.ToUInt16(data.ReadBytes(0x2), 0).ToString("X4").Substring(1, 2);

                        switch (_region){
                            case "20":
                            case "23":
                                region = "JPN";
                                break;
                            case "21":
                            case "24":
                                region = "USA";
                                break;
                            case "22":
                            case "25":
                                region = "EUR";
                                break;
                            case "26":
                                region = "CHN";
                                break;
                            case "27":
                                region = "KOR";
                                break;
                            case "28":
                                region = "TWN";
                                break;
                        }
                    }

                    for (int i = 0; i < sets; i++)
                    {
                        data.BaseStream.Position = 0xA028 + i * 0x30 + 0x10;
                        setIds[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        setIndexs[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        data.BaseStream.Position += 0x4;
                        setUniqueBadges[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        setTotalBadges[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        setBadgeIndexs[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                    }

                    data = new BinaryReader(badgeData.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None));
                    
                    for (int i = 0; i < uniqueBadges; i++)
                    {
                        data.BaseStream.Position = i * 0x8A0 + 0x35E80;
                        badgeNames[i] = Encoding.Unicode.GetString(data.ReadBytes(0x8A));
                        data.BaseStream.Position = i * 0x2800 + 0x318F80;
                        badgeImgs64[i] = data.ReadBytes(0x2000);
                        badgeShps64[i] = data.ReadBytes(0x800);
                        data.BaseStream.Position = i * 0xA00 + 0xCDCF80;
                        badgeImgs32[i] = data.ReadBytes(0x800);
                        badgeShps32[i] = data.ReadBytes(0x200);
                    }

                    for (int i = 0; i < sets; i++)
                    {
                        data.BaseStream.Position = i * 0x8A0;
                        setNames[i] = Encoding.Unicode.GetString(data.ReadBytes(0x8A));
                        data.BaseStream.Position = i * 0x2000 + 0x250F80;
                        setImgs[i] = data.ReadBytes(0x2000);
                    }

                    data.Close();
                    // -----



                    // Update the interface

                    if (uniqueBadges > 0)
                        selectedBadgeNumer.Maximum = uniqueBadges;
                    if (sets > 0)
                        selectSetNumer.Maximum = sets;

                    badgeOptions(uniqueBadges > 0);
                    setOptions(sets > 0);

                    createBadgeButton.Enabled = true;
                    createSetButton.Enabled = true;
                    regionDropdown.Enabled = true;
                    NNIDnumer.Enabled = true;

                    NNIDnumer.Value = NNID;

                    updateAll();
                    regionDropdown.Text = region;
                    setStartingNumer.Maximum = setBadgeIndexs[1];
                    saveDataToolStripMenuItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The folder you selected doesn't contain BadgeMngFile.dat nor BadgeData.dat!", "Error opening files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        // Update main info about the badge data
        //
        public void updateAll()
        {
            totalBadges = 0;
            foreach (ushort i in badgeQuants)
            {
                totalBadges += i;
            }
            setsLabel.Text = sets.ToString();
            totalBadgesLabel.Text = totalBadges.ToString();
            uniqueBadgesLabel.Text = uniqueBadges.ToString();

            if (uniqueBadges > 0)
                updateBadgeInfo();
            if (sets > 0)
                updateSetInfo();
        }
        //
        // Enable/disable badge editing options
        //
        public void badgeOptions(bool enable)
        {
            selectedBadgeNumer.Enabled = enable;
            badgeNameInput.Enabled = enable;
            badgeIdNumer.Enabled = enable;
            badgeSidNumer.Enabled = enable;
            badgeQuantityNumer.Enabled = enable;
            badgeSetIdNumer.Enabled = enable;
            exportBadgeImg.Enabled = enable;
            importBadgeImg.Enabled = enable;
            exportBadgeShp.Enabled = enable;
            importBadgeShp.Enabled = enable;
            exportBadgeImg32.Enabled = enable;
            importBadgeImg32.Enabled = enable;
            exportBadgeShp32.Enabled = enable;
            importBadgeShp32.Enabled = enable;
            fillBadgeShp.Enabled = enable;
            fillBadgeShp32.Enabled = enable;
            exportBadgeImage.Enabled = enable;
            importBadgeImage.Enabled = enable;
            badge255each.Enabled = enable;
            titleIDdropdown.Enabled = enable;
            titleIDnumer.Enabled = enable;
            
        }
        public void setOptions(bool enable)
        {
            selectSetNumer.Enabled = enable;
            setNameInput.Enabled = enable;
            setIdNumer.Enabled = enable;
            setStartingNumer.Enabled = enable;
            exportSetImgButton.Enabled = enable;
            importSetImgButton.Enabled = enable;
            exportSetImage.Enabled = enable;
            importSetImage.Enabled = enable;
        }
        //
        // Update the information about the currently selected badge or the currently selected set
        //
        public void updateBadgeInfo()
        {
            badgeNameInput.Text = badgeNames[badgeIndexs[(int)selectedBadgeNumer.Value - 1]];
            badgeIdNumer.Value = badgeIds[(int)selectedBadgeNumer.Value - 1];
            badgeSidNumer.Value = badgeSids[(int)selectedBadgeNumer.Value - 1];
            badgeQuantityNumer.Value = badgeQuants[(int)selectedBadgeNumer.Value - 1];
            badgeSetIdNumer.Value = badgeSetIds[(int)selectedBadgeNumer.Value - 1];
            titleIDnumer.Value = badgeTitleIds[(int)selectedBadgeNumer.Value - 1];

            updateTitleID();

            Badge.BADGE_IMG current;
            current.Image64 = BCLIM.newFromArray(addFooter(badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim64rgb565));
            current.Shape64 = BCLIM.newFromArray(addFooter(badgeShps64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim64a4));
            current.Image32 = BCLIM.newFromArray(addFooter(badgeImgs32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim32rgb565));
            current.Shape32 = BCLIM.newFromArray(addFooter(badgeShps32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim32a4));
            prevBadgeImg64.Image = Badge.BADGEtoBMP(current)[0];
            prevBadgeImg32.Image = Badge.BADGEtoBMP(current)[1];
        }
        public void updateSetInfo()
        {
            setStartingNumer.Minimum = 0;
            setStartingNumer.Maximum = 4294967296;

            setTotalBadges = new uint[100];
            setUniqueBadges = new uint[100];
            for (int i = 0; i < sets; i++)
            {
                for (int ii = 0; ii < uniqueBadges; ii++)
                {
                    if ((ii >= setBadgeIndexs[i] && ii < setBadgeIndexs[i + 1]) || (i + 1 == sets && ii >= setBadgeIndexs[i]))
                    {
                        setTotalBadges[i] += badgeQuants[ii];
                        setUniqueBadges[i] += 1;
                    }
                }
            }
            setNameInput.Text = setNames[setIndexs[(int)selectSetNumer.Value - 1]];
            setIdNumer.Value = setIds[(int)selectSetNumer.Value - 1];
            setStartingNumer.Value = setBadgeIndexs[(int)selectSetNumer.Value - 1] + 1;
            setUniqueBadgesLabel.Text = setUniqueBadges[(int)selectSetNumer.Value - 1].ToString();
            setTotalBadgesLabel.Text = setTotalBadges[(int)selectSetNumer.Value - 1].ToString();

            BCLIM.CLIM curset;

            curset = BCLIM.newFromArray(addFooter(setImgs[setIndexs[(int)selectSetNumer.Value - 1]], bclim64rgb565));
            prevSetImg.Image = Badge.cropImage(BCLIM.getIMG(curset), new Rectangle(0, 0, 48, 48));
        }
        
        public void updateTitleID()
        {
            string tidstrmain = badgeTitleIds[(int)selectedBadgeNumer.Value - 1].ToString("X8");
            string tidstr = "None / Unknown";

            switch (tidstrmain.Substring(0, 1))
            {
                case "0":
                    switch (tidstrmain.Substring(5, 1))
                    {
                        // System Settings
                        case "0":
                            tidstr = "System Settings";
                            break;

                        // Download Play
                        case "1":
                            tidstr = "Download Play";
                            break;

                        // Activity Log
                        case "2":
                            tidstr = "Activity Log";
                            break;

                        // Health and Safety Information
                        case "3":
                            tidstr = "Health and Safety Information";
                            break;

                        // Nintendo 3DS Camera
                        case "4":
                            tidstr = "Nintendo 3DS Camera";
                            break;

                        // Nintendo 3DS Sound
                        case "5":
                            tidstr = "Nintendo 3DS Sound";
                            break;

                        // Mii Maker
                        case "7":
                            tidstr = "Mii Maker";
                            break;

                        // StreetPass Mii Plaza
                        case "8":
                            tidstr = "StreetPass Mii Plaza";
                            break;

                        // eShop
                        case "9":
                            tidstr = "eShop";
                            break;

                        // System Transfer
                        case "A":
                            tidstr = "System Transfer";
                            break;

                        // Nintendo Zone
                        case "B":
                            tidstr = "Nintendo Zone";
                            break;

                        // Face Raiders
                        case "D":
                            tidstr = "Face Raiders";
                            break;

                        // AR Games
                        case "E":
                            tidstr = "AR Games";
                            break;
                    }

                    break;

                // New 3DS apps only
                case "2":
                    switch (tidstrmain.Substring(5, 1))
                    {
                        // Health and Safety Information [NEW 3DS]
                        case "3":
                            tidstr = "Health and Safety Information [NEW 3DS]";
                            break;

                        // Face Raiders [NEW 3DS]
                        case "D":
                            tidstr = "Face Raiders [NEW 3DS]";
                            break;
                    }

                    break;
            }
            titleIDdropdown.Text = tidstr;
        }
        public byte[] addFooter(byte[] bclim, byte[] footer)
        {
            byte[] output = new byte[bclim.Length + footer.Length];
            bclim.CopyTo(output, 0);
            footer.CopyTo(output, bclim.Length);
            return output;
        }
        //
        // Every time the badge number is changed, it updates the form with the newly selected badge's data;
        //
        private void selectedBadgeNumer_ValueChanged(object sender, EventArgs e)
        {
            if (uniqueBadges > 0)
                updateBadgeInfo();
        }
        private void selectSetNumer_ValueChanged(object sender, EventArgs e)
        {
            setStartingNumer.Minimum = 1;
            setStartingNumer.Maximum = 4294967296;

            updateAll();

            if (selectSetNumer.Value > 1)
            {
                setStartingNumer.Minimum = setBadgeIndexs[(int)selectSetNumer.Value - 2] + 2;
            }
            else
            {
                setStartingNumer.Minimum = 1;
            }
            if (selectSetNumer.Value < sets)
            {
                setStartingNumer.Maximum = setBadgeIndexs[(int)selectSetNumer.Value];
            }
            else
            {
                setStartingNumer.Maximum = uniqueBadges;
            }
        }
        //
        // Give 255 of each badge
        //
        private void badge255each_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < uniqueBadges; i++)
            {
                badgeQuants[i] = 255;
            }
            updateAll();
        }
        //
        // Save the data
        //
        private async void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to overwrite the old data?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                while (IsFileLocked(badgeMng))
                    await Task.Delay(25);
                BinaryWriter data = new BinaryWriter(badgeMng.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None));

                data.BaseStream.Position = 0x04;
                data.Write(sets);
                data.Write(uniqueBadges);
                data.BaseStream.Position = 0x18;
                data.Write(totalBadges);
                data.Write(NNID);

                for (int i = 0; i < uniqueBadges; i++)
                {
                    data.BaseStream.Position = 0x3E8 + i * 0x28 + 0x4;
                    data.Write(badgeIds[i]);
                    data.Write(badgeSetIds[i]);
                    data.Write(badgeIndexs[i]);
                    data.Write(badgeSids[i]);
                    data.BaseStream.Position += 0x2;
                    data.Write(badgeQuants[i]);
                    data.BaseStream.Position += 0x4;
                    data.Write(badgeTitleIds[i]);
                    data.BaseStream.Position += 0x4;
                    data.Write(badgeTitleIds[i]);
                }
                for (int i = 0; i < sets; i++)
                {
                    data.BaseStream.Position = 0xA028 + i * 0x30 + 0x10;
                    data.Write(setIds[i]);
                    data.Write(setIndexs[i]);
                    data.BaseStream.Position += 0x4;
                    data.Write(setUniqueBadges[i]);
                    data.Write(setTotalBadges[i]);
                    data.Write(setBadgeIndexs[i]);
                }

                data.Close();

                data = new BinaryWriter(badgeData.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None));

                data.BaseStream.Position = 0x35E80;
                for (int i = 0; i < 0x8A0 * uniqueBadges; i++)
                {
                    data.Write(0x00);
                }
                for (int i = 0; i < uniqueBadges; i++)
                {
                    for (int ii = 0; ii < 16; ii++)
                    {
                        data.BaseStream.Position = (badgeIndexs[i] * 0x8A0) + (ii * 0x8A) + 0x35E80;
                        data.Write(Encoding.Unicode.GetBytes(badgeNames[badgeIndexs[i]]));
                    }
                    data.BaseStream.Position = badgeIndexs[i] * 0x2800 + 0x318F80;
                    data.Write(badgeImgs64[badgeIndexs[i]]);
                    data.Write(badgeShps64[badgeIndexs[i]]);
                    data.BaseStream.Position = badgeIndexs[i] * 0xA00 + 0xCDCF80;
                    data.Write(badgeImgs32[badgeIndexs[i]]);
                    data.Write(badgeShps32[badgeIndexs[i]]);
                }

                data.BaseStream.Position = 0;
                for (int i = 0; i < 0x8A0 * sets; i++)
                {
                    data.Write(0x00);
                }
                for (int i = 0; i < sets; i++)
                {
                    for (int ii = 0; ii < 16; ii++)
                    {
                        data.BaseStream.Position = (setIndexs[i] * 0x8A0) + (ii * 0x8A);
                        data.Write(Encoding.Unicode.GetBytes(setNames[setIndexs[i]]));
                    }
                    data.BaseStream.Position = setIndexs[i] * 0x2000 + 0x250F80;
                    data.Write(setImgs[setIndexs[i]]);
                }

                data.Close();
            }
        }
        //
        // Allows the user to create a new badge
        //
        private void createBadgeButton_Click(object sender, EventArgs e)
        {
            if (uniqueBadges < 1000)
            {
                if (uniqueBadges == 0)
                    badgeOptions(true);

                uniqueBadges++;
                totalBadges++;
                badgeIds[uniqueBadges - 1] = uniqueBadges;
                if (uniqueBadges < 0)
                    badgeSetIds[uniqueBadges - 1] = setIds[sets - 1];
                else
                    badgeSetIds[uniqueBadges - 1] = 0;
                badgeSids[uniqueBadges - 1] = 0;
                badgeQuants[uniqueBadges - 1] = 1;
                badgeNames[uniqueBadges - 1] = "New badge";
                badgeIndexs[uniqueBadges - 1] = (ushort)(uniqueBadges - 1);

                badgeImgs64[uniqueBadges - 1] = new byte[0x2000];
                badgeShps64[uniqueBadges - 1] = new byte[0x800];
                badgeImgs32[uniqueBadges - 1] = new byte[0x800];
                badgeShps32[uniqueBadges - 1] = new byte[0x200];

                selectedBadgeNumer.Maximum = uniqueBadges;
                selectedBadgeNumer.Value = uniqueBadges;

                updateAll();
            }
            else
            {
                MessageBox.Show("You have too many badges to make a new one...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void createSetButton_Click(object sender, EventArgs e)
        {
            if (uniqueBadges == 0)
            {
                MessageBox.Show("You have no badges to make a set for...", "Uhhh, how?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                if (sets == 0)
                {
                    sets++;
                    setIds[sets - 1] = sets;
                    setNames[sets - 1] = "New set";
                    setBadgeIndexs[sets - 1] = uniqueBadges - 1;
                    setTotalBadges[sets - 1] = 1;
                    setUniqueBadges[sets - 1] = 1;
                    setIndexs[sets - 1] = sets - 1;
                    setImgs[sets - 1] = new byte[0x2000];
                    selectSetNumer.Maximum = sets;
                    selectSetNumer.Value = sets;
                    updateAll();
                    setOptions(true);
                }
                else
                {
                    if (setBadgeIndexs[sets - 1] < uniqueBadges - 1)
                    {
                        if (sets < 100)
                        {
                            sets++;
                            setIds[sets - 1] = sets;
                            setNames[sets - 1] = "New set";
                            setBadgeIndexs[sets - 1] = uniqueBadges - 1;
                            setTotalBadges[sets - 1] = 1;
                            setUniqueBadges[sets - 1] = 1;
                            setIndexs[sets - 1] = sets - 1;
                            setImgs[sets - 1] = new byte[0x2000];
                            selectSetNumer.Maximum++;
                            selectSetNumer.Value = sets;
                        }
                        else
                        {
                            MessageBox.Show("You have too many sets to make a new one...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough unique badges for a new set!", "Not enough badges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        //
        // Allows the user to export badge and set images
        //
        private void exportBadgeImg_Click(object sender, EventArgs e)
        {
            bclimExportPrompt(badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim64rgb565);
        }
        private void exportBadgeShp_Click(object sender, EventArgs e)
        {
            bclimExportPrompt(badgeShps64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim64a4);
        }
        private void exportBadgeImg32_Click(object sender, EventArgs e)
        {
            bclimExportPrompt(badgeImgs32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim32rgb565);
        }
        private void exportBadgeShp32_Click(object sender, EventArgs e)
        {
            bclimExportPrompt(badgeShps32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim32a4);
        }
        private void exportSetImgButton_Click(object sender, EventArgs e)
        {
            bclimExportPrompt(setImgs[setIndexs[(int)selectSetNumer.Value - 1]], bclim64rgb565);
        }
        //
        // Allows the user to import badge and set images
        //
        private void importBadgeImg_Click(object sender, EventArgs e)
        {
            byte[][] imported = bclimImportPrompt(0x2000, bclim64rgb565);
            if (imported[0] == null)
            {
                if (imported[1][0] == 0)
                {
                    MessageBox.Show("The file you imported doesn't have the right format...", "Error opening files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = imported[0];
            }
        }
        private void importBadgeShp_Click(object sender, EventArgs e)
        {
            byte[][] imported = bclimImportPrompt(0x800, bclim64a4);
            if (imported[0] == null)
            {
                if (imported[1][0] == 0)
                {
                    MessageBox.Show("The file you imported doesn't have the right format...", "Error opening files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                badgeShps64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = imported[0];
            }
        }
        private void importBadgeImg32_Click(object sender, EventArgs e)
        {
            byte[][] imported = bclimImportPrompt(0x800, bclim32rgb565);
            if (imported[0] == null)
            {
                if (imported[1][0] == 0)
                {
                    MessageBox.Show("The file you imported doesn't have the right format...", "Error opening files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                badgeImgs32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = imported[0];
            }
        }
        private void importBadgeShp32_Click(object sender, EventArgs e)
        {
            byte[][] imported = bclimImportPrompt(0x200, bclim32a4);
            if (imported[0] == null)
            {
                if (imported[1][0] == 0)
                {
                    MessageBox.Show("The file you imported doesn't have the right format...", "Error opening files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                badgeShps32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = imported[0];
            }
        }
        private void importSetImgButton_Click(object sender, EventArgs e)
        {
            byte[][] imported = bclimImportPrompt(0x2000, bclim64rgb565);
            if (imported[0] == null)
            {
                if (imported[1][0] == 0)
                {
                    MessageBox.Show("The file you imported doesn't have the right format...", "Error opening files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                setImgs[setIndexs[(int)selectSetNumer.Value - 1]] = imported[0];
            }
        }
        //
        // A file prompt for exporting a bclim file type
        //
        public void bclimExportPrompt(byte[] dataArray, byte[] bclimFooter)
        {
            SaveFileDialog export = new SaveFileDialog();
            export.Filter = "CTR-LIM File (*.bclim)|*.bclim";
            export.DefaultExt = "*.bclim";
            export.AddExtension = true;
            if (export.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(export.FileName)) { File.Delete(export.FileName); }
                BinaryWriter data = new BinaryWriter(File.OpenWrite(export.FileName));

                data.Write(dataArray);
                data.Write(bclimFooter);

                data.Close();
            }
        }
        public byte[][] bclimImportPrompt(int length, byte[] bclimFooter)
        {
            OpenFileDialog import = new OpenFileDialog();
            import.Filter = "CTR-LIM File (*.bclim)|*.bclim";
            import.DefaultExt = "*.bclim";
            import.AddExtension = true;
            byte[][] toImport = new byte[2][];
            toImport[0] = null;
            toImport[1] = new byte[1];
            toImport[1][0] = 0;
            if (import.ShowDialog() == DialogResult.OK)
            {
                BinaryReader data = new BinaryReader(File.OpenRead(import.FileName));

                data.BaseStream.Seek(-0x28, SeekOrigin.End);
                if (BitConverter.ToString(data.ReadBytes(0x28)) == BitConverter.ToString(bclimFooter))
                {
                    data.BaseStream.Position = 0;
                    toImport[0] = data.ReadBytes(length);
                }
                data.Close();
            } else
            {
                toImport[1][0] = 1;
            }
            return toImport;
        }
        //
        // Save values to arrays
        //
        private void badgeNameInput_TextChanged(object sender, EventArgs e)
        {
            badgeNames[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = badgeNameInput.Text;
        }
        private void badgeIdNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeIds[(int)selectedBadgeNumer.Value - 1] = (uint)badgeIdNumer.Value;
        }
        private void badgeSidNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeSids[(int)selectedBadgeNumer.Value - 1] = (ushort)badgeSidNumer.Value;
        }
        private void badgeQuantityNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeQuants[(int)selectedBadgeNumer.Value - 1] = (ushort)badgeQuantityNumer.Value;
            updateAll();
        }
        private void badgeSetIdNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeSetIds[(int)selectedBadgeNumer.Value - 1] = (uint)badgeSetIdNumer.Value;
        }

        private void setNameInput_TextChanged(object sender, EventArgs e)
        {
            setNames[setIndexs[(int)selectSetNumer.Value - 1]] = setNameInput.Text;
        }
        private void setIdNumer_ValueChanged(object sender, EventArgs e)
        {
            setIds[(int)selectSetNumer.Value - 1] = (uint)setIdNumer.Value;
        }
        private void setStartingNumer_ValueChanged(object sender, EventArgs e)
        {
            setBadgeIndexs[(int)selectSetNumer.Value - 1] = (uint)setStartingNumer.Value - 1;
            updateAll();
        }

        private void fillBadgeShp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 0x800; i++)
            {
                badgeShps64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]][i] = 0XFF;
            }
        }
        private void fillBadgeShp32_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 0x200; i++)
            {
                badgeShps32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]][i] = 0XFF;
            }
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        private void importBadgeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap Check = new Bitmap(ofd.FileName);
                if (Check.Width == 64 && Check.Height == 64)
                {
                    Badge.BADGE_IMG img = Badge.BMPtoBADGE(Check, pixelBadgeMode.Checked);
                    BinaryReader br = new BinaryReader(new MemoryStream(img.Image64.Data));

                    byte[] badgeImage64 = br.ReadBytes((int)img.Image64.dataLength);
                    br.Close();

                    br = new BinaryReader(new MemoryStream(img.Shape64.Data));
                    byte[] badgeShape64 = br.ReadBytes((int)img.Shape64.dataLength);
                    br.Close();

                    br = new BinaryReader(new MemoryStream(img.Image32.Data));
                    byte[] badgeImage32 = br.ReadBytes((int)img.Image32.dataLength);
                    br.Close();

                    br = new BinaryReader(new MemoryStream(img.Shape32.Data));
                    byte[] badgeShape32 = br.ReadBytes((int)img.Shape32.dataLength);
                    br.Close();

                    badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = badgeImage64;
                    badgeShps64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = badgeShape64;
                    badgeImgs32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = badgeImage32;
                    badgeShps32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = badgeShape32;

                    if (uniqueBadges > 0)
                        updateBadgeInfo();
                }
                else
                {
                    MessageBox.Show("The image you imported doesn't have a size of 64px * 64px.", "Wrong size...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void exportBadgeImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Badge.BADGE_IMG current;
                current.Image64 = BCLIM.newFromArray(addFooter(badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim64rgb565));
                current.Shape64 = BCLIM.newFromArray(addFooter(badgeShps64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim64a4));
                current.Image32 = BCLIM.newFromArray(addFooter(badgeImgs32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim32rgb565));
                current.Shape32 = BCLIM.newFromArray(addFooter(badgeShps32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]], bclim32a4));
                
                Badge.BADGEtoBMP(current)[0].Save(sfd.FileName);
            }
        }
        private void importSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap Check = new Bitmap(ofd.FileName);
                if (Check.Width == 48 && Check.Height == 48)
                {
                    BCLIM.CLIM set = Badge.adjustForSet(Check);

                    BinaryReader br = new BinaryReader(new MemoryStream(set.Data));
                    byte[] setImage = br.ReadBytes((int)set.dataLength);
                    br.Close();

                    setImgs[setIndexs[(int)selectSetNumer.Value - 1]] = setImage;

                    if (sets > 0)
                        updateSetInfo();
                }
                else
                {
                    MessageBox.Show("The image you imported doesn't have a size of 48px * 48px.", "Wrong size...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void exportSetImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BCLIM.CLIM set = BCLIM.newFromArray(addFooter(setImgs[setIndexs[(int)selectSetNumer.Value - 1]], bclim64rgb565));

                Badge.cropImage(BCLIM.getIMG(set), new Rectangle(0, 0, 48, 48)).Save(sfd.FileName);
            }
        }

        private void titleIDnumer_ValueChanged(object sender, EventArgs e)
        {
            updateTitleID();
        }

        public uint getTitleID(int index)
        {
            string rgn = "F";
            string titleIDstr = "FFFFFFFF";
            switch (region)
            {
                case "JPN":
                    rgn = "0";
                    break;
                case "USA":
                    rgn = "1";
                    break;
                case "EUR":
                    rgn = "2";
                    break;
                case "CHN":
                    rgn = "6";
                    break;
                case "KOR":
                    rgn = "7";
                    break;
                case "TWN":
                    rgn = "8";
                    break;
            }
            if (rgn != "F")
            {
                switch (index)
                {
                    // 0 1 2 3
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        titleIDstr = "0002" + rgn + (index - 1).ToString("X") + "00";
                        break;
                    // 3
                    case 5:
                        if (rgn != "6" || rgn != "8")
                            titleIDstr = "2002" + rgn + "300";
                        break;
                    // 4 5
                    case 6:
                    case 7:
                        titleIDstr = "0002" + rgn + (index - 2).ToString("X") + "00";
                        break;
                    // 7 8
                    case 8:
                    case 9:
                        titleIDstr = "0002" + rgn + (index - 1).ToString("X") + "00";
                        break;
                    // 9 A
                    case 10:
                    case 11:
                        if (rgn != "6")
                            titleIDstr = "0002" + rgn + (index - 1).ToString("X") + "00";
                        break;
                    // B
                    case 12:
                        if (rgn != "6" || rgn != "7" || rgn != "8")
                            titleIDstr = "0002" + rgn + (index - 1).ToString("X") + "00";
                        break;
                    // D
                    case 13:
                        titleIDstr = "0002" + rgn + "D00";
                        break;
                    // D
                    case 14:
                        if (rgn != "6" || rgn != "8")
                            titleIDstr = "2002" + rgn + "D00";
                        break;
                    // E
                    case 15:
                        titleIDstr = "0002" + rgn + "E00";
                        break;
                }
            }
            return Convert.ToUInt32(titleIDstr, 16);
        }
        public int getTitleIndex(string title)
        {
            string tidstrmain = title;
            int tidstr = 0;

            switch (tidstrmain.Substring(0, 1))
            {
                case "0":
                    switch (tidstrmain.Substring(5, 1))
                    {
                        // System Settings
                        case "0":
                            tidstr = 1;
                            break;

                        // Download Play
                        case "1":
                            tidstr = 2;
                            break;

                        // Activity Log
                        case "2":
                            tidstr = 3;
                            break;

                        // Health and Safety Information
                        case "3":
                            tidstr = 4;
                            break;

                        // Nintendo 3DS Camera
                        case "4":
                            tidstr = 6;
                            break;

                        // Nintendo 3DS Sound
                        case "5":
                            tidstr = 7;
                            break;

                        // Mii Maker
                        case "7":
                            tidstr = 8;
                            break;

                        // StreetPass Mii Plaza
                        case "8":
                            tidstr = 9;
                            break;

                        // eShop
                        case "9":
                            tidstr = 10;
                            break;

                        // System Transfer
                        case "A":
                            tidstr = 11;
                            break;

                        // Nintendo Zone
                        case "B":
                            tidstr = 12;
                            break;

                        // Face Raiders
                        case "D":
                            tidstr = 13;
                            break;

                        // AR Games
                        case "E":
                            tidstr = 15;
                            break;
                    }

                    break;

                // New 3DS apps only
                case "2":
                    switch (tidstrmain.Substring(5, 1))
                    {
                        // Health and Safety Information [NEW 3DS]
                        case "3":
                            tidstr = 5;
                            break;

                        // Face Raiders [NEW 3DS]
                        case "D":
                            tidstr = 14;
                            break;
                    }

                    break;
            }
            return tidstr;
        }

        private void titleIDdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            badgeTitleIds[(int)selectedBadgeNumer.Value - 1] = getTitleID(titleIDdropdown.SelectedIndex);
            updateAll();
        }

        private void regionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            region = regionDropdown.Text;
            for (int i = 0; i < uniqueBadges; i++)
            {
                if (badgeTitleIds[i] != 0xFFFFFFFF)
                    badgeTitleIds[i] = getTitleID(getTitleIndex(badgeTitleIds[i].ToString("X8")));
            }

            updateAll();
        }

        private void NNIDnumer_ValueChanged(object sender, EventArgs e)
        {
            NNID = (uint)NNIDnumer.Value;
        }
    }
}
