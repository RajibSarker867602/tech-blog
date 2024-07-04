using System;
using System.Collections.Generic;
using System.Text;

namespace TechBlog.Models.Hubs
{
    public class HubResponseDto
    {
        public string ConnectionId { get; set; }
        public long UserId { get; set; }
        public long ErrorHeaderId { get; set; }
        public string Message { get; set; }
        public long TotalRows { get; set; }
        public long ProcessedRows { get; set; }
        public bool IsCompletedProcess { get; set; }
        
        // file upload
        public long ProcessId { get; set; }
        public int FileUploadedStatus { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public long FileUploadType { get; set; }
        public long LogId { get; set; }
        public bool OnSuccess { get; set; }
        public bool OnFailed { get; set; }
        public bool IsProcessing { get; set; }
    }
}
