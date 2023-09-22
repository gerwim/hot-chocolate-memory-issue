namespace Web;

public static class ImageService
{
    public static string GetImage()
    {
        return Convert.ToBase64String(File.ReadAllBytes("giphy.gif"));
    }
}