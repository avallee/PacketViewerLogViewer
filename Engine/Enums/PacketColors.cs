using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketViewerLogViewer.Engine.Enums
{
    public static class PacketColors
    {
        static public Color ColBackIN;
        static public Color ColBackOUT;
        static public Color ColBackUNK;
        static public Color ColBarIN;
        static public Color ColBarOUT;
        static public Color ColBarUNK;
        static public Color ColFontIN;
        static public Color ColFontOUT;
        static public Color ColFontUNK;
        static public Color ColSelectedFontIN;
        static public Color ColSelectedFontOUT;
        static public Color ColSelectedFontUNK;
        static public Color ColSelectIN;
        static public Color ColSelectOUT;
        static public Color ColSelectUNK;
        static public Color ColSyncIN;
        static public Color ColSyncOUT;
        static public Color ColSyncUNK;
        static public int PacketListStyle;
        public static List<Color> DataColors = new List<Color>();

        public static void UpdateColorsFromSettings()
        {
            ColBackIN = Properties.Settings.Default.ColBackIN;
            ColBackOUT = Properties.Settings.Default.ColBackOUT;
            ColBackUNK = Properties.Settings.Default.ColBackUNK;
            ColBarIN = Properties.Settings.Default.ColBarIN;
            ColBarOUT = Properties.Settings.Default.ColBarOUT;
            ColBarUNK = Properties.Settings.Default.ColBarUNK;
            ColFontIN = Properties.Settings.Default.ColFontIN;
            ColFontOUT = Properties.Settings.Default.ColFontOUT;
            ColFontUNK = Properties.Settings.Default.ColFontUNK;
            ColSelectedFontIN = Properties.Settings.Default.ColSelectedFontIN;
            ColSelectedFontOUT = Properties.Settings.Default.ColSelectedFontOUT;
            ColSelectedFontUNK = Properties.Settings.Default.ColSelectedFontUNK;
            ColSelectIN = Properties.Settings.Default.ColSelectIN;
            ColSelectOUT = Properties.Settings.Default.ColSelectOUT;
            ColSelectUNK = Properties.Settings.Default.ColSelectUNK;
            ColSyncIN = Properties.Settings.Default.ColSyncIN;
            ColSyncOUT = Properties.Settings.Default.ColSyncOUT;
            ColSyncUNK = Properties.Settings.Default.ColSyncUNK;
            PacketListStyle = Properties.Settings.Default.PacketListStyle;

            // Default Field Colors
            var n = Properties.Settings.Default.ColFieldCount;
            DataColors.Clear();
            DataColors.Add(SystemColors.WindowText);
            if (n >= 2)
                DataColors.Add(Properties.Settings.Default.ColField1);

            if (n >= 3)
                DataColors.Add(Properties.Settings.Default.ColField2);

            if (n >= 4)
                DataColors.Add(Properties.Settings.Default.ColField3);

            if (n >= 5)
                DataColors.Add(Properties.Settings.Default.ColField4);

            if (n >= 6)
                DataColors.Add(Properties.Settings.Default.ColField5);

            if (n >= 7)
                DataColors.Add(Properties.Settings.Default.ColField6);

            if (n >= 8)
                DataColors.Add(Properties.Settings.Default.ColField7);

            if (n >= 9)
                DataColors.Add(Properties.Settings.Default.ColField8);

            if (n >= 10)
                DataColors.Add(Properties.Settings.Default.ColField9);

            if (n >= 11)
                DataColors.Add(Properties.Settings.Default.ColField10);

            if (n >= 12)
                DataColors.Add(Properties.Settings.Default.ColField11);

            if (n >= 13)
                DataColors.Add(Properties.Settings.Default.ColField12);

            if (n >= 14)
                DataColors.Add(Properties.Settings.Default.ColField13);

            if (n >= 15)
                DataColors.Add(Properties.Settings.Default.ColField14);

            if (n >= 16)
                DataColors.Add(Properties.Settings.Default.ColField15);
            /*
            DataColors.Add(Color.Chocolate);
            DataColors.Add(Color.MediumSeaGreen);
            DataColors.Add(Color.CornflowerBlue);
            DataColors.Add(Color.DarkSalmon);
            DataColors.Add(Color.DarkGray);
            DataColors.Add(Color.Brown);
            DataColors.Add(Color.MidnightBlue);
            */
        }
    }

}
