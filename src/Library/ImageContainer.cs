namespace CompAndDel;
using System;

public class ImageContainer
{
    private PictureProvider provider;

    public void SaveImage(IPicture picture, string path)
    {
        provider = new PictureProvider();
        provider.SavePicture(picture, path);
    }

    public string GeneratePath()
    {
        return DateTime.Now.ToString("yyyyMMdd_hhmmssfff") + ".jpg";
    }
}


