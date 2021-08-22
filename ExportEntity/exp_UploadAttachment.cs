using System;

namespace ExportEntity
{
    public class exp_UploadAttachment
    {
        public Int64 Id { get; set; }
        public string DocType { get; set; }
        public Int64 DocId { get; set; }
        public string Title { get; set; }
        public string Attachment { get; set; }
        public Int32 UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
