using CloudinaryDotNet.Actions;

namespace Sever.Services.Cloudinaries
{
    public interface IClodinaryService
    {
        Task<ImageUploadResult> UploadImageAsync(IFormFile file);

        Task<DeletionResult> DeleteImageAsync(string publicId);
    }
}
