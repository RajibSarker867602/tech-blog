namespace TechBlog.Models.Common
{
    public class FileUploadResult
    {
        internal FileUploadResult(bool isAdded, bool isUpdated, int toalCount = 0, int uploadedCount = 0, string message = "")
        {
            IsAdded = isAdded;
            IsUpdated = isUpdated;
            TotalCount = toalCount;
            UploadedCount = uploadedCount;
            Message = message;
        }

        internal FileUploadResult(bool isSuccess = true, bool isAdded = false, bool isUpdated = false, int uploadedCount = 0, string message = "")
        {
            IsSuccess = isSuccess;
            IsAdded = isAdded;
            IsUpdated = isUpdated;
            UploadedCount = uploadedCount;
            Message = message;
        }

        internal FileUploadResult(bool isFailed = true, string message = "")
        {
            IsFailed = isFailed;
            Message = message;
        }

        public bool IsSuccess { get; set; }
        public bool IsFailed { get; set; }
        public bool IsAdded { get; set; }
        public bool IsUpdated { get; set; }
        public int TotalCount { get; set; }
        public int UploadedCount { get; set; }
        public string Message { get; set; }

        public static FileUploadResult Added(int uploadedCount)
        {
            return new FileUploadResult(isAdded: true, uploadedCount: uploadedCount);
        }
        public static FileUploadResult Updated(int uploadedCount)
        {
            return new FileUploadResult(isUpdated: true, uploadedCount: uploadedCount);
        }
        public static FileUploadResult AddedUpdated(int uploadedCount, string message = "")
        {
            return new FileUploadResult(isSuccess: true, isAdded: true, isUpdated: true, uploadedCount: uploadedCount, message);
        }
        public static FileUploadResult Failed(string message)
        {
            return new FileUploadResult(true, message);
        }
    }
}
