using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public class Filter
    {
        // Remember to Unlock Bits after using this
        private static BitmapData GetData(Bitmap bmp)
        {
            return bmp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
        }

        public static Bitmap FromSize(Bitmap bmp)
        {
            return new Bitmap(bmp.Width, bmp.Height);
        }

        public static void Copy(ref Bitmap source, ref Bitmap destination)
        {
            if (destination == null || destination.Size != source.Size) destination = FromSize(source);

            BitmapData sourceData = GetData(source);
            BitmapData destinationData = GetData(destination);

            IntPtr sourceStart = sourceData.Scan0;
            IntPtr destinationStart = destinationData.Scan0;

            unsafe
            {

                byte* s = (byte*)(void*)sourceStart;
                byte* d = (byte*)(void*)destinationStart;

                for (int i = 0; i < source.Width; i++)
                {
                    for (int j = 0; j < source.Height; j++)
                    {
                        d[0] = s[0];
                        d[1] = s[1];
                        d[2] = s[2];
                        d[3] = s[3]; // Also copy alpha

                        s += 4;
                        d += 4;
                    }
                }
            }

            source.UnlockBits(sourceData);
            destination.UnlockBits(destinationData);
        }

        public static void Invert(ref Bitmap source, ref Bitmap destination)
        {
            if (destination == null || destination.Size != source.Size) destination = FromSize(source);

            BitmapData sourceData = GetData(source);
            BitmapData destinationData = GetData(destination);

            IntPtr sourceStart = sourceData.Scan0;
            IntPtr destinationStart = destinationData.Scan0;

            unsafe
            {

                byte* s = (byte*)(void*)sourceStart;
                byte* d = (byte*)(void*)destinationStart;

                for (int i = 0; i < source.Width; i++)
                {
                    for (int j = 0; j < source.Height; j++)
                    {
                        d[0] = (byte)(255 - s[0]);
                        d[1] = (byte)(255 - s[1]);
                        d[2] = (byte)(255 - s[2]);

                        s += 4;
                        d += 4;
                    }
                }
            }

            source.UnlockBits(sourceData);
            destination.UnlockBits(destinationData);
        }

        public static void Greyscale(ref Bitmap source, ref Bitmap destination)
        {
            if (destination == null || destination.Size != source.Size) destination = FromSize(source);

            BitmapData sourceData = GetData(source);
            BitmapData destinationData = GetData(destination);

            IntPtr sourceStart = sourceData.Scan0;
            IntPtr destinationStart = destinationData.Scan0;

            unsafe
            {

                byte* s = (byte*)(void*)sourceStart;
                byte* d = (byte*)(void*)destinationStart;

                for (int i = 0; i < source.Width; i++)
                {
                    for (int j = 0; j < source.Height; j++)
                    {
                        d[0] = d[1] = d[2] = (byte)(.299 * s[2] + .587 * s[1] + .114 * s[0]);

                        s += 4;
                        d += 4;
                    }
                }
            }

            source.UnlockBits(sourceData);
            destination.UnlockBits(destinationData);
        }

        public static void Sepia(ref Bitmap source, ref Bitmap destination)
        {
            if (destination == null || destination.Size != source.Size) destination = FromSize(source);

            BitmapData sourceData = GetData(source);
            BitmapData destinationData = GetData(destination);

            IntPtr sourceStart = sourceData.Scan0;
            IntPtr destinationStart = destinationData.Scan0;

            unsafe
            {
                float R = 1f;
                float G = 0.95f;
                float B = 0.82f;

                byte* s = (byte*)(void*)sourceStart;
                byte* d = (byte*)(void*)destinationStart;

                for (int i = 0; i < source.Width; i++)
                {
                    for (int j = 0; j < source.Height; j++)
                    {
                        d[0] = d[1] = d[2] = (byte)(.299 * s[2] + .587 * s[1] + .114 * s[0]);

                        d[0] = (byte)(d[0] * B);
                        d[1] = (byte)(d[1] * G);
                        d[2] = (byte)(d[2] * R);

                        s += 4;
                        d += 4;
                    }
                }
            }

            source.UnlockBits(sourceData);
            destination.UnlockBits(destinationData);
        }
    }
}
