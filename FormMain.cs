﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DroxEdit
{
    public partial class FormMain : Form
    {
        // File, Buffer and Stream
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DroxOperative\User\chars\global.sav";
        string iconPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Data\Icons";
        FileStream stream;
        byte[] buffer;

        // Items
        int cargoBays = 0;
        int[] cargoBaySizes = new int[8];
        ImageList itemImages = new ImageList();
        List<Item> items = new List<Item>();

        public FormMain()
        {
            InitializeComponent();

            // Setup Item Images
            itemImages.ImageSize = new Size(64, 64);
            string[] icons = Directory.GetFiles(iconPath);
            foreach (string icon in icons)
            {
                Image image = Image.FromFile(icon);
                itemImages.Images.Add(Path.GetFileNameWithoutExtension(icon), image);
            }
            listViewItems.LargeImageList = itemImages;

            if (!OpenFile())
            {
                MessageBox.Show("Your Drox Operative Stash file could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // Initialize the buffer
            buffer = new byte[256];

            // Load Database files
            ItemDatabase.Init();
            // ModifierDatabase.Init();
            
            // Read the Stash file
            ReadStash();

            // Enable update timer
            timer.Enabled = true;
            
            // Select the first item automatically
            listViewItems_ItemSelectionChanged(null, new ListViewItemSelectionChangedEventArgs(null, 0, true));
        }

        private bool OpenFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }

                if (stream == null)
                    return false;
                else
                    return true;
            }

            return false;
        }

        private void ReadStash()
        {
            // Header
            stream.Read(buffer, 0, 8);
            if (buffer[0] != 0x96 && buffer[3] == 0x08)
            {
                MessageBox.Show("Stash header is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            ReadCargoBays();
            ReadItems();
        }

        private void ReadCargoBays()
        {
            bool done = false;
            int index = 0;

            stream.Seek(0x0C, SeekOrigin.Begin);

            while (!done)
            {
                stream.Read(buffer, 0, 4);
                if (buffer[0] == 'B' && buffer[1] == 'a' && buffer[2] == 'g')
                {
                    switch (buffer[3])
                    {
                        case 0x31: // 1 - Tiny
                            cargoBaySizes[index++] = 4;
                            break;
                        case 0x32: // 2 - Small
                            cargoBaySizes[index++] = 6;
                            break;
                        case 0x33: // 3 - Medium
                            cargoBaySizes[index++] = 8;
                            break;
                        case 0x34: // 4 - Large
                            cargoBaySizes[index++] = 10;
                            break;
                        case 0x35: // 5 - Very Large
                            cargoBaySizes[index++] = 12;
                            break;
                        case 0x36: // 6 - Huge
                            cargoBaySizes[index++] = 14;
                            break;
                        case 0x37: // 7 - Giant
                            cargoBaySizes[index++] = 16;
                            break;
                        default: // Unknown
                            MessageBox.Show("Invalid cargo bay object!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            break;
                    }

                    cargoBays++;
                }
                else
                    done = true;

                stream.Seek(0x3E, SeekOrigin.Current);
            }
        }

        private void ReadItems()
        {
            bool done = false;
            int index = 0;

            // Seek to the first item
            stream.Seek(0x0C + (cargoBays * 0x42), SeekOrigin.Begin);
            for (int i = 0; i < 8 - cargoBays; i++)
                stream.Seek(0x04, SeekOrigin.Current);

            while (!done)
            {
                Item item = new Item();

                // Is there an item here?
                stream.Read(buffer, 0, 4);
                if (buffer[0] != 1)
                {
                    // No item, move to the next
                    stream.Seek(0x04, SeekOrigin.Current);

                    // We're done if we seek past the end of the file
                    if (stream.Position >= stream.Length)
                        done = true;

                    continue;
                }

                // Item Type, Subtype and Rank
                const int NameSize = 64; // 64 chars should be enough for reading the name data
                string type = string.Empty;
                string subtype = string.Empty;
                int length = 0;
                stream.Read(buffer, 0, NameSize);
                for (int i = 0; buffer[i] != 0; i++)
                {
                    length = i + 1;
                    type += (char)buffer[i];
                }
                string[] s = type.Split('-');
                if (s.Length >= 1) // Type
                    item.type = s[0];
                if (s.Length >= 2) // Rank
                    item.rank = int.Parse(s[1]);
                if (s.Length >= 3) // Prefix
                    item.prefix = s[2];

                // ID
                stream.Seek(0x01 - NameSize + length, SeekOrigin.Current);
                stream.Read(buffer, 0, 4);
                item.id = ReadInt();

                // Identified
                stream.Read(buffer, 0, 4);
                item.identified = Convert.ToBoolean(buffer[0]);

                // Modifier Count
                stream.Read(buffer, 0, 4);
                item.modifierCount = ReadInt();

                // TODO: Modifiers/Sockets - probably in it's own function

                // Armor
                stream.Read(buffer, 0, 4);
                item.armor = ReadInt();

                // Defense
                stream.Read(buffer, 0, 4);
                item.defense = ReadInt();

                // Power Load
                stream.Read(buffer, 0, 4);
                item.powerLoad = ReadInt();

                // Delimiter
                stream.Seek(0x0D, SeekOrigin.Current);

                // Durability
                stream.Read(buffer, 0, 4);
                item.durability = ReadInt();

                // Max Durability
                stream.Read(buffer, 0, 4);
                item.durabilityMax = ReadInt();

                // Skip unknown bytes
                stream.Seek(0x08, SeekOrigin.Current);

                // Minimum Level
                stream.Read(buffer, 0, 4);
                item.minLevel = ReadInt();

                // Get info from Database
                for (int i = 0; i < ItemDatabase.Items.Count; i++)
                    if (item.type == ItemDatabase.Items[i].type)
                    {
                        item.name = ItemDatabase.Items[i].name;
                        item.imageKey = ItemDatabase.Items[i].imageKey;
                        item.rankMax = ItemDatabase.Items[i].rankMax;
                    }

                // Add item to lists and move to next item
                items.Add(item);
                listViewItems.Items.Add("Item");
                index++;
            }
        }

        private int ReadInt()
        {
            byte[] data = new byte[4];

            for (int i = 0; i < 4; i++)
                data[i] = buffer[i];

            return BitConverter.ToInt32(data, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Update Item List
            for (int i = 0; i < items.Count; i++)
            {
                listViewItems.Items[i].Text = items[i].ToString();
                listViewItems.Items[i].ImageKey = items[i].imageKey;
            };
        }

        private void listViewItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            labelItemName.Text = items[e.ItemIndex].ToString();

            labelID.Text = "ID\n" + items[e.ItemIndex].id.ToString();
            checkBoxIdentified.Checked = items[e.ItemIndex].identified;
            numericUpDownRank.Maximum = items[e.ItemIndex].rankMax;
            if (numericUpDownRank.Maximum == 0) // Shit error check for unknown items
                numericUpDownRank.Value = 0;
            else
                numericUpDownRank.Value = items[e.ItemIndex].rank;
            numericUpDownArmor.Value = items[e.ItemIndex].armor;
            numericUpDownDefense.Value = items[e.ItemIndex].defense;
            numericUpDownPowerLoad.Value = items[e.ItemIndex].powerLoad;
            numericUpDownDurability.Value = items[e.ItemIndex].durability;
            numericUpDownDurabilityMax.Value = items[e.ItemIndex].durabilityMax;
            numericUpDownMinLevel.Value = items[e.ItemIndex].minLevel;

            labelModifiers.Text = "Modifiers: " + items[e.ItemIndex].modifierCount + " (" + items[e.ItemIndex].GetRarity() + ")";
        }
    }
}