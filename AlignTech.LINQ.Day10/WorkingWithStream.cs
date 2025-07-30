using System.IO.Compression;

namespace AlignTech.LINQ.Day10
{
    internal class WorkingWithStream
    {
        /// <summary>
        /// Copies files from a source directory to a destination directory, filtering by file extensions, and then creates a ZIP archive of the copied files.
        /// </summary>
        /// <param name="sourceDir">Source Directory</param>
        /// <param name="destDir">Destination Directory</param>
        /// <param name="extensions">File Extensions to Include</param>
        /// <returns></returns>
        public async Task CopyFiles(string sourceDir, string destDir, params string[] extensions)
        {
            string zipPath = Path.Combine(destDir, "TextAndCSV.zip");
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                if (Array.Exists(extensions, ext => file.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                {
                    string fileName = Path.GetFileName(file);
                    string destPath = Path.Combine(destDir, fileName);

                    // Retry logic for file access
                    bool success = false;
                    int retries = 0;
                    while (!success && retries < 3)
                    {
                        try
                        {
                            using (FileStream sourceStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true))
                            using (FileStream destStream = new FileStream(destPath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                            {
                                await sourceStream.CopyToAsync(destStream);
                                await destStream.FlushAsync();
                                destStream.Close();
                                sourceStream.Close();
                            }
                            success = true;
                        }
                        catch (IOException ex) when (ex.Message.Contains("another process"))
                        {
                            retries++;
                            await Task.Delay(1000); // Wait 1 second before retrying
                        }
                    }

                    if (!success)
                    {
                        Console.WriteLine($"Failed to copy {file} after {retries} retries.");
                        continue;
                    }

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    await Task.Delay(100); // Brief delay between files
                }
            }

            // Extended delay to ensure all file handles are released
            await Task.Delay(1000);

            //Zip it
            // Retry logic for ZIP creation
            bool zipSuccess = false;
            int zipRetries = 3;
            while (!zipSuccess && zipRetries > 0)
            {
                try
                {
                    if (File.Exists(zipPath))
                    {
                        File.SetAttributes(zipPath, FileAttributes.Normal); // Remove read-only attribute if exists
                        File.Delete(zipPath); // Delete existing ZIP to avoid conflicts
                    }
                    ZipFile.CreateFromDirectory(destDir, zipPath, CompressionLevel.Optimal, false);
                    zipSuccess = true;
                }
                catch (IOException ex) when (ex.Message.Contains("being used by another process"))
                {
                    zipRetries--;
                    await Task.Delay(2000); // Wait 2 seconds before retrying ZIP creation
                    Console.WriteLine($"ZIP creation failed, retries left: {zipRetries}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating ZIP: {ex.Message}");
                    break;
                }
            }

            if (!zipSuccess)
            {
                Console.WriteLine($"Failed to create ZIP at {zipPath} after retries.");
            }
        }
    }
}
