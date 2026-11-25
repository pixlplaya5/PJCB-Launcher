namespace PJCBLauncher;

public class DLManager
{
    // Reuse a single HttpClient instance across your app's lifecycle
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task<string> DownloadToFolderAsync(
        string url,
        string destinationFolder,
        IProgress<double>? progress = null,
        CancellationToken cancellationToken = default)
    {
        using var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
        response.EnsureSuccessStatusCode();

        // 1. Try getting the filename from the Content-Disposition header
        string? fileName = response.Content.Headers.ContentDisposition?.FileNameStar 
                        ?? response.Content.Headers.ContentDisposition?.FileName?.Trim('"');

        // 2. Fallback to extracting the filename from the URL
        if (string.IsNullOrWhiteSpace(fileName))
        {
            var uri = new Uri(url);
            fileName = Path.GetFileName(uri.LocalPath);
        }

        // 3. Final fallback if the URL has no filename (e.g., https://example.com)
        if (string.IsNullOrWhiteSpace(fileName))
        {
            fileName = $"download_{DateTime.Now:yyyyMMdd_HHmmss}";
        }

        // Sanitize invalid characters and ensure the folder exists
        fileName = string.Concat(fileName.Split(Path.GetInvalidFileNameChars()));
        Directory.CreateDirectory(destinationFolder);
        string fullPath = Path.Combine(destinationFolder, fileName);

        var totalBytes = response.Content.Headers.ContentLength ?? -1L;
        var canReportProgress = totalBytes != -1 && progress != null;

        await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationToken);
        await using var fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true);

        var buffer = new byte[8192];
        long totalRead = 0;
        int bytesRead;

        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
        {
            await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationToken);
            totalRead += bytesRead;

            if (canReportProgress)
            {
                double percentage = (double)totalRead / totalBytes * 100;
                progress!.Report(percentage);
            }
        }

        return fullPath; // Returns the final saved path
    }
}