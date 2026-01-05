using System;
using System.IO;

class HexViewer
{
    static void Main()
    {
        string filePath = @"path";
        int octetsPerLine = 16;

        if (!File.Exists(filePath))
        {
            Console.WriteLine("error - file not found");
            return;
        }

        using (FileStream fluxFile = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[octetsPerLine];
            long currentPosition = 0;
            int nrOctetsRead;

            while ((nrOctetsRead = fluxFile.Read(buffer, 0, buffer.Length)) > 0)
            {
                Console.Write($"{currentPosition:X8}: ");

                for (int i = 0; i < octetsPerLine; i++)
                {
                    if (i < nrOctetsRead)
                    {
                        Console.Write($"{buffer[i]:X2} ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }

                Console.Write("| ");

                for (int i = 0; i < nrOctetsRead; i++)
                {
                    char character = (char)buffer[i];

                    if (character >= 32 && character <= 126)
                    {
                        Console.Write(character);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
                currentPosition += nrOctetsRead;
            }
        }
    }
}