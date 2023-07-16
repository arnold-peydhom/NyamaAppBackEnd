using System;

namespace Business.Models
{
    public class ImageModel
    {
        public int ImageId { get; set; } = default!;
        public byte[] Content { get; set; } = default!;
        public string Extension { get; set; } = default!;
        public string Name { get; set; } = default!;
    }
}
