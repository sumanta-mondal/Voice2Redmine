// -----------------------------------------------------------------------
// <copyright file="Recognizer.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace vtmblip.ext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net;
    using System.Collections.Specialized;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IRecognizer
    {
        GoogleResponse RecognizeFlac(string flacpath);
    }
    
    [JsonObject(MemberSerialization.OptIn)]
    public class GoogleHypothesa
    {
        [JsonProperty]
        public string utterance { get; set; }

        [JsonProperty]
        public double confidence { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class GoogleResponse
    {
        [JsonProperty]
        public int status { get; set; }
        [JsonProperty]
        public string id { get; set; }
        [JsonProperty]
        public GoogleHypothesa[] hypotheses { get; set; }
    }

    public class GoogleRecognizer : IRecognizer
    {

        public GoogleResponse RecognizeFlac(string flacpath)
        {
            NameValueCollection parameters = new NameValueCollection();
            //parameters.Add("lang", "ru");
            //parameters.Add("client", "chromium");
            //?lang=ru&client=chromium
            string result = WebUpload.UploadFileEx(flacpath, "http://www.google.com/speech-api/v1/recognize?lang=ru&client=chromium",
                 "file", "audio/x-flac; rate=16000", parameters, null);

            return JsonConvert.DeserializeObject<GoogleResponse>(result);
        }
    }
}
