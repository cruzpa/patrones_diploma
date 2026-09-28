using System.Collections.Generic;

namespace facade
{
    public class Video
    {
        public Video(string fileName, string format)
        {
            FileName = fileName;
            Format = format;
            Steps = new List<string>();
        }

        public string FileName { get; private set; }

        public string Format { get; private set; }

        public List<string> Steps { get; private set; }
    }
}
