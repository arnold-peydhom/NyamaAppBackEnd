using System;

namespace DataAccess.Entities
{
    public class Image
    {
        public int ImageId { get; set; } = default!;
        public byte[] Content { get; set; } = default!;
        public string Extension { get; set; } = default!;
        public string Name { get; set; } = default!;
    }
}
