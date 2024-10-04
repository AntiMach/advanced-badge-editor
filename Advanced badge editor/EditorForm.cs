using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

using RTTools;

namespace AdvancedBadgeEditor
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
            titleIDdropdown.Text = "None / Unknown";
            regionDropdown.Text = "???";
        }

        //
        // Folder browser
        //
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

        bool dropdownUpdate = true;

        #region systemApps
        readonly string[] systemApps = new string[] {
            //JPN
            "00020000",
            "00020100",
            "00020200",
            "00020300",
            "20020300",
            "00020400",
            "00020500",
            "00020700",
            "00020800",
            "00020900",
            "00020A00",
            "00020B00",
            "00020D00",
            "20020D00",
            "00020E00",
            //USA
            "00021000",
            "00021100",
            "00021200",
            "00021300",
            "20021300",
            "00021400",
            "00021500",
            "00021700",
            "00021800",
            "00021900",
            "00021A00",
            "00021B00",
            "00021D00",
            "20021D00",
            "00021E00",
            //EUR
            "00022000",
            "00022100",
            "00022200",
            "00022300",
            "20022300",
            "00022400",
            "00022500",
            "00022700",
            "00022800",
            "00022900",
            "00022A00",
            "00022B00",
            "00022D00",
            "20022D00",
            "00022E00",
            //CHN
            "00026000",
            "00026100",
            "00026200",
            "00026300",
            "00026400",
            "00026500",
            "00026700",
            "00026800",
            "00026D00",
            "00026E00",
            //KOR
            "00027000",
            "00027100",
            "00027200",
            "00027300",
            "20027300",
            "00027400",
            "00027500",
            "00027700",
            "00027800",
            "00027900",
            "00027A00",
            "00027D00",
            "20027D00",
            "00027E00",
            // TWN
            "00028000",
            "00028100",
            "00028200",
            "00028300",
            "00028400",
            "00028500",
            "00028700",
            "00028800",
            "00028900",
            "00028A00",
            "00028D00",
            "00028E00",
            };
        #endregion

        //
        //
        //
        uint[] badgeIds = new uint[1000];
        uint[] badgeSetIds = new uint[1000];
        ushort[] badgeSids = new ushort[1000];
        ushort[] badgeQuants = new ushort[1000];
        string[] badgeNames = new string[1000];
        uint[] badgeTitleIds = new uint[1000];
        uint[] badgeHighIds = new uint[1000];
        ushort[] badgeIndexs = new ushort[1000];
        Bitmap[] badgeImgs64 = new Bitmap[1000];
        Bitmap[] badgeImgs32 = new Bitmap[1000];
        //
        //
        //
        uint[] setIds = new uint[100];
        uint[] setUniqueBadges = new uint[100];
        uint[] setTotalBadges = new uint[100];
        uint[] setBadgeIndexs = new uint[100];
        uint[] setIndexs = new uint[100];
        string[] setNames = new string[100];
        Bitmap[] setImgs = new Bitmap[1000];
        //
        //
        //
        public void ResetInfo()
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
            badgeImgs32 = new Bitmap[1000];
            badgeImgs64 = new Bitmap[1000];

            setIds = new uint[100];
            setUniqueBadges = new uint[100];
            setTotalBadges = new uint[100];
            setBadgeIndexs = new uint[100];
            setIndexs = new uint[100];
            setNames = new string[100];
            setImgs = new Bitmap[100];

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
        private void RegionDropdown_DropDown(object sender, EventArgs e)
        {
            if (regionDropdown.Items.Contains("???"))
                regionDropdown.Items.Remove("???");
        }
        //
        // Open data prompt:
        //
        private void OpenDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openData = new FolderBrowserDialog
            {
                Description = "Select a folder to open the files from",
            };
            if (openData.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openData.SelectedPath + "/BadgeMngFile.dat") && File.Exists(openData.SelectedPath + "/BadgeData.dat"))
                {
                    ResetInfo();

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

                    loading.Maximum = (int)(sets * 2 + uniqueBadges * 2);
                    loading.Value = 0;

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
                        badgeHighIds[i] = BitConverter.ToUInt32(data.ReadBytes(0x4), 0);
                        data.BaseStream.Position -= 0x8;
                        string _region = badgeTitleIds[i].ToString("X8").Substring(3, 1);

                        if (systemApps.Contains(badgeTitleIds[i].ToString("X8")) && badgeHighIds[i] == 0x00040010)
                        {
                            switch (_region)
                            {
                                case "0":
                                    region = "JPN";
                                    break;
                                case "1":
                                    region = "USA";
                                    break;
                                case "2":
                                    region = "EUR";
                                    break;
                                case "6":
                                    region = "CHN";
                                    break;
                                case "7":
                                    region = "KOR";
                                    break;
                                case "8":
                                    region = "TWN";
                                    break;
                            }
                        }

                        loading.PerformStep();
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
                        loading.PerformStep();
                    }

                    data.Close();

                    data = new BinaryReader(badgeData.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None));

                    for (int i = 0; i < uniqueBadges; i++)
                    {
                        data.BaseStream.Position = i * 0x8A0 + 0x35E80;
                        badgeNames[i] = Encoding.Unicode.GetString(data.ReadBytes(0x8A));
                        data.BaseStream.Position = i * 0x2800 + 0x318F80;
                        badgeImgs64[i] = RT.RGB565andA4toPNG(data.ReadBytes(0x2800), 64);
                        data.BaseStream.Position = i * 0xA00 + 0xCDCF80;
                        badgeImgs32[i] = RT.RGB565andA4toPNG(data.ReadBytes(0xA00), 32);
                        loading.PerformStep();
                    }

                    for (int i = 0; i < sets; i++)
                    {
                        data.BaseStream.Position = i * 0x8A0;
                        setNames[i] = Encoding.Unicode.GetString(data.ReadBytes(0x8A));
                        data.BaseStream.Position = i * 0x2000 + 0x250F80;
                        setImgs[i] = RT.GetSetImage(data.ReadBytes(0x2000));
                        loading.PerformStep();
                    }

                    data.Close();
                    // -----



                    // Update the interface

                    if (uniqueBadges > 0)
                        selectedBadgeNumer.Maximum = uniqueBadges;
                    if (sets > 0)
                        selectSetNumer.Maximum = sets;

                    BadgeOptions(uniqueBadges > 0);
                    SetOptions(sets > 0);

                    createBadgeButton.Enabled = true;
                    createSetButton.Enabled = true;
                    regionDropdown.Enabled = true;
                    NNIDnumer.Enabled = true;
                    delAll.Enabled = true;

                    NNIDnumer.Value = NNID;

                    UpdateAll();
                    regionDropdown.Text = region;
                    setStartingNumer.Maximum = setBadgeIndexs[0] + 1;
                    saveDataToolStripMenuItem.Enabled = true;
                    saveDataToToolStripMenuItem.Enabled = true;
                    badgeFileprbToolStripMenuItem.Enabled = true;
                    setFilecabToolStripMenuItem.Enabled = true;
                    importEntireSetData.Enabled = true;

                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    MessageBox.Show("The folder you selected doesn't contain BadgeMngFile.dat nor BadgeData.dat!", "Error opening files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        // Create new data
        //
        private void NewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (badgeData != null && badgeMng != null)
            {
                if (MessageBox.Show("Changes made to the last files will be lost if not saved! Are you sure you want to create new data?", "Create new data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            badgeData = null;
            badgeMng = null;
            ResetInfo();

            createBadgeButton.Enabled = true;
            createSetButton.Enabled = true;
            regionDropdown.Enabled = true;
            NNIDnumer.Enabled = true;
            delAll.Enabled = true;

            UpdateAll();
            regionDropdown.Text = region;
            setStartingNumer.Maximum = setBadgeIndexs[0] + 1;
            saveDataToolStripMenuItem.Enabled = true;
            saveDataToToolStripMenuItem.Enabled = true;
            badgeFileprbToolStripMenuItem.Enabled = true;
            setFilecabToolStripMenuItem.Enabled = true;
            importEntireSetData.Enabled = true;
        }

        public void ResetData(FileInfo badgeDataFile, FileInfo badgeMngFile)
        {
            BinaryWriter bw = new BinaryWriter(badgeMngFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None));

            WriteBytes(bw, 0x00, 0x10);
            WriteBytes(bw, 0xFF, 0x4);
            WriteBytes(bw, 0x00, 0x3D4);
            for (int i = 0; i < 1000; i++)
            {
                WriteBytes(bw, 0x00, 0x4);
                WriteBytes(bw, 0xFF, 0xA);
                WriteBytes(bw, 0x00, 0xA);
                WriteBytes(bw, 0xFF, 0x8);
                WriteBytes(bw, 0x00, 0x8);
            }
            for (int i = 0; i < 100; i++)
            {
                WriteBytes(bw, 0xFF, 0x8);
                WriteBytes(bw, 0x00, 0x4);
                bw.Write((ushort)0x2710);
                WriteBytes(bw, 0x00, 0x2);
                WriteBytes(bw, 0xFF, 0xC);
                WriteBytes(bw, 0x00, 0x8);
                WriteBytes(bw, 0xFF, 0x4);
                WriteBytes(bw, 0x00, 0x8);
            }
            for (int i = 0; i < 360; i++)
            {
                WriteBytes(bw, 0x00, 0x4);
                WriteBytes(bw, 0xFF, 0xA);
                WriteBytes(bw, 0x00, 0x2);
                WriteBytes(bw, 0xFF, 0x8);
            }

            bw.Close();
            bw = new BinaryWriter(badgeDataFile.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None));

            WriteBytes(bw, 0x00, 0xF4DF80);

            bw.Close();
        }
        public void WriteBytes(BinaryWriter bwf, byte val, int len)
        {
            for (int loop = 0; loop < len; loop++)
            {
                bwf.Write(val);
            }
        }
        //
        // Save data to files
        //
        public void SaveData(FileInfo badgeDataFile, FileInfo badgeMngFile)
        {
            ResetData(badgeDataFile, badgeMngFile);
            BinaryWriter bw = new BinaryWriter(badgeMngFile.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None));

            bw.BaseStream.Position = 0x04;
            bw.Write(sets);
            bw.Write(uniqueBadges);
            bw.BaseStream.Position = 0x18;
            bw.Write(totalBadges);
            bw.Write(NNID);

            loading.Maximum = (int)(sets * 2 + uniqueBadges * 2);
            loading.Value = 0;

            for (int i = 0; i < uniqueBadges; i++)
            {
                bw.BaseStream.Position = 0x3EC + i * 0x28;
                bw.Write(badgeIds[i]);
                bw.Write(badgeSetIds[i]);
                bw.Write(badgeIndexs[i]);
                bw.Write(badgeSids[i]);
                bw.BaseStream.Position += 0x2;
                bw.Write(badgeQuants[i]);
                bw.BaseStream.Position += 0x4;
                bw.Write(badgeTitleIds[i]);
                bw.Write(badgeHighIds[i]);
                bw.Write(badgeTitleIds[i]);
                bw.Write(badgeHighIds[i]);
                loading.PerformStep();
            }
            for (int i = 0; i < sets; i++)
            {
                bw.BaseStream.Position = 0xA038 + i * 0x30;
                bw.Write(setIds[i]);
                bw.Write(setIndexs[i]);
                bw.BaseStream.Position += 0x4;
                bw.Write(setUniqueBadges[i]);
                bw.Write(setTotalBadges[i]);
                bw.Write(setBadgeIndexs[i]);
                loading.PerformStep();
            }

            bw.Close();

            bw = new BinaryWriter(badgeDataFile.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None));

            bw.BaseStream.Position = 0x35E80;
            for (int i = 0; i < uniqueBadges; i++)
            {
                for (int ii = 0; ii < 16; ii++)
                {
                    bw.BaseStream.Position = (badgeIndexs[i] * 0x8A0) + (ii * 0x8A) + 0x35E80;
                    bw.Write(Encoding.Unicode.GetBytes(badgeNames[badgeIndexs[i]]));
                }
                bw.BaseStream.Position = badgeIndexs[i] * 0x2800 + 0x318F80;
                RT.PNGtoRGB565andA4(badgeImgs64[badgeIndexs[i]], out byte[] rgb565_64, out byte[] a4_64);
                RT.PNGtoRGB565andA4(badgeImgs32[badgeIndexs[i]], out byte[] rgb565_32, out byte[] a4_32);
                bw.Write(rgb565_64);
                bw.Write(a4_64);
                bw.BaseStream.Position = badgeIndexs[i] * 0xA00 + 0xCDCF80;
                bw.Write(rgb565_32);
                bw.Write(a4_32);
                loading.PerformStep();
            }

            bw.BaseStream.Position = 0;
            for (int i = 0; i < sets; i++)
            {
                for (int ii = 0; ii < 16; ii++)
                {
                    bw.BaseStream.Position = (setIndexs[i] * 0x8A0) + (ii * 0x8A);
                    bw.Write(Encoding.Unicode.GetBytes(setNames[setIndexs[i]]));
                }
                bw.BaseStream.Position = setIndexs[i] * 0x2000 + 0x250F80;
                bw.Write(RT.AdjustForSet(setImgs[setIndexs[i]]));
                loading.PerformStep();
            }

            bw.Close();

            SystemSounds.Asterisk.Play();
        }
        //
        // Update main info about the badge data
        //
        public void UpdateAll()
        {
            totalBadges = 0;
            foreach (ushort i in badgeQuants)
            {
                totalBadges += i;
            }
            if (uniqueBadges > 0) selectedBadgeNumer.Maximum = uniqueBadges;
            if (sets > 0) selectSetNumer.Maximum = sets;
            setsLabel.Text = sets.ToString();
            totalBadgesLabel.Text = totalBadges.ToString();
            uniqueBadgesLabel.Text = uniqueBadges.ToString();

            if (uniqueBadges > 0)
            {
                BadgeOptions(true);
                UpdateBadgeInfo();
            }
            else
            {
                BadgeOptions(false);
            }

            if (sets > 0)
            {
                SetOptions(true);
                UpdateSetInfo();
            }
            else
            {
                SetOptions(false);
            }
        }
        //
        // Enable/disable badge editing options
        //
        public void BadgeOptions(bool enable)
        {
            selectedBadgeNumer.Enabled = enable;
            badgeNameInput.Enabled = enable;
            badgeIdNumer.Enabled = enable;
            badgeSidNumer.Enabled = enable;
            badgeQuantityNumer.Enabled = enable;
            badgeSetIdNumer.Enabled = enable;
            exportBadgeImage.Enabled = enable;
            importBadgeImage.Enabled = enable;
            badge255each.Enabled = enable;
            titleIDdropdown.Enabled = enable;
            titleIDnumer.Enabled = enable;
            titleHighNumer.Enabled = enable;
            delBadge.Enabled = enable;

        }
        public void SetOptions(bool enable)
        {
            selectSetNumer.Enabled = enable;
            setNameInput.Enabled = enable;
            setIdNumer.Enabled = enable;
            setStartingNumer.Enabled = enable;
            exportSetImage.Enabled = enable;
            importSetImage.Enabled = enable;
            delSet.Enabled = enable;
            fixBadgeSetIds.Enabled = enable;
        }
        //
        // Update the information about the currently selected badge or the currently selected set
        //
        public void UpdateBadgeInfo()
        {
            badgeNameInput.Text = badgeNames[badgeIndexs[(int)selectedBadgeNumer.Value - 1]];
            badgeIdNumer.Value = badgeIds[(int)selectedBadgeNumer.Value - 1];
            badgeSidNumer.Value = badgeSids[(int)selectedBadgeNumer.Value - 1];
            badgeQuantityNumer.Value = badgeQuants[(int)selectedBadgeNumer.Value - 1];
            badgeSetIdNumer.Value = badgeSetIds[(int)selectedBadgeNumer.Value - 1];
            titleIDnumer.Value = badgeTitleIds[(int)selectedBadgeNumer.Value - 1];
            titleHighNumer.Value = badgeHighIds[(int)selectedBadgeNumer.Value - 1];

            UpdateTitleID();

            prevBadgeImg64.Image = badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]];
            prevBadgeImg32.Image = badgeImgs32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]];
        }
        public void UpdateSetInfo()
        {
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

            prevSetImg.Image = setImgs[setIndexs[(int)selectSetNumer.Value - 1]];
        }

        public void DeleteBadge()
        {
            int badgeSet = (int)sets - 1;
            if (badgeSet < 0) { badgeSet = 0; }
            for (int i = 0; i < sets; i++)
            {
                if (badgeIndexs[(int)selectedBadgeNumer.Value - 1] >= setBadgeIndexs[i] && badgeIndexs[(int)selectedBadgeNumer.Value - 1] < setBadgeIndexs[i + 1])
                {
                    badgeSet = i;
                }
            }
            int badgeIndex = badgeIndexs[(int)selectedBadgeNumer.Value - 1];

            badgeIds = RemoveIndex(badgeIds, (int)selectedBadgeNumer.Value - 1);
            badgeSetIds = RemoveIndex(badgeSetIds, (int)selectedBadgeNumer.Value - 1);
            badgeSids = RemoveIndex(badgeSids, (int)selectedBadgeNumer.Value - 1);
            badgeQuants = RemoveIndex(badgeQuants, (int)selectedBadgeNumer.Value - 1);
            badgeNames = RemoveIndex(badgeNames, badgeIndexs[(int)selectedBadgeNumer.Value - 1]);
            badgeTitleIds = RemoveIndex(badgeTitleIds, (int)selectedBadgeNumer.Value - 1);
            badgeHighIds = RemoveIndex(badgeHighIds, (int)selectedBadgeNumer.Value - 1);
            badgeImgs32 = RemoveIndex(badgeImgs32, badgeIndexs[(int)selectedBadgeNumer.Value - 1]);
            badgeImgs64 = RemoveIndex(badgeImgs64, badgeIndexs[(int)selectedBadgeNumer.Value - 1]);
            badgeIndexs = RemoveIndex(badgeIndexs, (int)selectedBadgeNumer.Value - 1);
            uniqueBadges--;
            for (int i = 0; i < uniqueBadges; i++)
            {
                if (badgeIndexs[i] > badgeIndex) badgeIndexs[i]--;
            }
            for (int i = badgeSet + 1; i < sets; i++)
            {
                setBadgeIndexs[i]--;
            }

            if ((setBadgeIndexs[badgeSet] > (int)uniqueBadges - 1 && sets > 0) || (setBadgeIndexs[badgeSet] - setBadgeIndexs[badgeSet + 1] == 0 && sets > 1))
            {
                DeleteSetFromBadges(badgeSet);
            }
            if (selectedBadgeNumer.Value == uniqueBadges + 1 && uniqueBadges > 0) selectedBadgeNumer.Value--;
            UpdateAll();
        }
        public void DeleteSetFromBadges(int index)
        {
            int setIndex = (int)setIndexs[index];

            setIds = RemoveIndex(setIds, index);
            setUniqueBadges = RemoveIndex(setUniqueBadges, index);
            setTotalBadges = RemoveIndex(setTotalBadges, index);
            setBadgeIndexs = RemoveIndex(setBadgeIndexs, index);
            setNames = RemoveIndex(setNames, (int)setIndexs[index]);
            setImgs = RemoveIndex(setImgs, (int)setIndexs[index]);
            setIndexs = RemoveIndex(setIndexs, index);
            sets--;

            for (int i = 0; i < sets; i++)
            {
                if (setIndexs[i] > setIndex) setIndexs[i]--;
            }
            if (selectSetNumer.Value == sets + 1 && sets > 0) selectSetNumer.Value--;
        }
        public void DeleteSet()
        {
            int uniqueBadgesSet = (int)setBadgeIndexs[(int)selectSetNumer.Value] - (int)setBadgeIndexs[(int)selectSetNumer.Value - 1];
            if ((int)selectSetNumer.Value == sets) uniqueBadgesSet = (int)uniqueBadges - (int)setBadgeIndexs[(int)selectSetNumer.Value - 1];

            int subtract = (int)uniqueBadges - (int)selectedBadgeNumer.Value;
            if (subtract > uniqueBadgesSet) { subtract = uniqueBadgesSet; }

            if (sets > 1)
            {
                if (selectedBadgeNumer.Value == uniqueBadges)
                    selectedBadgeNumer.Value -= uniqueBadgesSet - subtract;
            }


            int deleteBadgesFrom = (int)setBadgeIndexs[(int)selectSetNumer.Value - 1];
            for (int i = 0; i < uniqueBadgesSet; i++)
            {
                DeleteBadgeFromSet(deleteBadgesFrom);
            }
            int setIndex = (int)setIndexs[(int)selectSetNumer.Value - 1];

            setIds = RemoveIndex(setIds, (int)selectSetNumer.Value - 1);
            setUniqueBadges = RemoveIndex(setUniqueBadges, (int)selectSetNumer.Value - 1);
            setTotalBadges = RemoveIndex(setTotalBadges, (int)selectSetNumer.Value - 1);
            setBadgeIndexs = RemoveIndex(setBadgeIndexs, (int)selectSetNumer.Value - 1);
            setNames = RemoveIndex(setNames, (int)setIndexs[(int)selectSetNumer.Value - 1]);
            setImgs = RemoveIndex(setImgs, (int)setIndexs[(int)selectSetNumer.Value - 1]);
            setIndexs = RemoveIndex(setIndexs, (int)selectSetNumer.Value - 1);
            sets--;

            for (int i = (int)selectSetNumer.Value - 1; i < sets; i++)
            {
                setBadgeIndexs[i] -= (uint)uniqueBadgesSet;
            }

            for (int i = 0; i < sets; i++)
            {
                if (setIndexs[i] > setIndex) setIndexs[i]--;
            }

            if (selectSetNumer.Value == sets + 1 && sets > 0) selectSetNumer.Value--;
            UpdateAll();
        }
        public void DeleteBadgeFromSet(int index)
        {
            int badgeIndex = badgeIndexs[index];

            badgeIds = RemoveIndex(badgeIds, index);
            badgeSetIds = RemoveIndex(badgeSetIds, index);
            badgeSids = RemoveIndex(badgeSids, index);
            badgeQuants = RemoveIndex(badgeQuants, index);
            badgeNames = RemoveIndex(badgeNames, badgeIndexs[index]);
            badgeTitleIds = RemoveIndex(badgeTitleIds, index);
            badgeHighIds = RemoveIndex(badgeHighIds, index);
            badgeImgs32 = RemoveIndex(badgeImgs32, badgeIndexs[index]);
            badgeImgs64 = RemoveIndex(badgeImgs64, badgeIndexs[index]);
            badgeIndexs = RemoveIndex(badgeIndexs, index);
            uniqueBadges--;
            for (int i = 0; i < uniqueBadges; i++)
            {
                if (badgeIndexs[i] > badgeIndex) badgeIndexs[i]--;
            }
        }

        public Bitmap[] RemoveIndex(Bitmap[] tochange, int index)
        {
            List<Bitmap> list = new List<Bitmap>(tochange);
            list.RemoveAt(index);
            list.Add(null);
            return list.ToArray();
        }
        public ulong[] RemoveIndex(ulong[] tochange, int index)
        {
            List<ulong> list = new List<ulong>(tochange);
            list.RemoveAt(index);
            list.Add(0);
            return list.ToArray();
        }
        public uint[] RemoveIndex(uint[] tochange, int index)
        {
            List<uint> list = new List<uint>(tochange);
            list.RemoveAt(index);
            list.Add(0);
            return list.ToArray();
        }
        public ushort[] RemoveIndex(ushort[] tochange, int index)
        {
            List<ushort> list = new List<ushort>(tochange);
            list.RemoveAt(index);
            list.Add(0);
            return list.ToArray();
        }
        public string[] RemoveIndex(string[] tochange, int index)
        {
            List<string> list = new List<string>(tochange);
            list.RemoveAt(index);
            list.Add("");
            return list.ToArray();
        }
        public byte[][] RemoveIndex(byte[][] tochange, int index)
        {
            int newArrayLenght = tochange[index].Length;
            List<byte[]> list = new List<byte[]>(tochange);
            list.RemoveAt(index);
            list.Add(new byte[newArrayLenght]);
            return list.ToArray();
        }

        public void UpdateTitleID()
        {
            string tidstrmain = badgeTitleIds[(int)selectedBadgeNumer.Value - 1].ToString("X8");
            string tidstr = "None / Unknown";

            if (systemApps.Contains(tidstrmain) && badgeHighIds[(int)selectedBadgeNumer.Value - 1] == 0x00040010)
            {
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
            }
            dropdownUpdate = false;
            titleIDdropdown.Text = tidstr;
            dropdownUpdate = true;
        }
        public byte[] AddFooter(byte[] bclim, byte[] footer)
        {
            byte[] output = new byte[bclim.Length + footer.Length];
            bclim.CopyTo(output, 0);
            footer.CopyTo(output, bclim.Length);
            return output;
        }
        //
        // Every time the badge number is changed, it updates the form with the newly selected badge's data;
        //
        private void SelectedBadgeNumer_ValueChanged(object sender, EventArgs e)
        {
            if (uniqueBadges > 0)
                UpdateBadgeInfo();
        }
        private void SelectSetNumer_ValueChanged(object sender, EventArgs e)
        {
            setStartingNumer.Minimum = 1;
            setStartingNumer.Maximum = 4294967296;

            UpdateAll();

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
        private void Badge255Each_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < uniqueBadges; i++)
            {
                badgeQuants[i] = 255;
            }
            UpdateAll();
        }
        //
        // Save the data
        //
        private void SaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (badgeData == null && badgeMng == null)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog
                {
                    Description = "Select a folder to save the files to",
                };
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(fbd.SelectedPath + "/BadgeMngFile.dat") && File.Exists(fbd.SelectedPath + "/BadgeData.dat"))
                    {
                        if (MessageBox.Show("There already exists data in that folder. Do you want to overwrite it?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    badgeData = new FileInfo(fbd.SelectedPath + "/BadgeData.dat");
                    badgeMng = new FileInfo(fbd.SelectedPath + "/BadgeMngFile.dat");
                    SaveData(badgeData, badgeMng);
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to overwrite the old data?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveData(badgeData, badgeMng);
                }
            }
        }

        private void SaveDataToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "Select a folder to save the files to",
            };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fbd.SelectedPath + "/BadgeMngFile.dat") && File.Exists(fbd.SelectedPath + "/BadgeData.dat"))
                {
                    if (MessageBox.Show("There already exists data in that folder. Do you want to overwrite it?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
                badgeData = new FileInfo(fbd.SelectedPath + "/BadgeData.dat");
                badgeMng = new FileInfo(fbd.SelectedPath + "/BadgeMngFile.dat");
                SaveData(badgeData, badgeMng);
            }
        }
        //
        // Allows the user to create a new badge
        //
        private void CreateBadgeButton_Click(object sender, EventArgs e)
        {
            if (uniqueBadges < 1000)
            {
                if (uniqueBadges == 0)
                    BadgeOptions(true);

                uniqueBadges++;
                totalBadges++;
                badgeIds[uniqueBadges - 1] = uniqueBadges;
                if (sets > 0)
                    badgeSetIds[uniqueBadges - 1] = setIds[sets - 1];
                else
                    badgeSetIds[uniqueBadges - 1] = 0;
                badgeSids[uniqueBadges - 1] = 0;
                badgeQuants[uniqueBadges - 1] = 1;
                badgeNames[uniqueBadges - 1] = "New badge";
                badgeIndexs[uniqueBadges - 1] = (ushort)(uniqueBadges - 1);
                badgeTitleIds[uniqueBadges - 1] = 0xFFFFFFFF;
                badgeHighIds[uniqueBadges - 1] = 0xFFFFFFFF;

                badgeImgs64[uniqueBadges - 1] = new Bitmap(64, 64);
                badgeImgs32[uniqueBadges - 1] = new Bitmap(64, 64);

                selectedBadgeNumer.Maximum = uniqueBadges;
                selectedBadgeNumer.Value = uniqueBadges;

                UpdateAll();
            }
            else
            {
                MessageBox.Show("You have too many badges to make a new one...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CreateSetButton_Click(object sender, EventArgs e)
        {
            if (uniqueBadges == 0)
            {
                MessageBox.Show("You have no badges to make a set with...", "Uhhh, how?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (sets >= 100)
            {
                MessageBox.Show("You have too many sets to make a new one...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (sets > 0)
            {
                if (setBadgeIndexs[sets - 1] >= uniqueBadges - 1)
                {
                    MessageBox.Show("Not enough unique badges for a new set!", "Not enough badges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (sets == 0)
                SetOptions(true);

            sets++;
            setIds[sets - 1] = sets;
            setNames[sets - 1] = "New set";
            setBadgeIndexs[sets - 1] = uniqueBadges - 1;
            setTotalBadges[sets - 1] = 1;
            setUniqueBadges[sets - 1] = 1;
            setIndexs[sets - 1] = sets - 1;
            setImgs[sets - 1] = new Bitmap(48, 48, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            selectSetNumer.Maximum = sets;
            selectSetNumer.Value = sets;
            SelectSetNumer_ValueChanged(null, null);
        }
        //
        // Save values to arrays
        //
        private void BadgeNameInput_TextChanged(object sender, EventArgs e)
        {
            badgeNames[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = badgeNameInput.Text;
        }
        private void BadgeIdNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeIds[(int)selectedBadgeNumer.Value - 1] = (uint)badgeIdNumer.Value;
        }
        private void BadgeSubIDNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeSids[(int)selectedBadgeNumer.Value - 1] = (ushort)badgeSidNumer.Value;
        }
        private void BadgeQuantityNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeQuants[(int)selectedBadgeNumer.Value - 1] = (ushort)badgeQuantityNumer.Value;
            UpdateAll();
        }
        private void BadgeSetIdNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeSetIds[(int)selectedBadgeNumer.Value - 1] = (uint)badgeSetIdNumer.Value;
        }

        private void SetNameInput_TextChanged(object sender, EventArgs e)
        {
            setNames[setIndexs[(int)selectSetNumer.Value - 1]] = setNameInput.Text;
        }
        private void SetIDNumer_ValueChanged(object sender, EventArgs e)
        {
            setIds[(int)selectSetNumer.Value - 1] = (uint)setIdNumer.Value;
        }
        private void SetStartingNumer_ValueChanged(object sender, EventArgs e)
        {
            setBadgeIndexs[(int)selectSetNumer.Value - 1] = (uint)setStartingNumer.Value - 1;
            UpdateAll();
        }
        //
        // Other stuff
        //
        private void ImportBadgeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap normal = new Bitmap(ofd.FileName);
                Bitmap downscaled = IMG.DownscaleImage(normal, 2, !pixelBadgeMode.Checked);

                if (normal.Width == 64 && normal.Height == 64)
                {

                    badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = normal;
                    badgeImgs32[badgeIndexs[(int)selectedBadgeNumer.Value - 1]] = downscaled;

                    if (uniqueBadges > 0)
                        UpdateBadgeInfo();
                }
                else
                {
                    MessageBox.Show("The image you imported doesn't have a size of 64px * 64px.", "Wrong size...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExportBadgeImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                badgeImgs64[badgeIndexs[(int)selectedBadgeNumer.Value - 1]].Save(sfd.FileName);
            }
        }
        private void ImportSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(ofd.FileName);
                if (img.Width == 48 && img.Height == 48)
                {
                    setImgs[setIndexs[(int)selectSetNumer.Value - 1]] = img;

                    if (sets > 0)
                        UpdateSetInfo();
                }
                else
                {
                    MessageBox.Show("The image you imported doesn't have a size of 48px * 48px.", "Wrong size...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExportSetImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PNG File (*.png)|*.png",
                DefaultExt = "*.png",
                AddExtension = true,
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                setImgs[setIndexs[(int)selectSetNumer.Value - 1]].Save(sfd.FileName);
            }
        }

        private void NNIDnumer_ValueChanged(object sender, EventArgs e)
        {
            NNID = (uint)NNIDnumer.Value;
        }

        private void TitleIDdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownUpdate)
            {
                badgeTitleIds[(int)selectedBadgeNumer.Value - 1] = GetTitleID(titleIDdropdown.SelectedIndex);
                if (titleIDdropdown.SelectedIndex != 0)
                    badgeHighIds[(int)selectedBadgeNumer.Value - 1] = 0x00040010;
                else
                    badgeHighIds[(int)selectedBadgeNumer.Value - 1] = 0xFFFFFFFF;
            }

            UpdateAll();
        }
        private void RegionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            region = regionDropdown.Text;
            for (int i = 0; i < uniqueBadges; i++)
            {
                if (systemApps.Contains(badgeTitleIds[i].ToString("X8")))
                    badgeTitleIds[i] = GetTitleID(GetTitleIndex(badgeTitleIds[i].ToString("X8")));
            }

            UpdateAll();
        }

        private void TitleIDnumer_ValueChanged(object sender, EventArgs e)
        {
            badgeTitleIds[(int)selectedBadgeNumer.Value - 1] = (uint)titleIDnumer.Value;
            UpdateTitleID();
        }
        private void TitleHighNumer_ValueChanged(object sender, EventArgs e)
        {
            badgeHighIds[(int)selectedBadgeNumer.Value - 1] = (uint)titleHighNumer.Value;
            UpdateTitleID();
        }

        public uint GetTitleID(int index)
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
        public int GetTitleIndex(string title)
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

        private void DelBadge_Click(object sender, EventArgs e)
        {
            DeleteBadge();
        }
        private void DelSet_Click(object sender, EventArgs e)
        {
            DeleteSet();
        }
        private void DelAll_Click(object sender, EventArgs e)
        {
            uniqueBadges = 0;
            sets = 0;

            badgeIds = new uint[1000];
            badgeSetIds = new uint[1000];
            badgeSids = new ushort[1000];
            badgeQuants = new ushort[1000];
            badgeNames = new string[1000];
            badgeTitleIds = new uint[1000];
            badgeIndexs = new ushort[1000];
            badgeImgs32 = new Bitmap[1000];
            badgeImgs64 = new Bitmap[1000];

            setIds = new uint[100];
            setUniqueBadges = new uint[100];
            setTotalBadges = new uint[100];
            setBadgeIndexs = new uint[100];
            setIndexs = new uint[100];
            setNames = new string[100];
            setImgs = new Bitmap[100];
            UpdateAll();
        }

        private void BadgeFilePrbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Badge File (*.prb)|*.prb",
                DefaultExt = "*.prb",
                AddExtension = true,
                Multiselect = true,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loading.Maximum = ofd.FileNames.Length * 2;
                loading.Value = 0;
                uint totalbadges = 0;
                foreach (string file in ofd.FileNames)
                {
                    BinaryReader br = new BinaryReader(File.OpenRead(file));
                    br.BaseStream.Seek(0, 0);
                    if (br.ReadUInt32() != 0x53425250)
                    {
                        MessageBox.Show("One of the files you were trying to import is not valid (file: " + Path.GetFileName(file) + ")", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        br.Close();
                        return;
                    }
                    br.BaseStream.Seek(0xB8, 0);
                    uint width = br.ReadUInt32();
                    uint height = br.ReadUInt32();
                    totalbadges += width * height;
                    loading.PerformStep();
                }
                if (uniqueBadges + totalbadges > 1000)
                {
                    MessageBox.Show("Unable to import that many badges...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string file in ofd.FileNames)
                {
                    BinaryReader br = new BinaryReader(File.OpenRead(file));
                    uint id, titleid, titlehid, width, height;
                    string name;

                    br.BaseStream.Seek(0x3C, 0);
                    id = br.ReadUInt32();
                    br.BaseStream.Seek(0xA4, 0);
                    titleid = br.ReadUInt32();
                    titlehid = br.ReadUInt32();
                    br.BaseStream.Seek(0xB8, 0);
                    width = br.ReadUInt32();
                    height = br.ReadUInt32();
                    br.BaseStream.Seek(0xE0, 0);
                    name = Encoding.Unicode.GetString(br.ReadBytes(0x8A));

                    byte[][] data_64 = new byte[width * height][];
                    byte[][] data_32 = new byte[width * height][];

                    if (uniqueBadges == 0)
                        BadgeOptions(true);

                    if (width * height == 1)
                        br.BaseStream.Seek(0x1100, 0);
                    else
                        br.BaseStream.Seek(0x4300, 0);

                    for (uint w = 0; w < width; w++)
                    {
                        for (uint h = 0; h < height; h++)
                        {
                            ushort subid = Convert.ToUInt16(Convert.ToString((ushort)((((width - 1) * 4) + ((height - 1) * 8)) + w + (h * 2)), 2), 16);

                            uniqueBadges++;
                            totalBadges++;

                            if (sets > 0)
                                badgeSetIds[uniqueBadges - 1] = setIds[sets - 1];
                            else
                                badgeSetIds[uniqueBadges - 1] = 0;

                            badgeIds[uniqueBadges - 1] = id;


                            badgeSids[uniqueBadges - 1] = subid;
                            badgeQuants[uniqueBadges - 1] = 1;
                            badgeNames[uniqueBadges - 1] = name;
                            badgeIndexs[uniqueBadges - 1] = (ushort)(uniqueBadges - 1);
                            badgeTitleIds[uniqueBadges - 1] = titleid;
                            badgeHighIds[uniqueBadges - 1] = titlehid;

                            data_64[(h * width) + w] = br.ReadBytes(0x2800);
                            data_32[(h * width) + w] = br.ReadBytes(0xA00);
                        }
                    }

                    for (int i = 0; i < width * height; i++)
                    {
                        badgeImgs64[uniqueBadges - ((width * height) - i)] = RT.RGB565andA4toPNG(data_64[i], 64);
                        badgeImgs32[uniqueBadges - ((width * height) - i)] = RT.RGB565andA4toPNG(data_32[i], 32);
                    }
                    br.Close();
                    loading.PerformStep();
                }
                selectedBadgeNumer.Maximum = uniqueBadges;
                selectedBadgeNumer.Value = uniqueBadges;
                SelectedBadgeNumer_ValueChanged(null, null);
                UpdateAll();
            }
        }
        private void SetFileCabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Set File (*.cab)|*.cab",
                DefaultExt = "*.cab",
                AddExtension = true,
            };

            if (uniqueBadges == 0)
            {
                MessageBox.Show("Not enough unique badges for a new set!.", "Not enough badges", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (sets >= 100)
            {
                MessageBox.Show("You have too many sets to import a new one...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (sets > 0)
            {
                if (setBadgeIndexs[sets - 1] >= uniqueBadges - 1)
                {
                    MessageBox.Show("Not enough unique badges for a new set!", "Not enough badges", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));

                br.BaseStream.Seek(0, 0);
                if (br.ReadUInt32() != 0x53424143)
                {
                    MessageBox.Show("The file you are trying to import is not valid", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    br.Close();
                    return;
                }

                if (sets == 0)
                    SetOptions(true);

                sets++;
                br.BaseStream.Seek(0x24, 0);
                setIds[sets - 1] = br.ReadUInt32();
                br.BaseStream.Seek(0x68, 0);
                setNames[sets - 1] = Encoding.Unicode.GetString(br.ReadBytes(0x8A));
                setBadgeIndexs[sets - 1] = uniqueBadges - 1;
                setTotalBadges[sets - 1] = 1;
                setUniqueBadges[sets - 1] = 1;
                setIndexs[sets - 1] = sets - 1;
                br.BaseStream.Seek(0x2080, 0);
                setImgs[sets - 1] = RT.GetSetImage(br.ReadBytes(0x2000));
                selectSetNumer.Maximum = sets;
                selectSetNumer.Value = sets;
                SelectSetNumer_ValueChanged(null, null);
                br.Close();
            }
        }
        private void FixBadgeSetIds_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sets - 1; i++)
            {
                for (int badge = (int)setBadgeIndexs[setIndexs[i]]; badge < setBadgeIndexs[setIndexs[i + 1]]; badge++)
                {
                    badgeSetIds[badgeIndexs[badge]] = setIds[setIndexs[i]];
                }
            }

            for (int badge = (int)setBadgeIndexs[setIndexs[sets - 1]]; badge < uniqueBadges; badge++)
            {
                badgeSetIds[badgeIndexs[badge]] = setIds[setIndexs[sets - 1]];
            }
            UpdateAll();
        }
        private void ImportEntireSetData_Click(object sender, EventArgs e)
        {
            if (sets >= 100)
            {
                MessageBox.Show("You have too many sets to import a new one...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            OpenFileDialog set = new OpenFileDialog()
            {
                Filter = "Set File (*.cab)|*.cab",
                DefaultExt = "*.cab",
                AddExtension = true,
                Title = "Select the set file",
            };
            if (set.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(File.OpenRead(set.FileName));
                br.BaseStream.Seek(0, 0);
                if (br.ReadUInt32() != 0x53424143)
                {
                    MessageBox.Show("The file you are trying to import is not valid", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    br.Close();
                    return;
                }
                br.Close();

                OpenFileDialog badges = new OpenFileDialog()
                {
                    Filter = "Badge File (*.prb)|*.prb",
                    DefaultExt = "*.prb",
                    AddExtension = true,
                    Multiselect = true,
                    Title = "Select all of the badges to be added to the set"
                };
                if (badges.ShowDialog() == DialogResult.OK)
                {
                    loading.Maximum = badges.FileNames.Length * 2;
                    loading.Value = 0;
                    uint totalbadges = 0;
                    foreach (string file in badges.FileNames)
                    {
                        br = new BinaryReader(File.OpenRead(file));
                        br.BaseStream.Seek(0, 0);
                        if (br.ReadUInt32() != 0x53425250)
                        {
                            MessageBox.Show("One of the files you were trying to import is not valid (file: " + Path.GetFileName(file) + ")", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            br.Close();
                            return;
                        }
                        br.BaseStream.Seek(0xB8, 0);
                        uint width = br.ReadUInt32();
                        uint height = br.ReadUInt32();
                        totalbadges += width * height;
                        loading.PerformStep();
                    }
                    if (uniqueBadges + totalbadges > 1000)
                    {
                        MessageBox.Show("Unable to import that many badges...", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    br = new BinaryReader(File.OpenRead(set.FileName));

                    if (sets == 0)
                        SetOptions(true);

                    sets++;
                    br.BaseStream.Seek(0x24, 0);
                    setIds[sets - 1] = br.ReadUInt32();
                    br.BaseStream.Seek(0x68, 0);
                    setNames[sets - 1] = Encoding.Unicode.GetString(br.ReadBytes(0x8A));
                    setBadgeIndexs[sets - 1] = uniqueBadges;
                    setTotalBadges[sets - 1] = totalbadges;
                    setUniqueBadges[sets - 1] = totalbadges;
                    setIndexs[sets - 1] = sets - 1;
                    br.BaseStream.Seek(0x2080, 0);
                    setImgs[sets - 1] = RT.GetSetImage(br.ReadBytes(0x2000));
                    br.Close();

                    foreach (string file in badges.FileNames)
                    {
                        br = new BinaryReader(File.OpenRead(file));
                        uint id, titleid, titlehid, width, height;
                        string name;

                        br.BaseStream.Seek(0x3C, 0);
                        id = br.ReadUInt32();
                        br.BaseStream.Seek(0xA4, 0);
                        titleid = br.ReadUInt32();
                        titlehid = br.ReadUInt32();
                        br.BaseStream.Seek(0xB8, 0);
                        width = br.ReadUInt32();
                        height = br.ReadUInt32();
                        br.BaseStream.Seek(0xE0, 0);
                        name = Encoding.Unicode.GetString(br.ReadBytes(0x8A));

                        byte[][] data_64 = new byte[width * height][];
                        byte[][] data_32 = new byte[width * height][];

                        if (uniqueBadges == 0)
                            BadgeOptions(true);

                        if (width * height == 1)
                            br.BaseStream.Seek(0x1100, 0);
                        else
                            br.BaseStream.Seek(0x4300, 0);

                        for (uint w = 0; w < width; w++)
                        {
                            for (uint h = 0; h < height; h++)
                            {
                                ushort subid = Convert.ToUInt16(Convert.ToString((ushort)((((width - 1) * 4) + ((height - 1) * 8)) + w + (h * 2)), 2), 16);

                                uniqueBadges++;
                                totalBadges++;

                                badgeSetIds[uniqueBadges - 1] = setIds[sets - 1];

                                badgeIds[uniqueBadges - 1] = id;
                                badgeSids[uniqueBadges - 1] = subid;
                                badgeQuants[uniqueBadges - 1] = 1;
                                badgeNames[uniqueBadges - 1] = name;
                                badgeIndexs[uniqueBadges - 1] = (ushort)(uniqueBadges - 1);
                                badgeTitleIds[uniqueBadges - 1] = titleid;
                                badgeHighIds[uniqueBadges - 1] = titlehid;

                                data_64[(h * width) + w] = br.ReadBytes(0x2800);
                                data_32[(h * width) + w] = br.ReadBytes(0xA00);
                            }
                        }

                        for (int i = 0; i < width * height; i++)
                        {
                            badgeImgs64[uniqueBadges - ((width * height) - i)] = RT.RGB565andA4toPNG(data_64[i], 64);
                            badgeImgs32[uniqueBadges - ((width * height) - i)] = RT.RGB565andA4toPNG(data_32[i], 32);
                        }

                        br.Close();
                        loading.PerformStep();
                    }
                    selectSetNumer.Maximum = sets;
                    selectSetNumer.Value = sets;
                    SelectSetNumer_ValueChanged(null, null);
                    selectedBadgeNumer.Maximum = uniqueBadges;
                    selectedBadgeNumer.Value = uniqueBadges;
                    SelectedBadgeNumer_ValueChanged(null, null);
                    UpdateAll();
                }
            }
        }


    }
}
