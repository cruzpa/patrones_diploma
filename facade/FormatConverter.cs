using System.IO;

namespace facade
{
    public class FormatConverter
    {
        public Video Convert(Video video, string format)
        {
            string destinationFormat = format.Trim().ToLower();
            string convertedFileName = Path.GetFileNameWithoutExtension(video.FileName) + "." + destinationFormat;
            Video convertedVideo = new Video(convertedFileName, destinationFormat);

            convertedVideo.Steps.AddRange(video.Steps);
            convertedVideo.Steps.Add("FormatConverter: convierte el video de " + video.Format + " a " + destinationFormat + ".");
            convertedVideo.Steps.Add("FormatConverter: genera el archivo " + convertedFileName + ".");

            return convertedVideo;
        }
    }
}
