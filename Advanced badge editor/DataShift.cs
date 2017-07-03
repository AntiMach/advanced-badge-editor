using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace RTTools
{
    class DataShift
    {
        static internal int bits(int num)
        {
            int ret = num;
            int loops = 0;
            while (ret > 0)
            {
                ret /= 2;
                loops++;
            }
            return loops;
        }

        static internal int getZfromXY(int X, int Y)
        {
            int Z = 0;
            for (int bX = 0; bX <= bits(X); bX++)
            {
                Z += ((X & (int)Math.Pow(2, bX)) << bX);
            }
            for (int bY = 0; bY <= bits(Y); bY++)
            {
                Z += ((Y & (int)Math.Pow(2, bY)) << (bY + 1));
            }
            return Z;
        }

        static internal void getXYfromZ(int Z, out int X, out int Y)
        {
            X = 0;
            for (int bZ = 0; bZ <= (bits(Z) / 2); bZ++)
            {
                X += ((Z & (int)Math.Pow(2, (bZ * 2))) >> bZ);
            }
            Y = 0;
            for (int bZ = 0; bZ <= (bits(Z) / 2); bZ++)
            {
                Y += ((Z & (int)Math.Pow(2, (bZ * 2) + 1)) >> bZ + 1);
            }
        }

        static internal ulong getDataOffset(int tileX, int tileY, int pixel, int width)
        {
            int X, Y;
            getXYfromZ(pixel, out X, out Y);
            return (ulong)((tileX * 8) + X + ((tileY * 8 + Y) * width));
        }

        static internal void ARGB8toRGB565andA4(Color argb, out ushort rgb565, out byte a4)
        {
            rgb565 = (ushort)((((argb.R >> 3) & 0x1F) << 11) + (((argb.G >> 2) & 0x3F) << 5) + ((argb.B >> 3) & 0x1F));
            a4 = (byte)(argb.A >> 4);
        }

        static internal Color RGB565andA4toARGB8(byte A4, ushort RGB565)
        {
            int[] ret = new int[4];
            ret[0] = A4 * 17;
            if (ret[0] > 255) ret[0] = 255;
            ret[1] = (RGB565 & 0xF800) >> 8;
            ret[2] = (RGB565 & 0x7E0) >> 3;
            ret[3] = (RGB565 & 0x1F) << 3;
            return Color.FromArgb(ret[0], ret[1], ret[2], ret[3]);
        }

        static internal ushort[] getRGB565array(byte[] data, int size)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryReader br = new BinaryReader(ms);

            ushort[] rgb565 = new ushort[size * size];
            for (int i = 0; i < size * size; i++)
            {
                rgb565[i] = br.ReadUInt16();
            }
            br.Close();
            return rgb565;
        }

        static internal byte[] getA4array(byte[] data, int size)
        {
            byte[] a4 = new byte[size * size];
            for (int i = 0; i < (size * size) / 2; i++)
            {
                a4[i * 2] = (byte)(data[i + ((size * size) * 2)] & 0x0F);
                a4[(i * 2) + 1] = (byte)((data[i + ((size * size) * 2)] & 0xF0) >> 4);
            }
            return a4;
        }

        static internal byte[] combine2Arrays(byte[] data1, byte[] data2)
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            bw.Write(data1);
            bw.Write(data2);
            bw.Close();

            return ms.ToArray();
        }
    }

    class IMG
    {
        static internal Bitmap downscaleImg(Bitmap img, int dscale, bool hq)
        {
            float width = img.Width / dscale;
            float height = img.Height / dscale;

            Bitmap bmp = new Bitmap((int)width, (int)height);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            Graphics graph = Graphics.FromImage(bmp);

            if (hq)
            {
                graph.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graph.SmoothingMode = SmoothingMode.HighQuality;
                graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graph.CompositingMode = CompositingMode.SourceCopy;
                graph.CompositingQuality = CompositingQuality.HighQuality;
            }
            using (ImageAttributes wrapMode = new ImageAttributes())
            {
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graph.DrawImage(img, new Rectangle(0, 0, (int)width, (int)height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, wrapMode);
            }

            return bmp;
        }

        static internal Bitmap cropImage(Bitmap img, Rectangle area)
        {
            Bitmap Output = new Bitmap(area.Width, area.Height);
            Graphics Adjust = Graphics.FromImage(Output);

            Adjust.DrawImage(img, 0, 0, area, GraphicsUnit.Pixel);

            return Output;
        }

        static internal Bitmap stretchImage(Bitmap img)
        {
            Bitmap new_img = new Bitmap(img);

            int start;
            Color Pixel = new Color();

            //
            // Stretch from the right
            //
            for (int y = 0; y < new_img.Height - 1; y++)
            {
                start = 0;
                for (int x = new_img.Width - 1; x > 0; x--)
                {
                    if (new_img.GetPixel(x, y).A > 0)
                    {
                        start = x;
                        Pixel = Color.FromArgb(255, new_img.GetPixel(x, y).R, new_img.GetPixel(x, y).G, new_img.GetPixel(x, y).B);
                        x = 0;
                    }
                }

                for (int x = start; x < new_img.Width; x++)
                {
                    new_img.SetPixel(x, y, Pixel);
                }

            }

            //
            // Stretch from the left
            //
            for (int y = 0; y < new_img.Height - 1; y++)
            {
                start = 0;
                for (int x = 0; x < new_img.Width - 1; x++)
                {
                    if (new_img.GetPixel(x, y).A > 0)
                    {
                        start = x;
                        Pixel = Color.FromArgb(255, new_img.GetPixel(x, y).R, new_img.GetPixel(x, y).G, new_img.GetPixel(x, y).B);
                        x = new_img.Width - 1;
                    }
                }

                for (int x = start; x > -1; x--)
                {
                    new_img.SetPixel(x, y, Pixel);
                }

            }

            //
            // Stretch from the top
            //
            for (int x = 0; x < new_img.Width; x++)
            {
                start = 0;
                for (int y = 0; y < new_img.Height - 1; y++)
                {
                    if (new_img.GetPixel(x, y).A > 0)
                    {
                        start = y;
                        Pixel = Color.FromArgb(255, new_img.GetPixel(x, y).R, new_img.GetPixel(x, y).G, new_img.GetPixel(x, y).B);
                        y = new_img.Height - 1;
                    }
                }

                for (int y = start; y > -1; y--)
                {
                    new_img.SetPixel(x, y, Pixel);
                }

            }

            //
            // Stretch from the bottom
            //
            for (int x = 0; x < new_img.Width; x++)
            {
                start = 0;
                for (int y = new_img.Height - 1; y > 0; y--)
                {
                    if (new_img.GetPixel(x, y).A > 0)
                    {
                        start = y;
                        Pixel = Color.FromArgb(255, new_img.GetPixel(x, y).R, new_img.GetPixel(x, y).G, new_img.GetPixel(x, y).B);
                        y = 0;
                    }
                }

                for (int y = start; y < new_img.Height; y++)
                {
                    new_img.SetPixel(x, y, Pixel);
                }

            }

            return new_img;
        }
    }

    class RT
    {
        static internal void createBadgeFromImage(Bitmap img, out byte[] RGB565_64, out byte[] A4_64, out byte[] RGB565_32, out byte[] A4_32)
        {
            Bitmap downscaled = IMG.downscaleImg(img, 2, true);

            PNGtoRGB565andA4(img, out RGB565_64, out A4_64);
            PNGtoRGB565andA4(downscaled, out RGB565_32, out A4_32);
        }

        static internal void getImagesFromBadge(byte[] data, out Bitmap img64, out Bitmap img32)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryReader br = new BinaryReader(ms);

            img64 = RGB565andA4toPNG(br.ReadBytes(0x2800), 64);
            img32 = RGB565andA4toPNG(br.ReadBytes(0xA00), 32);

            br.Close();
        }

        static internal void retriveDataFromBadge(string filepath, out byte[][] data, out uint width, out uint height)
        {
            BinaryReader br = new BinaryReader(new FileStream(filepath, FileMode.Open));
            br.BaseStream.Seek(0xB8, 0);
            width = br.ReadUInt32();
            height = br.ReadUInt32();

            data = new byte[width * height * 2][];

            if (width >= 2 || height >= 2)
                br.BaseStream.Seek(0x4300, 0);
            else
                br.BaseStream.Seek(0x1100, 0);

            for (int x = 0; x < width * height; x++)
            {
                data[x * 2] = br.ReadBytes(0x2800);
                data[x * 2 + 1] = br.ReadBytes(0xA00);
            }
                

            br.Close();
        }

        static internal Bitmap RGB565andA4toPNG(byte[] data, int size)
        {
            return getPNG(DataShift.getRGB565array(data, size), DataShift.getA4array(data, size), size, size);
        }

        static internal void PNGtoRGB565andA4(Bitmap image, out byte[] rgb565, out byte[] a4)
        {
            Bitmap stretched = IMG.stretchImage(image);

            rgb565 = getBCLIM(stretched, 0);
            a4 = getBCLIM(image, 1);
        }

        static internal Bitmap getPNG(ushort[] rgb565, byte[] a4, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Color[] colors = new Color[width * height];

            for (int tY = 0; tY < height / 8; tY++)
            {
                for (int tX = 0; tX < width / 8; tX++)
                {
                    for (int Y = 0; Y < 8; Y++)
                    {
                        for (int X = 0; X < 8; X++)
                        {
                            int z = DataShift.getZfromXY(X, Y);

                            bmp.SetPixel(X + tX * 8, Y + tY * 8, DataShift.RGB565andA4toARGB8(a4[z + (tY * 8 * width) + (tX * 64)], rgb565[z + (tY * 8 * width) + (tX * 64)]));
                        }
                    }
                }
            }

            return bmp;
        }
        
        static internal byte[] getBCLIM(Bitmap image, int fmt)
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            for (int tY = 0; tY < image.Height / 8; tY++)
            {
                for (int tX = 0; tX < image.Width / 8; tX++)
                {
                    for (int pixel = 0; pixel < 64; pixel++)
                    {
                        int x, y;
                        DataShift.getXYfromZ(pixel, out x, out y);

                        x += tX * 8;
                        y += tY * 8;

                        Color c = image.GetPixel(x, y);

                        ushort rgb565;
                        byte a4;

                        DataShift.ARGB8toRGB565andA4(c, out rgb565, out a4);

                        switch (fmt)
                        {
                            case 0:
                                bw.Write(rgb565);
                                break;
                            case 1:
                                byte val = a4;
                                pixel++;
                                DataShift.getXYfromZ(pixel, out x, out y);
                                x += tX * 8;
                                y += tY * 8;
                                c = image.GetPixel(x, y);
                                DataShift.ARGB8toRGB565andA4(c, out rgb565, out a4);
                                val |= (byte)(a4 << 4);
                                bw.Write(val);
                                break;
                        }
                    }
                }
            }

            bw.Close();
            return ms.ToArray();
        }

        static internal byte[] adjustForSet(Bitmap img)
        {
            Bitmap Output = new Bitmap(64, 64);
            Graphics Adjust = Graphics.FromImage(Output);

            Adjust.DrawImage(img, new Rectangle(0, 0, 48, 48));
            Output = IMG.stretchImage(Output);

            byte[] rgb565, a4;

            PNGtoRGB565andA4(Output, out rgb565, out a4);

            return rgb565;
        }

        static internal Bitmap getSetImage(byte[] data)
        {
            byte[] nul = new byte[0x800];
            for (int i = 0; i < nul.Length; i++)
                nul[i] = 0xFF;

            return IMG.cropImage(RGB565andA4toPNG(DataShift.combine2Arrays(data, nul), 64), new Rectangle(0, 0, 48, 48));
        }
    }
}
