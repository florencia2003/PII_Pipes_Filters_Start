using System;

namespace CompAndDel;

 //Ejercico 2
public class ImageContainer
{
    private PictureProvider provider;

    public string GeneratePath()
    {
        return DateTime.Now.ToString("yyyyMMdd_hhmmssfff") + ".jpg";
    }
    
    public void SaveImage(IPicture picture, string path)
    {
        provider = new PictureProvider();
        provider.SavePicture(picture, path);
    }

}


