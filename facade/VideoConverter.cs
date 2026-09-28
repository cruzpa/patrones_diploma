using System;
using System.IO;

namespace facade
{
    public class VideoConverter
    {
        private VideoLoader videoLoader;
        private FormatConverter formatConverter;

        public VideoConverter()
        {
            videoLoader = new VideoLoader();
            formatConverter = new FormatConverter();
        }

        public Video Convert(string fileName, string format)
        {
            Validate(fileName, format);

            Video loadedVideo = videoLoader.Load(fileName);
            Video convertedVideo = formatConverter.Convert(loadedVideo, format);

            convertedVideo.Steps.Add("VideoConverter: entrega el video convertido al cliente.");
            return convertedVideo;
        }

        private void Validate(string fileName, string format)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("Debe indicar el nombre del archivo.");
            }

            if (string.IsNullOrWhiteSpace(Path.GetExtension(fileName)))
            {
                throw new ArgumentException("El archivo debe tener extension.");
            }

            if (string.IsNullOrWhiteSpace(format))
            {
                throw new ArgumentException("Debe indicar el formato destino.");
            }
        }
    }
}
