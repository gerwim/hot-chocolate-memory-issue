namespace Web;

public static class ImageService
{
    private static readonly string _image = Convert.ToBase64String(File.ReadAllBytes("giphy.gif"));

    public static string GetImage() => _image;
}
