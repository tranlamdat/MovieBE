using CloudinaryDotNet.Actions;

namespace Sever.Services.Cloudinaries
{
    public interface IClodinaryService
    {
        Task<ImageUploadResult> UploadImageAsync(IFormFile file, string folderName);

        Task<VideoUploadResult> UploadVideoAsync(IFormFile file, string folderName);

        Task<DeletionResult> DeleteMediaAsync(string publicId);
    }
}
