using System.IO;

namespace facade
{
    public class VideoLoader
    {
        public Video Load(string fileName)
        {
            string format = Path.GetExtension(fileName).TrimStart('.').ToLower();
            Video video = new Video(fileName, format);

            video.Steps.Add("VideoLoader: levanta el archivo " + fileName + ".");
            video.Steps.Add("VideoLoader: detecta que el formato original es " + format + ".");

            return video;
        }
    }
}
