using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SubScriberRaffle.Models;
public class UserProfileDetail
{
    public string Id { get; set; }

    public Image Image { get; set; }

    public string UserName { get; set; }

    public string Comment { get; set; }

    public string ImageUrl { get; set; }

    public bool IsSelected { get; set; }

    public async Task DownloadImageAndSet() // to be used unique file name
    {
        if (Image is not null)
        {
            await Task.CompletedTask;
            return;
        }

        try
        {
            Directory.CreateDirectory(Constants.LocalImageDir);

            string filePath = Path.Combine(Constants.LocalImageDir, Id + ".png");

            if (File.Exists(filePath))
            {
                Image = Image.FromFile(filePath);
                return;
            }

            HttpClient client = new HttpClient();

            byte[] fileBytes = await client.GetByteArrayAsync(ImageUrl);
            File.WriteAllBytes(filePath, fileBytes);

            Image = Image.FromStream(new MemoryStream(fileBytes));
        }
        catch (Exception ex)
        {
            // ignore
        }
    }
}
