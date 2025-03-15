using System;

namespace Domain.DTOs;

public class ChuckNorrisDTO
{
        public List<string> categories { get; set; } = new List<string>();
        public string created_at { get; set; } = string.Empty;
        public string icon_url { get; set; }= string.Empty;
        public string id { get; set; }= string.Empty;
        public string updated_at { get; set; }= string.Empty;
        public string url { get; set; }= string.Empty;
        public string value { get; set; }= string.Empty;
}
